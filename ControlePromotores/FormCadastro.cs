﻿using System;
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
using System.Text.RegularExpressions;
using System.Threading;


namespace ControlePromotores
{
    public partial class FormCadastro : Form
    {
        //Variaveis que serão usadas para inserir a data de forma correta no banco
        private String dia = null;
        private String mes = null;
        private String ano = null;
        
        //Variável para auxilio, da gravação do envia relatorio
        char enviaRelatorio;

        //Variavel para guardar o código do promotor selecionado.
        private int selecao = 0;

        //Variavel para edição de promotor cadastrado
        private int linha = -1;

        //DataTable pra receber promotores pesquisados.
        DataTable dados;

        //Variável para definir se será insert ou update
        bool editar = false;

        public FormCadastro()
        {
            InitializeComponent();
            tabIndex();
        }

        private void novoButton_Click(object sender, EventArgs e)
        {
            
            MessageBoxButtons botao = MessageBoxButtons.YesNo;
            DialogResult resposta = MessageBox.Show("Deseja cadastrar um novo promotor ?", "Cadastrar novo", botao);
            if (resposta == DialogResult.Yes)
            {
                resetFormDefault();
                resetDataGrid();
                tabControl1.SelectedTab = tabPage2;
                nomeTextBox.Focus();
                GravarButton.Enabled = true;
            }
            else
            {
                resetFormDefault();
                tabControl1.SelectedTab = tabPage1;
            }
            
        }

        private void pesquisaButton_Click(object sender, EventArgs e)
        {
            //Limpa o form
            resetFormDefault();
            
            //Verifica se o botao gravar está habilitado, se sim, desabilita.
            if (GravarButton.Enabled == true)
                GravarButton.Enabled = false;
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
            dados = new DataTable();

            //Verifica se a conexão está aberta, se sim, Fecha a conexão.
            if (conn != null)
            {
                conn.Close();
            }

            //Preenche o DataTable com os dados obtidos do DataAdapter
            adaptador.Fill(dados);
            //Preenche o dataGrid, com os dados do DataTable
            promotoresGrid.DataSource=dados;

            //Omite a impressaodigital na pesquisa de promotores
            promotoresGrid.Columns["impressaodigital"].Visible = false;
            promotoresGrid.Columns["foto"].Visible = false;

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
            digitalTextBox.Text = "";
            cpfTextBox.Text = "";
            fotoTextBox.Text = "";
            enviaRelatorioCheckBox.Checked = true;
            dia = null;
            mes = null;
            ano = null;
            editar = false;
            GravarButton.Enabled = false;         
        }

        private void resetDataGrid()
        {
            //Zera o datasource e da um refresh no DataGrid
            promotoresGrid.DataSource = null;
            promotoresGrid.Refresh();
        }

       
        private void editarButton_Click(object sender, EventArgs e)
        {
            
            if (linha == -1)
            {
                MessageBox.Show("Favor selecionar um fornecedor para editar !");
            }
            else
            {
                //Define que será atualização de cadastro e não inserção
                editar = true;
                
                //Define os campos de texto com os valores do promotor a ser editado.
                nomeTextBox.Text = dados.Rows[linha]["nome"].ToString();
                cpfTextBox.Text = dados.Rows[linha]["cpf"].ToString();
                EnderecoTextBox.Text = dados.Rows[linha]["endereco"].ToString();
                EmpresaTextBox.Text = dados.Rows[linha]["empresa"].ToString();
                CelularTextBox.Text = dados.Rows[linha]["celular"].ToString();
                emailTextBox.Text = dados.Rows[linha]["email"].ToString();
                telefoneTextBox.Text = dados.Rows[linha]["telefone"].ToString();
                fotoTextBox.Text = dados.Rows[linha]["foto"].ToString();
                //Ajuste da data para não gravar em formato incorreto no banco ao gravar o promotor atualizado.
                NascimentoTextBox.Text = (Convert.ToDateTime(dados.Rows[linha]["dtnascimento"])).ToString("dd / MM / yyyy");
                digitalTextBox.Text = dados.Rows[linha]["impressaodigital"].ToString();
                contatoSupervisorTextBox.Text = dados.Rows[linha]["contatosupervisor"].ToString();
                emailSupervisorTextBox.Text = dados.Rows[linha]["emailsupervisor"].ToString();
                cargaHorariaTextBox.Text = dados.Rows[linha]["cargaHoraria"].ToString();
                if (dados.Rows[linha]["enviaRelatorio"].ToString().Equals("S"))
                    enviaRelatorioCheckBox.Checked = true;
                else
                    enviaRelatorioCheckBox.Checked = false;

                //Muda para página de edição do formulario
                tabControl1.SelectedTab = tabPage2;

                //Habilita a gravação do promotor.
                GravarButton.Enabled = true;
            }

        }

