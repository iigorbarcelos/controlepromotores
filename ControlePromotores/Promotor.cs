using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ControlePromotores
{
    class Promotor
    {
        //Declara todos os atributos e seus gets e sets
        private long codpromotor { get; set; }
        private String nome {get ; set;}
        private String endereco {get ; set;}
        private String cpf { get; set; }
        private String empresa {get; set;}
        private String dataNascimento;      
        private String impressaoDigital { get; set; }
        private String celular { get; set; }
        private String telefone { get; set; }
        private String email { get; set; }
        private int horainicial { get; set; }
        private int horafinal { get; set; }
        private String contatoSupervisor { get; set; }
        private String emailSupervisor { get; set; }

        public void setdataNascimento(String dia, String mes, String ano)
        {
            this.dataNascimento = ano +"/"+ mes+"/" + dia;
        }

    }
}
