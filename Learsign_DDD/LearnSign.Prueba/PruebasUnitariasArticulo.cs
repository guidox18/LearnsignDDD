using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LearnSign.Dominio;

namespace LearnSign.Prueba
{
    [TestClass]
    public class PruebasUnitariasArticulo
    {
        [TestMethod]
        public void ArticuloCreadoSatisfactoriamente()
        {
            var lo_articulo = Articulo.Agregar(1, "Articulo 01", "Descripcion del articulo 01", "/imagenes/foto0001.jpg");
            Assert.IsNotNull(lo_articulo);
            Assert.IsTrue(lo_articulo.IdArticulo == 1);

        }

    }
}
