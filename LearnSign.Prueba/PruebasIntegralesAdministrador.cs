using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LearnSign.Dominio;
using Learnsign.Infraestructura;

namespace LearnSign.Prueba
{
    [TestClass]
    public class PruebasIntegralesAdministrador
    {
        [TestMethod]
        public void AgregarAdministrador()
        {
            var lo_administrador = Administrador.Agregar(1, 70653666, "Edwin", "Condori Vilcapuma", "edwin@gmail.com", "Zela 666", 052311413, 974858666, 1, "123456");
            using (var lo_contexto = new LearnSignContexto())
            {
                lo_contexto.Administradores.Add(lo_administrador);
                lo_contexto.SaveChanges();
            }
            Assert.IsTrue(lo_administrador != null);
        }
    }
}
