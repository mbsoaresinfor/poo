using POO_2.entidades;
using System;

namespace POO_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Cachorro dog1 = new Cachorro();
            Console.WriteLine(dog1.nome);
            dog1.nome = "pity";
            Console.WriteLine(dog1.nome);
            dog1.peso = 5;
            dog1.late();

            Cachorro dog2 = new Cachorro();
            dog2.nome = "luck";
            dog2.late();

            if (dog2.Equals(dog1))
            {
                Console.WriteLine("os dogs são iguais");
            }
            else
            {
                Console.WriteLine("os dogs não são iguais");
            }

            Console.WriteLine(dog1 +  " racao é " + dog1.racao);
            dog1.peso.ToString();
            Console.WriteLine(dog2);
        }
    }
}
