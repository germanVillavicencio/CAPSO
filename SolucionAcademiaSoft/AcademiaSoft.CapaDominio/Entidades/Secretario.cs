using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaSoft.CapaDominio.Entidades
{
    public class Secretario : Persona
    {
        private List<Matricula> listaDeMatriculas;
        private double sueldo;

        public Secretario() { }
        public Secretario(double sueldo, String nombre, String dni, DateTime fechaNac, String apellidoP, String apellidoM, String celular, String correo, String direccion)
        {
            this.Sueldo = sueldo;
            Nombre = nombre;
            Dni = dni;
            FechaDeNacimiento = fechaNac;
            ApellidoPaterno = apellidoP;
            ApellidoPaterno = apellidoM;
            Celular = celular;
            Correo = correo;
            Direccion = direccion;
        }

        public double Sueldo { get => sueldo; set => sueldo = value; }
        public List<Matricula> ListaDeMatriculas { get => listaDeMatriculas; set => listaDeMatriculas = value; }
    }
}
