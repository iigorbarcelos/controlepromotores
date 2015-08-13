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


namespace ControlePromotores
{
    public partial class ConfiguraEmail : Form
    {
        private bool atualizaConfigEmail = false;

        public ConfiguraEmail()
        {
            InitializeComponent();
            ativaTransparenciaLabel();
            obtemVersao();
        }

        private void ativaTransparenciaLabel()
        {
            tituloLabel.Parent = pictureBox1;
            versionLabel.Parent = pictureBox1;
        }

        private void ConfiguraEmail_Load(object sender, EventArgs e)
        {

            SqlConnection conn = new ConnectionFactory().getConnection();

            try
            {
                SqlCommand carregaDados = new SqlCommand(
                    @"SELECT
                  NOMEPARAMETRO
                 ,VALOR 
                  FROM PARAMETROS
                  WHERE NOMEPARAMETRO IN ('HOST', 'SSL', 'EMAIL', 'USUARIO', 'SENHA')", conn);


                SqlDataReader rdParametros = carregaDados.ExecuteReader();

                while (rdParametros.Read())
                {
                    if (rdParametros["NOMEPARAMETRO"].ToString().Equals("HOST"))
                    {
                        hostTextBox.Text = rdParametros["VALOR"].ToString();
                    }

                    if (rdParametros["NOMEPARAMETRO"].ToString().Equals("SSL"))
                    {
                        if (rdParametros["VALOR"].ToString().Equals("S"))
                        {
                            sslComboBox.SelectedItem = "SIM";
                        }
                        else
                        {
                            sslComboBox.SelectedItem = "NAO";
                        }                       
                    }

                    if (rdParametros["NOMEPARAMETRO"].ToString().Equals("EMAIL"))
                    {
                        EmailTextBox.Text = rdParametros["VALOR"].ToString();
                    }

                    if (rdParametros["NOMEPARAMETRO"].ToString().Equals("USUARIO"))
                    {
                        usuarioTextBox.Text = rdParametros["VALOR"].ToString();
                    }

                    if (rdParametros["NOMEPARAMETRO"].ToString().Equals("SENHA"))
                    {
                        senhaTextBox.Text = rdParametros["VALOR"].ToString();
                    }
                }

            }
            catch (SqlException exc)
            {
                MessageBox.Show("Erro ao buscar dados cadastrados"+ exc);
            }
            finally
            {
                conn.Close();
            }
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {          
               
        }

        private void gravarButton_Click(object sender, EventArgs e)
        {
           

        }

        private void obtemVersao()
        {
            //Mostra a versão atual do programa.
            versionLabel.Text = "versão: " + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }

        private void devGravarButton_Click(object sender, EventArgs e)
        {
            atualizaConfigEmail = true;
            //Valida se tem algum campo em branco para não gravar nenhuma informação incorreta.
            if (hostTextBox.Text.Equals("") || (EmailTextBox.Text.Equals("") || (usuarioTextBox.Text.Equals("")
                || senhaTextBox.Text.Equals(""))))
            {
                MessageBox.Show("Favor preencher todos os campos!");
            }
            else
            {
                SqlConnection conn = new ConnectionFactory().getConnection();

                try
                {
                    SqlCommand qrAtualizaHost = new SqlCommand(
                    @"UPDATE PARAMETROS
                  SET VALOR = @HOST
                  WHERE NOMEPARAMETRO = 'HOST'", conn);

                    qrAtualizaHost.Parameters.AddWithValue("@HOST", hostTextBox.Text);

                    SqlCommand qrAtualizaEmail = new SqlCommand(
            @"UPDATE PARAMETROS
                  SET VALOR = @EMAIL
                  WHERE NOMEPARAMETRO = 'EMAIL'", conn);

                    qrAtualizaEmail.Parameters.AddWithValue("@EMAIL", EmailTextBox.Text);

                    SqlCommand qrAtualizaUsuario = new SqlCommand(
            @"UPDATE PARAMETROS
                  SET VALOR = @USUARIO
                  WHERE NOMEPARAMETRO = 'USUARIO'", conn);

                    qrAtualizaUsuario.Parameters.AddWithValue("@USUARIO", usuarioTextBox.Text);

                    SqlCommand qrAtualizaSenha = new SqlCommand(
            @"UPDATE PARAMETROS
                  SET VALOR = @SENHA
                  WHERE NOMEPARAMETRO = 'SENHA'", conn);

                    qrAtualizaSenha.Parameters.AddWithValue("@SENHA", senhaTextBox.Text);

                    SqlCommand qrAtualizaSSL = new SqlCommand(
            @"UPDATE PARAMETROS
                  SET VALOR = @SSL
                  WHERE NOMEPARAMETRO = 'SSL'", conn);
                    if (sslComboBox.SelectedItem.ToString().Equals("SIM"))
                    {
                        qrAtualizaSSL.Parameters.AddWithValue("@SSL", 'S');
                    }
                    else
                    {
                        qrAtualizaSSL.Parameters.AddWithValue("@SSL", 'N');
                    }

                    //Executa todas as atualizações necessárias.
                    qrAtualizaEmail.ExecuteNonQuery();
                    qrAtualizaHost.ExecuteNonQuery();
                    qrAtualizaSenha.ExecuteNonQuery();
                    qrAtualizaSSL.ExecuteNonQuery();
                    qrAtualizaUsuario.ExecuteNonQuery();
                }
                catch (SqlException exc)
                {
                    atualizaConfigEmail = false;
                    MessageBox.Show("Erro ao atualizar dados !" + exc);
                }
                finally
                {
                    conn.Close();
                }

                if (atualizaConfigEmail == true)
                {
                    MessageBox.Show("Dados atualizados com sucesso !");
                }
                else
                {
                    MessageBox.Show("Erro ao atualizar os dados do email !");
                }
            }
        }

        private void devCancelarButton_Click(object sender, EventArgs e)
        {
            this.Dispose();       
        }

        private void configurarTabpage_Click(object sender, EventArgs e)
        {

        }

    }
}
