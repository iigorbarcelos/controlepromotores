using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NITGEN.SDK.NBioBSP;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data.Sql;
using System.Threading;

namespace ControlePromotores
{
    public class interfaceBiometria
    {
        //Cria variáveis necessárias para as configurações da leitura,gravação e validação
        private NBioAPI m_NBioAPI;
        private short m_OpenedDeviceID;
        private NBioAPI.Type.HFIR m_hNewFIR;
        private NBioAPI.Type.FIR_TEXTENCODE m_textFIR;
        private NBioAPI.IndexSearch m_IndexSearch;
        private short iDeviceID;
        private String firDigital;
        private NBioAPI.Type.WINDOW_OPTION m_WinOption;
        
        public interfaceBiometria()
        {
            //Inicializa leitor e ja pega uma conexão com o banco
            m_NBioAPI = new NBioAPI();
            m_OpenedDeviceID = NBioAPI.Type.DEVICE_ID.NONE;
            m_IndexSearch = new NBioAPI.IndexSearch(m_NBioAPI);
            defineDispositivo();

            //Inicia o sistema de busca de digitais cadastradas.
            m_IndexSearch.InitEngine();

            //Inicializa o módulo para captura da Digital           
            //Inicializa a variável da opção da janela, e define a janela de captura como invisivel
            m_WinOption = new NBioAPI.Type.WINDOW_OPTION();
            m_WinOption.WindowStyle = NBioAPI.Type.WINDOW_STYLE.INVISIBLE;
            
        }

        public void defineDispositivo()
        {
            //Define o ID do dispositivo automaticamente
            iDeviceID = NBioAPI.Type.DEVICE_ID.AUTO;
        }

        public void fechaDispositivo()
        {
            //Fecha o dispositivo para o caso de ele ja estar aberto
            m_NBioAPI.CloseDevice(iDeviceID);
            
        }

        public void abreDispositivo()
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
        //return Template da digital capturada.
        public String cadastraDigital()
        {
            abreDispositivo();
            //Aciona método para chamar a dll traduzida da janela de coleta da digital.
            mudaSkin();
            //Método que faz a captura da digitasl.
            uint ret5 = m_NBioAPI.Enroll(null, out m_hNewFIR, null, NBioAPI.Type.TIMEOUT.DEFAULT, null, m_WinOption);
            if (ret5 == NBioAPI.Error.NONE)
            {
                //Converter FIR capturada para textoFIR
                m_NBioAPI.GetTextFIRFromHandle(m_hNewFIR, out m_textFIR, true);
                //Coloca o texto obtido na String para guardar no banco.
                firDigital = m_textFIR.TextFIR;
                fechaDispositivo();
                return firDigital;
             }
            //Retorna nulo, caso de algum erro no meio do processo.
            return null;
        }

        //Captura uma digital e verifica se bate com alguma FIR cadastrada no banco, caso sim, retorna o ID do usuário.
        //@return ID do usuário.      
        public long verificaIdentidade()
        {

            //Variavel que vai estar com o template capturado pelo leitor
            NBioAPI.Type.HFIR digitalCapturada;
                      
            //Captura a digital do promotor
            m_NBioAPI.Capture(out digitalCapturada, NBioAPI.Type.TIMEOUT.INFINITE, m_WinOption);

            //Cria variável do callback
            NBioAPI.IndexSearch.CALLBACK_INFO_0 cbInfo0 = new NBioAPI.IndexSearch.CALLBACK_INFO_0();

            //Cria variável que vai receber as informações da digital
            NBioAPI.IndexSearch.FP_INFO fpInfo;

            //Pega a digital capturada, e compara para ver se é encontrada uma digital compatível no banco
            m_IndexSearch.IdentifyData(digitalCapturada, NBioAPI.Type.FIR_SECURITY_LEVEL.NORMAL, out fpInfo, cbInfo0);

            //retorna o id do usuário como inteiro
            return Convert.ToUInt32(fpInfo.ID);
        }
        
        public void carregaFIRCadastrada()
        {
            
            //Variável que vai receber o template da digital capturada pelo leitor
            string template;
            //Variável que vai receber o id do usuário, caso ele esteja cadastrado no banco
            uint codpromotor = 0;

            //Variável que vai receber o FIR em texto, do banco de dados
            NBioAPI.Type.FIR_TEXTENCODE templatefromDB = new NBioAPI.Type.FIR_TEXTENCODE();

            //Informações da Fingerprint
            NBioAPI.IndexSearch.FP_INFO[] fpInfo;
            
            //Solicita conexão com o banco
            SqlConnection conn = new ConnectionFactory().getConnection();

            //Comando sql para buscar cadastro do banco
            String command = "select codpromotor, impressaodigital from promotores";

            //Prepara o comando e a conexão para ser executado no banco.
            SqlCommand query = new SqlCommand(command, conn);

            //Cria um reader para ler os dados encontrados.
            SqlDataReader reader = query.ExecuteReader();
           
            try
            {
                while (reader.Read())
                {

                    //Pega código do promotor da consulta
                    codpromotor = Convert.ToUInt32(reader["codpromotor"].ToString(), 10);

                    //Pega a string correspondente da digital do banco
                    template = reader["impressaodigital"].ToString();

                    //Guarda na memória a impressao digital pegada do banco
                    templatefromDB.TextFIR = template;

                    //Adiciona as digitais encontradas na memória.
                    m_IndexSearch.AddFIR(templatefromDB, codpromotor, out fpInfo);                  
                }
            }
            catch (SqlException exc)
            {
                MessageBox.Show("Erro ao carregar dados do banco.\n" + exc);
            }
            finally
            {
                conn.Close();
                reader.Close();             
            }

        }

        //Muda a janela de coleta da digital para padrão em portugues.
        public void mudaSkin()
        {
            string janelaTraduzida = "C:/Windows/System/NBSP2Por.dll";     
            m_NBioAPI.SetSkinResource(janelaTraduzida);
            m_WinOption.WindowStyle = NBioAPI.Type.WINDOW_STYLE.NO_WELCOME;

         }
            

        }
    }

