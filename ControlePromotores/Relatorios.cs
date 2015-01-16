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
using System.Collections;

namespace ControlePromotores
{
    public partial class Relatorios : Form
    {

        ArrayList<Promotor> listaPromotores = new ArrayList<Promotor>();
        
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
            //adaptador.Fill(movpromotores);
 
            adaptador.Fill(DataSetPromotores);
            //Preenche a grid com os dados
            entradasGrid.DataSource = DataSetPromotores.Tables[0];

            //Preenche o dataset com os dados do adaptador.
            
        }

        private void imprimirButton_Click(object sender, EventArgs e)
        {
            RelatorioMovimentacoes movimentacoes = new RelatorioMovimentacoes();
            movimentacoes.Show();
        }

        private void enviaRelatorioEmail_Click(object sender, EventArgs e)
        {
            //Pega conexão com o banco
            SqlConnection conn = new ConnectionFactory().getConnection();

            //Cria um novo comando sql
            SqlCommand command = new SqlCommand(";WITH Lancamentoshoras As ( " +

"SELECT " +
    "codpromotor, Data, hora, " +
   "ROW_NUMBER() OVER ( " +
        "PARTITION BY Data, codpromotor " +
        "ORDER BY Data, codpromotor, hora) As Pos " +
"FROM movpromotores), " +

"LancamentosOrganizados As ( " +

"SELECT " +
    "L1.codpromotor, L1.Data, " +
    "L1.hora As Entrada, L2.hora As Saida " +
"FROM " +
    "Lancamentoshoras As L1 " +
    "INNER JOIN Lancamentoshoras As L2 ON " +
        "L1.codpromotor = L2.codpromotor " +
        "AND L1.Data = L2.Data " +
        "AND L1.Pos = L2.Pos - 1 " +
        "AND L1.Pos % 2 = 1) " +

"SELECT codpromotor, datepart(WEEK,Data) as semana, " +
    "RIGHT('0' + CAST(SUM(DateDiff(Mi,Entrada,Saida)) / 60 As VARCHAR(2)),2) + ':' + " +
    "RIGHT('0' + CAST(SUM(DateDiff(Mi,Entrada,Saida)) % 60 As VARCHAR(2)),2) " +
"As CargaHoraria " +

"FROM LancamentosOrganizados " +
"GROUP BY codpromotor, datepart(WEEK,Data)", conn);

            try
            {
                SqlDataReader reader = command.ExecuteReader();

                Promotor promotor = new Promotor();
               
                while (reader.Read())
                {
                    promotor
                }
            }
            catch (SqlException exc)
            {
                MessageBox.Show("Erro ao consultar dados da semana \n" + exc);
            }
            finally
            {
                conn.Close();
            }
            
            
        }
    }
}
