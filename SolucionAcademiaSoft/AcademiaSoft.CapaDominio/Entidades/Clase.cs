using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaSoft.CapaDominio.Entidades
{
    public class Clase
    {
        private Docente docente;
        private Horario horario;
        private Curso curso;

        private String codigo;

        public Clase(String codigo, String salon)
        {
            this.codigo = codigo;
        }

        public String Codigo { get => codigo; set => codigo = value; }
        public Docente Docente { get => docente; set => docente = value; }
        public Horario Horario { get => horario; set => horario = value; }
        public Curso Curso { get => curso; set => curso = value; }
    }
}
