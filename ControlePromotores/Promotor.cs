using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ControlePromotores
{
    public class Promotor
    {
        //Declara todos os atributos e seus gets e sets
        public int codpromotor { get; set; }
        public  String nome {get ; set;}
       // public String endereco {get ; set;}
       // public String cpf { get; set; }
       // public String empresa { get; set; }
        //public String dataNascimento;
        //public String impressaoDigital { get; set; }
        //public String celular { get; set; }
        //public String telefone { get; set; }
        //public String email { get; set; }
       // public String contatoSupervisor { get; set; }
        public String emailSupervisor { get; set; }
        public double cargaHoraria { get; set; }
        public String horasAcumuladas { get; set; }
        public int semana { get; set; }

       // public void setdataNascimento(String dia, String mes, String ano)
     //   {
     //       this.dataNascimento = ano +"/"+ mes+"/" + dia;
     //   }

    }
}
