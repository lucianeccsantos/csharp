using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using LCCDS.Csharp.Dominio.Entidade;

namespace LCCDS.Csharp.Infra.Data.Configuracao
{
    public class OrgaoExpedidorConfiguracao : EntityTypeConfiguration<OrgaoExpedidor>
    {
        public OrgaoExpedidorConfiguracao()
        {
            HasKey(d => d.Id);

            Property(d => d.Nome)
                .IsRequired()
                .HasMaxLength(200);
            Property(d => d.Sigla)
                .IsOptional()
                .HasMaxLength(25);
        }
    }
}
