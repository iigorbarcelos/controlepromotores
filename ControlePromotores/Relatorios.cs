using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace ControlePromotores
{
    public partial class Relatorios : Form
    {
        public Relatorios()
        {
            InitializeComponent();
        }

        private void sairButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void pesquisarButton_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new ConnectionFactory().getConnection();

            String command = "select"+
                              " * "+
                             "from movpromotores";

            SqlDataAdapter adaptador = new SqlDataAdapter(command,conn);

            //Cria a tabela movpromotores para receber os dados do adaptador
            DataTable movpromotores = new DataTable();
            //Criao dataset pra receber a tabela movpromotor
            DataSet DataSetPromotores = new DataSet();
            //Preenche a datatable movpromotores com os resultados do adaptador.
            adaptador.Fill(movpromotores);
 
            adaptador.Fill(DataSetPromotores);
            //Preenche a grid com os dados
            entradasGrid.DataSource = DataSetPromotores.Tables[0];

            //Preenche o dataset com os dados do adaptador.
            
        }
    }
}