        private void GravarButton_Click(object sender, EventArgs e)
        {
            //Variavel pra indicar se há erro
            bool erro = false;

            //Verifica se o usuário quer que envie relatório ou não.
            if (enviaRelatorioCheckBox.Checked == true)
                enviaRelatorio = 'S';
            else
                enviaRelatorio = 'N';

            //Comando sql
            SqlCommand command;
            //Variavel de mensagem de retorno ao usuário
            String mensagemRetorno = "Promotor cadastrado com sucesso.";
           
            //Pega conexão no banco de dados
            SqlConnection conn = new ConnectionFactory().getConnection();
            
            //Cria comando do insert no banco.
            if (editar == false)
            {
                command = new SqlCommand("INSERT INTO PROMOTORES" +
                              "(nome," +
                              "endereco," +
                              "empresa," +
                              "impressaoDigital," +
                              "celular," +
                              "telefone," +
                              "dtnascimento," +
                              "email," +
                              "emailSupervisor," +
                              "contatoSupervisor," +
                              "cpf,"+
                              "foto,"+
                              "cargaHoraria,"+
                              "enviaRelatorio)" +

                              " values" +
                              "('" + nomeTextBox.Text +
                              "', '" + EnderecoTextBox.Text +
                              "', '" + EmpresaTextBox.Text +
                              "', '" + digitalTextBox.Text +
                              "', '" + CelularTextBox.Text +
                              "', '" + telefoneTextBox.Text +
                              "', '" + ano + "/" + mes + "/" + dia +
                              "', '" + emailTextBox.Text +
                              "', '" + emailSupervisorTextBox.Text +
                              "', '" + contatoSupervisorTextBox.Text +
                              "', '" + cpfTextBox.Text  +
                              "', '" + fotoTextBox.Text +
                              "', '" + cargaHorariaTextBox.Text + "'"+
                              " , '" + enviaRelatorio +"')", conn);
            }
            else
            {
                command = new SqlCommand("update promotores set nome = '" + nomeTextBox.Text + "'," +
                                          "endereco = '" + EnderecoTextBox.Text + "'," +
                                          "empresa = '" + EmpresaTextBox.Text + "'," +
                                          "impressaodigital = '" + digitalTextBox.Text + "'," +
                                          "celular = '" + CelularTextBox.Text + "'," +
                                          "telefone = '" + telefoneTextBox.Text + "'," +
                                          "email = '" + emailTextBox.Text + "'," +
                                          "emailsupervisor = '" + emailSupervisorTextBox.Text + "'," +
                                          "contatosupervisor = '" + contatoSupervisorTextBox.Text + "'," +
                                          "cpf = '" + cpfTextBox.Text + "'," +
                                          "foto = '"+ fotoTextBox.Text+ "'," +
                                          "cargaHoraria = '"+ cargaHorariaTextBox.Text + "',"+
                                          "enviaRelatorio = '"+ enviaRelatorio + "'"+
                                          " where codpromotor = " + selecao.ToString(), conn);
            }

            try
            {
                command.ExecuteNonQuery();
            }
            catch (SqlException exc)
            {
                if (editar == false)
                {
                    mensagemRetorno = "Erro ao cadastrar Promotor, verifique se todos os campos foram preenchidos!\n" + exc;
                    erro = true;
                }
                else
                {
                    mensagemRetorno = "Erro ao atualizar dados do promotor, favor verifique as informações inseridas.\n" + exc;
                    erro = true;
                }
            }
            finally
            {
                //Verifica se a conexão está fechada, se false, fecha a conexão
                if (conn != null)
                    conn.Close();
            }

            if (erro == false)
            {
                MessageBox.Show(mensagemRetorno);
                //Reseta todo o fomulario e fecha o calendário caso esteja aberto.
                resetFormDefault();
                monthCalendar1.Hide();
                selecao = 0;
                linha = -1;
                editar = false;
               
            } 
      
        }

        

