using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LearnSign.Dominio;

namespace LearnSign.Prueba
{
    [TestClass]
    public class PruebasUnitariasTema
    {
        [TestMethod]
        public void TemaCreadoSatisfactoriamente()
        {
            var lo_tema = Tema.Agregar(1,1,"TemaNuevo","URL_Tema","DescripcionTema");
            Assert.IsNotNull(lo_tema);
            Assert.IsTrue(lo_tema.IdTema == 1);
        }
    }
}
