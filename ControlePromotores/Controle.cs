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
using System.Threading;

namespace ControlePromotores
{
    public partial class Controle : Form
    {
        private long codpromotor = 0;
        interfaceBiometria biometria = new interfaceBiometria();
        ConfiguraEmail email = new ConfiguraEmail();
     
        public Controle()
        {
            InitializeComponent();
            codigoTextBox.TabIndex = 0;          
        }
                      
        private void sairButton_Click(object sender, EventArgs e)
        {
            this.Dispose();         
        }

        //Ativa o leitor para fazer a captura da digital e informa os dados do promotor        
        public void ativaCaptura()
        {
           
            biometria.carregaFIRCadastrada();
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 5000;
            timer.Start();
            timer.Tick += new EventHandler(timer_Tick);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            limpaFormulario(); 
            //Entra no laço quando houver um dedo no leitor.
            while (biometria.checkFinger() == true)
            {
                try
                {                      
                    biometria.abreDispositivo();
                    codpromotor = biometria.verificaIdentidade();
                    biometria.fechaDispositivo();
                    buscaDadosPromotor(codpromotor);
                    registraEntrada(codpromotor, nomeTextBox.Text, empresaTextBox.Text);
                    email.enviaEmail(emailSupervisorTextBox.ToString(), 
                                    "Atividade do funcionario "+nomeTextBox.Text.ToString()+ " - Atacadao DiaDia", 
                                    "Nova atividade do funcionário "+ nomeTextBox.Text +
                                    "<br> Dia - "+ DateTime.Now.ToString().Substring(0,10)+ "\n"+
                                    "<br> Hora: "+ DateTime.Now.TimeOfDay.ToString().Substring(0,5));
                }
                catch (Exception)
                {

                }               
            }
        }        
        
        //Busca dados do promotor que está dando entrada
        //@param1 código do promotor identificado
        private void buscaDadosPromotor(long codpromotor)
        {
            SqlConnection conn = new ConnectionFactory().getConnection();

            SqlCommand command = new SqlCommand(
                "select codpromotor, nome, empresa, "+
                " isnull(foto, 'C:/Users/Igor Barcelos/Documents/Visual Studio 2012/Projects/projetosmercado/ControlePromotores/img/indigente.jpg') as foto "+
                ", emailsupervisor "+
                "from promotores where codpromotor = @codpromotor", conn);

            //Substitui o parametro pelo código do promotor identificado.
            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = "@codpromotor";
            parametro.Value = codpromotor;
            //Adiciona no sqlcommand, o parametro substituido pelo valor
            command.Parameters.Add(parametro);
            //Cria o reader para receber os dados
            try
            {
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                        codigoTextBox.Text = codpromotor.ToString();
                        nomeTextBox.Text = reader.GetString(1);
                        empresaTextBox.Text = reader.GetString(2);
                        fotoPictureBox.ImageLocation = reader.GetString(3);
                        emailSupervisorTextBox.Text = reader.GetString(4);
                }

                reader.Close();
            }
            catch (SqlException)
            {

            }
            finally
            {
                conn.Close();                
            }

        }

        public void registraEntrada(long codpromotor, String nome, String empresa)
        {
            if (codpromotor != 0)
            {
                SqlConnection conn = new ConnectionFactory().getConnection();

                SqlCommand command = new SqlCommand(
                    "INSERT INTO movpromotores(codpromotor, nome, empresa, data, hora) "+
                    "values(@codpromotor, @nome, @empresa, @data, @hora)", conn);
                SqlParameter codparam = new SqlParameter("@codpromotor", codpromotor);
                SqlParameter nomparam = new SqlParameter("@nome", nome);
                SqlParameter empresaparam = new SqlParameter("@empresa", empresa);
                SqlParameter dataparam = new SqlParameter("@data", DateTime.Now.ToString("yyyy / MM / dd"));
                SqlParameter horaparam = new SqlParameter("@hora", DateTime.Now);

                command.Parameters.Add(codparam);
                command.Parameters.Add(nomparam);
                command.Parameters.Add(empresaparam);
                command.Parameters.Add(dataparam);
                command.Parameters.Add(horaparam);

                try
                {
                    command.ExecuteNonQuery();
                }
                catch (SqlException exc)
                {
                    MessageBox.Show("Erro " + exc);
                }
                finally
                {
                    conn.Close();
                }
            }
           

        }

        public void limpaFormulario()
        {
                codigoTextBox.Text = "";
                nomeTextBox.Text = "";
                empresaTextBox.Text = "";
                fotoPictureBox.ImageLocation = "C:/Users/Igor Barcelos/Documents/Visual Studio 2012/Projects/projetosmercado/ControlePromotores/img/indigente.jpg";
                codpromotor = 0;
        }

        
        private void ativaButton_Click(object sender, EventArgs e)
        {
            ativaCaptura();
        }

        private void desativaButton_Click(object sender, EventArgs e)
        {

        }

    }
}