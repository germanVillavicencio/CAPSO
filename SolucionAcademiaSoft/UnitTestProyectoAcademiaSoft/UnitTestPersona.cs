using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AcademiaSoft.CapaDominio.Entidades;

namespace UnitTestProyectoAcademiaSoft
{
    [TestClass]
    public class UnitTestPersona
    {
        [TestMethod]
        public void Test1_CalcularEdad()
        {
            Persona persona = new Persona();
            persona.FechaDeNacimiento = new DateTime(1996, 05 , 15);
            int resultadoEsperado = 24;
            int resultado = persona.calcularEdad();
            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        public void Test2_CalcularEdad()
        {
            Persona persona = new Persona();
            persona.FechaDeNacimiento = new DateTime(1996, 06 , 06);
            int resultadoEsperado = 24;
            int resultado = persona.calcularEdad();
            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        public void Test3_CalcularEdad()
        {
            Persona persona = new Persona();
            persona.FechaDeNacimiento = new DateTime(1996, 06 , 07);
            int resultadoEsperado = 23;
            int resultado = persona.calcularEdad();
            Assert.AreEqual(resultadoEsperado, resultado);
        }

    }
}
