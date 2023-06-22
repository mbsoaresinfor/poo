using POO_3.servicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_3.controller
{
    class PessoaController
    {

        PessoaController() { }

        PessoaController(string nome) { }

        PessoaController(int idade) { }

        PessoaController(int idade,string nome) { }


        PessoaServico pessoaService;
        
        public void salvaPessoa(Pessoa pessoa)
        {
            // transfo. pessoa -> pessoaEntidade.
            pessoaService.salvar(null);
        }

        public int salvaPessoa(string nome, int idade)
        {
            // transfo. pessoa -> pessoaEntidade.
            pessoaService.salvar(null);
            return -1;
        }

        public int salvaPessoa(int idade,string nome)
        {
            // transfo. pessoa -> pessoaEntidade.
            pessoaService.salvar(null);
            return -1;
        }

        public void salvaPessoa(int idade, string nome,double peso)
        {
            // transfo. pessoa -> pessoaEntidade.
            pessoaService.salvar(null);         
        }
    }
}
