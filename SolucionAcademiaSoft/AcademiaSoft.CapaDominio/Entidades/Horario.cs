using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaSoft.CapaDominio.Entidades
{
    public class Horario
    {
        private string inicio;
        private string fin;
        private string dia;
        private string turno;

        public Horario() { }

        public Horario(string inicio, string fin, string dia, string turno)
        {
            this.inicio = inicio;
            this.fin = fin;
            this.Dia = dia;
            this.Turno = turno;
        }

        public string Inicio { get => inicio; set => inicio = value; }
        public string Fin { get => fin; set => fin = value; }
        public string Dia { get => dia; set => dia = value; }
        public string Turno { get => turno; set => turno = value; }
    }
}
