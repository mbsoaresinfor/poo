using POO_2.entidades;
using POO_2.repository;
using System;

namespace POO_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cachorro dog1 = new Cachorro();
            //Console.WriteLine(dog1.nome);
            //dog1.nome = "pity";
            //Console.WriteLine(dog1.nome);
            //dog1.peso = 5;
            //dog1.late();

            //Cachorro dog2 = new Cachorro();
            //dog2.nome = "luck";
            //dog2.late();

            //if (dog2.Equals(dog1))
            //{
            //    Console.WriteLine("os dogs são iguais");
            //}
            //else
            //{
            //    Console.WriteLine("os dogs não são iguais");
            //}

            //Console.WriteLine(dog1 +  " racao é " + dog1.racao);
            //dog1.peso.ToString();
            //Console.WriteLine(dog2);

            //Cachorro c = new Cachorro();
            //BancoDados bancoDados = new BancoDados();
            //bancoDados.conectar();


            //Pessoa pessoa = new Pessoa("pedro",15);

            //PessoaRepository pessoaRepository = new PessoaRepository();

            //Pessoa p = new Pessoa("marcelo", 04);

            //Cachorro cachorro = new Cachorro();
            //cachorro.nome = "kksdksds";
            //cachorro.peso = 555;
            //cachorro.racao = "sdsdsdsd";

            Pessoa pessoa = new Pessoa();
            pessoa.setNomeRua("cachoerinha");

            BancoDados bancoDados = new BancoDados();
            bancoDados.conectar("192.168.72.5");
            bancoDados.conectar();

            Calculadora calculadora = new Calculadora();
            calculadora.somar(1, 1); // int
            calculadora.somar(2d, 2d); // double
            calculadora.somar(2f, 2); // float




        }
    }
}
