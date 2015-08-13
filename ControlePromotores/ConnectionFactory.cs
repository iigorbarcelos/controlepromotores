using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Oracle.ManagedDataAccess.Client;
using System.Windows.Forms;

namespace ControlePromotores
{
    class ConnectionFactory
    {
        //String de conexão sql server
        private static string connStringSqlServer =
        @"server = 10.10.0.65;
        Database = biometria;
        User Id  = sa;
        Password = pvcs88ss12;";

        //String de conexão Oracle.
        private static string connStringOracle =
                 "Data Source=(DESCRIPTION="
               + "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=10.10.0.19)(PORT=1521)))"
               + "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=WINT)));"
               + "User Id=pravoce;Password=436vocepra;";

        //Representa a conexão com o banco
        private static SqlConnection conn = null;

        //Variável da conexão com o banco oracle
        private static OracleConnection connOracle = null;

        //Método para obter conexão
        public SqlConnection getConnection()
        {
            conn = new SqlConnection(connStringSqlServer);
            try
            {
                conn.Open();
            }
            catch (SqlException e)
            {
                conn = null;
               System.Windows.Forms.MessageBox.Show("Erro ao abrir conexão como banco !\n"+ e);
            }

            //System.Windows.Forms.MessageBox.Show("Conexão efetuada com sucesso !");
            return conn;
        }

        //Método responsável pela conexão com o oracle.
        public OracleConnection getConnectionOracle()
        {

            try
            {
                //Conecta ao datasource usando a conexão Oracle
                connOracle = new OracleConnection(connStringOracle);

                //Abre a conexão com o banco de dados
                connOracle.Open();

            }
            // Retorna erro
            catch (Exception ex)
            {
                connOracle = null;
                MessageBox.Show("Erro na conexão com o servidor oracle." + ex);
            }

            return connOracle;
        }


    }
}
