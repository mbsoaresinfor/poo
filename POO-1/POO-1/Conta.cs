using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_1
{
    public abstract class Conta
    {
        public float saldo;
        private Pessoa pessoa  = new Pessoa();

        public Conta(int quantidadeCorrentista)
        {
            saldo = quantidadeCorrentista;
        }


        public void setIdadeCorrentista(int idade)
        {
            pessoa.idade = idade;
        }

        virtual public float calcularSaldo()
        {
            return saldo;
        }

        public abstract void teste();
      

    }
}
