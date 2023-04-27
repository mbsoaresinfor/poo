using POO_3.dominios;
using System;
using System.Collections.Generic;

namespace POO_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Cachorro c1 = new Cachorro();
            c1.nome = "luck";
            c1.comer();

            Cachorro c2 = new Cachorro();
            c2.nome = "pity";
            c2.comer();

            List<Cachorro> listaDogbancoDados = new List<Cachorro>();
            listaDogbancoDados.Add(c1);
            listaDogbancoDados.Add(c2);
            String nomeDog = "luck";

            foreach(Cachorro cachorro in listaDogbancoDados)
            {
                if(cachorro.nome == nomeDog)
                {
                    Console.WriteLine("achei o cachorro 1 ");
                }
            }

            Cachorro cachorroParaBuscar = new Cachorro();
            cachorroParaBuscar.nome = "luck";

            if (listaDogbancoDados.Contains(cachorroParaBuscar))
            {
                Console.WriteLine("achei o cachorro 2");
            }

            if (c1.Equals(c2))
            {
                Console.WriteLine("os cachorros são iguais");
            }
            else
            {
                Console.WriteLine("os cachorros não são iguais");
            }

            Console.WriteLine($"o nome do cachrro e {c1.nome} e sua racao {c1.racao}");
            Console.WriteLine($"o nome do cachrro e {c2.nome} e sua racao {c2.racao}");
            c1.nome = "";
            int idade = 15;
            Console.WriteLine(idade);
            Console.WriteLine(c2);
            
            
        }
        public static int fatorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            return n * fatorial(n - 1);
        }
    }
}
