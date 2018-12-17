using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using LCCDS.Csharp.Dominio.Entidade;

namespace LCCDS.Csharp.Infra.Data.Configuracao
{
    public class DocumentoConfiguracao : EntityTypeConfiguration<Documento>
    {
        public DocumentoConfiguracao()
        {
            HasKey(c => c.Id);
                       
            Property(c => c.NumeroIdentificacao)
                .IsRequired();
            Property(c => c.DataExpedicao)
                .IsOptional();
            Property(c => c.DataValidade)
                .IsOptional();

            HasRequired(c => c.OrgaoExpedidor);
            HasRequired(c => c.TipoDocumento);

            
    }
    }
}
