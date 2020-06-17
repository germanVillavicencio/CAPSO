using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AcademiaSoft.CapaDominio.Entidades;
using AcademiaSoft.CapaDominio.Contratos;
using AcademiaSoft.CapaPersistencia.SQLServerDAO;
using System.Diagnostics;

namespace AcademiaSoft.CapaAplicacion.Servicios
{
    public class RegistrarMatriculaServicio
    {
        private IGestorDAO gestorDAO;
        private IAlumnoDAO alumnoDAO;
        private ICicloAcademicoDAO cicloAcademicoDAO;
        private IMatriculaDAO matriculaDAO;

        public RegistrarMatriculaServicio()
        {
            gestorDAO = new GestorSQL();
            alumnoDAO = new AlumnoDAO(gestorDAO);
            cicloAcademicoDAO = new CicloAcademicoDAO(gestorDAO);
            matriculaDAO = new MatriculaDAO(gestorDAO);
        }

        

        public Alumno buscarPorDni(string dni)
        {
            gestorDAO.abrirConexion();
            Alumno alumno = alumnoDAO.buscarPorDni(dni);
            gestorDAO.cerrarConexion();
            return alumno;
        }

        public Boolean verificarVacantes(ref CicloAcademico cicloAcademico, ref String mensaje, ref int totalMatriculasMañana, ref int totalMatriculasTarde)
        {    
            cicloAcademico = obtenerCicloActual();

            if (cicloAcademico != null)
            {
                gestorDAO.abrirConexion();
                cicloAcademico.Matriculas = new List<Matricula>();
                cicloAcademico = cicloAcademicoDAO.obtenerMatriculasDeUnCiclo(cicloAcademico,ref totalMatriculasMañana, ref totalMatriculasTarde);
                gestorDAO.cerrarConexion();

                if (cicloAcademico.esValidoRegistro(totalMatriculasMañana) && cicloAcademico.esValidoRegistro(totalMatriculasTarde))
                {
                    mensaje = "Vacantes disponibles para AMBOS TURNOS";
                    return true;
                }
                else
                {
                    if(cicloAcademico.esValidoRegistro(totalMatriculasMañana))
                    {
                        mensaje = "Solo hay vacantes disponibles para el TURNO MAÑANA";
                        return true;
                    }

                    if (cicloAcademico.esValidoRegistro(totalMatriculasTarde))
                    {
                        mensaje = "Solo hay vacantes disponibles para el TURNO TARDE";
                        return true;
                    }
                    mensaje = "Sin vacantes disponibles";
                }
            }
            else
            {
                mensaje = "No existe ciclo academico disponible";
            }

           
            return false;
        }

        private CicloAcademico obtenerCicloActual()
        {
            gestorDAO.abrirConexion();
            CicloAcademico cicloAcademico;
            cicloAcademico = null;// ciclo academico actual
            List<CicloAcademico> ciclosAcademicos = cicloAcademicoDAO.buscarCiclosAcademicos();

            foreach (CicloAcademico ciclo in ciclosAcademicos)
            {
                if (ciclo.esValidoFechaMatricula())
                {
                    cicloAcademico = ciclo;
                    break;
                }

            }
            gestorDAO.cerrarConexion();

            return cicloAcademico;
        }

        public bool verificarAlumnoMatriculado(string dni, CicloAcademico cicloAcademico)//verifico si el alumno ya está matricula en el ciclo actual
        {
            if (cicloAcademico.estaAlumnoMatriculado(dni))
            {
                return true;
            }
            return false;
        }

        public List<Clase> obtenerClases(string periodo)
        {
            List<Clase> listaDeClases = new List<Clase>();
            gestorDAO.abrirConexion();
            listaDeClases = cicloAcademicoDAO.obtenerClasesDeUnCiclo(periodo);
            gestorDAO.cerrarConexion();
            return listaDeClases;
        }

        public void guardarMatricula(Matricula matricula, bool estaAlumnoRegistrado, string turno) {
            gestorDAO.abrirConexion();

            if (!estaAlumnoRegistrado)
            {
                matricula.Pago = matricula.calcularPago();
                gestorDAO.abrirConexion();
                alumnoDAO.guardarAlumno(matricula.Alumno);
                gestorDAO.cerrarConexion();
            }

            gestorDAO.abrirConexion();
            matriculaDAO.guardarMatricula(matricula,turno);

            gestorDAO.cerrarConexion(); 
        }
    }
}
