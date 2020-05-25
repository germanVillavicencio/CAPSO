using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AcademiaSoft.CapaDominio.Entidades;
using AcademiaSoft.CapaPersistencia.SQLServerDAO;

namespace AcademiaSoft.CapaAplicacion.Servicios
{
    public class RegistrarMatriculaServicio
    {
        private GestorSQL gestorSQL;
        private AlumnoDAO alumnoDAO;
        private CicloAcademicoDAO cicloAcademicoDAO;
        private MatriculaDAO matriculaDAO;

        public RegistrarMatriculaServicio()
        {
            gestorSQL = new GestorSQL();
            alumnoDAO = new AlumnoDAO(gestorSQL);
            cicloAcademicoDAO = new CicloAcademicoDAO(gestorSQL);
            matriculaDAO = new MatriculaDAO(gestorSQL);
        }

        public Alumno buscarPorDni(string dni)
        {
            gestorSQL.abrirConexion();
            Alumno alumno = alumnoDAO.buscarPorDni(dni);
            gestorSQL.cerrarConexion();
            return alumno;
        }

        public bool verificarVacantes(string periodo)
        {
            int totalAlumnosRegistrados = 0;
            gestorSQL.abrirConexion();
            CicloAcademico cicloAcademico = null;// ciclo academico actual
            List<CicloAcademico> ciclosAcademicos = cicloAcademicoDAO.buscarCiclosAcademicos();

            gestorSQL.iniciarTransaccion();
            foreach (CicloAcademico ciclo in ciclosAcademicos)
            {
                if (ciclo.esValidoFechaMatricula())
                {
                    cicloAcademico = ciclo;
                    break;
                }
                    
            }
            if(cicloAcademico != null)
            {
                totalAlumnosRegistrados = matriculaDAO.calcularAlumnosRegistrados(cicloAcademico.Periodo);
                gestorSQL.cerrarConexion();
                if (cicloAcademico.esValidoRegistro(totalAlumnosRegistrados))
                {
                    return true;
                }
            }

            return false;
        }

        private bool verificarAlumnoMatricula(string dni)
        {
            CicloAcademico cicloAcademico = new CicloAcademico();
            gestorSQL.abrirConexion();
            cicloAcademico.Matriculas = cicloAcademicoDAO.listarMatriculasActuales();
            gestorSQL.cerrarConexion();
            if (cicloAcademico.estaAlumnoMatriculado(dni))
            {
                return true;
            }
            return false;
        }

        private void guardarMatricula(Matricula matricula, Alumno alumno, bool alumnoEncontrado, string turno) {
            gestorSQL.abrirConexion();

            if (alumnoEncontrado)
            {
                if (!verificarAlumnoMatricula(alumno.Dni))
                {
                    gestorSQL.iniciarTransaccion();
                    matriculaDAO.guardarMatricula(matricula,turno);
                }
            }
            else
            {
                gestorSQL.iniciarTransaccion();
                alumnoDAO.guardarAlumno(alumno);
                gestorSQL.iniciarTransaccion();
                matriculaDAO.guardarMatricula(matricula,turno);
            }
            gestorSQL.cerrarConexion(); 
        }
    }
}
