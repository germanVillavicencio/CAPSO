using AcademiaSoft.CapaDominio.Contratos;
using AcademiaSoft.CapaDominio.Entidades;
using AcademiaSoft.CapaPersistencia.SQLServerDAO;
using System;

namespace AcademiaSoft.CapaAplicacion.Servicios
{
    public class RegistrarAlumnoServicio
    {
        private readonly IGestorDAO gestorDAO;
        private readonly IAlumnoDAO alumnoDAO;

        public RegistrarAlumnoServicio()
        {
            gestorDAO = new GestorSQL();
            alumnoDAO = new AlumnoDAO(gestorDAO);
        }

        //METODO PARA GUARDAR EL ALUMNO EN LA BD, PRIMERO VALIDA LAS REGLAS DE NEGOCIO
        public void GuardarAlumno(Alumno alumno)
        {
            if (alumno.Dni.Length != 8)
                throw new Exception("No se puede guardar porque el DNI no es una cadena de 8 digitos.");
            if (!alumno.SonSoloNumeros(alumno.Dni))
                throw new Exception("No se puede guardar porque el DNI ingresado no contiene solo digitos.");
            if (alumno.Nombre.Length == 0)
                throw new Exception("No se puede guardar porque el nombre no puede ser una cadena vacía.");
            if (!alumno.EsNombreValido(alumno.Nombre))
                throw new Exception("No se puede guardar porque el nombre no tiene un formato válido.");
            if (alumno.ApellidoPaterno.Length == 0)
                throw new Exception("No se puede guardar porque el apellido paterno no puede ser una cadena vacía.");
            if (!alumno.EsNombreValido(alumno.ApellidoPaterno))
                throw new Exception("No se puede guardar porque el apellido paterno no tiene un formato válido.");
            if (alumno.ApellidoMaterno.Length == 0)
                throw new Exception("No se puede guardar porque el apellido materno no puede ser una cadena vacía.");
            if (!alumno.EsNombreValido(alumno.ApellidoMaterno))
                throw new Exception("No se puede guardar porque el apellido materno no tiene un formato válido.");
            if (!alumno.EsFechaDeNacimientoValida())
                throw new Exception("No se puede guardar porque la fecha de nacimiento es mayor o igual a la fecha actual.");
            if (!alumno.EsEdadValida())
                throw new Exception("No se puede guardar porque la edad del alumno es menor a 14.");
            if (!alumno.SonSoloNumeros(alumno.Celular))
                throw new Exception("No se puede guardar porque el celular ingresado no contiene solo digitos.");
            if (!alumno.EsCorreoValido())
                throw new Exception("No se puede guardar porque el correo no tiene un formato válido.");
            gestorDAO.AbrirConexion();
            if (!alumnoDAO.EsValidoCorreo(alumno.Correo))
                throw new Exception("No se puede guardar porque el correo ya se encuentra registrado.");
            gestorDAO.CerrarConexion();
            gestorDAO.AbrirConexion();
            alumnoDAO.GuardarAlumno(alumno);
            gestorDAO.CerrarConexion();
        }
    }
}
