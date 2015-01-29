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
        //Nome de usuário que é passado do momento do cadastro, para salvar o arquivo no padrao correto.
        String nomeusuario;

        //Variáveis que recebem parentesco de classes acima dela
        //parentMaster = FormCadastro
        //parentSec = Webcam
        FormCadastro parentMaster;
        Webcam parentSec;

        public SnapshotForm(String nomePromotor, FormCadastro _parentMaster, Webcam _parentSec)
        {
            InitializeComponent();
            //Formata o nome do usuário para o arquivo ficar em um padrao legivel e aceito.
            nomeusuario = nomePromotor.Replace(" ", "");

            this.parentMaster = _parentMaster;
            this.parentSec = _parentSec;
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
            ImageFormat format = ImageFormat.Jpeg;
            Bitmap image = (Bitmap)pictureBox.Image;
            saveFileDialog.FileName = "T:/img/users/"+nomeusuario + "-" + DateTime.Now.ToString("dd / MM / yyyy").Replace("/", "_")+".jpg";
            ControlePromotores.Properties.Settings.Default.SomeProperty = "T:/img/users/" + nomeusuario + "-" + DateTime.Now.ToString("dd / MM / yyyy").Replace("/", "_") + ".jpg";
            ControlePromotores.Properties.Settings.Default.Save();
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
            //Após a imagem ser salva, atualiza a foto no formulario principal, juntamente com o caminho do arquivo no servidor.
            //Fecha todos os formularios relacionados a Webcam
            this.parentMaster.atualizaFoto();
            this.parentSec.closeDevice();
            this.parentSec.Dispose();
            this.Dispose();
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
