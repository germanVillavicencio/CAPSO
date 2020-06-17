using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AcademiaSoft.CapaDominio.Entidades;

namespace UnitTestProyectoAcademiaSoft
{
    [TestClass]
    public class UnitTestDocente
    {

        [TestMethod]
        public void Test3_CalcularSueldo()
        {
            Docente docente = new Docente();
            docente.HorasTrabajadas = 20;
            docente.PagoPorHora = 20;
            double resultadoEsperado = 400;
            double resultado = docente.calcularSueldo();
            Assert.AreEqual(resultadoEsperado, resultado);
        }
    }
}
