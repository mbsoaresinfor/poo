using POO_2.entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_2
{
    public class Pessoa
    {

        private Endereco endereco;


        public Pessoa() { }

        public void setNomeRua(string nomeRua)
        {
            if(endereco == null)
            {
                endereco = new Endereco();
                endereco.pessoa = this;
            }
            endereco.nomeRua = nomeRua;
        }


        public Pessoa(string nome)
        {
            this.nome = nome;            
        }

        public Pessoa( int idade)
        {            
            this.idade = idade;
        }

        public Pessoa(string nome, int idade)
        {
            this.nome = nome;
            this.idade = idade;
        }
        public string nome{ get; set; }
        public int idade { get; set; }        
    }
}
