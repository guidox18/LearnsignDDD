using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LearnSign.Dominio;

namespace LearnSign.Prueba
{
    [TestClass]
    public class PruebasUnitariasEvaluacion
    {
        [TestMethod]
        public void EvaluacionCreadoSatisfactoriamente()
        {
            var lo_evaluacion = Evaluacion.Agregar(1, 1, 1, 01-04-2016 , 1);
            Assert.IsNotNull(lo_evaluacion);
            Assert.IsTrue(lo_evaluacion.IdEvaluacion == 1);
        }
    }
}
