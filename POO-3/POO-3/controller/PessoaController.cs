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
        PessoaServico pessoaService;
        
        public void salvaPessoa(Pessoa pessoa)
        {
            // transfo. pessoa -> pessoaEntidade.
            pessoaService.salvar(null);
        }
    }
}
