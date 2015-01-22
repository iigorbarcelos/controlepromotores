using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace ControlePromotores
{
    public partial class SnapshotForm : Form
    {
        String nomeusuario;
        public SnapshotForm(String nomePromotor)
        {
            InitializeComponent();
            nomeusuario = nomePromotor.Replace(" ", "");
        }

        public void SetImage(Bitmap bitmap)
        {
            lock (this)
            {
                Bitmap old = (Bitmap)pictureBox.Image;
                pictureBox.Image = bitmap;

                if (old != null)
                {
                    old.Dispose();
                }
            }
        }

        private void salvarButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = "T:/img/users/";
            saveFileDialog.DefaultExt = ".jpg";
            ImageFormat format = ImageFormat.Jpeg;
            Bitmap image = (Bitmap)pictureBox.Image;
            saveFileDialog.FileName = "T:/img/users/"+nomeusuario + "__" + DateTime.Now.ToString("dd / MM / yyyy").Replace("/", "_")+".jpg";
            Properties.Settings.Default.SomeProperty = "T:/img/users/" + nomeusuario + "__" + DateTime.Now.ToString("dd / MM / yyyy").Replace("/", "_") + ".jpg";
            Properties.Settings.Default.Save();
            bool result = true;
            try
            {
                image.Save(saveFileDialog.FileName, format);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Erro ao salvar a imagem no banco de dados.\n"+ exc);
                result = false;
            }

            if (result == true)
                MessageBox.Show("A imagem foi salva com sucesso!.");
            this.Dispose();
        }
    }
}
