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

        public Alumno buscarPorDni(string dni)
        {
            gestorDAO.abrirConexion();
            Alumno alumno = alumnoDAO.buscarPorDni(dni);
            gestorDAO.cerrarConexion();
            return alumno;
        }

        public void guardarAlumno(Alumno alumno)
        {
            if (!alumno.esCorreoValido())
                throw new Exception("No se puede guardar porque el correo no tiene un formato válido.");
            if (!alumno.sonSoloNumeros(alumno.Dni))
                throw new Exception("No se puede guardar porque el DNI ingresado no contiene solo digitos numéricos.");
            if (!alumno.sonSoloNumeros(alumno.Celular))
                throw new Exception("No se puede guardar porque el celular ingresado no contiene solo digitos numéricos.");
            if (!alumno.esFechaDeNacimientoValida())
                throw new Exception("No se puede guardar porque la fecha de nacimiento es mayor o igual a la fecha actual.");
            if (alumno.esEdadValida())
                throw new Exception("No se puede guardar porque la edad del alumno es menor a 14.");
            gestorDAO.abrirConexion();
            alumnoDAO.guardarAlumno(alumno);
            gestorDAO.cerrarConexion();
        }
    }
}
