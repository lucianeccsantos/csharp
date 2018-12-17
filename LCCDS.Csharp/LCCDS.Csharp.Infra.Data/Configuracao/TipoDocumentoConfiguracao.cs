using LCCDS.Csharp.Dominio.Entidade;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCCDS.Csharp.Infra.Data.Configuracao
{
    public class TipoDocumentoConfiguracao : EntityTypeConfiguration<TipoDocumento>
    {
        public TipoDocumentoConfiguracao()
        {
            HasKey(d => d.Id);

            Property(d => d.Nome)
                .IsRequired();
        }
    }
}
