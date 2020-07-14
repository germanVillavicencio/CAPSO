using System.Collections.Generic;

namespace AcademiaSoft.CapaDominio.Entidades
{
    public class Secretario : Persona
    {
        private List<Matricula> listaDeMatriculas;
        private double sueldo;

        public Secretario() { }

        public double Sueldo { get => sueldo; set => sueldo = value; }
        public List<Matricula> ListaDeMatriculas { get => listaDeMatriculas; set => listaDeMatriculas = value; }
    }
}
