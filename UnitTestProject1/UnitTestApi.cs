﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTestApi
    {
        [TestMethod]
        public void TestMesAteASeis()
        {
            var paramtrosCalculo = new { ValorInicial ="10", Prazo ="6"};
            var calcular = new Calcular();
            var testcalculo = calcular.CalcularParametros(paramtrosCalculo.ValorInicial, paramtrosCalculo.Prazo);
            Assert.IsNotNull(testcalculo.Count);
        }

        [TestMethod]
        public void TestMesAteASeisVazio()
        {
            var paramtrosCalculo = new { ValorInicial = "", Prazo = "" };
            var calcular = new Calcular();
            var testcalculo = calcular.CalcularParametros(paramtrosCalculo.ValorInicial, paramtrosCalculo.Prazo);
            Assert.IsTrue(testcalculo.Count==0);
        }

        [TestMethod]
        public void TestMesAteDoze()
        {
            var paramtrosCalculo = new { ValorInicial = "10", Prazo = "12" };
            var calcular = new Calcular();
            var testcalculo = calcular.CalcularParametros(paramtrosCalculo.ValorInicial, paramtrosCalculo.Prazo);
            Assert.IsNotNull(testcalculo.Count);
        }

        [TestMethod]
        public void TestMesAteDozeVazio()
        {
            var paramtrosCalculo = new { ValorInicial = "", Prazo = "" };
            var calcular = new Calcular();
            var testcalculo = calcular.CalcularParametros(paramtrosCalculo.ValorInicial, paramtrosCalculo.Prazo);
            Assert.IsTrue(testcalculo.Count==0);
        }

        [TestMethod]
        public void TestMesAteVinteQuatro()
        {
            var paramtrosCalculo = new { ValorInicial = "10", Prazo = "24" };
            var calcular = new Calcular();
            var testcalculo = calcular.CalcularParametros(paramtrosCalculo.ValorInicial, paramtrosCalculo.Prazo);
            Assert.IsNotNull(testcalculo.Count);
        }

        [TestMethod]
        public void TestMesAteVinteQuatroVazio()
        {
            var paramtrosCalculo = new { ValorInicial = "", Prazo = "" };
            var calcular = new Calcular();
            var testcalculo = calcular.CalcularParametros(paramtrosCalculo.ValorInicial, paramtrosCalculo.Prazo);
            Assert.IsTrue(testcalculo.Count==0);
        }

        [TestMethod]
        public void TestMesAcimaVinteQuatro()
        {
            var paramtrosCalculo = new { ValorInicial = "10", Prazo = "25" };
            var calcular = new Calcular();
            var testcalculo = calcular.CalcularParametros(paramtrosCalculo.ValorInicial, paramtrosCalculo.Prazo);
            Assert.IsNotNull(testcalculo.Count);
        }

        [TestMethod]
        public void TestMesAcimaVinteQuatroVazio()
        {
            var paramtrosCalculo = new { ValorInicial = "", Prazo = "" };
            var calcular = new Calcular();
            var testcalculo = calcular.CalcularParametros(paramtrosCalculo.ValorInicial, paramtrosCalculo.Prazo);
            Assert.IsTrue(testcalculo.Count==0);
        }
    }
}
