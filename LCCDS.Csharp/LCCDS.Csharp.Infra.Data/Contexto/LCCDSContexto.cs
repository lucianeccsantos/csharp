using LCCDS.Csharp.Dominio.Entidade;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCCDS.Csharp.Infra.Data.Contexto
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

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Properties()
                .Where(p => p.Name == "Id")
                .Configure(p => p.IsKey());

            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(250)
                                .HasColumnType("varchar"));
            


        }
    }
}
