using System;
using System.Collections.Generic;

namespace AcademiaSoft.CapaDominio.Entidades
{
    public class Curso
    {
        private List<Clase> listaDeClases;

        private String nombre;
        private String codigo;

        public Curso() { }

        public string Nombre { get => nombre; set => nombre = value; }
        public String Codigo { get => codigo; set => codigo = value; }
        public List<Clase> ListaDeClases { get => listaDeClases; set => listaDeClases = value; }
    }
}
