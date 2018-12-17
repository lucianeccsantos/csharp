using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCCDS.Csharp.Dominio.Entidade
{
    public class Documento
    {
        public int Id { get; set; }
        public TipoDocumento TipoDocumento { get; set; }
        public string NumeroIdentificacao { get; set; }
        public DateTime DataExpedicao { get; set; }
        public DateTime DataValidade { get; set; }
        public OrgaoExpedidor OrgaoExpedidor { get; set; }

    }
}
