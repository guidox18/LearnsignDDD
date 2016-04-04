﻿using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LearnSign.Dominio;
using Learnsign.Infraestructura;

namespace LearnSign.Prueba
{
    /// <summary>
    /// Descripción resumida de PruebasIntegralesArticulo
    /// </summary>
    [TestClass]
    public class PruebasIntegralesArticulo
    {
        public PruebasIntegralesArticulo()
        {
            //
            // TODO: Agregar aquí la lógica del constructor
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Obtiene o establece el contexto de las pruebas que proporciona
        ///información y funcionalidad para la serie de pruebas actual.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Atributos de prueba adicionales
        //
        // Puede usar los siguientes atributos adicionales conforme escribe las pruebas:
        //
        // Use ClassInitialize para ejecutar el código antes de ejecutar la primera prueba en la clase
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup para ejecutar el código una vez ejecutadas todas las pruebas en una clase
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Usar TestInitialize para ejecutar el código antes de ejecutar cada prueba 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup para ejecutar el código una vez ejecutadas todas las pruebas
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void AgregarArticulo()
        {
            var lo_articulo = Articulo.Agregar(1, "Articulo 01", "Descripcion del articulo 01", "/imagenes/foto0001.jpg");
            using (var lo_contexto = new LearnSignContexto())
            {

                lo_contexto.Articulos.Add(lo_articulo);
                lo_contexto.SaveChanges();

            }
            Assert.IsTrue(lo_articulo.IdArticulo == 1);
            //
            // TODO: Agregar aquí la lógica de las pruebas
            //
        }
    }
}