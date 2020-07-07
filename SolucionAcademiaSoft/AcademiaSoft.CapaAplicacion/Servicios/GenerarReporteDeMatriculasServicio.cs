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
    public class GenerarReporteDeMatriculasServicio
    {
        private IGestorDAO gestorDAO;
        private ICicloAcademicoDAO cicloAcademicoDAO;
        private IMatriculaDAO matriculaDAO;

        public GenerarReporteDeMatriculasServicio()
        {
            gestorDAO = new GestorSQL();
            cicloAcademicoDAO = new CicloAcademicoDAO(gestorDAO);
            matriculaDAO = new MatriculaDAO(gestorDAO);
        }

        public List<CicloAcademico> obtenerCiclosAcademicos()
        {
            gestorDAO.abrirConexion();
            List<CicloAcademico> ciclos = new List<CicloAcademico>();
            ciclos = cicloAcademicoDAO.buscarCiclosAcademicos();
            gestorDAO.cerrarConexion();

            return ciclos;
        }

        public List<Matricula> obtenerMatriculasDeUnCiclo(string periodo)
        {
            List<Matricula> matriculas = null;
            gestorDAO.abrirConexion();
            matriculas = matriculaDAO.obtenerMatriculasDeUnCiclo(periodo);
            gestorDAO.cerrarConexion();

            return matriculas;
        }
    }
}
