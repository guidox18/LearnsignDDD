using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LearnSign.Dominio;

namespace LearnSign.Prueba
{
    [TestClass]
    public class PruebasUnitariasAlumno
    {
        [TestMethod]
        public void AlumnoCreadoSatisfactoriamente()
        {
            var lo_alumno = Alumno.Agregar(1, "Guido", "Pacsi Candia", "pacsi.guido@gmail.com", 1, "123456");
            Assert.IsNotNull(lo_alumno);
            Assert.IsTrue(lo_alumno.IdAlumno == 1);
        }

    }
}
