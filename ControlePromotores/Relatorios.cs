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
using System.Diagnostics;
using Microsoft.Reporting.WinForms;    
using System.IO;
using Oracle.ManagedDataAccess.Client;

namespace ControlePromotores
{
    public partial class Relatorios : Form
    {
        StringBuilder selectPromotores = null;
        
        //Lista com todos os promotores e suas horas pendentes para envio de emails automático.
        ArrayList listaPromotores = new ArrayList();
        Promotor promotor = new Promotor();
  
        public Relatorios()
        {
            InitializeComponent();
            ImprimirButton.Enabled = false;

            //Define qual o container responsável para ativar a transparência.
            tituloLabel.Parent = FundoPictureBox;
            filtrosGroupBox.Parent = FundoPictureBox;
            qtRegistrosLabel.Parent = FundoPictureBox;
            ativaTransparenciaLabel();
            obtemVersao();
            populaFiliais();
        }

        private void ativaTransparenciaLabel()
        {
            versionLabel.Parent = FundoPictureBox;
        }


        private void obtemVersao()
        {
            //Mostra a versão atual do programa.
            versionLabel.Text = "versão: " + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
        } 

        private void Relatorios_Load(object sender, EventArgs e)
        {

        }

        private void populaFiliais()
        {
            OracleConnection conn = new ConnectionFactory().getConnectionOracle();

            OracleCommand cmdSelectFiliais = new OracleCommand(@"SELECT CODIGO, FANTASIA FROM PCFILIAL
                                                                 WHERE CODIGO NOT IN (2, 5, 7, 6, 3, 99)
                                                                 ORDER BY CODIGO", conn);

            try
            {
                OracleDataReader rdSelectFiliais = cmdSelectFiliais.ExecuteReader();

                while (rdSelectFiliais.Read())
                {
                    FilialComboBox.Items.Add(rdSelectFiliais["CODIGO"].ToString()+
                                             " - "+ rdSelectFiliais["FANTASIA"].ToString());
                }

                rdSelectFiliais.Close();
            }
            catch (OracleException exc)
            {
                MessageBox.Show("Erro ao buscar filiais!"+ exc);
            }
            finally
            {
                conn.Close();
            }
        }

        private void entradasGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void entradasGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.entradasGrid.Columns[e.ColumnIndex].Name == "SAIDA")
            {
                if (e.Value == null)
                {
                    DataGridViewRow row = entradasGrid.Rows[e.RowIndex];
                    row.DefaultCellStyle.BackColor = Color.Yellow;
                    e.CellStyle.BackColor = Color.Red;
                }
            }
        }

