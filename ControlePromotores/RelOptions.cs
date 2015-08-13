using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlePromotores
{
    public partial class formRelOptions : Form
    {
        String query, pathLayout;

        public formRelOptions(String _query)
        {
            InitializeComponent();
            groupBoxTipo.Parent = fundoPictureBox;
            //Atribui valor passado do outro form para este.
            query = _query;
        }

        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (radioButtonSintetico.Checked == true)
            {
                pathLayout = @"T:\rel\relatorioSinteticoPromotores.rpt";
            }
            else if (radioButtonAnaliticoData.Checked == true)
            {
                pathLayout = @"T:\rel\relatorioAnaliticoPromotores.rpt";
            }

            relPreview visualizarRelatorio = new relPreview(query, pathLayout);
            visualizarRelatorio.Show();
            this.Dispose();
        }
    }
}
