using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NITGEN.SDK.NBioBSP;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ControlePromotores
{
    public class interfaceBiometria
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

        public interfaceBiometria()
        {
            //Inicializa leitor e ja pega uma conexão com o banco
            m_NBioAPI = new NBioAPI();
            m_OpenedDeviceID = NBioAPI.Type.DEVICE_ID.NONE;
            m_IndexSearch = new NBioAPI.IndexSearch(m_NBioAPI);
            SqlConnection conn = new ConnectionFactory().getConnection();

            //Inicializa o módulo para captura da Digital
            defineDispositivo();
            fechaDispositivo();
            abreDispositivo();
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
            }
            else
            {
                MessageBox.Show("Erro ao acessar dispositivo:\n" + ret3);
            }
        }


        //Ativa leitor pra cadastrar a digital
        public void cadastraDigital()
        {

            uint ret5 = m_NBioAPI.Enroll(out m_hNewFIR, null);
            if (ret5 == NBioAPI.Error.NONE)
            {
                MessageBox.Show("Digital cadastrada com sucesso");
                //Converter FIR capturada para textoFIR
                m_NBioAPI.GetTextFIRFromHandle(m_hNewFIR, out m_textFIR, true);
                //Coloca o texto obtido na String para guardar no banco.
                firDigital = m_textFIR.TextFIR;
 
            }
        }
        
    }
}
