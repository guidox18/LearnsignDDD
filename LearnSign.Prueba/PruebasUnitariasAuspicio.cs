using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LearnSign.Dominio;

namespace LearnSign.Prueba
{
    [TestClass]
    public class PruebasUnitariasAuspicio
    {
        [TestMethod]
        public void AuspicioCreadoSatisfactoriamente()
        {
            var lo_auspicio = Auspicio.Agregar(1, "Auspicio 01", "/imagenes/foto0001.jpg");
            Assert.IsNotNull(lo_auspicio);
            Assert.IsTrue(lo_auspicio.IdAuspicio == 1);
        }
    }
}
