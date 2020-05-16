using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaSoft.CapaDominio.Entidades
{
    public class Persona
    {
        protected String dni;
        protected String nombre;
        protected String apellidoPaterno;
        protected String apellidoMaterno;
        protected DateTime fechaDeNacimiento;
        protected String celular;
        protected String correo;
        protected String direccion;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Dni { get => dni; set => dni = value; }
        public DateTime FechaDeNacimiento { get => fechaDeNacimiento; set => fechaDeNacimiento = value; }
        public string ApellidoPaterno { get => apellidoPaterno; set => apellidoPaterno = value; }
        public string ApellidoMaterno { get => apellidoMaterno; set => apellidoMaterno = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Celular { get => celular; set => celular = value; }

        public void calcularEdad()
        {

        }
    }
}
