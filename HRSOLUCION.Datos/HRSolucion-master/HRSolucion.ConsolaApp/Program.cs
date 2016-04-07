using HRSolucion.Datos.EF.Contextos;
using HRSolucion.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSolucion.ConsolaApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CREAMOS REGION Y PAISES (FORMA 1)");
            Region lo_region = Region.Crear(1,"ASIA");
            Pais lo_pais_01 = Pais.Crear("JP", "JAPON", lo_region);
            Pais lo_pais_02 = Pais.Crear("IN", "INDIA", lo_region);
            using (var lo_contexto = new HRContexto())
            {
                lo_contexto.Regiones.Add(lo_region);
                lo_contexto.Paises.Add(lo_pais_01);
                lo_contexto.Paises.Add(lo_pais_02);
                lo_contexto.SaveChanges();
            }
            Console.WriteLine("Región : {0} Creada!!!",lo_region.NombreRegion);
            Console.WriteLine("Pais : {0} Creado!!!", lo_pais_01.NombrePais);
            Console.WriteLine("Pais : {0} Creado!!!", lo_pais_02.NombrePais);
            Console.ReadKey();

            //Console.WriteLine("\n\nCREAMOS REGION Y PAISES (FORMA 2)");
            //lo_region = Region.Crear(2, "EUROPA");
            //lo_region.AdicionarPais("ES", "ESPAÑA");
            //lo_region.AdicionarPais("GE", "ALEMANIA");
            //using (var lo_contexto = new HRContexto())
            //{
            //    lo_contexto.Regiones.Add(lo_region);
            //    lo_contexto.SaveChanges();
            //}
            //Console.WriteLine("Región : {0} Creada!!!", lo_region.NombreRegion);
            //Console.WriteLine("Pais : {0} Creado!!!", lo_pais_01.NombrePais);
            //Console.WriteLine("Pais : {0} Creado!!!", lo_pais_02.NombrePais);
            //Console.ReadKey();

            Console.WriteLine("\n\nACTUALIZAMOS PRIMERA REGION CREADA");
            using (var lo_contexto = new HRContexto())
            {
                var lo_region_seleccionada = lo_contexto.Regiones.Find(1);
                lo_region_seleccionada.Anular();
                lo_contexto.SaveChanges();
                Console.WriteLine("Región : {0} Anulada!!!", lo_region.NombreRegion);
            }
            Console.ReadKey();            
        }
    }
}
