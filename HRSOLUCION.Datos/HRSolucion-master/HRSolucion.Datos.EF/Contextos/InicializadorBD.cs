using HRSolucion.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSolucion.Datos.EF.Contextos
{
    public class InicializadorBD : CreateDatabaseIfNotExists<HRContexto>
    {
        protected override void Seed(HRContexto context)
        {
            //base.Seed(context);
            //var region01 = new Region() { IDRegion = 1, NombreRegion = "Europa"};
            //var region02 = new Region() { IDRegion = 2, NombreRegion = "Asia" };

            //context.Regiones.Add(region01);
            //context.Regiones.Add(region02);
            //context.SaveChanges();
        }
    }
}
