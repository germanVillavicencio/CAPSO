using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaSoft.CapaDominio.Entidades
{
    public class Secretario : Persona
    {
        private Matricula matricula;
        private double sueldo;

        internal Matricula Matricula { get => matricula; set => matricula = value; }
        public double Sueldo { get => sueldo; set => sueldo = value; }

        public Secretario(double sueldo,String nombre,String dni,DateTime fechaNac, String apellidoP, String apellidoM, int telefono, String correo, String direccion)
        {
            this.Sueldo = sueldo;
            Nombre = nombre;
            Dni = dni;
            FechaDeNacimiento = fechaNac;
            ApellidoPaterno = apellidoP;
            ApellidoPaterno = apellidoM;
            Telefono = telefono;
            Correo = correo;
            Direccion = direccion;
        }

        public void registrarMatricula()
        {

        }

        public void registrarDocente()
        {

        }

        public void registrarCurso()
        {

        }
    }
}
