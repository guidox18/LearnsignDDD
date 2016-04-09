using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Learnsign.Dominio;

namespace LearnSign.Prueba
{
    [TestClass]
    public class PruebasUnitariasModulo
    {
        [TestMethod]
        public void ModuloCreadoSatisfactoriamente()
        {
            var lo_modulo = Modulo.Agregar(1,"nombremodulo",1);
            Assert.IsNotNull(lo_modulo);
            Assert.IsTrue(lo_modulo.IdModulo == 1);
        }
    }
}
