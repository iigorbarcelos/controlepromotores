using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

using NITGEN.SDK.NBioBSP;

namespace ControlePromotores
{
    public partial class CadastraDigitalForm : Form
    {

        //Cria variáveis necessárias para as configurações da leitura,gravação e validação
        NBioAPI m_NBioAPI;
        short m_OpenedDeviceID;
        NBioAPI.Type.HFIR m_hNewFIR;
        NBioAPI.Type.FIR m_biFIR;
        NBioAPI.Type.FIR_TEXTENCODE m_textFIR;
        NBioAPI.Type.DEVICE_INFO_EX[] m_DeviceInfoEx;
        NBioAPI.IndexSearch m_IndexSearch;
        short iDeviceID;
        String firDigital;
        
        public CadastraDigitalForm()
        {
            InitializeComponent();
   
            //Inicializa leitor e ja pega uma conexão com o banco
            m_NBioAPI = new NBioAPI();
            m_OpenedDeviceID = NBioAPI.Type.DEVICE_ID.NONE;
            m_IndexSearch = new NBioAPI.IndexSearch(m_NBioAPI);
            SqlConnection conn = new ConnectionFactory().getConnection();

            //Inicializa o módulo para captura da Digital
            defineDispositivo();
            fechaDispositivo();
            abreDispositivo();
            cadastraDigital();
        }
                
        
        private void defineDispositivo()
        {
            //Define o ID do dispositivo automaticamente
            iDeviceID = NBioAPI.Type.DEVICE_ID.AUTO;
        }
        
        private void fechaDispositivo()
        {
            //Fecha o dispositivo para o caso de ele ja estar aberto
            m_NBioAPI.CloseDevice(m_OpenedDeviceID);
        }

        private void abreDispositivo()
        {
            //Abre o dispositivo
            uint ret3 = m_NBioAPI.OpenDevice(iDeviceID);

             if (ret3 == NBioAPI.Error.NONE)
            {
                m_OpenedDeviceID = iDeviceID;
            } else 
             {
               MessageBox.Show("Erro ao acessar dispositivo:\n"+ ret3); 
             }
        }

         private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void recadastrarButton_Click(object sender, EventArgs e)
        {
        
        }

        //Ativa leitor pra cadastrar a digital
        private void cadastraDigital()
        {
            
            uint ret5 = m_NBioAPI.Enroll(out m_hNewFIR, null);
            if (ret5 == NBioAPI.Error.NONE)
            {
                MessageBox.Show("Digital cadastrada com sucesso");
                //Converter FIR capturada para textoFIR
                m_NBioAPI.GetTextFIRFromHandle(m_hNewFIR, out m_textFIR, true);
                //Coloca o texto obtido na String para guardar no banco.
                firDigital = m_textFIR.TextFIR;
                //Joga a FIR no TextBox (Apenas para visualização
                digitalTextBox.Text = firDigital;
                //MessageBox.Show(codigo.ToString());
            }
        }
    
           

          
    }
}
