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
            persona.FechaDeNacimiento = new DateTime(1996, 05, 15);
            int resultadoEsperado = 24;
            int resultado = persona.CalcularEdad();
            Assert.AreEqual(resultadoEsperado, resultado);
        }


        [TestMethod]
        public void Test1_esCorreoValido()
        {
            Persona persona = new Persona();
            persona.Correo = "alexis_covid@gmail.com";
            bool resultadoEsperado = true;
            bool resultado = persona.EsCorreoValido();
            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        public void Test2_esCorreoValido()
        {
            Persona persona = new Persona();
            persona.Correo = "alexis2020gmail.com";
            bool resultadoEsperado = false;
            bool resultado = persona.EsCorreoValido();
            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        public void Test3_esCorreoValido()
        {
            Persona persona = new Persona();
            persona.Correo = "alexis2020@look";
            bool resultadoEsperado = false;
            bool resultado = persona.EsCorreoValido();
            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        public void Test1_sonSoloNumeros()
        {
            Persona persona = new Persona();
            String palabra = "12345";
            bool resultadoEsperado = true;
            bool resultado = persona.SonSoloNumeros(palabra);
            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        public void Test2_sonSoloNumeros()
        {
            Persona persona = new Persona();
            String palabra = "1abc2";
            bool resultadoEsperado = false;
            bool resultado = persona.SonSoloNumeros(palabra);
            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        public void Test1_esFechaDeNacimientoValida()
        {
            Persona persona = new Persona();
            persona.FechaDeNacimiento = new DateTime(2021, 07, 15);
            bool resultadoEsperado = false;
            bool resultado = persona.EsFechaDeNacimientoValida();
            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        public void Test2_esFechaDeNacimientoValida()
        {
            Persona persona = new Persona();
            persona.FechaDeNacimiento = new DateTime(2008, 07, 05);
            bool resultadoEsperado = true;
            bool resultado = persona.EsFechaDeNacimientoValida();
            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        public void Test3_esEdadValida()
        {
            Persona persona = new Persona();
            persona.FechaDeNacimiento = new DateTime(1997, 07, 05);
            bool resultadoEsperado = true;
            bool resultado = persona.EsEdadValida();
            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        public void Test4_esEdadValida()
        {
            Persona persona = new Persona();
            persona.FechaDeNacimiento = new DateTime(2010, 07, 05);
            bool resultadoEsperado = false;
            bool resultado = persona.EsEdadValida();
            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        public void Test1_esNombreValido()
        {
            Persona persona = new Persona();
            persona.Nombre = "Germ@n";
            bool resultadoEsperado = false;
            bool resultado = persona.EsNombreValido(persona.Nombre);
            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        public void Test2_esNombreValido()
        {
            Persona persona = new Persona();
            persona.Nombre = "German";
            bool resultadoEsperado = true;
            bool resultado = persona.EsNombreValido(persona.Nombre);
            Assert.AreEqual(resultadoEsperado, resultado);
        }

    }
}
