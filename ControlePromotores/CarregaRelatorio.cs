using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;
using System.Data;

namespace ControlePromotores
{
    class CarregaRelatorio
    {

        public ReportDocument carregarRelatorio(String query, String pathLayout)
        {
            ReportDocument rpDocument = null;
            
            try
            {
                SqlConnection conn = new ConnectionFactory().getConnection();

                SqlDataAdapter adaptador = new SqlDataAdapter(query, conn);

                DataTable tabela = new DataTable();

                adaptador.Fill(tabela);

                rpDocument = new ReportDocument();
                String pathReport = pathLayout;
                rpDocument.Load(pathReport);

                rpDocument.SetDataSource(tabela);
            }
            catch (SqlException exc)
            {
                System.Windows.Forms.MessageBox.Show("Erro ao buscar dados do relatório.\n"+ exc);
            }
            catch (Exception exc)
            {
                System.Windows.Forms.MessageBox.Show("Algum erro ocorreu na busca do relatório.\n"+ exc);
            }

            return rpDocument;
        }
    }
}
