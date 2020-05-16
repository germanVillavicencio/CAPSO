using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaSoft.CapaDominio.Entidades
{
    public class Examen
    {
        private int nota;
        private String codigo;

        public Examen(int nota, String codigo)
        {
            this.Nota = nota;
            this.Codigo = codigo;
        }

        public string Codigo { get => codigo; set => codigo = value; }
        public int Nota { get => nota; set => nota = value; }
    }
}
