using System;
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
        private double precio;
        private DateTime fechaInicio;
        private DateTime fechaFin;
        private DateTime fechaInicioMatricula;
        private List<Clase> clases;
        private List<Matricula> listaMatriculas;

        public CicloAcademico() { }

        public string Periodo { get => periodo; set => periodo = value; }
        public int TotalDeAlumnos { get => totalDeAlumnos; set => totalDeAlumnos = value; }
        public List<Clase> Clases { get => clases; set => clases = value; }
        public DateTime FechaInicioMatricula { get => fechaInicioMatricula; set => fechaInicioMatricula = value; }
        public List<Matricula> ListaMatriculas { get => listaMatriculas; set => listaMatriculas = value; }
        public double Precio { get => precio; set => precio = value; }
        public DateTime FechaInicio { get => fechaInicio; set => fechaInicio = value; }
        public DateTime FechaFin { get => fechaFin; set => fechaFin = value; }


        //V(G) = 2
        public bool EsValidoRegistro(int cantidadAlumnosRegistrados)
        {
            bool esValido;

            if (cantidadAlumnosRegistrados < totalDeAlumnos)
                esValido = true;
            else
                esValido = false;

            return esValido;
        }

        //V(G) = 2
        public bool EstaAlumnoMatriculado(string dni)
        {
            foreach(Matricula m in listaMatriculas)
            {
                if (m.Alumno.Dni.Equals(dni))
                    return true;
            }

            return false;
        }

        //V(G) = 2
        public bool EsValidoFechaMatricula()
        {
            DateTime fechaActual = DateTime.Today;

            DateTime fechaFinMatricula = fechaInicioMatricula.AddDays(20);

            if ( fechaActual >= fechaInicioMatricula  && fechaActual <= fechaFinMatricula)
                return true;
            else
                return false;

        }

        //V(G) = 1
        public DateTime CalcularFechaInicioClases()
        {
            return fechaInicioMatricula.AddDays(14);//Dos semanas despues de la fecha de inicio de matricula
        }

        //V(G) = 1
        public DateTime CalcularFechaTerminoClases()
        {
            return fechaInicioMatricula.AddDays(132);//18 semanas mas 6 dias despues del pago de matricula
        }

        public int CalcularMatriculasPorTurno(string turno)
        {
            int total = 0;
            foreach(Matricula matricula in listaMatriculas)
            {
                if (matricula.Turno.Equals(turno))
                    total++;
            }

            return total;
        }
    }
}
