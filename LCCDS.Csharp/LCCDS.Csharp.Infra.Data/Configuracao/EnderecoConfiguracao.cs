using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using LCCDS.Csharp.Dominio.Entidade;

namespace LCCDS.Csharp.Infra.Data.Configuracao
{
    public class EnderecoConfiguracao : EntityTypeConfiguration<Endereco>
    {
        public EnderecoConfiguracao()
        {
            HasKey(d => d.Id);

            Property(d => d.Logradouro)
                .IsRequired();

            Property(d => d.Numero)
                .IsOptional();

            Property(d => d.Complemento)
                .IsOptional();

            Property(d => d.Bairro)
                .IsOptional()
                .HasMaxLength(50);

            Property(d => d.Cidade)
                .IsRequired()
                .HasMaxLength(100);

            Property(d => d.Estado)
                .IsRequired()
                .HasMaxLength(2);




            
        }
    }
}
