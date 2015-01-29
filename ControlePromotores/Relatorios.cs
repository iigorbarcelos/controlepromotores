using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Collections;


namespace ControlePromotores
{
    public partial class Relatorios : Form
    {


        ArrayList listaPromotores = new ArrayList();
        Promotor promotor = new Promotor();

  
        public Relatorios()
        {
            InitializeComponent();
          
        }

        private void sairButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void pesquisarButton_Click(object sender, EventArgs e)
        {
           SqlConnection conn = new ConnectionFactory().getConnection();

           SqlCommand command = new SqlCommand();

              // monta o filtro...
              StringBuilder filter = new StringBuilder();
              this.AppendFilter(filter, command, "codpromotor", TextBoxCodigo);
              this.AppendFilter(filter, command, "nome", TextBoxNome);

              command.CommandText = @"SELECT
                              numtransent
                              ,   codpromotor
                              ,   nome
                              ,   empresa
                              ,   hora
                              FROM MOVPROMOTORES WHERE " + filter.ToString();


           command.Connection = conn;
         
            SqlDataAdapter adaptador = new SqlDataAdapter(command);

            DataTable movpromotores = new DataTable();

            adaptador.Fill(movpromotores);

            entradasGrid.DataSource = movpromotores;            

            entradasGrid.Refresh();
        }

        private void AppendFilter(StringBuilder filter, System.Data.SqlClient.SqlCommand command,
         string fieldName, TextBox textBox)
        {
            // verifica se preencheu o textbox...
            if (!string.IsNullOrEmpty(textBox.Text))
            {
                
                if(fieldName.Equals("nome")){
                    // adiciona o filtro...
                    if (filter.Length > 0)
                        filter.Append(" AND ");
                    filter.Append(string.Format("{0} LIKE @{0}", fieldName));
                    // adiciona o parâmetro...
                    command.Parameters.AddWithValue(string.Format("@{0}", fieldName), "%"+textBox.Text+"%");
                }
                else
                {
                    // adiciona o filtro...
                    if (filter.Length > 0)
                        filter.Append(" AND ");
                    filter.Append(string.Format("{0} = @{0}", fieldName));
                    // adiciona o parâmetro...
                    command.Parameters.AddWithValue(string.Format("@{0}", fieldName), textBox.Text);
                }
                
            }
        }

        private void imprimirButton_Click(object sender, EventArgs e)
        {
        }

        private void enviaRelatorioEmail_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new ConnectionFactory().getConnection();
            
            //Cria um novo comando sql
            SqlCommand command = new SqlCommand(

@";WITH Lancamentoshoras As (

SELECT  
    codpromotor, Data, hora,  
   ROW_NUMBER() OVER ( 
        PARTITION BY Data, codpromotor 
        ORDER BY Data, codpromotor, hora) As Pos 
FROM movpromotores),

LancamentosOrganizados As ( 

SELECT 
    L1.codpromotor, L1.Data, 
    L1.hora As Entrada, L2.hora As Saida
FROM 
    Lancamentoshoras As L1
    INNER JOIN Lancamentoshoras As L2 ON
        L1.codpromotor = L2.codpromotor 
        AND L1.Data = L2.Data
        AND L1.Pos = L2.Pos - 1
        AND L1.Pos % 2 = 1) 

SELECT codpromotor, datepart(WEEK,Data) as semana,  
    RIGHT('0' + CAST(SUM(DateDiff(Mi,Entrada,Saida)) / 60 As VARCHAR(2)),2) + ',' +
    RIGHT('0' + CAST(SUM(DateDiff(Mi,Entrada,Saida)) % 60 As VARCHAR(2)),2) 
As CargaHoraria

FROM LancamentosOrganizados
where DATEPART(WEEK, Data) = DATEPART(WEEK,SYSDATETIME())
GROUP BY codpromotor, datepart(WEEK,Data)", conn);

            try
            {

                ArrayList listaGrid = new ArrayList();
                SqlDataReader relatorioSemanas = command.ExecuteReader();
            
                while (relatorioSemanas.Read())
                {
                    /*O busca dados, completa os dados que são obtidos pelo select do acúmulo de horas, como nome, email do 
                    supervisor e etc, para cada linha obtida com o select de carga horaria. Esse método, também ja inclui
                    cada promotor na lista, com as informações completas.
                    */
                  listaGrid.AddRange(buscaDados(relatorioSemanas.GetInt32(0), relatorioSemanas.GetString(2), relatorioSemanas.GetInt32(1)));                
                }

                entradasGrid.DataSource = listaPromotores;

                //popula a grid com os resultados da busca.
                entradasGrid.DataSource = listaGrid;
                // Atualiza o GUI do usuário.
                entradasGrid.Refresh();

            }

            catch (SqlException exc)
            {
                MessageBox.Show("Erro ao consultar dados da semana \n" + exc);
            }
            finally
            {
                conn.Close();
                          
            }
            
            
        }

