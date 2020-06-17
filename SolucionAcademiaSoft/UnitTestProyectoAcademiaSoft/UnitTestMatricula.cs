using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AcademiaSoft.CapaDominio.Entidades;

namespace UnitTestProyectoAcademiaSoft
{
    [TestClass]
    public class UnitTestMatricula
    {
        //CALCULAR DESCUENTO
        [TestMethod]
        public void Test1_CalcularDescuento()
        {
            Matricula matricula = new Matricula();
            CicloAcademico cicloAcademico = new CicloAcademico();
            cicloAcademico.FechaInicioMatricula = new DateTime(2020, 06, 06);
            matricula.CicloAcademico = cicloAcademico;
            matricula.Precio = 1000;
            double resultadoEsperado = 0;
            double resultado = matricula.calcularDescuento();
            Assert.AreEqual(resultadoEsperado, resultado);
        }


        [TestMethod]
        public void Test3_CalcularDescuento()
        {
            Matricula matricula = new Matricula();
            CicloAcademico cicloAcademico = new CicloAcademico();
            cicloAcademico.FechaInicioMatricula = new DateTime(2020, 06, 15);
            matricula.CicloAcademico = cicloAcademico;
            matricula.Precio = 1000;
            double resultadoEsperado = 150;
            double resultado = matricula.calcularDescuento();
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
            matricula.Precio = 600;
            double resultado_esperado = 510;
            double resultado_obtenido = matricula.calcularPago();
            Assert.AreEqual(resultado_esperado, resultado_obtenido);
        }
    }
}
