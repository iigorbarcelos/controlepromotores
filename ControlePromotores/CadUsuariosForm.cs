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
    public partial class CadUsuariosForm : DevExpress.XtraEditors.XtraForm
    {

        //SqlConnection
        SqlConnection conn;
        //Variável que indica qual o tipo de operação a ser feita
        bool novoCadastro;

        public CadUsuariosForm()
        {
            InitializeComponent();
            ativaTransparecia();

            conn = new ConnectionFactory().getConnection();
        }

        public void ativaTransparecia()
        {
            TituloLabel.Parent = PictureBoxFundo;
        }

        private void CadUsuariosForm_Load(object sender, EventArgs e)
        {
            populaGridUsuarios();
        }

        private void populaGridUsuarios()
        {
            SqlDataAdapter adpSelectUsuarios = new SqlDataAdapter("SELECT * FROM USUARIOS ORDER BY MATRICULA", conn);

            DataSet dadosUsuarios = new DataSet();

            adpSelectUsuarios.Fill(dadosUsuarios);

            GridUsuarios.DataSource = dadosUsuarios.Tables[0];

        }

        private void NovoButton_Click(object sender, EventArgs e)
        {
            MessageBoxButtons botao = MessageBoxButtons.YesNo;
            DialogResult resposta = MessageBox.Show("Deseja cadastrar um novo usuário ?", "Cadastrar usuario", botao);

            if (resposta == DialogResult.Yes)
            {
                novoCadastro = true;
                TabControlCadastro.SelectedTabPage = CadastroTabPage;
                resetaGrid();
                NomeTextBox.Focus();

                try
                {

                    SqlCommand cmdBuscarProxNumMatricula = new SqlCommand(@"
                                                    SELECT COUNT(*)+1 AS PROXMATRICULA FROM USUARIOS", conn);

                    SqlDataReader rdBuscarProxNumMatricula = cmdBuscarProxNumMatricula.ExecuteReader();

                    while (rdBuscarProxNumMatricula.Read())
                    {
                        MatriculaTextBox.Text = rdBuscarProxNumMatricula["PROXMATRICULA"].ToString();
                    }

                    rdBuscarProxNumMatricula.Close();
                }
                catch (SqlException exc)
                {
                    MessageBox.Show("Falha ao buscar próximo número de matricula, verifique a conexão com o banco!\n"+exc);
                }

            }
            else
            {

            }
        }

        private void resetaGrid()
        {
            MatriculaTextBox.Text = "";
            SituacaoRadioGroup.EditValue = 'A';
            NomeTextBox.Text = "";
            EnderecoTextBox.Text = "";
            UsuarioTextBox.Text = "";
            TelefoneTextBox.Text = "";
        }

        private void SairButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private void PesquisarButton_Click(object sender, EventArgs e)
        {
            if (TabControlCadastro.SelectedTabPage == CadastroTabPage)
            {
                TabControlCadastro.SelectedTabPage = TabPagePesquisar;
                populaGridUsuarios();
            }
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            resetaGrid();
            TabControlCadastro.SelectedTabPage = TabPagePesquisar;
        }

        private void GravarButton_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            
            if (novoCadastro == true)
            {
                SqlCommand InsertUsuario = new SqlCommand(@"INSERT INTO USUARIOS 
                                            VALUES (@NOME, @ENDERECO,
                                                    @TELEFONE, @SENHA, @SITUACAO,
                                                    @NOME_USUARIO)", conn);

                InsertUsuario.Parameters.AddWithValue("@NOME", NomeTextBox.Text.ToUpper());
                InsertUsuario.Parameters.AddWithValue("@ENDERECO", EnderecoTextBox.Text.ToUpper());
                InsertUsuario.Parameters.AddWithValue("@TELEFONE", TelefoneTextBox.Text);
                InsertUsuario.Parameters.AddWithValue("@SENHA", "768B12D5E1B8464B8AA79E1B7BF693CC");
                InsertUsuario.Parameters.AddWithValue("@SITUACAO", SituacaoRadioGroup.EditValue);
                InsertUsuario.Parameters.AddWithValue("@NOME_USUARIO", UsuarioTextBox.Text.ToUpper());

                try
                {
                    InsertUsuario.ExecuteNonQuery();

                    MessageBox.Show("Usuário cadastrado com sucesso! ");
                    resetaGrid();
                    TabControlCadastro.SelectedTabPage = TabPagePesquisar;
                    populaGridUsuarios();
                }
                catch (SqlException exc)
                {
                    MessageBox.Show("Erro ao cadastrar usuário!\n" + exc);
                }
            }
            else
            {
                SqlCommand updateUsuario = new SqlCommand(@"UPDATE USUARIOS SET
                                                            NOME = @NOME
                                                           ,ENDERECO = @ENDERECO
                                                           ,TELEFONE = @TELEFONE
                                                           ,NOME_USUARIO = @USUARIO
                                                           ,SITUACAO = @SITUACAO
                                                           WHERE MATRICULA = @MATRICULA");

                updateUsuario.Parameters.AddWithValue("@NOME", NomeTextBox.Text);
                updateUsuario.Parameters.AddWithValue("@ENDERECO", EnderecoTextBox.Text);
                updateUsuario.Parameters.AddWithValue("@TELEFONE",TelefoneTextBox.Text);
                updateUsuario.Parameters.AddWithValue("@USUARIO", UsuarioTextBox.Text);
                updateUsuario.Parameters.AddWithValue("@SITUACAO", SituacaoRadioGroup.EditValue);
                updateUsuario.Parameters.AddWithValue("@MATRICULA", MatriculaTextBox.Text);

                try
                {
                    updateUsuario.ExecuteNonQuery();
                }
                catch (SqlException exc)
                {
                    MessageBox.Show("Falha ao atualizar dados do usuário ! Verifique os campos preenchidos.\n"+ exc);
                }
            }

            //Tenta fechar a conexão.
            try
            {
                conn.Close();
            }
            catch (Exception)
            {
            }
                    
        }

        private void EditarButton_Click(object sender, EventArgs e)
        {
            try
            {
                int row = gridView1.GetSelectedRows()[gridView1.SelectedRowsCount - 1];
                //pega o código da filial selecionada
                int matriculaUsuarioSelecionado = Convert.ToInt32(gridView1.GetRowCellDisplayText(row, gridView1.VisibleColumns[0]));

                //Faz o select para buscar os dados do usuário
                SqlCommand cmdSelectUsuarioEdicao = new SqlCommand(@"SELECT * FROM USUARIOS 
                                                                    WHERE MATRICULA = " + matriculaUsuarioSelecionado, conn);

                SqlDataReader rdSelectUsuarioEdicao = cmdSelectUsuarioEdicao.ExecuteReader();

                while (rdSelectUsuarioEdicao.Read())
                {
                    MatriculaTextBox.Text = rdSelectUsuarioEdicao["MATRICULA"].ToString();
                    NomeTextBox.Text = rdSelectUsuarioEdicao["NOME"].ToString();
                    EnderecoTextBox.Text = rdSelectUsuarioEdicao["ENDERECO"].ToString();
                    TelefoneTextBox.Text = rdSelectUsuarioEdicao["TELEFONE"].ToString();
                    UsuarioTextBox.Text = rdSelectUsuarioEdicao["NOME_USUARIO"].ToString();
                    SituacaoRadioGroup.EditValue = rdSelectUsuarioEdicao["SITUACAO"].ToString();
                }

                rdSelectUsuarioEdicao.Close();

                TabControlCadastro.SelectedTabPage = CadastroTabPage;

                GravarButton.Enabled = true;

                //Informa o tipo de operação a ser executada
                novoCadastro = false;
            }
            catch (Exception exc)
            {
                novoCadastro = true;
                MessageBox.Show("Não foi possível editar o usuário em questão, por favor selecione uma filial.\n" + exc);
            }
        }

        private void ResetarButton_Click(object sender, EventArgs e)
        {
            SqlCommand cmdResetaSenha = new SqlCommand(@"UPDATE USUARIOS SET SENHA = '768B12D5E1B8464B8AA79E1B7BF693CC'
                                                         WHERE MATRICULA = @MATRICULA", conn);

            cmdResetaSenha.Parameters.AddWithValue("@MATRICULA", MatriculaTextBox.Text );

            try
            {
                cmdResetaSenha.ExecuteNonQuery();

                MessageBox.Show("A senha do usuário foi resetada com sucesso! Informe ao usuário que a senha é PADRAO.");
            }
            catch (SqlException exc)
            {
                MessageBox.Show("Falha ao resetar a senha do usuário!\n"+ exc);
            }
        }


    }
}