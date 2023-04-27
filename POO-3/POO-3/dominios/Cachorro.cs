using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_3.dominios
{
    public class Cachorro
    {
        public String nome { get; set; }
        public String racao { get; set; }
        public float peso { get; set; }

        public void comer()
        {
            Console.WriteLine($"O cachorro {nome} está comendo");
        }

        public override bool Equals(object obj)
        {
            return obj is Cachorro cachorro &&
                   nome == cachorro.nome;
        }

        public override string ToString()
        {
            return $"o nome do cachrro e {nome} e sua racao {racao}";
        }
    }
}
