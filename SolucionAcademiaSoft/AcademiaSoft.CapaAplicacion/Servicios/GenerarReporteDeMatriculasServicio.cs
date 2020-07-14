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
        private readonly IGestorDAO gestorDAO;
        private readonly ICicloAcademicoDAO cicloAcademicoDAO;
        private readonly IMatriculaDAO matriculaDAO;

        public GenerarReporteDeMatriculasServicio()
        {
            gestorDAO = new GestorSQL();
            cicloAcademicoDAO = new CicloAcademicoDAO(gestorDAO);
            matriculaDAO = new MatriculaDAO(gestorDAO);
        }

        public List<CicloAcademico> ObtenerCiclosAcademicos()
        {
            gestorDAO.AbrirConexion();
            List<CicloAcademico> ciclos = new List<CicloAcademico>();
            ciclos = cicloAcademicoDAO.BuscarCiclosAcademicos();
            gestorDAO.CerrarConexion();

            return ciclos;
        }

        public List<Matricula> ObtenerMatriculasDeUnCiclo(string periodo)
        {
            List<Matricula> matriculas = null;
            gestorDAO.AbrirConexion();
            matriculas = matriculaDAO.ObtenerMatriculasDeUnCiclo(periodo);
            gestorDAO.CerrarConexion();

            return matriculas;
        }
    }
}
