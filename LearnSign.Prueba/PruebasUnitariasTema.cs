using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Learnsign.Dominio;


namespace LearnSign.Prueba
{
    [TestClass]
    public class PruebasUnitariasTema
    {
        [TestMethod]
        public void TemaCreadoSatisfactoriamente()
        {
            var lo_modulo = Modulo.Agregar(1, "modulo", 1);
            var lo_tema = Tema.Agregar(1, lo_modulo, "TemaNuevo", "URL_Tema", "DescripcionTema");
            using (var lo_contexto = new LearnSignContexto())
            {
                lo_contexto.Modulos.Add(lo_modulo);
                lo_contexto.Temas.Add(lo_tema);

                lo_contexto.SaveChanges();
            }

            Assert.IsNotNull(lo_tema);
        }
    }
}
