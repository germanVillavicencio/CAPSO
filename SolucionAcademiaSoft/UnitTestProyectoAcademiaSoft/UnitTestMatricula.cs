﻿using AcademiaSoft.CapaDominio.Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProyectoAcademiaSoft
{
    [TestClass]
    public class UnitTestMatricula
    {
        //CALCULAR DESCUENTO
        [TestMethod]
        public void Test1_CalcularDescuento()
        {
            Matricula matricula = new Matricula();    //RESTAMOS 3 DIAS PARA PROBAR LIMITE
            CicloAcademico cicloAcademico = new CicloAcademico();
            cicloAcademico.FechaInicioMatricula = DateTime.Today.AddDays(-4);
            matricula.CicloAcademico = cicloAcademico;
            double precio = 1000;
            double resultadoEsperado = 0;
            double resultado = matricula.CalcularDescuento(precio);
            Assert.AreEqual(resultadoEsperado, resultado);
        }


        [TestMethod]
        public void Test2_CalcularDescuento()
        {
            Matricula matricula = new Matricula();
            CicloAcademico cicloAcademico = new CicloAcademico();
            cicloAcademico.FechaInicioMatricula = DateTime.Today;
            matricula.CicloAcademico = cicloAcademico;
            double precio = 1000;
            double resultadoEsperado = 150;
            double resultado = matricula.CalcularDescuento(precio);
            Assert.AreEqual(resultadoEsperado, resultado);
        }

        //CALCULAR PAGO
        [TestMethod]
        public void Test1_CalcularPago()
        {
            Matricula matricula = new Matricula();
            CicloAcademico cicloAcademico = new CicloAcademico();
            cicloAcademico.FechaInicioMatricula = new DateTime(2020, 06, 15);
            matricula.CicloAcademico = cicloAcademico;
            double precio = 1000;
            double resultado_esperado = 510;
            double resultado_obtenido = matricula.CalcularPago(precio);
            Assert.AreEqual(resultado_esperado, resultado_obtenido);
        }
    }
}
