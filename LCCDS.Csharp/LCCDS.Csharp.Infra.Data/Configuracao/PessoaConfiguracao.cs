using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using LCCDS.Csharp.Dominio.Entidade;

namespace LCCDS.Csharp.Infra.Data.Configuracao
{
    public class PessoaConfiguracao : EntityTypeConfiguration<Pessoa>
    {
        public PessoaConfiguracao()
        {
            HasKey(d => d.Id);

            Property(d => d.Nome)
                .IsRequired();

            HasRequired(d => d.Documentos)
                .WithMany()
                .HasForeignKey(d => d.Documentos);
            HasRequired(d => d.Endereco)
                .WithMany()
                .HasForeignKey(d => d.Endereco);

        }
    }
}
