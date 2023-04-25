using System;

namespace POO_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            Console.WriteLine(p1.nome);
            p1.nome = "marcelo";
            p1.idade = 30;
            Console.WriteLine(p1.nome);
            Console.WriteLine(p1.idade);
            Console.WriteLine(p1.eMaiorIdade());

            Pessoa p2 = new Pessoa();
            p2.nome = "MARCELO";
            p2.idade = 17;
            Console.WriteLine(p2.nome);
            Console.WriteLine(p2.idade);
            Console.WriteLine(p2.eMaiorIdade());

            Console.WriteLine(p1.Equals(p2));

            Console.WriteLine("O nome da pessoa é " + p1.nome +
                " e a idade é " + p1.idade);
            Console.WriteLine("O nome da pessoa é " + p2.nome +
                " e a idade é " + p2.idade);
            Console.WriteLine(p1);
            Console.WriteLine(p2);



        }

        public static bool isEmpty(String valor)
        {
            return valor != null && valor.Equals("") ? true : false;
        }
        public static bool isNull(String valor)
        {
            return valor == null  ? true : false;
        }


        public static int somar(int a, int b)
        {
            return a + b;
        }
            
    }
}
