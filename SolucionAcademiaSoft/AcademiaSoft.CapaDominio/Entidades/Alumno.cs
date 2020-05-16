using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaSoft.CapaDominio.Entidades
{
    public class Alumno : Persona
    {
        private int idCard;
        private Matricula matricula;

        public Alumno() { }

        public Alumno(int idCard, String nombre, String dni, DateTime fechaNac, String apellidoP, String apellidoM, String celular, String correo, String direccion)
        {
            this.IdCard = idCard;
            Nombre = nombre;
            Dni = dni;
            FechaDeNacimiento = fechaNac;
            ApellidoPaterno = apellidoP;
            ApellidoPaterno = apellidoM;
            Celular = celular;
            Correo = correo;
            Direccion = direccion;
        }

        public int IdCard { get => idCard; set => idCard = value; }
        
    }
}
