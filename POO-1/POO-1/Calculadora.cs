using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_1
{
    class Calculadora 
    {
        int valor;
        String operacao;

        int somar(int a, int b)
        {
            operacao = "somar";
            valor =  a + b;
            return valor;
        }
        int subtrair(int a, int b)
        {
            operacao = "subtrair";
            valor = a - b;
            return valor;
        }
    
         int ultimaResultado()
        {
            return valor;
        }
        
        String ultimaOperacao()
        {
            return operacao;
        }


    }
}
