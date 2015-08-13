using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using CrystalDecisions.CrystalReports;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;
using System.Data.SqlClient;


namespace ControlePromotores
{
    public partial class formDispararRelatorio : DevExpress.XtraEditors.XtraForm
    {
        String dataInicio, dataFinal;

        StringBuilder sbQuery = new StringBuilder();

        public formDispararRelatorio()
        {
            InitializeComponent();
            labelControl1.Parent = pictureBox1;
            groupControl1.Parent = pictureBox1;
            lbDe.Parent = pictureBox1;
            lbRegistro.Parent = pictureBox1;
        }

        private void EnviarButton_Click(object sender, EventArgs e)
        {
            
        }

        private void formDispararRelatorio_Load(object sender, EventArgs e)
        {
            
        }

        private long getQuantidade()
        {
            long quantidade = 0;

            SqlConnection conn = new ConnectionFactory().getConnection();

            SqlCommand cmd = new SqlCommand(@"select distinct(codpromotor) as codpromotor from movpromotores
                                              where data between @dataini and @datafim", conn);

            cmd.Parameters.AddWithValue("@dataini", dateTimePickerInicio.Value);
            cmd.Parameters.AddWithValue("@datafim", dateTimePickerFinal.Value);

            try
            {
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    quantidade++; 
                }

                reader.Close();
            }
            catch (Exception)
            {
            }
            finally
            {
                conn.Close();
            }

            return quantidade;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

        //Alimenta a variável das datas
            dataInicio = dateTimePickerInicio.Value.ToString("dd-MM-yyyy");
            dataFinal = dateTimePickerFinal.Value.ToString("dd-MM-yyyy");

            SqlConnection conn = new ConnectionFactory().getConnection();

            SqlCommand cmd = new SqlCommand(@"select distinct(codpromotor) as codpromotor from movpromotores
                                              where data between @dataini and @datafim", conn);

            cmd.Parameters.AddWithValue("@dataini", dateTimePickerInicio.Value);
            cmd.Parameters.AddWithValue("@datafim", dateTimePickerFinal.Value);

            try
            {
                cxTotal.Text = getQuantidade().ToString();
                
                SqlDataReader reader = cmd.ExecuteReader();
     
                while (reader.Read())
                {                    
                    ReportDocument rpDocument =
                            new CarregaRelatorio().carregarRelatorio(montaQuery(reader["codpromotor"].ToString()), "T:\\rel\\relatorioDisparo.rpt");

                   //Cria um stream do pdf
                   System.IO.Stream st = 
                       rpDocument.ExportToStream(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat);
                   
                    //Faz a leitura do stream para byte
                   System.IO.BinaryReader br = new System.IO.BinaryReader(st);

                   byte[] pdfByte = new byte[st.Length];

                   for (int i = 0; i < st.Length; ++i)
                   {
                       pdfByte[i] = br.ReadByte();
                   }
                   
                    //Fecha o stream e o byte reader
                   st.Close();
                   br.Close();

                   //Grava o email na fila de envio
                   if (gravaLogEMail(reader["codpromotor"].ToString(), pdfByte))
                   {
                       listBox1.Items.Add("Promotor "+ reader["codpromotor"].ToString() + " -> Gerou com sucesso!");
                   }
                   else
                   {
                       listBox1.Items.Add("Promotor " + reader["codpromotor"].ToString() + " -> Falha ao gerar");
                   }
             
                   listBox1.SelectedIndex = listBox1.Items.Count-1;
                    
                   quantidade.Text = (listBox1.Items.Count).ToString();
                    
                   if (listBox1.Items.Count == Convert.ToInt64(cxTotal.Text))
                       MessageBox.Show("O processo foi finalizado com sucesso!");

                   rpDocument.Close();

                    Application.DoEvents();
                    
                }

                reader.Close();
            }catch(Exception exc)
            {
                MessageBox.Show("Erro ao gerar relatório\n"+ exc);
            }
            finally
            {
                conn.Close();
            } 
        }

        private bool gravaLogEMail(String codpromotor, byte[] bytesPdf)
        {
            String[] destinatarios = new String[5];
            String nome = "";

            SqlConnection connDados = new ConnectionFactory().getConnection();

            //Busca dados do promotor
            SqlCommand cmdbuscaDados = new SqlCommand(@"SELECT * FROM PROMOTORES WHERE CODPROMOTOR = @CODPROMOTOR", connDados);
            cmdbuscaDados.Parameters.AddWithValue("CODPROMOTOR", codpromotor);

            try
            {
                SqlDataReader reader = cmdbuscaDados.ExecuteReader();

                while (reader.Read())
                {
                    destinatarios[0] = reader["emailsupervisor"].ToString();

                    if (reader["emailcomprador"] != DBNull.Value)
                        destinatarios[1] = reader["emailcomprador"].ToString();

                    if (reader["emailadicional"] != DBNull.Value)
                        destinatarios[2] = reader["emailadicional"].ToString();

                    nome = reader["nome"].ToString();
                }

                reader.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Erro ao buscar dados do promotor!\n" + exc);
            }
            finally
            {
                connDados.Close();
            }

            if (String.IsNullOrEmpty(destinatarios[0]))
            {
                return false;
            }

            //Grava dados na tabela de email para ser enviado
            SqlConnection conn = new ConnectionFactory().getConnection();

            SqlCommand cmd = new SqlCommand(
                               @"INSERT INTO EMAILS 
                                 (DESTINATARIO, ASSUNTO, MENSAGEM, EMAILCOMPRADOR, EMAILADICIONAL,
                                  STATUS, ANEXO, NOMEDESTINATARIO, TEMANEXO)
                                  VALUES(@DESTINATARIO, @ASSUNTO, @MENSAGEM, @EMAILCOMPRADOR, @EMAILADICIONAL,
                                  'N', @ANEXO, @NOMEDESTINATARIO, @TEMANEXO)", conn);

            cmd.Parameters.AddWithValue("@DESTINATARIO", destinatarios[0]);
            cmd.Parameters.AddWithValue("ASSUNTO", "Relatório Semanal de Frequência de promotor: " +
                                      dateTimePickerInicio.Value.ToString("dd/MM/yyyy") + " À " +
                                      dateTimePickerFinal.Value.ToString("dd/MM/yyyy"));

            cmd.Parameters.AddWithValue("@MENSAGEM", @"Segue em anexo, relatório de frequência do(a) promtor(a) " + nome +
                            " <br><br><br> Att, <br><br><br> Atacadão dia a dia / Pravocê supermercados <br><br><br>" +
                            "<br><br> OBS: Por favor, não responda esse email!");

            if (destinatarios[1] == null)
                cmd.Parameters.AddWithValue("@EMAILCOMPRADOR", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@EMAILCOMPRADOR", destinatarios[1]);

            if (destinatarios[2] == null)
                cmd.Parameters.AddWithValue("@EMAILADICIONAL", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@EMAILADICIONAL", destinatarios[2]);

            cmd.Parameters.AddWithValue("@ANEXO", bytesPdf);
            cmd.Parameters.AddWithValue("@NOMEDESTINATARIO", nome);
            cmd.Parameters.AddWithValue("@TEMANEXO", 'S');

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Erro ao gravar log do email." + exc);
                return false;
            }
            finally
            {
                conn.Close();
            }

            return true;

        }


        public String montaQuery(String codpromotor)
        {
            sbQuery.Clear();
            sbQuery.Append(
     @"select ENTRADAS.data
	  ,ENTRADAS.codpromotor
      ,ENTRADAS.CODFILIAL
	  ,ENTRADAS.nome
	  ,ENTRADAS.FORNECEDOR
      ,ENTRADAS.horasContratuais
	  ,ENTRADAS.entrada1
	  ,ENTRADAS.saida1
	  ,ENTRADAS.entrada2
	  ,ENTRADAS.saida2
	  , dbo.func_cargaHoraria(entradas.saida2,entradas.entrada2,entradas.saida1,entradas.entrada1) as CARGAHORARIA
	  , dbo.func_CalculaMinutosDiarios(entradas.saida2,entradas.entrada2,entradas.saida1,entradas.entrada1) as MINUTOSDIARIOS

 from 
	(select convert(char,m.data,106) as data 
	  , m.codpromotor
      , M.CODFILIAL
	  , p.nome
	  , p.FORNECEDOR
      , p.cargaHoraria as horasContratuais
	  ,(select max(x.hora) from  movpromotores x where x.codpromotor=m.codpromotor and x.data=m.data and x.registro=1) entrada1
	  ,(select max(x.hora) from  movpromotores x where x.codpromotor=m.codpromotor and x.data=m.data and x.registro=2) saida1  
	  ,(select max(x.hora) from  movpromotores x where x.codpromotor=m.codpromotor and x.data=m.data and x.registro=3) entrada2    
	  ,(select max(x.hora) from  movpromotores x where x.codpromotor=m.codpromotor and x.data=m.data and x.registro=4) saida2
	from 
	  movpromotores m, promotores p
	where m.registro is not null
	and p.codpromotor = m.codpromotor
	and m.data BETWEEN '" + dateTimePickerInicio.Value.ToString("yyyy/MM/dd") + "' AND '" +
                            dateTimePickerFinal.Value.ToString("yyyy/MM/dd") + "'");

            sbQuery.Append(" AND M.CODPROMOTOR = "+ codpromotor);
            sbQuery.Append(" ) ENTRADAS");
            sbQuery.Append(@"
        group by  entradas.codpromotor
                 ,ENTRADAS.CODFILIAL
                 ,entradas.nome
                 ,entradas.FORNECEDOR
                 ,entradas.horasContratuais
                 ,ENTRADAS.data
                 ,ENTRADAS.entrada1
                 ,ENTRADAS.entrada2
                 ,ENTRADAS.saida1
                 ,ENTRADAS.saida2         
                
     order by ENTRADAS.data desc, ENTRADAS.FORNECEDOR, ENTRADAS.nome");

            return sbQuery.ToString();
        }
    }
}