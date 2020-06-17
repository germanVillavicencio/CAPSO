using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AcademiaSoft.CapaDominio;
using AcademiaSoft.CapaDominio.Entidades;
using System.Collections.Generic;

namespace UnitTestProyectoAcademiaSoft
{
    [TestClass]
    public class UnitTestCicloAcademico
    {
        //-----REGLA esValidoRegistro()
        [TestMethod]
        public void esValidoRegistroTest1()
        {
            int cantidadDeAlumnosRegistrado = 29;
            CicloAcademico ca = new CicloAcademico();
            ca.TotalDeAlumnos = 30;
            bool resultadoEsperado = true;  //limite
            bool resultadoFinal = ca.esValidoRegistro(cantidadDeAlumnosRegistrado);
            Assert.AreEqual(resultadoEsperado, resultadoFinal);
        }

        [TestMethod]
        public void esValidoRegistroTest2()
        {
            int cantidadDeAlumnosRegistrado = 31;
            CicloAcademico ca = new CicloAcademico();
            ca.TotalDeAlumnos = 30;
            bool resultadoEsperado = false;  // + del limite
            bool resultadoFinal = ca.esValidoRegistro(cantidadDeAlumnosRegistrado);
            Assert.AreEqual(resultadoEsperado, resultadoFinal);
        }


        //-----REGLA estaAlumnoMatriculado()

        //FUNCION PARA AGREGAR MATRICULAS AL CICLOACADEMICO
        public List<Matricula> crearMatriculas()
        {
            Alumno alum1 = new Alumno(); alum1.Nombre = "Jose"; alum1.Dni = "73737373";
            Alumno alum2 = new Alumno(); alum2.Nombre = "Juan"; alum2.Dni = "74747474";
            Alumno alum3 = new Alumno(); alum3.Nombre = "Jairo"; alum3.Dni = "75757575";
            Alumno alum4 = new Alumno(); alum4.Nombre = "Jorge"; alum4.Dni = "76767676";

            List<Matricula> listaDeMatriculas = new List<Matricula>();

            Matricula matr1 = new Matricula(); matr1.Alumno = alum1;
            Matricula matr2 = new Matricula(); matr2.Alumno = alum2;
            Matricula matr3 = new Matricula(); matr3.Alumno = alum3;
            Matricula matr4 = new Matricula(); matr4.Alumno = alum4;

            listaDeMatriculas.Add(matr1); listaDeMatriculas.Add(matr2);
            listaDeMatriculas.Add(matr3); listaDeMatriculas.Add(matr4);

            return listaDeMatriculas;
        }

        [TestMethod]
        public void estaAlumnoMatriculadoTest1()
        {
            List<Matricula> listaMatriculas = crearMatriculas();
            CicloAcademico ca = new CicloAcademico();
            ca.Matriculas = listaMatriculas;
            string dniAlumno = "73737373";
            bool resultadoEsperado = true;
            bool resultadoFinal = ca.estaAlumnoMatriculado(dniAlumno);
            Assert.AreEqual(resultadoEsperado, resultadoFinal);
        }

        [TestMethod]
        public void estaAlumnoMatriculadoTest2()
        {
            List<Matricula> listaMatriculas = crearMatriculas();
            CicloAcademico ca = new CicloAcademico();
            ca.Matriculas = listaMatriculas;
            string dniAlumno = "12131415";
            bool resultadoEsperado = false;
            bool resultadoFinal = ca.estaAlumnoMatriculado(dniAlumno);
            Assert.AreEqual(resultadoEsperado, resultadoFinal);
        }

        /*
        [TestMethod]
        public void estaAlumnoMatriculadoTest3()
        {
            List<Matricula> listaMatriculas = crearMatriculas();
            CicloAcademico ca = new CicloAcademico();
            ca.Matriculas = listaMatriculas;
            string dniAlumno = "75757575";
            bool resultadoEsperado = true;
            bool resultadoFinal = ca.estaAlumnoMatriculado(dniAlumno);
            Assert.AreEqual(resultadoEsperado, resultadoFinal);
        }

        [TestMethod]
        public void estaAlumnoMatriculadoTest4()
        {
            List<Matricula> listaMatriculas = crearMatriculas();
            CicloAcademico ca = new CicloAcademico();
            ca.Matriculas = listaMatriculas;
            string dniAlumno = "99669966";
            bool resultadoEsperado = false;
            bool resultadoFinal = ca.estaAlumnoMatriculado(dniAlumno);
            Assert.AreEqual(resultadoEsperado, resultadoFinal);
        }*/


