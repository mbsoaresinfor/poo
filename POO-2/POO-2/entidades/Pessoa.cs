using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_2
{
    public class Pessoa
    {
        public Pessoa() { }

        public Pessoa(string nome, int idade)
        {
            this.nome = nome;
            this.idade = idade;
        }
        public string nome{ get; set; }
        public int idade { get; set; }        
    }
}
