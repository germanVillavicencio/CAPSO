using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

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

        public int CalcularEdad()
        {
            int edad = 0;

            edad = DateTime.Today.AddTicks(-fechaDeNacimiento.Ticks).Year - 1;

            return edad;
        }

        public bool EsCorreoValido()
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(correo, expresion))
            {
                if (Regex.Replace(correo, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public bool SonSoloNumeros(string palabra)
        {
            char[] cadena = palabra.ToCharArray();
            for (int i = 0; i < cadena.Length; i++)
            {
                if (!char.IsDigit(cadena[i]))
                    return false;
            }

            return true;
        }

        //La fecha de nacimiento no puede ser mayor al día actual
        public bool EsFechaDeNacimientoValida()
        {
            if (fechaDeNacimiento.Date >= DateTime.Today.Date)
                return false;
            else
                return true;
        }

        //Un alumno menor de 14 años no se puede registrar
        public bool EsEdadValida()
        {
            if (CalcularEdad() < 14)
                return false;
            else
                return true;
        }

        public bool EsNombreValido(string palabra)
        {
            var existeCaracteresNoValidos = palabra.ToCharArray().Any(c => !char.IsLetter(c));

            char[] cadena = palabra.ToCharArray();
            for (int i = 0; i < cadena.Length; i++)
            {
                if (!char.IsLetter(cadena[i]) && !char.IsWhiteSpace(cadena[i]))
                    return false;
            }
            return true;
        }
    }
}
