using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_3.dominios
{
    class Onibus
    {
        public int poltrona  { get; set; }
        public string nomePassageiro { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Onibus onibus &&
                   poltrona == onibus.poltrona &&
                   nomePassageiro == onibus.nomePassageiro;
        }

        public override string ToString()
        {
            return $"nome do passageiro {nomePassageiro}";
        }
    }
}
