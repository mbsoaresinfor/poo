using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_1
{
    class Computador
    {
        String nome;
        int clock;

        public void  mostraNomeComputador()
        {
            Console.WriteLine("O nome do computador " + nome);
        }

        int mostraClock()
        {
            return clock;
        }


    }
}
