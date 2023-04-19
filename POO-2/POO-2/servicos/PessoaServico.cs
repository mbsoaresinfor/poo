using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_2.servicos
{
    public class PessoaServico
    {
        public Boolean eMaiorIdade(Pessoa pessoa)
        {
            return pessoa.idade >= 18;

        }

    }
}
