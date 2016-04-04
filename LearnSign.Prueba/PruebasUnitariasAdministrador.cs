using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LearnSign.Dominio;

namespace LearnSign.Prueba
{
    [TestClass]
    public class PruebasUnitariasAdministrador
    {
        [TestMethod]
        public void AdminsitradorCreadoSatisfactoriamente()
        {
            var lo_adminsitrador = Adminsitrador.Agregar(1, 70653666, "Edwin", "Condori Vilcapuma", "edwin@gmail.com", "Zela 666", 052311413, 974858666, 1, "123456");
            Assert.IsNotNull(lo_adminsitrador);
            Assert.IsTrue(lo_adminsitrador.IdAdministrador == 1);

        }
    }
}
