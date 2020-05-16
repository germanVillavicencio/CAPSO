using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaSoft.CapaDominio.Entidades
{
    public class Matricula
    {
        private Secretario secretario;
        private Alumno alumno;
        private CicloAcademico cicloAcademico;
        private List<Examen> listaDeExamenes;
        private List<Clase> listaDeClases;

        private int codigo;
        private DateTime fecha;
        private double pago;

        public Matricula(int codigo, DateTime fecha, double pago)
        {
            this.codigo = codigo;
            this.fecha = fecha;
            this.pago = pago;
        }

        public int Codigo { get => codigo; set => codigo = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public double Pago { get => pago; set => pago = value; }
        public Secretario Secretario { get => secretario; set => secretario = value; }
        public Alumno Alumno { get => alumno; set => alumno = value; }
        public List<Examen> ListaDeExamenes { get => listaDeExamenes; set => listaDeExamenes = value; }
        public CicloAcademico CicloAcademico { get => cicloAcademico; set => cicloAcademico = value; }
        public List<Clase> ListaDeClases { get => listaDeClases; set => listaDeClases = value; }

        public void calcularDescuento()
        {

        }

    }
}
