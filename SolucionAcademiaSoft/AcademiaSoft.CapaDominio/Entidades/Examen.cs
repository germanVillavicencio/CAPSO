using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaSoft.CapaDominio.Entidades
{
    public class Examen
    {
        private Clase clase;

        private int calificacion;
        private String tipo;
        private double procentaje;

        public Examen(int calificacion, string tipo, double procentaje)
        {
            this.calificacion = calificacion;
            this.tipo = tipo;
            this.procentaje = procentaje;
        }

        public int Calificacion { get => calificacion; set => calificacion = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public double Procentaje { get => procentaje; set => procentaje = value; }
        internal Clase Clase { get => clase; set => clase = value; }
    }
}
