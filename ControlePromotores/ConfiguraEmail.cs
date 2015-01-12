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
using System.Net.Mail;
using System.Net;
using System.Net.Mime;
using System.Net.Security;

namespace ControlePromotores
{
    public partial class ConfiguraEmail : Form
    {

        public ConfiguraEmail()
        {
            InitializeComponent();
            
        }

        private void ConfiguraEmail_Load(object sender, EventArgs e)
        {
        }


        private void cancelarButton_Click(object sender, EventArgs e)
        {
            
            this.Dispose();
            
        }

        private void gravarButton_Click(object sender, EventArgs e)
        {

           

        }

        public bool enviaEmail(String emailDestinatario, String assunto, String corpoMensagem)
        {

            SmtpClient client = new SmtpClient();
            client.Host = "smtp.gmail.com";
            client.Port = 587;
            client.EnableSsl = true;
            
            MailAddress remetente = new MailAddress(
                "controledepromotor@gmail.com", "Controle de Frequência");

            MailAddress destinatario = new MailAddress(emailDestinatario);

            MailMessage mensagem = new MailMessage(remetente, destinatario);

            mensagem.Body = corpoMensagem;

            mensagem.Subject = assunto;

            mensagem.IsBodyHtml = true;

            NetworkCredential credenciais = new NetworkCredential("controledepromotor@gmail.com", "igor1212");

            client.Credentials = credenciais;
            client.Timeout = 100000;

            try
            {

                client.Send(mensagem);
            }

            catch (Exception)
            {
                return false;
            }

            return true;
        }
    }
}
