using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PasswordHash;

namespace ControlePromotores
{
    class Cryptografia
    {
        public Cryptografia()
        {

        }

        public String criptografarPass(String password)
        {
            password = PasswordHash.Encrypt.MD5("#$%" + password + "150875*()");

            password = PasswordHash.Encrypt.MD5("*%&"+ password + "/852369");

            return password;
        }
    }
}
