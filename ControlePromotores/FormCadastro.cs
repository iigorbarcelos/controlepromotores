using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace ControlePromotores
{
    public partial class FormCadastro : Form
    {
        public FormCadastro()
        {
            InitializeComponent();
        }

        private void novoButton_Click(object sender, EventArgs e)
        {
            resetFormDefault();
            resetDataGrid();
            tabControl1.SelectedTab = tabPage2;
            nomeTextBox.Focus();
        }

        private void pesquisaButton_Click(object sender, EventArgs e)
        {
            //Verifica se está na página de pesquisa, se não, direciona o usuário para ela.
            if (tabControl1.SelectedTab != tabPage1)
            {
                tabControl1.SelectedTab = tabPage1;
            }
            //Solicita conexão com o banco de dados.
            SqlConnection conn = new ConnectionFactory().getConnection();
            
            //Busca promotores cadastrados
            String command = "Select * from promotores";

            //Preenche o DataAdapter com os dados provenientes do resultado da consulta no banco.
            SqlDataAdapter adaptador = new SqlDataAdapter(command, conn);
            //Instancia um novo DataTable
            DataTable dados = new DataTable();

            //Verifica se a conexão está aberta, se sim, Fecha a conexão.
            if (conn != null)
            {
                conn.Close();
            }

            //Preenche o DataTable com os dados obtidos do DataAdapter
            adaptador.Fill(dados);
            //Preenche o dataGrid, com os dados do DataTable
            promotoresGrid.DataSource=dados;
            

        }

        private void sairButton_Click(object sender, EventArgs e)
        {
            //Encerra a aplicação e libera a memória do computador
            this.Dispose();
        }

        //Metódo para limpar formulário
        private void resetFormDefault()
        {
            nomeTextBox.Text = "";
            EnderecoTextBox.Text = "";
            EmpresaTextBox.Text = "";
            CelularTextBox.Text = "";
            emailTextBox.Text = "";
            emailSupervisorTextBox.Text = "";
            contatoSupervisorTextBox.Text = "";
            NascimentoTextBox.Text = "";
            telefoneTextBox.Text = "";
           
        }

        private void resetDataGrid()
        {
            //Zera o datasource e da um refresh no DataGrid
            promotoresGrid.DataSource = null;
            promotoresGrid.Refresh();
        }

       
        private void editarButton_Click(object sender, EventArgs e)
        {
            //Reseta o data grid
            resetDataGrid();
            resetFormDefault();

        }

        private void GravarButton_Click(object sender, EventArgs e)
        {
            //Pega conexão no banco de dados
            SqlConnection conn = new ConnectionFactory().getConnection();
            //Cria comando do insert no banco.
            SqlCommand command = new SqlCommand("INSERT INTO PROMOTORES" +
                               "(nome," +
                               "endereco," +
                               "empresa," +
                               "impressaoDigital," +
                               "celular," +
                               "telefone," +
                               "dtnascimento," +
                               "emailPromotor," +
                               "emailSupervisor," +
                               "contatoSupervisor)" +

                               " values" +
                               "('" + nomeTextBox.Text +
                               "', '" + EnderecoTextBox.Text +
                               "', '" + EmpresaTextBox.Text +
                               "', '" + digitalTextBox.Text +
                               "', '" + CelularTextBox.Text +
                               "', '" + telefoneTextBox.Text +
                               "', '" + NascimentoTextBox.Text +
                               "', '" + emailTextBox.Text +
                               "', '" + emailSupervisorTextBox.Text +
                               "', '" + contatoSupervisorTextBox.Text + "')", conn);

            try
            {
                command.ExecuteNonQuery();
            }
            catch (SqlException exc)
            {
                MessageBox.Show("Erro ao gravar promotor no banco. " + exc);
             
            }
            finally
            {
                //Verifica se a conexão está fechada, se false, fecha a conexão
                if (conn != null)
                    conn.Close();
            }

            MessageBox.Show("Promotor cadastrado com sucesso.");

      
        }
    }
}
