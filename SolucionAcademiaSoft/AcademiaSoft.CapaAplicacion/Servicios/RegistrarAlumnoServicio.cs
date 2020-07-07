using AcademiaSoft.CapaDominio.Contratos;
using AcademiaSoft.CapaDominio.Entidades;
using AcademiaSoft.CapaPersistencia.SQLServerDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaSoft.CapaAplicacion.Servicios
{
    public class RegistrarAlumnoServicio
    {
        private IGestorDAO gestorDAO;
        private IAlumnoDAO alumnoDAO;

        public RegistrarAlumnoServicio()
        {
            gestorDAO = new GestorSQL();
            alumnoDAO = new AlumnoDAO(gestorDAO);
        }

        public void guardarAlumno(Alumno alumno)
        {
            if (alumno.Dni.Length != 8)
                throw new Exception("No se puede guardar porque el DNI no es una cadena de 8 digitos.");
            if (!alumno.sonSoloNumeros(alumno.Dni))
                throw new Exception("No se puede guardar porque el DNI ingresado no contiene solo digitos.");
            if (alumno.Nombre.Length == 0)
                throw new Exception("No se puede guardar porque el nombre no puede ser una cadena vacía.");
            if (!alumno.esNombreValido(alumno.Nombre))
                throw new Exception("No se puede guardar porque el nombre no tiene un formato válido.");
            if (alumno.ApellidoPaterno.Length == 0)
                throw new Exception("No se puede guardar porque el apellido paterno no puede ser una cadena vacía.");
            if (!alumno.esNombreValido(alumno.ApellidoPaterno))
                throw new Exception("No se puede guardar porque el apellido paterno no tiene un formato válido.");
            if (alumno.ApellidoMaterno.Length == 0)
                throw new Exception("No se puede guardar porque el apellido materno no puede ser una cadena vacía.");
            if (!alumno.esNombreValido(alumno.ApellidoMaterno))
                throw new Exception("No se puede guardar porque el apellido materno no tiene un formato válido.");
            if (!alumno.esFechaDeNacimientoValida())
                throw new Exception("No se puede guardar porque la fecha de nacimiento es mayor o igual a la fecha actual.");
            if (!alumno.esEdadValida())
                throw new Exception("No se puede guardar porque la edad del alumno es menor a 14.");
            if (!alumno.sonSoloNumeros(alumno.Celular))
                throw new Exception("No se puede guardar porque el celular ingresado no contiene solo digitos.");
            if (!alumno.esCorreoValido())
                throw new Exception("No se puede guardar porque el correo no tiene un formato válido.");
            
            gestorDAO.abrirConexion();
            alumnoDAO.guardarAlumno(alumno);
            gestorDAO.cerrarConexion();
        }
    }
}
