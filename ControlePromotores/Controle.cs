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
        Thread ativa = null;
        interfaceBiometria biometria = new interfaceBiometria();
     
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
            biometria = new interfaceBiometria();
            biometria.carregaFIRCadastrada();
            while (ativa.IsAlive)
            {
                try
                {
                    biometria.abreDispositivo();
                    codpromotor = biometria.verificaIdentidade();
                    buscaDadosPromotor(codpromotor);
                    registraEntrada(codpromotor, nomeTextBox.Text, empresaTextBox.Text);
                    Thread.Sleep(3500);
                    limpaFormulario();
                    biometria.fechaDispositivo();
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
                "select codpromotor, nome, empresa, isnull(foto, 'C:/Users/Igor Barcelos/Documents/Visual Studio 2012/Projects/projetosmercado/ControlePromotores/img/indigente.jpg') as foto from promotores where codpromotor = @codpromotor", conn);

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
                    this.Invoke(new MethodInvoker(delegate
                    {
                        codigoTextBox.Text = codpromotor.ToString();
                        nomeTextBox.Text = reader.GetString(1);
                        empresaTextBox.Text = reader.GetString(2);
                        fotoPictureBox.ImageLocation = reader.GetString(3);
                       
                    }));
                }

                reader.Close();
            }
            catch (SqlException)
            {
                //MessageBox.Show("Não foi possível reconhecer sua digital, favor posicione o dedo novamente no leitor !");

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
                SqlParameter dataparam = new SqlParameter("@data", DateTime.Now);
                SqlParameter horaparam = new SqlParameter("@hora", DateTime.Now.TimeOfDay);

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
            this.Invoke(new MethodInvoker(delegate
            {
                codigoTextBox.Text = "";
                nomeTextBox.Text = "";
                empresaTextBox.Text = "";
                fotoPictureBox.ImageLocation = "C:/Users/Igor Barcelos/Documents/Visual Studio 2012/Projects/projetosmercado/ControlePromotores/img/indigente.jpg";
                codpromotor = 0;
                
            }));

        }

        
        private void ativaButton_Click(object sender, EventArgs e)
        {
            ativa = new Thread(ativaCaptura);
            ativa.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                ativa.Abort();
            }catch (ThreadAbortException)
            {
                MessageBox.Show("Voce parou a thread com sucesso !");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            if(biometria.checkFinger() == true)
                MessageBox.Show("Verdadeiro!");
            else
                MessageBox.Show("Falso!");

        }

    }
}
