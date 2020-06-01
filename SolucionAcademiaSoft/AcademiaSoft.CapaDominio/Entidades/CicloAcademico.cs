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
        private DateTime fechaInicio;
        private DateTime fechaFin;
        private DateTime fechaInicioMatricula;
        private List<Clase> clases;
        private List<Matricula> matriculasMañana;
        private List<Matricula> matriculasTarde;

        public CicloAcademico() { }
        public CicloAcademico(string periodo, int totalDeAlumnos, DateTime fechaInicio, DateTime fechaFin, DateTime fechaInicioMatricula)
        {
            this.Periodo = periodo;
            this.TotalDeAlumnos = totalDeAlumnos;
            this.FechaInicio = fechaInicio;
            this.FechaFin = fechaFin;
            this.FechaInicioMatricula = fechaInicioMatricula;
            this.Clases = new List<Clase>();
            this.MatriculasMañana = new List<Matricula>();
            this.MatriculasTarde = new List<Matricula>();
        }

        public string Periodo { get => periodo; set => periodo = value; }
        public int TotalDeAlumnos { get => totalDeAlumnos; set => totalDeAlumnos = value; }
        public DateTime FechaInicio { get => fechaInicio; set => fechaInicio = value; }
        public DateTime FechaFin { get => fechaFin; set => fechaFin = value; }
        public List<Clase> Clases { get => clases; set => clases = value; }
        public DateTime FechaInicioMatricula { get => fechaInicioMatricula; set => fechaInicioMatricula = value; }
        public List<Matricula> MatriculasMañana { get => matriculasMañana; set => matriculasMañana = value; }
        public List<Matricula> MatriculasTarde { get => matriculasTarde; set => matriculasTarde = value; }

        public bool esValidoRegistro(int cantidadAlumnosRegistrados)
        {
            return (totalDeAlumnos>cantidadAlumnosRegistrados);
        }

        public bool estaAlumnoMatriculado(string dni)
        {
            foreach(Matricula m in matriculasMañana)
            {
                if (m.Alumno.Dni.Equals(dni))
                    return true;
            }

            foreach (Matricula m in matriculasTarde)
            {
                if (m.Alumno.Dni.Equals(dni))
                    return true;
            }
            return false;
        }

        public bool esValidoFechaMatricula()
        {
            DateTime fechaActual = DateTime.Today;

            if (fechaInicioMatricula.AddDays(20)>= fechaActual && fechaInicioMatricula<= fechaActual)
            {
                return true;
            }
            return false;
        }

        public DateTime calcularFechaInicioClases()
        {
            return fechaInicioMatricula.AddDays(14);//Dos semanas despues de inicio de pago de matricula
        }

        public DateTime calcularFechaTerminoClases()
        {
            return fechaInicioMatricula.AddDays(132);//18 semanas mas 6 dias despues del pago de matricula
        }
    }
}
