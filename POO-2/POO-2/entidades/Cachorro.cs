using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_2.entidades
{
     public class Cachorro
    {
        public String nome { get ; set; }
        public String racao { get; set; }
        public long peso { get; set; }

        public Cachorro() { } // construtor padrao, default

        public Cachorro(String nome)
        {
            this.nome = nome;
        }

        public Cachorro(ParametrosCachorro parametrosCachorro)
        {
            this.nome = parametrosCachorro.nome;
        }

        public void late()
        {
            
            Console.WriteLine("o dog " + nome + " está latindo");
        }

        public void comer()
        {
            Console.WriteLine("o dog " + nome + " está comendo");
        }

        public override bool Equals(object obj)
        {
            return obj is Cachorro cachorro &&
                   nome == cachorro.nome;
        }

        public override string ToString()
        {
            return $"O nome do dog {nome} tem {peso} kilos";
        }
    }
}
