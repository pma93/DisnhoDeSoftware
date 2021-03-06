﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using PatronMixin;

namespace PatronMixinTest
{
    /// <summary>
    /// Clase de pruebas para un pasiego.
    /// </summary>
    [TestClass]
    public class PasiegoTest
    {
        /// <summary>
        /// Test para el metodo hacerQuesada.
        /// </summary>
        [TestMethod]
        public void hacerQuesadaTest()
        {
            Pasiego pasiego = new Pasiego();
            Assert.AreEqual("Haciendo Quesada",pasiego.hacerQuesada());
        } //hacerQuesadaTest

        /// <summary>
        /// Test para el metodo hacerSobaos.
        /// </summary>
        [TestMethod]
        public void hacerSobaosTest()
        {
            Pasiego pasiego = new Pasiego();
            Assert.AreEqual("Haciendo Sobaos", pasiego.hacerSobaos());
        } //hacerSobaosTest
    } //PasiegoTest
} //namespace
