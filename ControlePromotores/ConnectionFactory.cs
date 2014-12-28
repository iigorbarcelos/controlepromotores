using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;  


namespace ControlePromotores
{
    class ConnectionFactory
    {
        //String de conexão
  
        private static string connString =
        @"server = IGOR\BIOMETRIC;
        Database = biometria;
        Trusted_Connection = true;";

        //Representa a conexão com o banco
        private static SqlConnection conn = null;

        //Método para obter conexão
        public SqlConnection getConnection()
        {
            conn = new SqlConnection(connString);
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


    }
}