        private void calendarioButton_Click(object sender, EventArgs e)
        {
            MonthCalendar calendario = new MonthCalendar();
            calendario.Visible = true;

        }

        private void calendarioPictureBox_Click(object sender, EventArgs e)
        {
            if (monthCalendar1.Visible == false)
                monthCalendar1.Visible = true;
            else monthCalendar1.Visible = false;
        }

        private void cadastraDigitalButton_Click(object sender, EventArgs e)
        {
            interfaceBiometria biometria = new interfaceBiometria();
            digitalTextBox.Text = biometria.cadastraDigital();
        }

        //Método para alterar a sequencia do atalho tab quando o usuario apertar.
        //Apenas para facilitar a vida do usuário no cadastro de um novo promotor.
        private void tabIndex()
        {
            nomeTextBox.TabIndex = 0;
            cpfTextBox.TabIndex = 1;
            EnderecoTextBox.TabIndex = 2;
            EmpresaTextBox.TabIndex = 3;
            CelularTextBox.TabIndex = 4;
            emailTextBox.TabIndex = 5;
            telefoneTextBox.TabIndex = 6;
            NascimentoTextBox.TabIndex = 7;
            contatoSupervisorTextBox.TabIndex = 8;
            emailSupervisorTextBox.TabIndex = 9;
            digitalTextBox.TabIndex = 10;
            cadastraDigitalButton.TabIndex = 11;

        }


        private void tabControl1_MouseClick(object sender, MouseEventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage1)
            {
                GravarButton.Enabled = false;
            }
            else
            {
                novoButton.PerformClick();
            }
        }

        private void promotoresGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            linha = promotoresGrid.CurrentRow.Index;
            selecao = int.Parse(promotoresGrid.CurrentRow.Cells[0].Value.ToString());
            
        }

        private void nomeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >='0' && e.KeyChar <='9') || (e.KeyChar == '-') || (e.KeyChar== ',' ) || (e.KeyChar == '.')))
            {
                e.Handled = true;
            } 
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            dia = monthCalendar1.SelectionStart.Day.ToString();
            mes = monthCalendar1.SelectionStart.Month.ToString();
            ano = monthCalendar1.SelectionStart.Year.ToString();
            NascimentoTextBox.Text = dia + "/" + mes + "/" + ano;

            if (monthCalendar1.Visible == false)
                monthCalendar1.Visible = true;
            else monthCalendar1.Visible = false;
        }


        private void cpfTextBox_Leave(object sender, EventArgs e)
        {

            StringBuilder sb = new StringBuilder(cpfTextBox.Text);
            sb.Remove(3, 1);
            sb.Remove(6,1);
            sb.Remove(9, 1);

            
            if (!Validacoes.IsCpf(sb.ToString()))
            {
                validaCPFLabel.Visible = true;
                cpfTextBox.Focus();
            }
            else
            {
                validaCPFLabel.Visible = false;
            }
        }

        private void fotoButton_Click(object sender, EventArgs e)
        {
            if (nomeTextBox.Text == "" || nomeTextBox.Text == " ")
            {
                MessageBox.Show("Por favor, preencha os dados do promotor a ser cadastrado primeiro.");
            }
            else
            {
                
                Webcam webcam = new Webcam(nomeTextBox.Text, this);
                webcam.Show();
            }
        }

        public void atualizaFoto()
        {
            fotoPictureBox.ImageLocation = ControlePromotores.Properties.Settings.Default.SomeProperty;
            fotoTextBox.Text = ControlePromotores.Properties.Settings.Default.SomeProperty;
        }

        private void emailTextBox_Leave_1(object sender, EventArgs e)
        {
            if (!Validacoes.ValidaEnderecoEmail(emailTextBox.Text))
            {
                emailInvalidoLabel.Visible = true;
                emailTextBox.Focus();
            }
            else
            {
                emailInvalidoLabel.Visible = false;
            }
        }

        private void emailSupervisorTextBox_Leave(object sender, EventArgs e)
        {
            if (!Validacoes.ValidaEnderecoEmail(emailSupervisorTextBox.Text))
            {
                emailSupervisorInvalidoLabel.Visible = true;
                emailSupervisorTextBox.Focus();
            }
            else
            {
                emailSupervisorInvalidoLabel.Visible = false;
            }
        }

    }
}
