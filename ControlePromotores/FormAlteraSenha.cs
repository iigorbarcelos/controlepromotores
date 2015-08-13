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
using System.Data.SqlClient;

namespace ControlePromotores
{
    public partial class FormAlteraSenha : DevExpress.XtraEditors.XtraForm
    {
        //Conection
        SqlConnection conn;
        //Matricula do usuário a ter a senha alterada
        int matricula;

        public FormAlteraSenha(int _matricula)
        {
            conn = new ConnectionFactory().getConnection();
            InitializeComponent();
            SenhaLabel.Parent = FundoPictureBox;
            SenhaConfirmarLabel.Parent = FundoPictureBox;
            matricula = _matricula;
            SenhaTextBox.Focus();
        }

        private void ConfirmarButton_Click(object sender, EventArgs e)
        {
                Cryptografia criptografarSenha = new Cryptografia();
                SqlCommand updateSenha = new SqlCommand(@"update usuarios set senha = @SENHA
                                                        where matricula = @MATRICULA", conn);

                updateSenha.Parameters.AddWithValue("@SENHA", criptografarSenha.criptografarPass(SenhaConfirmarTextBox.Text));
                updateSenha.Parameters.AddWithValue("@MATRICULA", matricula);

                try
                {
                    updateSenha.ExecuteNonQuery();
                }
                catch (SqlException)
                {
                    MessageBox.Show("Erro ao atualizar senha do usuário ! Tente novamente!");
                }
                finally
                {
                    conn.Close();
                }
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {

        }

        private void SenhaConfirmarTextBox_Leave(object sender, EventArgs e)
        {
            if (!SenhaTextBox.Text.Equals(SenhaConfirmarTextBox.Text) || SenhaTextBox.Text.Equals(""))
            {
                MessageBox.Show("As senhas não coincidem!");
                SenhaConfirmarTextBox.Text = "";
                SenhaTextBox.Text = "";
                SenhaTextBox.Focus();
                ConfirmarButton.Enabled = false;
            }
            else
            {
                ConfirmarButton.Enabled = true;
            }
        }
    }
}