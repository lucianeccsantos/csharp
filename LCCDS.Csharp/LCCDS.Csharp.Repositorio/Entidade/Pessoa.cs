using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCCDS.Csharp.Repositorio.Entidade
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public List<Endereco> Enderecos { get; set; }
        public List<Documento> Documentos { get; set; }
        
    }
}
