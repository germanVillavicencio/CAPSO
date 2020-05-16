using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaSoft.CapaDominio.Entidades
{
    public class Horario
    {
        private DateTime inicio;
        private DateTime fin;
        private String dia;
        private String turno;

        public Horario(DateTime inicio, DateTime fin, String dia, String turno)
        {
            this.inicio = inicio;
            this.fin = fin;
            this.Dia = dia;
            this.turno = turno;
        }

        public DateTime Inicio { get => inicio; set => inicio = value; }
        public DateTime Fin { get => fin; set => fin = value; }
        public string Dia { get => dia; set => dia = value; }

        public bool esHorarioValido()
        {
            return true;
        }
    }
}
