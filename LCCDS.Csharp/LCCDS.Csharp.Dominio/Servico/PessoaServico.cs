using LCCDS.Csharp.Dominio.Entidade;
using LCCDS.Csharp.Dominio.Interfaces.Repositorio;
using LCCDS.Csharp.Dominio.Interfaces.Servico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCCDS.Csharp.Dominio.Servico
{
    public class PessoaServico : ServiceBase<Pessoa>, IPessoaServico
    {
        private readonly IPessoaRepositorio _pessoaRepositorio;

        public PessoaServico(IPessoaRepositorio pessoaRepositorio)
            : base(pessoaRepositorio)
        {
            _pessoaRepositorio = pessoaRepositorio;
        }

    }
}
