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
using PasswordHash;
using System.Data.SqlClient;

namespace ControlePromotores
{
    public partial class LoginForm : DevExpress.XtraEditors.XtraForm
    {
        //Conexão da classe
        SqlConnection conn;
        //Código do usuário logado
        int matricula = 0;
        //Valida Usuário
        bool validado = false;

        public LoginForm()
        {
            InitializeComponent();
            conn = new ConnectionFactory().getConnection();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            ativaTransparencia();
        }

        private void abreConexao()
        {
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
        }

        private void fechaConexao()
        {
            if (conn.State != ConnectionState.Closed)
            {
                conn.Close();
            }
        }

        private void ativaTransparencia()
        {
            TituloPictureBox.Parent = pictureBoxFundo;
            UsuarioLabel.Parent = pictureBoxFundo;
            SenhaLabel.Parent = pictureBoxFundo;
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void LoginTextBox_Leave(object sender, EventArgs e)
        {
            UsuarioTextBox.Text = UsuarioTextBox.Text.ToUpper();
        }

        private void EntrarButton_Click(object sender, EventArgs e)
        {
            Cryptografia criptografar = new Cryptografia();
            
            SqlCommand validaUsuario = new SqlCommand(@"SELECT COUNT(*) AS VALIDA, MAX(SENHA) SENHA
                                                        , max(matricula) as matricula
                                                        FROM USUARIOS 
                                                              WHERE NOME_USUARIO = @NOME_USUARIO
                                                              AND SENHA = @SENHA", conn);

            validaUsuario.Parameters.AddWithValue("@NOME_USUARIO", UsuarioTextBox.Text);
            validaUsuario.Parameters.AddWithValue("@SENHA", criptografar.criptografarPass(senhaTextBox.Text));

            try
            {

                abreConexao();

                SqlDataReader rdValidaUsuario = validaUsuario.ExecuteReader();


                while (rdValidaUsuario.Read())
                {
                    if (Convert.ToInt32(rdValidaUsuario["VALIDA"]) > 0)
                    {
                        if (rdValidaUsuario["SENHA"].Equals("768B12D5E1B8464B8AA79E1B7BF693CC"))
                        {
                          MessageBox.Show("SERÁ NECESSÁRIO INFORMAR UMA NOVA SENHA!");
                          FormAlteraSenha alterarSenha = new FormAlteraSenha(Convert.ToInt32(rdValidaUsuario["MATRICULA"]));
                          if (alterarSenha.ShowDialog() == DialogResult.OK)
                          {
                              MessageBox.Show("Senha alterada com sucesso!");
                              validado = true;
                              matricula = Convert.ToInt32(rdValidaUsuario["MATRICULA"]);
                          }
                          else
                          {
                              validado = false;
                          }

                        }
                        else
                        {
                            validado = true;
                            matricula = Convert.ToInt32(rdValidaUsuario["MATRICULA"]);
                        }
                        
                    }
                    else
                    {
                        validado = false;
                        matricula = 0;                      
                    }
                }

                if (validado)
                {     
                   MenuPrincipalForm menu = new MenuPrincipalForm(matricula, conn);
                   menu.Show();
                   this.Visible = false;
                } else 
                {
                    MessageBox.Show("Usuário ou Senha inválidos, por favor verifique as suas credenciais!");
                    senhaTextBox.Text = "";
                    senhaTextBox.Focus();
                }

                rdValidaUsuario.Close();
                validaUsuario.Dispose();

            }
            catch (SqlException exc)
            {
                matricula = 0;
                validado = false;
                MessageBox.Show("Usuário não encontrado, verifique as suas credenciais.\n"+ exc);
                senhaTextBox.Text = "";
                senhaTextBox.Focus();
            }
            finally
            {
                fechaConexao();
            }
            
        }

        private void senhaTextBox_Leave(object sender, EventArgs e)
        {
        }

        private void senhaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                EntrarButton.PerformClick();
            }
        }

    }
}