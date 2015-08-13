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
using Oracle.ManagedDataAccess.Client;

namespace ControlePromotores
{
    public partial class CadFornecForm : DevExpress.XtraEditors.XtraForm
    {
        OracleConnection conn;
        
        public CadFornecForm()
        {
            InitializeComponent();
            conn = new ConnectionFactory().getConnectionOracle();
            TituloLabel.Parent = FundoPictureBox;
        }

        private void CadFornecForm_Load(object sender, EventArgs e)
        {
            populaGridFornecedores();
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

        private void populaGridFornecedores()
        {

            try
            {
                abreConexao();

                OracleDataAdapter adpPopulaGrid = new OracleDataAdapter(@"SELECT CODFORNEC
                                                                        , FORNECEDOR
                                                                        , CGC 
                                                                        FROM PCFORNEC 
                                                                        ORDER BY CODFORNEC", conn);

                DataSet dsFornec = new DataSet();

                adpPopulaGrid.Fill(dsFornec);

                GridFornecedores.DataSource = dsFornec.Tables[0];

            }
            catch (OracleException exc)
            {
                MessageBox.Show("Falha ao buscar os dados da grid dos fornecedores\n" + exc);
            }
            finally
            {
                fechaConexao();
            }
        }

        private void PesquisarButton_Click(object sender, EventArgs e)
        {
            abreConexao();

            StringBuilder sbSelectFornecedores = new StringBuilder();

            sbSelectFornecedores.Append(@"SELECT CODFORNEC
                                           , FORNECEDOR
                                           , CGC 
                                          FROM PCFORNEC
                                          WHERE 0=0");

            if (!pesqCodigoTextBox.Text.Equals(""))
            {
                sbSelectFornecedores.Append(" AND CODFORNEC = " + Convert.ToInt32(pesqCodigoTextBox.Text));
            }
            if(!pesqNomeTextBox.Text.Equals(""))
            {
                sbSelectFornecedores.Append(" AND FORNECEDOR LIKE '%" + pesqNomeTextBox.Text + "%'");
            }

            sbSelectFornecedores.Append(" ORDER BY CODFORNEC");
                                         
            try
            {
                OracleDataAdapter adpSelectFornecedores = new OracleDataAdapter(sbSelectFornecedores.ToString(), conn);

                DataSet dsFornecedores = new DataSet();

                adpSelectFornecedores.Fill(dsFornecedores);

                GridFornecedores.DataSource = dsFornecedores.Tables[0];

                GridFornecedores.Refresh();
            }
            catch (OracleException exc)
            {
                MessageBox.Show("Erro ao buscar fornecedores."+ exc);
            }
            finally
            {
                fechaConexao();
                sbSelectFornecedores.Clear();
            }

           
        }

        private void SairButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}