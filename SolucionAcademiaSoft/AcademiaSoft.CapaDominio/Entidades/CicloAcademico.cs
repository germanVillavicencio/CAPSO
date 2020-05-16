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

        public CicloAcademico(string periodo, int totalDeAlumnos, DateTime fechaInicio, DateTime fechaFin)
        {
            this.Periodo = periodo;
            this.TotalDeAlumnos = totalDeAlumnos;
            this.FechaInicio = fechaInicio;
            this.FechaFin = fechaFin;
        }

        public string Periodo { get => periodo; set => periodo = value; }
        public int TotalDeAlumnos { get => totalDeAlumnos; set => totalDeAlumnos = value; }
        public DateTime FechaInicio { get => fechaInicio; set => fechaInicio = value; }
        public DateTime FechaFin { get => fechaFin; set => fechaFin = value; }
    }
}
