using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LearnSign.Dominio;

namespace LearnSign.Prueba
{
    [TestClass]
    public class PruebasUnitariasComentario
    {
        [TestMethod]
        public void ComentarioCreadoSatisfactoriamente()
        {

            var lo_comentario = Comentario.Agregar(1, 1,1, "Comentario del alumno", DateTime.Parse("17-12-2015"));
            Assert.IsNotNull(lo_comentario);
            Assert.IsTrue(lo_comentario.IdComentario == 1);

        }
    }
}
