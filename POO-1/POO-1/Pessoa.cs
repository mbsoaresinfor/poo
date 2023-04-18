using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_1
{
    class Pessoa
    {
        string nome { get; set; }        
        float peso { get; set; }
        int idade { get; set; }
        string endereco { get; set; }
        int altura { get; set; }
        string sexo { get; set; }

        public Boolean isBrasileiro()
        {
            return nome.Equals("brasil");
        }

    }
}
