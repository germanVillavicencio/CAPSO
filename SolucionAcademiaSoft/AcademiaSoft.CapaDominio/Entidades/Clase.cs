using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaSoft.CapaDominio.Entidades
{
    public class Clase
    {
        private Alumno alumno;
        private Docente docente;
        private Horario horario;
        private List<Examen> listaDeExamenes;
        private Curso curso;

        private int codigo;
        private String salon;

        public Clase(int codigo, string salon)
        {
            this.codigo = codigo;
            this.salon = salon;
        }

        public int Codigo { get => codigo; set => codigo = value; }
        public string Salon { get => salon; set => salon = value; }
        internal Alumno Alumno { get => alumno; set => alumno = value; }
        internal Docente Docente { get => docente; set => docente = value; }
        internal Horario Horario { get => horario; set => horario = value; }
        
        internal List<Examen> ListaDeExamenes { get => listaDeExamenes; set => listaDeExamenes = value; }
        internal Curso Curso { get => curso; set => curso = value; }
    }
}
