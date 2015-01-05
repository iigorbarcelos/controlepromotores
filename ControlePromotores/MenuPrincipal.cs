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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
            
        }

        private void CadastrarPromotorPicture_Click(object sender, EventArgs e)
        {
            FormCadastro cadastro = new FormCadastro();
            cadastro.Show();
        }

        private void CadastrarPromotorLabel_Click(object sender, EventArgs e)
        {
            FormCadastro cadastro = new FormCadastro();
            cadastro.Show();
        }

        private void sairPictureBox_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void sairLabel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void catracaPictureBox_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            controle.Show();
        }

        private void catracaLabel_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            controle.Show();
        }

        private void relatorioPictureBox_Click(object sender, EventArgs e)
        {
            Relatorios relatorio = new Relatorios();
            relatorio.Show();
        }

        private void relatorioLabel_Click(object sender, EventArgs e)
        {
            Relatorios relatorio = new Relatorios();
            relatorio.Show();
        }

        private void emailPictureBox_Click(object sender, EventArgs e)
        {
            ConfiguraEmail configuraEmail = new ConfiguraEmail();
            configuraEmail.Show();
        }

        private void emailLabel_Click(object sender, EventArgs e)
        {
            ConfiguraEmail configuraEmail = new ConfiguraEmail();
            configuraEmail.Show();
        }


    }
}
