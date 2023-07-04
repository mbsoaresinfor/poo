using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_1
{
    public class Pessoa
    {

        public string? nome { get; set; } 
        public float peso { get; set; } 
        public int idade { get; set; } 
        public string endereco { get; set; }
        public int altura { get; set; }
        public string sexo { get; set; }

        public String eMaiorIdade()
        {
            
            return idade >= 18 ? "e maior de idade" : 
                "nao e maior idade";
        }

        public override bool Equals(object obj)
        {
            
            return obj is Pessoa pessoa && 
                   nome == pessoa.nome?.ToLower();
        }

        public override string ToString()
        {
            return "O nome da pessoa é " + nome +
                " e a idade é " + idade;
        }
    }
}
