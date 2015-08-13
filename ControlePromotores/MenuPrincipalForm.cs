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
    public partial class MenuPrincipalForm : DevExpress.XtraEditors.XtraForm
    {
       //Cria a conection
        SqlConnection conn;

        //Variável para inteiro
        int qtdeEmails;
        
        public MenuPrincipalForm(int matricula, SqlConnection _conn)
        {
            InitializeComponent();
            ativaTransparencia();
            obtemVersao();
            conn = new ConnectionFactory().getConnection();
            carregaDadosUsuario(matricula);

            _conn.Close();
        }

        
        private void carregaDadosUsuario(int matricula)
        {
            SqlCommand cmdSelectUsuario = new SqlCommand(@"SELECT MATRICULA, NOME FROM USUARIOS
                                                          WHERE MATRICULA = " + matricula, conn);

            try
            {
                abreConexao();

                SqlDataReader rdSelectUsuario = cmdSelectUsuario.ExecuteReader();

                while (rdSelectUsuario.Read())
                {
                    numMatricula.Text = rdSelectUsuario["MATRICULA"].ToString();
                    nomeCompletoLabel.Text = rdSelectUsuario["NOME"].ToString();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Erro ao carregar dados vindos do login!");
            }
            finally
            {
                fechaConexao();
            }
        }

        private void verificaAlertas()
        {
            listAlertas.Items.Clear();
            
            qtdeEmails = 0;
            
            abreConexao();

            SqlCommand cmdBuscaEmailsPendetes = new SqlCommand(@"SELECT COUNT(*) AS QTDE FROM EMAILS WHERE STATUS = 'N'", conn);

            try
            {
                qtdeEmails = Convert.ToInt32(cmdBuscaEmailsPendetes.ExecuteScalar());

                if (qtdeEmails >= 10)
                {
                    listAlertas.Items.Add("Existem emails que não foram enviados! Qtde: "+ qtdeEmails);
                }
            }
            finally
            {
                fechaConexao();
                listAlertas.Refresh();
            }
        }

        private void ativaTransparencia()
        {
            TituloPictureBox.Parent = fundoPictureBox;
            tileControl1.Parent = fundoPictureBox;
            groupAlertas.Parent = fundoPictureBox;
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

        private void obtemVersao()
        {
            //Mostra a versão atual do programa.
            versionLabel.Text = "versão: " + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }

        private void sairButton_Click(object sender, EventArgs e)
        {
                Application.Exit();    
        }

        private void tileItemCadFornec_ItemClick(object sender, TileItemEventArgs e)
        {
            CadFornecForm cadFornec = new CadFornecForm();
            cadFornec.Show();
        }

        private void tileItemCadPromotor_ItemClick(object sender, TileItemEventArgs e)
        {
            FormCadastro cadPromotor = new FormCadastro();
            cadPromotor.Show();
        }

        private void relogioTimer_Tick(object sender, EventArgs e)
        {
            timerLabel.Text = DateTime.Now.ToLongTimeString();
        }

        private void tileItemConfigEmail_ItemClick(object sender, TileItemEventArgs e)
        {
            ConfiguraEmail configemail = new ConfiguraEmail();
            configemail.Show();
        }

        private void tileItemRelatorios_ItemClick(object sender, TileItemEventArgs e)
        {
            Relatorios relatorios = new Relatorios();
            relatorios.Show();
        }

        private void tileItemCadFilial_ItemClick(object sender, TileItemEventArgs e)
        {
            XtraCadFilial cadFilial = new XtraCadFilial();
            cadFilial.Show();
        }

        private void MenuPrincipalForm_Load(object sender, EventArgs e)
        {

        }

        private void tileItemCadUsuarios_ItemClick(object sender, TileItemEventArgs e)
        {
            CadUsuariosForm cadUsuarios = new CadUsuariosForm();
            cadUsuarios.Show();
        }

        private void EnviarSMSTileItem_ItemClick(object sender, TileItemEventArgs e)
        {
            formDispararRelatorio sms = new formDispararRelatorio();
            sms.Show();
        }

        private void timerAlertas_Tick(object sender, EventArgs e)
        {
            verificaAlertas();
        }

        private void MenuPrincipalForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}