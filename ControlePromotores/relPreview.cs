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
using CrystalDecisions.CrystalReports;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;

namespace ControlePromotores
{
    public partial class relPreview : Form
    {
        //Documento que será usado para carregar o relatório.
        ReportDocument rpDocument = null;
        
        public relPreview(String query, String pathLayout)
        {
            InitializeComponent();
            //Busca os dados do relatório e joga no reportDocument.
            rpDocument = new CarregaRelatorio().carregarRelatorio(query, pathLayout);
        }

        private void relPreview_Load(object sender, EventArgs e)
        {
           //Define o datasource do relatório como o rpDocument
            crystalReportViewer1.ReportSource = rpDocument;
            crystalReportViewer1.Zoom(100);
         //   crystalReportViewer1.Visible = true;
           // rpDocument.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, "C:\\temp\\teste.pdf");         
        }

    }
}
