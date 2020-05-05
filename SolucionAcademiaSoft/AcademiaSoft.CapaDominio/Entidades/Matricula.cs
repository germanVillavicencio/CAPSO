using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaSoft.CapaDominio.Entidades
{
    class Matricula
    {
        private Secretario secretario;
        private Alumno alumno;

        private int codigo;
        private DateTime fecha;
        private double pago;
        private String periodo;

        public Matricula(int codigo, DateTime fecha, double pago, string periodo)
        {
            this.codigo = codigo;
            this.fecha = fecha;
            this.pago = pago;
            this.periodo = periodo;
        }

        public int Codigo { get => codigo; set => codigo = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public double Pago { get => pago; set => pago = value; }
        public string Periodo { get => periodo; set => periodo = value; }
        internal Secretario Secretario { get => secretario; set => secretario = value; }

        public void calcularDescuento()
        {

        }

    }
}
