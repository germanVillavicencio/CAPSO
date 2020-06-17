﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaSoft.CapaDominio.Entidades
{
    public class CicloAcademico
    {
        private String periodo;
        private int totalDeAlumnos;
        private DateTime fechaInicio;
        private DateTime fechaFin;
        private DateTime fechaInicioMatricula;
        private List<Clase> clases;
        private List<Matricula> matriculas;

        public CicloAcademico() { }
        public CicloAcademico(string periodo, int totalDeAlumnos, DateTime fechaInicio, DateTime fechaFin, DateTime fechaInicioMatricula)
        {
            this.Periodo = periodo;
            this.TotalDeAlumnos = totalDeAlumnos;
            this.FechaInicio = fechaInicio;
            this.FechaFin = fechaFin;
            this.FechaInicioMatricula = fechaInicioMatricula;
            this.Clases = new List<Clase>();
            this.Matriculas = new List<Matricula>();
        }

        public string Periodo { get => periodo; set => periodo = value; }
        public int TotalDeAlumnos { get => totalDeAlumnos; set => totalDeAlumnos = value; }
        public DateTime FechaInicio { get => fechaInicio; set => fechaInicio = value; }
        public DateTime FechaFin { get => fechaFin; set => fechaFin = value; }
        public List<Clase> Clases { get => clases; set => clases = value; }
        public DateTime FechaInicioMatricula { get => fechaInicioMatricula; set => fechaInicioMatricula = value; }
        public List<Matricula> Matriculas { get => matriculas; set => matriculas = value; }

        //V(G) = 2
        public bool esValidoRegistro(int cantidadAlumnosRegistrados)
        {
            bool esValido;

            if (cantidadAlumnosRegistrados < totalDeAlumnos)
                esValido = true;
            else
                esValido = false;

            return esValido;
        }

        //V(G) = 2
        public bool estaAlumnoMatriculado(string dni)
        {
            foreach(Matricula m in matriculas)
            {
                if (m.Alumno.Dni.Equals(dni))
                    return true;
            }

            return false;
        }

        //V(G) = 2
        public bool esValidoFechaMatricula()
        {
            DateTime fechaActual = DateTime.Today;

            DateTime fechaFinMatricula = fechaInicioMatricula.AddDays(20);

            if ( fechaActual >= fechaInicioMatricula  && fechaActual <= fechaFinMatricula)
                return true;
            else
                return false;

        }

        //V(G) = 1
        public DateTime calcularFechaInicioClases()
        {
            return fechaInicioMatricula.AddDays(14);//Dos semanas despues de la fecha de inicio de matricula
        }

        //V(G) = 1
        public DateTime calcularFechaTerminoClases()
        {
            return fechaInicioMatricula.AddDays(132);//18 semanas mas 6 dias despues del pago de matricula
        }
    }
}
