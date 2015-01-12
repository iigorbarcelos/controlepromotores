using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace ControlePromotores
{
    public partial class RelatorioMovimentacoes : Form
    {
        public RelatorioMovimentacoes()
        {
            InitializeComponent();
            inicializaRelatorio();
        }


        public void inicializaRelatorio()
        {            
            try
            {
                ReportDocument cryRpt = new ReportDocument();
                string path_ = System.AppDomain.CurrentDomain.BaseDirectory;
                string caminho = path_ + "Relatorio.rpt";
                cryRpt.Load(caminho);
                crystalReportViewer1.ReportSource = cryRpt;
                crystalReportViewer1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.InnerException.ToString());
            }
        }


    }
}
