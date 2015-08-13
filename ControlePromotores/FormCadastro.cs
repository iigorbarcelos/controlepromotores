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
using System.Text.RegularExpressions;
using System.Threading;
using System.IO;


namespace ControlePromotores
{
    public partial class FormCadastro : Form
    {
        
        //Variavel que guarda a query da pesquisa do promotores
        StringBuilder sbQueryPesquisa;
        
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
            //Executa o endereçamento de TABS
            tabIndex();
            obtemVersao();
        }

        private void obtemVersao()
        {
            //Mostra a versão atual do programa.
            versionLabel.Text = "versão: " + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }

        private void novoButton_Click(object sender, EventArgs e)
        {
            
           
        }

        private void pesquisaButton_Click(object sender, EventArgs e)
        {
            

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
            CodFornecTextBox.Text = "";
            CelularTextBox.Text = "";
            emailTextBox.Text = "";
            emailSupervisorTextBox.Text = "";
            pg02txEmailComprador.Text = "";
            pg02txEmailAdicional.Text = "";
            contatoSupervisorTextBox.Text = "";
            dtNascimentoPicker.Value = DateTime.Now;
            telefoneTextBox.Text = "";
            digitalTextBox.Text = "";
            cpfTextBox.Text = "";
            fotoTextBox.Text = "";
            FornecedorTextBox.Text = "";
            cargaHorariaTextBox.Text = "";
            fotoPictureBox.ImageLocation = "T:/img/indigente.jpg";
            enviaRelatorioCheckBox.Checked = true;
            dia = null;
            mes = null;
            ano = null;
            editar = false;
            devGravarButton.Enabled = false;         
        }

        private void resetDataGrid()
        {
            //Zera o datasource e da um refresh no DataGrid
            promotoresGrid.DataSource = null;
            promotoresGrid.Refresh();
        }

       
        private void editarButton_Click(object sender, EventArgs e)
        {
            
          

        }

        private void GravarButton_Click(object sender, EventArgs e)
        {
            
        }

        

        private void calendarioButton_Click(object sender, EventArgs e)
        {
            MonthCalendar calendario = new MonthCalendar();
            calendario.Visible = true;

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
            CodFornecTextBox.TabIndex = 3;
            CelularTextBox.TabIndex = 4;
            emailTextBox.TabIndex = 5;
            telefoneTextBox.TabIndex = 6;
            dtNascimentoPicker.TabIndex = 7;
            contatoSupervisorTextBox.TabIndex = 8;
            emailSupervisorTextBox.TabIndex = 9;
            digitalTextBox.TabIndex = 10;
            cadastraDigitalButton.TabIndex = 11;
        }


