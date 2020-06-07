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
            int cantidadDeAlumnosRegistrado = 12;
            CicloAcademico ca = new CicloAcademico();
            ca.TotalDeAlumnos = 30 ;
            bool resultadoEsperado = true;
            bool resultadoFinal = ca.esValidoRegistro(cantidadDeAlumnosRegistrado);
            Assert.AreEqual(resultadoEsperado, resultadoFinal);
        }

        [TestMethod]
        public void esValidoRegistroTest2()
        {
            int cantidadDeAlumnosRegistrado = 32;
            CicloAcademico ca = new CicloAcademico();
            ca.TotalDeAlumnos = 30;
            bool resultadoEsperado = false;
            bool resultadoFinal = ca.esValidoRegistro(cantidadDeAlumnosRegistrado);
            Assert.AreEqual(resultadoEsperado, resultadoFinal);
        }


        //-----REGLA estaAlumnoMatriculado()

        //FUNCION PARA AGREGAR MATRICULAS AL CICLOACADEMICO
        public List<Matricula> crearMatriculas()
        {
            Alumno a1 = new Alumno();
            a1.Nombre = "Jose"; a1.Dni = "73737373";

            Alumno a2 = new Alumno();
            a2.Nombre = "Juan"; a2.Dni = "74747474";

            Alumno a3 = new Alumno();
            a3.Nombre = "Jairo"; a3.Dni = "75757575";

            Alumno a4 = new Alumno();
            a4.Nombre = "Jorge"; a4.Dni = "76767676";

            List<Matricula> listaDeMatriculas = new List<Matricula>();
            Matricula m1 = new Matricula(); Matricula m2 = new Matricula();
            m1.Alumno = a1; m2.Alumno = a2;
            Matricula m3 = new Matricula(); Matricula m4 = new Matricula();
            m3.Alumno = a3; m4.Alumno = a4;

            listaDeMatriculas.Add(m1); listaDeMatriculas.Add(m2); 
            listaDeMatriculas.Add(m3); listaDeMatriculas.Add(m4);

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
        }


        //-----REGLA esValidoFechaMatricula()
        [TestMethod]
        public void esValidoFechaMatriculaTest1()
        {
            CicloAcademico ca = new CicloAcademico();
            ca.FechaInicioMatricula = new DateTime(2020, 05, 26);
            bool resultadoEsperado = true;
            bool resultadoFinal = ca.esValidoFechaMatricula();
            Assert.AreEqual(resultadoEsperado, resultadoFinal);
        }

        [TestMethod]
        public void esValidoFechaMatriculaTest2()
        {
            CicloAcademico ca = new CicloAcademico();
            ca.FechaInicioMatricula = new DateTime(2020, 05, 12);
            bool resultadoEsperado = false;
            bool resultadoFinal = ca.esValidoFechaMatricula();
            Assert.AreEqual(resultadoEsperado, resultadoFinal);
        }

        [TestMethod]
        public void esValidoFechaMatriculaTest3()
        {
            CicloAcademico ca = new CicloAcademico();
            ca.FechaInicioMatricula = new DateTime(2020, 06, 07); //fecha de entrega de S9
            bool resultadoEsperado = true;
            bool resultadoFinal = ca.esValidoFechaMatricula();
            Assert.AreEqual(resultadoEsperado, resultadoFinal);
        }

        [TestMethod]
        public void esValidoFechaMatriculaTest4()
        {
            CicloAcademico ca = new CicloAcademico();
            ca.FechaInicioMatricula = new DateTime(2020, 05, 18);
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
            DateTime resultadoEsperado = new DateTime(2020, 05, 24);
            DateTime resultadoFinal = ca.calcularFechaInicioClases();
            Assert.AreEqual(resultadoEsperado, resultadoFinal);
        }

        [TestMethod]
        public void calcularFechaInicioClasesTest2()
        {
            CicloAcademico ca = new CicloAcademico();
            ca.FechaInicioMatricula = new DateTime(2020, 05, 16);
            DateTime resultadoEsperado = new DateTime(2020, 05, 30);
            DateTime resultadoFinal = ca.calcularFechaInicioClases();
            Assert.AreEqual(resultadoEsperado, resultadoFinal);
        }

        [TestMethod]
        public void calcularFechaInicioClasesTest3()
        {
            CicloAcademico ca = new CicloAcademico();
            ca.FechaInicioMatricula = new DateTime(2020, 06, 01);
            DateTime resultadoEsperado = new DateTime(2020, 06, 15);
            DateTime resultadoFinal = ca.calcularFechaInicioClases();
            Assert.AreEqual(resultadoEsperado, resultadoFinal);
        }


        //-----REGLA calcularFechaTerminoClases()
        [TestMethod]
        public void calcularFechaTerminoClasesTest1()
        {
            CicloAcademico ca = new CicloAcademico();
            ca.FechaInicioMatricula = new DateTime(2020, 06, 04);
            DateTime resultadoEsperado = new DateTime(2020, 10, 14);
            DateTime resultadoFinal = ca.calcularFechaTerminoClases();
            Assert.AreEqual(resultadoEsperado, resultadoFinal);
        }

        [TestMethod]
        public void calcularFechaTerminoClasesTest2()
        {
            CicloAcademico ca = new CicloAcademico();
            ca.FechaInicioMatricula = new DateTime(2020, 05, 30);
            DateTime resultadoEsperado = new DateTime(2020, 10, 9);
            DateTime resultadoFinal = ca.calcularFechaTerminoClases();
            Assert.AreEqual(resultadoEsperado, resultadoFinal);
        }

        [TestMethod]
        public void calcularFechaTerminoClasesTest3()
        {
            CicloAcademico ca = new CicloAcademico();
            ca.FechaInicioMatricula = new DateTime(2020, 06, 18);
            DateTime resultadoEsperado = new DateTime(2020, 10, 28);
            DateTime resultadoFinal = ca.calcularFechaTerminoClases();
            Assert.AreEqual(resultadoEsperado, resultadoFinal);
        }

    }
}
