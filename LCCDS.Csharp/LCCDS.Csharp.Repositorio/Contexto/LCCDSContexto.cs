using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCCDS.Csharp.Repositorio.Contexto
{
    public class LCCDSContexto : DbContext
    {
        public LCCDSContexto() : base("LCCDSContexto")
        {

        }

        public DbSet<Pessoa> Pessoa { get; set; }
        public DbSet<Documento> Documento { get; set; }
        public DbSet<TipoDocumento> TipoDocumento { get; set; }
        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<OrgaoExpedidor> OrgaoExpedidor { get; set; }

    }
}
