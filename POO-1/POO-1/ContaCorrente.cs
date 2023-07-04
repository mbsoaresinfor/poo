using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_1
{
    public class ContaCorrente : Conta
    {
        public ContaCorrente(int quantidadeCorrentista) : base(quantidadeCorrentista)
        {
            Console.WriteLine("exec construct contacorrente");
        }

        public override void teste()
        {
            throw new NotImplementedException();
        }

        public override float calcularSaldo()
        {
            return base.calcularSaldo() + 15;
        }
    }
}