        //-----REGLA esValidoFechaMatricula()
        [TestMethod]
        public void esValidoFechaMatriculaTest1()
        {
            CicloAcademico ca = new CicloAcademico();
            ca.FechaInicioMatricula = new DateTime(2020, 05, 03);
            bool resultadoEsperado = false;
            bool resultadoFinal = ca.esValidoFechaMatricula();
            Assert.AreEqual(resultadoEsperado, resultadoFinal);
        }

        [TestMethod]
        public void esValidoFechaMatriculaTest2()
        {
            CicloAcademico ca = new CicloAcademico();
            ca.FechaInicioMatricula = new DateTime(2020, 05, 15);
            bool resultadoEsperado = false;
            bool resultadoFinal = ca.esValidoFechaMatricula();
            Assert.AreEqual(resultadoEsperado, resultadoFinal);
        }

        [TestMethod]
        public void esValidoFechaMatriculaTest3()
        {
            CicloAcademico ca = new CicloAcademico();
            ca.FechaInicioMatricula = new DateTime(2020, 06, 17); //fecha de entrega de S11 primer dia
            bool resultadoEsperado = true;
            bool resultadoFinal = ca.esValidoFechaMatricula();
            Assert.AreEqual(resultadoEsperado, resultadoFinal);
        }

        [TestMethod]
        public void esValidoFechaMatriculaTest4()
        {
            CicloAcademico ca = new CicloAcademico();
            ca.FechaInicioMatricula = new DateTime(2020, 05, 28); //ultimo dia
            bool resultadoEsperado = true;
            bool resultadoFinal = ca.esValidoFechaMatricula();
            Assert.AreEqual(resultadoEsperado, resultadoFinal);
        }


        //-----REGLA calcularFechaInicioClases()
        [TestMethod]
        public void calcularFechaInicioClasesTest1()
        {
            CicloAcademico ca = new CicloAcademico();
            ca.FechaInicioMatricula = new DateTime(2020, 05, 10);
            DateTime resultadoEsperado = new DateTime(2020, 05, 24); //+14 dias
            DateTime resultadoFinal = ca.calcularFechaInicioClases();
            Assert.AreEqual(resultadoEsperado, resultadoFinal);
        }

        [TestMethod]
        public void calcularFechaInicioClasesTest2()
        {
            CicloAcademico ca = new CicloAcademico();
            ca.FechaInicioMatricula = new DateTime(2020, 05, 16);
            DateTime resultadoEsperado = new DateTime(2020, 05, 30); //+14 dias
            DateTime resultadoFinal = ca.calcularFechaInicioClases();
            Assert.AreEqual(resultadoEsperado, resultadoFinal);
        }
        /*
        [TestMethod]
        public void calcularFechaInicioClasesTest3()
        {
            CicloAcademico ca = new CicloAcademico();
            ca.FechaInicioMatricula = new DateTime(2020, 06, 01);
            DateTime resultadoEsperado = new DateTime(2020, 06, 15); //+14 dias
            DateTime resultadoFinal = ca.calcularFechaInicioClases();
            Assert.AreEqual(resultadoEsperado, resultadoFinal);
        }
        */

        //-----REGLA calcularFechaTerminoClases()
        [TestMethod]
        public void calcularFechaTerminoClasesTest1()
        {
            CicloAcademico ca = new CicloAcademico();
            ca.FechaInicioMatricula = new DateTime(2020, 06, 04);
            DateTime resultadoEsperado = new DateTime(2020, 10, 14); // +132 dias
            DateTime resultadoFinal = ca.calcularFechaTerminoClases();
            Assert.AreEqual(resultadoEsperado, resultadoFinal);
        }

        [TestMethod]
        public void calcularFechaTerminoClasesTest2()
        {
            CicloAcademico ca = new CicloAcademico();
            ca.FechaInicioMatricula = new DateTime(2020, 05, 30);
            DateTime resultadoEsperado = new DateTime(2020, 10, 9); // +132 dias
            DateTime resultadoFinal = ca.calcularFechaTerminoClases();
            Assert.AreEqual(resultadoEsperado, resultadoFinal);
        }

        [TestMethod]
        public void calcularFechaTerminoClasesTest3()
        {
            CicloAcademico ca = new CicloAcademico();
            ca.FechaInicioMatricula = new DateTime(2020, 06, 18);
            DateTime resultadoEsperado = new DateTime(2020, 10, 28); // +132 dias
            DateTime resultadoFinal = ca.calcularFechaTerminoClases();
            Assert.AreEqual(resultadoEsperado, resultadoFinal);
        }

    }
}
