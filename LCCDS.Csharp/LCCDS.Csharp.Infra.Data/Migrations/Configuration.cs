using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Migrations;

namespace LCCDS.Csharp.Infra.Data.Migrations
{
    public class Configuration : DbMigrationsConfiguration<Contexto.LCCDSContexto>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }
    }
}