        private void tabControl1_MouseClick(object sender, MouseEventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage1)
            {
                devGravarButton.Enabled = false;
            }
            else
            {
                devNovoButton.PerformClick();
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

        private void devPesquisarButton_Click(object sender, EventArgs e)
        {
            //Limpa o form
            resetFormDefault();

            //Verifica se o botao gravar está habilitado, se sim, desabilita.
            if (devGravarButton.Enabled == true)
                devGravarButton.Enabled = false;
            //Verifica se está na página de pesquisa, se não, direciona o usuário para ela.
            if (tabControl1.SelectedTab != tabPage1)
            {
                tabControl1.SelectedTab = tabPage1;
            }
            //Solicita conexão com o banco de dados.
            SqlConnection conn = new ConnectionFactory().getConnection();

            //Busca promotores cadastrados
            sbQueryPesquisa = new StringBuilder();
            sbQueryPesquisa.Clear();

            sbQueryPesquisa.Append(@"SELECT
                               CODPROMOTOR
                               ,NOME
                               ,CODFORNEC
                               ,FORNECEDOR
                               ,CPF
                               ,EMAIL
                               ,EMAILSUPERVISOR
                               ,TELEFONE
                               ,CONTATOSUPERVISOR
                               ,CARGAHORARIA
                               ,DTNASCIMENTO
                               ,ENDERECO
                               FROM PROMOTORES
                               WHERE 0 = 0"); 

            if (!String.IsNullOrEmpty(pg01txCodpromotor.Text))
            {
                sbQueryPesquisa.Append(" AND CODPROMOTOR = "+ pg01txCodpromotor.Text);
            }

            if (!String.IsNullOrEmpty(pg01txEmail.Text))
            {
                sbQueryPesquisa.Append(" AND EMAIL LIKE '%"+ pg01txEmail + "%'");
            }
            
            if (!String.IsNullOrEmpty(pg01txFornecedor.Text))
            {
                sbQueryPesquisa.Append(" AND FORNECEDOR LIKE '%"+ pg01txFornecedor.Text.ToUpper() + "%'");
            }

            if (!String.IsNullOrEmpty(pg01txNome.Text))
            {
                sbQueryPesquisa.Append(" AND NOME LIKE '%"+ pg01txNome.Text.ToUpper() + "%'");
            }

            if (pg01IncompletoCheckBox.Checked == true)
            {
                sbQueryPesquisa.Append(" AND EMAILSUPERVISOR = '' OR EMAIL = ''");
            }

            sbQueryPesquisa.Append(" ORDER BY NOME");

            //Preenche o DataAdapter com os dados provenientes do resultado da consulta no banco.
            SqlDataAdapter adaptador = new SqlDataAdapter(sbQueryPesquisa.ToString(), conn);
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
            promotoresGrid.DataSource = dados;
        }

        private void devNovoButton_Click(object sender, EventArgs e)
        {
            MessageBoxButtons botao = MessageBoxButtons.YesNo;
            DialogResult resposta = MessageBox.Show("Deseja cadastrar um novo promotor ?", "Cadastrar novo", botao);
            if (resposta == DialogResult.Yes)
            {
                resetFormDefault();
                resetDataGrid();
                tabControl1.SelectedTab = tabPage2;
                nomeTextBox.Focus();
                devGravarButton.Enabled = true;
            }
            else
            {
                resetFormDefault();
                tabControl1.SelectedTab = tabPage1;
            }
            
        }

        private void devEditarButton_Click(object sender, EventArgs e)
        {
            if (linha == -1)
            {
                MessageBox.Show("Favor selecionar um promotor para editar !");
            }
            else
            {
                //Define que será atualização de cadastro e não inserção
                editar = true;

                SqlConnection conn = new ConnectionFactory().getConnection();

                try
                {
                    SqlCommand cmdSelectDadosEdicao = new SqlCommand(@"SELECT * FROM PROMOTORES
                                                  WHERE CODPROMOTOR = @CODPROMOTOR", conn);

                    cmdSelectDadosEdicao.Parameters.AddWithValue("@CODPROMOTOR", Convert.ToInt32(promotoresGrid.CurrentRow.Cells[0].Value));

                    SqlDataReader rdSelectDadosEdicao = cmdSelectDadosEdicao.ExecuteReader();

                    while (rdSelectDadosEdicao.Read())
                    {
                        nomeTextBox.Text = rdSelectDadosEdicao["NOME"].ToString();
                        cpfTextBox.Text = rdSelectDadosEdicao["CPF"].ToString();
                        EnderecoTextBox.Text = rdSelectDadosEdicao["ENDERECO"].ToString();
                        CodFornecTextBox.Text = rdSelectDadosEdicao["CODFORNEC"].ToString();
                        FornecedorTextBox.Text = rdSelectDadosEdicao["FORNECEDOR"].ToString();
                        CelularTextBox.Text = rdSelectDadosEdicao["CELULAR"].ToString();
                        emailTextBox.Text = rdSelectDadosEdicao["EMAIL"].ToString();
                        telefoneTextBox.Text = rdSelectDadosEdicao["TELEFONE"].ToString();
                        fotoTextBox.Text = rdSelectDadosEdicao["FOTO"].ToString();
                        fotoPictureBox.ImageLocation = fotoTextBox.Text;
                        dtNascimentoPicker.Value = Convert.ToDateTime(rdSelectDadosEdicao["DTNASCIMENTO"]);
                        digitalTextBox.Text = rdSelectDadosEdicao["IMPRESSAODIGITAL"].ToString();
                        contatoSupervisorTextBox.Text = rdSelectDadosEdicao["CONTATOSUPERVISOR"].ToString();
                        emailSupervisorTextBox.Text = rdSelectDadosEdicao["EMAILSUPERVISOR"].ToString();
                        cargaHorariaTextBox.Text = rdSelectDadosEdicao["CARGAHORARIA"].ToString();
                        if (rdSelectDadosEdicao["ENVIARELATORIO"].Equals("S"))
                            enviaRelatorioCheckBox.Checked = true;
                        else
                            enviaRelatorioCheckBox.Checked = false;
                        pg02txEmailAdicional.Text = rdSelectDadosEdicao["EMAILADICIONAL"].ToString();
                        pg02txEmailComprador.Text = rdSelectDadosEdicao["EMAILCOMPRADOR"].ToString();
                    }

                    rdSelectDadosEdicao.Close();

                }
                catch (SqlException exc)
                {
                    MessageBox.Show("Erro ao carregar dados do promotor"+exc);
                }
                finally
                {
                    conn.Close();
                }

                //Muda para página de edição do formulario
                tabControl1.SelectedTab = tabPage2;

                //Habilita a gravação do promotor.
                devGravarButton.Enabled = true;
            }
        }

        private byte[] gravaArrayFoto()
        {
            MemoryStream stream = new MemoryStream();

            fotoPictureBox.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);

            byte[] foto = stream.ToArray();

            return foto;
        }
        
        private void devGravarButton_Click(object sender, EventArgs e)
        {       
            
            //Validações na hora do cadastro.
            if ((String.IsNullOrEmpty(emailSupervisorTextBox.Text)) || (emailSupervisorTextBox.Text.Length < 9)){
                MessageBox.Show("È obrigatório informar o email do supervisor antes de continuar!");
                return;
            }

            if (String.IsNullOrEmpty(fotoTextBox.Text))
            {
                MessageBox.Show("É obrigatório cadastrar uma foto para o promotor!");
                return;
            }

            if (String.IsNullOrEmpty(digitalTextBox.Text))
            {
                MessageBox.Show("È obrigatório cadastrar a biometria para o usuário.");
                return;
            }

            if (String.IsNullOrEmpty(CodFornecTextBox.Text))
            {
                MessageBox.Show("É obrigatório informar um fornecedor para o promotor!");
                return;
            }

            if(String.IsNullOrEmpty(nomeTextBox.Text))
            {
                MessageBox.Show("É obrigatório informar o nome do promotor!");
                return;
            }

            
            //Variavel pra indicar se há erro
            bool erro = false;

            //Comando sql
            SqlCommand command;
            //Variavel de mensagem de retorno ao usuário
            String mensagemRetorno = "Promotor cadastrado com sucesso.";

            //Pega conexão no banco de dados
            SqlConnection conn = new ConnectionFactory().getConnection();

            //Cria comando do insert no banco.
            if (editar == false)
            {
                command = new SqlCommand(@"INSERT INTO PROMOTORES
                                          (nome,
                                          endereco,
                                          impressaoDigital,
                                          celular,
                                          telefone,
                                          dtnascimento,
                                          email,
                                          emailSupervisor,
                                          contatoSupervisor,
                                          cpf,
                                          foto,
                                          fotopromotor,
                                          cargaHoraria,
                                          enviaRelatorio,
                                          codfornec,
                                          fornecedor,
                                          emailcomprador,
                                          emailadicional)
                
                                          VALUES(@NOME
                                                ,@ENDERECO
                                                ,@IMPRESSAODIGITAL
                                                ,@CELULAR
                                                ,@TELEFONE
                                                ,@DTNASCIMENTO
                                                ,@EMAIL
                                                ,@EMAILSUPERVISOR
                                                ,@CONTATOSUPERVISOR
                                                ,@CPF
                                                ,@FOTO
                                                ,@fotopromotor
                                                ,@CARGAHORARIA
                                                ,@ENVIARELATORIO
                                                ,@CODFORNEC
                                                ,@FORNECEDOR
                                                ,@emailcomprador
                                                ,@emailadicional)", conn);


                command.Parameters.AddWithValue("@NOME", nomeTextBox.Text);
                command.Parameters.AddWithValue("@ENDERECO", EnderecoTextBox.Text);
                command.Parameters.AddWithValue("@IMPRESSAODIGITAL", digitalTextBox.Text);
                command.Parameters.AddWithValue("@CELULAR", CelularTextBox.Text);
                command.Parameters.AddWithValue("@TELEFONE", telefoneTextBox.Text);
                command.Parameters.AddWithValue("@DTNASCIMENTO", Convert.ToDateTime(dtNascimentoPicker.Text).ToString("yyyy/MM/dd"));
                command.Parameters.AddWithValue("@EMAIL", emailTextBox.Text);
                command.Parameters.AddWithValue("@EMAILSUPERVISOR", emailSupervisorTextBox.Text);
                command.Parameters.AddWithValue("@CONTATOSUPERVISOR", contatoSupervisorTextBox.Text);
                command.Parameters.AddWithValue("@CPF", cpfTextBox.Text);
                command.Parameters.AddWithValue("@FOTO", fotoTextBox.Text);
                command.Parameters.AddWithValue("@fotopromotor", gravaArrayFoto());
                command.Parameters.AddWithValue("@CARGAHORARIA", cargaHorariaTextBox.Text);
                if (enviaRelatorioCheckBox.Checked == true)
                    command.Parameters.AddWithValue("@ENVIARELATORIO", 'S');
                else
                    command.Parameters.AddWithValue("@ENVIARELATORIO", 'N');
                command.Parameters.AddWithValue("@CODFORNEC", CodFornecTextBox.Text);
                command.Parameters.AddWithValue("@FORNECEDOR", FornecedorTextBox.Text);
                command.Parameters.AddWithValue("@emailcomprador", pg02txEmailComprador.Text);
                command.Parameters.AddWithValue("@emailadicional", pg02txEmailAdicional.Text);
 
            }
            else
            {
                command = new SqlCommand(@"update promotores set nome = @NOME,
                                          endereco = @ENDERECO, codfornec = @CODFORNEC,
                                          impressaodigital = @IMPRESSAODIGITAL, celular = @CELULAR,
                                          telefone = @TELEFONE, email = @EMAIL, emailsupervisor = @EMAILSUPERVISOR,
                                          contatosupervisor = @CONTATOSUPERVISOR, cpf = @CPF, foto = @FOTO, fotopromotor = @fotopromotor,
                                          cargaHoraria = @CARGAHORARIA, enviaRelatorio = @ENVIARELATORIO,
                                          fornecedor = @FORNECEDOR, dtnascimento = @DTNASCIMENTO,
                                          emailcomprador = @EMAILCOMPRADOR, emailadicional = @EMAILADICIONAL 
                                          where codpromotor = @CODPROMOTOR", conn);

                command.Parameters.AddWithValue("@NOME", nomeTextBox.Text);
                command.Parameters.AddWithValue("@ENDERECO", EnderecoTextBox.Text);
                command.Parameters.AddWithValue("@CODFORNEC", CodFornecTextBox.Text);
                command.Parameters.AddWithValue("@IMPRESSAODIGITAL", digitalTextBox.Text);
                command.Parameters.AddWithValue("@CELULAR", CelularTextBox.Text);
                command.Parameters.AddWithValue("@TELEFONE", telefoneTextBox.Text);
                command.Parameters.AddWithValue("@EMAIL", emailTextBox.Text);
                command.Parameters.AddWithValue("@EMAILSUPERVISOR", emailSupervisorTextBox.Text);
                command.Parameters.AddWithValue("@CONTATOSUPERVISOR", contatoSupervisorTextBox.Text);
                command.Parameters.AddWithValue("@CPF", cpfTextBox.Text);
                command.Parameters.AddWithValue("@FOTO", fotoTextBox.Text);
                command.Parameters.AddWithValue("@fotopromotor", gravaArrayFoto());
                command.Parameters.AddWithValue("@CARGAHORARIA", cargaHorariaTextBox.Text);
                if (enviaRelatorioCheckBox.Checked == true)
                    command.Parameters.AddWithValue("@ENVIARELATORIO", 'S');
                else
                    command.Parameters.AddWithValue("@ENVIARELATORIO", 'N');
                command.Parameters.AddWithValue("@FORNECEDOR", FornecedorTextBox.Text);
                command.Parameters.AddWithValue("@DTNASCIMENTO", Convert.ToDateTime(dtNascimentoPicker.Text).ToString("yyyy/MM/dd"));
                command.Parameters.AddWithValue("@EMAILCOMPRADOR", pg02txEmailComprador.Text);
                command.Parameters.AddWithValue("@EMAILADICIONAL", pg02txEmailAdicional.Text);
                command.Parameters.AddWithValue("@CODPROMOTOR", selecao.ToString());
            }

            try
            {
                command.ExecuteNonQuery();

                tabControl1.SelectedTab = tabPage1;
            }
            catch (SqlException exc)
            {
                if (editar == false)
                {
                    erro = true;
                    mensagemRetorno = "Erro ao cadastrar Promotor, verifique se todos os campos foram preenchidos!\n" + exc;
                }
                else
                {
                    erro = true;
                    mensagemRetorno = "Erro ao atualizar dados do promotor, favor verifique as informações inseridas.\n" + exc;                 
                }
            }
            finally
            {
                //Verifica se a conexão está fechada, se false, fecha a conexão
                if (conn != null && conn.State == ConnectionState.Open)
                    conn.Close();

                //Zera o command.
                command = null;
            }

            if (erro == false)
            {
                MessageBox.Show(mensagemRetorno);
                //Reseta todo o fomulario e fecha o calendário caso esteja aberto.
                resetFormDefault();
                selecao = 0;
                linha = -1;
                editar = false;

            }
            else
            {
                MessageBox.Show(mensagemRetorno);
            }
      
        }

        private void devSairButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BuscaEmpresaButton_Click(object sender, EventArgs e)
        {

            PesquisaForm pesquisar = new PesquisaForm("SELECT CODFORNEC, FORNECEDOR, CGC AS CNPJ FROM PCFORNEC"
                                                      ,"Pesquisar fornecedores", "CODFORNEC", "FORNECEDOR");

            if (pesquisar.ShowDialog() == DialogResult.OK)
            {
                CodFornecTextBox.Text = pesquisar.codfornec.ToString();
                FornecedorTextBox.Text = pesquisar.empresa;
            }
            else
            {
                CodFornecTextBox.Text = "";
                FornecedorTextBox.Text = "";
            }
        }

        private void pg01btEmitir_Click(object sender, EventArgs e)
        {
            if (sbQueryPesquisa == null)
            {
                MessageBox.Show("Favor efetuar uma pesquisa para emissão!");
            }
            else
            {
                relPreview visualizarRelatorio = new relPreview(sbQueryPesquisa.ToString(), @"T:\rel\RelCadpromotores.rpt");
                visualizarRelatorio.Show();
            }
        }

    }
}