        private void PesquisarButton_Click_1(object sender, EventArgs e)
        {         
            SqlConnection conn = new ConnectionFactory().getConnection();

            SqlCommand command = new SqlCommand();

            ImprimirButton.Enabled = true;

            //String que conterá o select responsável por buscar os promotores.
            selectPromotores = new StringBuilder();

            // Monta o select e adiciona os filtros caso necessário.
            selectPromotores.Append(
     @"select ENTRADAS.data
	  ,ENTRADAS.codpromotor
      ,ENTRADAS.CODFILIAL
	  ,ENTRADAS.nome
	  ,ENTRADAS.FORNECEDOR
      ,ENTRADAS.horasContratuais
	  ,ENTRADAS.entrada1
	  ,ENTRADAS.saida1
	  ,ENTRADAS.entrada2
	  ,ENTRADAS.saida2
	  , dbo.func_cargaHoraria(entradas.saida2,entradas.entrada2,entradas.saida1,entradas.entrada1) as CARGAHORARIA
	  , dbo.func_CalculaMinutosDiarios(entradas.saida2,entradas.entrada2,entradas.saida1,entradas.entrada1) as MINUTOSDIARIOS

 from 
	(select convert(char,m.data,106) as data 
	  , m.codpromotor
      , M.CODFILIAL
	  , p.nome
	  , p.FORNECEDOR
      , p.cargaHoraria as horasContratuais
	  ,(select max(x.hora) from  movpromotores x where x.codpromotor=m.codpromotor and x.data=m.data and x.registro=1) entrada1
	  ,(select max(x.hora) from  movpromotores x where x.codpromotor=m.codpromotor and x.data=m.data and x.registro=2) saida1  
	  ,(select max(x.hora) from  movpromotores x where x.codpromotor=m.codpromotor and x.data=m.data and x.registro=3) entrada2    
	  ,(select max(x.hora) from  movpromotores x where x.codpromotor=m.codpromotor and x.data=m.data and x.registro=4) saida2
	from 
	  movpromotores m, promotores p
	where m.registro is not null
	and p.codpromotor = m.codpromotor
	and m.data BETWEEN '" + dtPickerInicio.Value.ToString("yyyy/MM/dd") + "' AND '" +
                                       dtPickerFim.Value.ToString("yyyy/MM/dd") + "'");

            //Adiciona os filtros caso necessário

            if (!TextBoxCodigo.Text.Equals(""))
            {
                selectPromotores.Append(" AND M.CODPROMOTOR = " + TextBoxCodigo.Text);
            }
            if (!TextBoxNome.Text.Equals(""))
            {
                selectPromotores.Append(" AND P.NOME LIKE '%" + TextBoxNome.Text + "%'");
            }
            if (!CodFornecTextBox.Text.Equals(""))
            {
                selectPromotores.Append(" AND P.CODFORNEC = " + Convert.ToInt32(CodFornecTextBox.Text) + " ");
            }
            if (FilialComboBox.SelectedItem != null)
            {
                selectPromotores.Append(" AND M.CODFILIAL = "+ Convert.ToInt32(FilialComboBox.SelectedItem.ToString().Substring(0, FilialComboBox.SelectedItem.ToString().IndexOf("-")-1))+ " ");
            }

            //Termina de montar o select após os filtros.
            selectPromotores.Append(") ENTRADAS ");
            selectPromotores.Append(
             @"group by  entradas.codpromotor
                 ,ENTRADAS.CODFILIAL
                 ,entradas.nome
                 ,entradas.FORNECEDOR
                 ,entradas.horasContratuais
                 ,ENTRADAS.data
                 ,ENTRADAS.entrada1
                 ,ENTRADAS.entrada2
                 ,ENTRADAS.saida1
                 ,ENTRADAS.saida2         
                
                 order by ENTRADAS.data desc, ENTRADAS.FORNECEDOR, ENTRADAS.nome");

            //Define o comando do select que será executado após ser montado.
            command.CommandText = selectPromotores.ToString();

            //Conexão que será usada no select.
            command.Connection = conn;

            try
            {
                //Adaptador que irá buscar os dados no banco
                SqlDataAdapter adaptador = new SqlDataAdapter(command);

                DataTable movpromotores = new DataTable();

                adaptador.Fill(movpromotores);

                //Popula o Data Grid
                entradasGrid.DataSource = movpromotores;

                qtRegistrosTextBox.Text = entradasGrid.Rows.Count.ToString();

                //Atuliza o dataGrid
                entradasGrid.Refresh();
            }
            catch (SqlException exc)
            {
                MessageBox.Show("Erro ao buscar os dados! \n"+ exc);
            }
            finally
            {
                conn.Close();
            }         
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            formRelOptions previewImpressao = new formRelOptions(selectPromotores.ToString());
            previewImpressao.Show();
        }

        private void SairButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void procuraButton_Click(object sender, EventArgs e)
        {
            PesquisaForm pesquisaFornec = new PesquisaForm("SELECT CODFORNEC, FORNECEDOR, CGC AS CNPJ FROM PCFORNEC"
                                                      , "Pesquisar fornecedores", "CODFORNEC", "FORNECEDOR");

            if (pesquisaFornec.ShowDialog() == DialogResult.OK)
            {
                CodFornecTextBox.Text = pesquisaFornec.codfornec.ToString();
                FornecedorTextBox.Text = pesquisaFornec.empresa;
            }
            else
            {
                CodFornecTextBox.Text = "";
                FornecedorTextBox.Text = "";
            }
        }   
    }

}
