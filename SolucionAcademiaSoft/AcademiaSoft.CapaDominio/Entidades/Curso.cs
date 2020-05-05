using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaSoft.CapaDominio.Entidades
{
    class Curso
    {
        private List<Clase> listaDeClases;

        private String nombre;
        private int codigo;

        public Curso(string nombre, int codigo)
        {
            this.nombre = nombre;
            this.codigo = codigo;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Codigo { get => codigo; set => codigo = value; }
        internal List<Clase> ListaDeClases { get => listaDeClases; set => listaDeClases = value; }
    }
}
