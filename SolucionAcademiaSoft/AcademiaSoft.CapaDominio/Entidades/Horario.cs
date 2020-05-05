using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaSoft.CapaDominio.Entidades
{
    public class Horario
    {
        private Clase clase;

        private DateTime inicio;
        private DateTime fin;
        private DateTime dia;

        public Horario(DateTime inicio, DateTime fin, DateTime dia)
        {
            this.inicio = inicio;
            this.fin = fin;
            this.dia = dia;
        }

        public DateTime Inicio { get => inicio; set => inicio = value; }
        public DateTime Fin { get => fin; set => fin = value; }
        public DateTime Dia { get => dia; set => dia = value; }
        internal Clase Clase { get => clase; set => clase = value; }

        public bool esHorarioValido()
        {
            return true;
        }
    }
}
