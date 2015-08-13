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
    public partial class PesquisaForm : DevExpress.XtraEditors.XtraForm
    {
        StringBuilder query = new StringBuilder();
        
        OracleConnection conn;
        
        public PesquisaForm(String queryBusca, String Titulo, String Filtro1, String Filtro2)
        {
            InitializeComponent();
            TituloLabel.Text = Titulo;
            if(!Filtro1.Equals(""))
                  FiltroComboBox.Items.Add(Filtro1);
            if (!Filtro2.Equals(""))
                FiltroComboBox.Items.Add(Filtro2);
            query.Append(queryBusca);
            ativaTransparencia();
            FiltroTextBox.Text = "";

            conn = new ConnectionFactory().getConnectionOracle();
        }

        public int codfornec
        {
            get { return Convert.ToInt32(GridPesquisa.CurrentRow.Cells[0].Value);  }
        }

        public String empresa
        {
            get { return GridPesquisa.CurrentRow.Cells[1].Value.ToString();}
        }

        private void ativaTransparencia()
        {
            TituloLabel.Parent = FundoPictureBox;
        }

        private void PesquisarButton_Click(object sender, EventArgs e)
        {
            StringBuilder sbQuery = new StringBuilder();
            sbQuery.Append(query);

            
            try
            {            
                if (!FiltroTextBox.Text.Equals("") && !FiltroComboBox.SelectedItem.ToString().Equals("FORNECEDOR"))
                {
                    sbQuery.Append(" WHERE " + FiltroComboBox.SelectedItem.ToString() + " = " + FiltroTextBox.Text);
                }

                if (!FiltroTextBox.Text.Equals("") && FiltroComboBox.SelectedItem.ToString().Equals("FORNECEDOR"))
                {
                    sbQuery.Append(" WHERE " + FiltroComboBox.SelectedItem.ToString() + " like '%" + FiltroTextBox.Text + "%'");
                }

                OracleDataAdapter adpBuscarDados = new OracleDataAdapter(sbQuery.ToString(), conn);

                DataTable resultado = new DataTable();

                adpBuscarDados.Fill(resultado);

                GridPesquisa.DataSource = resultado;

                sbQuery.Clear();

            }
            catch (OracleException)
            {

            }

           
        }

        private void SairButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}