using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_1
{
    class Produto
    {
        String nome;
        float preco;
        String descricao;

        public String mostraNomeProduto()
        {
            return nome;
        }

        public float mostraPreco()
        {
            return preco;
        }

        public void mostradescricaoProduto()
        {
            Console.WriteLine(descricao);
        }


    }
}
