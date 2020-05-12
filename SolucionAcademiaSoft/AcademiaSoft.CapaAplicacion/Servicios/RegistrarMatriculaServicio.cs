using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using AcademiaSoft.CapaDominio.Entidades;
using AcademiaSoft.CapaPersistencia.SQLServerDAO;

namespace AcademiaSoft.CapaAplicacion.Servicios
{
    public class RegistrarMatriculaServicio
    {
        private GestorSQL gestorSQL;
        private AlumnoDAO alumnoDAO;

        public RegistrarMatriculaServicio()
        {
            gestorSQL = new GestorSQL();
            alumnoDAO = new AlumnoDAO(gestorSQL);
        }

        public Alumno buscarPorDni(string dni)
        {
            gestorSQL.abrirConexion();
            Alumno alumno = alumnoDAO.buscarPorDni(dni);
            gestorSQL.cerrarConexion();

            return alumno;
        }
    }
}