        //@param1 codpromotor
        //@param2 horasaCUMULADAS - TOTAL DE HORAS DA SEMANA
        //@param3 semana - INTEIRO COM NUMERO DA SEMANA CORRESPONDENTE
        //@return Arraylist - contém todos os promotores que foram encontrados.
        public ArrayList buscaDados(int codpromotor, String horasAcumuladas, int semana)
        {
          
            ArrayList listaPromotores = new ArrayList();

            SqlConnection conn = new ConnectionFactory().getConnection();
            Promotor promotor = new Promotor();
            promotor.codpromotor = codpromotor;
            promotor.horasAcumuladas = horasAcumuladas;
            promotor.semana = semana;

            SqlCommand command = new SqlCommand(
                @"SELECT
                    NOME, 
                    EMAILSUPERVISOR,
                    CARGAHORARIA
                  FROM PROMOTORES
                  WHERE CODPROMOTOR = @CODPROMOTOR", conn);

            SqlParameter codpromotorParametro = new SqlParameter("@CODPROMOTOR", codpromotor);

            command.Parameters.Add(codpromotorParametro);

            try
            {
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    promotor.nome = (string)reader["nome"];
                    promotor.emailSupervisor = (string)reader["emailsupervisor"];
                    promotor.cargaHoraria = Convert.ToDouble(reader["cargaHoraria"]);

                }

                //reader.Close();
                command.Dispose();
            }
            catch (SqlException exc)
            {
                MessageBox.Show("Erro ao enviar todos os emails!" + exc);
            }
            finally
            {
                conn.Close();
                
            }

            //Calculo das horas pendentes do funcionario em questao, baseado na quantidade de horas acumuladas e horas cadastradas.
            String horasPendentes = (Convert.ToDouble(promotor.cargaHoraria) - Convert.ToDouble(promotor.horasAcumuladas)).ToString().Replace(",",":");

            if (enviaEmail(promotor.emailSupervisor, "Relatório de atividade semanal de promotores Atacadao Dia a Dia", 
                       "Funcionário: "+ promotor.nome + "<br>Horas atingidas: "+ promotor.horasAcumuladas.Replace(",", ":") + "hrs.<br>"+
                       "Carga horária cadastrada: "+ promotor.cargaHoraria+ "hrs.<br>"
                       +"Horas pendentes: "+ horasPendentes + "hrs."))
                MessageBox.Show("Email enviado com sucesso !");
            else
                MessageBox.Show("Falha ao enviar email");

            listaPromotores.Add(promotor);

            //Grava o log da pendencia do fornecedor
            conn.Open();

            string queryInsertLog = "";

            if (promotor.semana == 1)
            {
                queryInsertLog = @"INSERT INTO LOGCARGAHORARIA
                  (CODPROMOTOR
                  ,NOME
                  ,HORASPENDENTES
                  ,SEMANA1
                  ,MES)
                   VALUES (
                    '" + promotor.codpromotor + "','" +
                       promotor.nome + "','" +
                       horasPendentes + "'," +
                       "@semana1" + "," +
                       "@mes" + ")";
            }
            else if (semana == 2)
            {
                queryInsertLog = @"INSERT INTO LOGCARGAHORARIA
                  (CODPROMOTOR
                  ,NOME
                  ,HORASPENDENTES
                  ,SEMANA2
                  ,MES)
                   VALUES (
                    '" + promotor.codpromotor + "','" +
                       promotor.nome + "','" +
                       horasPendentes + "'," +
                       "@semana2" + "," +
                       "@mes" + ")";
            }
            else if (semana == 3)
            {
                queryInsertLog = @"INSERT INTO LOGCARGAHORARIA
                  (CODPROMOTOR
                  ,NOME
                  ,HORASPENDENTES
                  ,SEMANA3
                  ,MES)
                   VALUES (
                    '" + promotor.codpromotor + "','" +
                       promotor.nome + "','" +
                       horasPendentes + "'," +
                       "@semana3" + "," +
                       "@mes" + ")";
            }
            else
            {
                queryInsertLog = @"INSERT INTO LOGCARGAHORARIA
                  (CODPROMOTOR
                  ,NOME
                  ,HORASPENDENTES
                  ,SEMANA4
                  ,MES)
                   VALUES (
                    '" + promotor.codpromotor + "','" +
                       promotor.nome + "','" +
                       horasPendentes + "'," +
                       "@semana4" + "," +
                       "@mes" + ")";
            }
            


            SqlCommand gravaLog = new SqlCommand(queryInsertLog, conn);   
            
            SqlParameter @mes = new SqlParameter("@mes", DateTime.Now.Month);
            gravaLog.Parameters.Add(@mes);

           
        
             switch (semana)
             {
                 case 1:
                                        
                     SqlParameter @semana1 = new SqlParameter("@semana1", horasPendentes);
                     gravaLog.Parameters.Add(@semana1);
                     break;
                 case 2:
                     SqlParameter @semana2 = new SqlParameter("@semana2", horasPendentes);
                     gravaLog.Parameters.Add(@semana2);
                     break;
                 case 3:
                     SqlParameter @semana3 = new SqlParameter("@semana3", horasPendentes);
                     gravaLog.Parameters.Add(@semana3);
                     break;
                 case 4:
                     SqlParameter @semana4 = new SqlParameter("@semana4", horasPendentes);
                     gravaLog.Parameters.Add(@semana4);
                     break;
             }
           
            try
            {
               gravaLog.ExecuteNonQuery(); 
            } catch (SqlException exc){
                MessageBox.Show("Erro ao gravar log de horas pendentes"+ exc);
            } finally {
                conn.Close();
            }

            promotor = null;
            return listaPromotores;
        }

        public bool enviaEmail(String destinatario, String assunto, String mensagem)
        {

            ConfiguraEmail email = new ConfiguraEmail();
            if (email.enviaEmail(destinatario, assunto, mensagem))
                return true;
            else
                return false;

        }

        private void Relatorios_Load(object sender, EventArgs e)
        {


        }      
        
    }
}
