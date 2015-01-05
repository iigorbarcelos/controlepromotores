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
    public partial class ConfiguraEmail : Form
    {

        DataTable parametros = null;
        
        public ConfiguraEmail()
        {
            InitializeComponent();

            SqlConnection conn = new ConnectionFactory().getConnection();
            try
            {
                //Busca parametros cadastrados no banco
                
                String sql = "SELECT NOMEPARAMETRO, VALOR FROM PARAMETROS";
                SqlDataAdapter adaptador = new SqlDataAdapter(sql, conn);
                adaptador.Fill(parametros);
                parametros = new DataTable();
                setInitValues();
            }
            catch (SqlException exc)
            {
                MessageBox.Show("Erro ao fazer consulta sql\n" + exc);
            }
            catch (ArgumentNullException exc)
            {
                MessageBox.Show("Erro ao preencher adaptador\n" + exc);
            }
            finally
            {
                if (conn != null)
                    conn = null;
            }
            
        }

        private void ConfiguraEmail_Load(object sender, EventArgs e)
        {
     
             //Combo box para configuração ssl.
             sslComboBox.Items.Add("True");
             sslComboBox.Items.Add("False");

             setInitValues();

        }

        public void setInitValues()
        {

            hostTextBox.Text = parametros.Rows[0][1].ToString();
            sslComboBox.SelectedItem = parametros.Rows[1][1].ToString();
            usuarioTextBox.Text = parametros.Rows[2][1].ToString();
            senhaTexBox.Text = parametros.Rows[3][1].ToString();
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            setInitValues();
            this.Dispose();
            
        }

        private void gravarButton_Click(object sender, EventArgs e)
        {
         
            /*SqlCommand command = new SqlCommand(
                            "INSERT INTO PARAMETROS (NOMEPARAMETRO, VALOR) " +
                            "VALUES ('HOST', @HOST)" +
                                 ", ('SSL', @SSL)" +
                                 ", ('USUARIO', @USUARIO)" +
                                 ", ('SENHA', @SENHA)", conn);

            SqlParameter */

        }

        
    }
}
