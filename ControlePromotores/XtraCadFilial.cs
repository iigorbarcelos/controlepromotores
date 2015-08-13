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
    public partial class XtraCadFilial : DevExpress.XtraEditors.XtraForm
    {
        //Variável para conexão oracle
        OracleConnection conn;

        
        public XtraCadFilial()
        {
            InitializeComponent();
            ativaTransparencia();

            conn = new ConnectionFactory().getConnectionOracle();
        }

        private void ativaTransparencia()
        {
            tituloLabel.Parent = fundoPictureBox;
        }

        private void XtraCadFilial_Load(object sender, EventArgs e)
        {
            populaGridFilial();
        }

        private void populaGridFilial()
        {
            abreConexao();

            OracleDataAdapter adpSelectFiliais = 
                new OracleDataAdapter(@"SELECT CODIGO
                                        , FANTASIA
                                        , RAZAOSOCIAL
                                        , CGC
                                        , DTEXCLUSAO
                                        FROM PCFILIAL 
                                        ORDER BY CODIGO", conn);

            DataSet dsFiliais = new DataSet();

            adpSelectFiliais.Fill(dsFiliais);

            FiliaisGridControl.DataSource = dsFiliais.Tables[0];

            fechaConexao();
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

        private void SairButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
   
    }
}