using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_1
{
    class ContaPoupanca : Conta
    {
        public ContaPoupanca(int quantidadeCorrentista) : base(quantidadeCorrentista)
        {
        }

        public override float calcularSaldo()
        {
            return base.calcularSaldo()  + 2;
        }

        public override void teste()
        {
            throw new NotImplementedException();
        }
    }
}
