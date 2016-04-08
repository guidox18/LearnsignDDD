using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learnsign.Infraestructura.Contexto
{
    public class InicializadorDb : CreateDatabaseIfNotExists<LearnSignContexto>
    {
        protected override void Seed(LearnSignContexto contexto)
        {

        }
    }
}
