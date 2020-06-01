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

        public Boolean verificarVacantes(ref CicloAcademico cicloAcademico, ref String mensaje)
        {
            gestorSQL.abrirConexion();
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
            
            if(cicloAcademico != null)
            {
                gestorSQL.iniciarTransaccion();
                cicloAcademico.MatriculasMañana = new List<Matricula>();
                cicloAcademico.MatriculasTarde = new List<Matricula>();
                cicloAcademico = cicloAcademicoDAO.obtenerMatriculasDeUnCiclo(cicloAcademico);
                gestorSQL.cerrarConexion();

                int numeroMatriculasMañana = cicloAcademico.MatriculasMañana.Count();
                int numeroMatriculasTarde = cicloAcademico.MatriculasTarde.Count();

               
                if (cicloAcademico.esValidoRegistro(numeroMatriculasMañana) && cicloAcademico.esValidoRegistro(numeroMatriculasTarde))
                {
                    mensaje = "Vacantes disponibles para AMBOS TURNOS";
                    return true;
                }
                else
                {
                    if(cicloAcademico.esValidoRegistro(numeroMatriculasMañana))
                    {
                        mensaje = "Solo hay vacantes disponibles para el TURNO MAÑANA";
                        return true;
                    }

                    if (cicloAcademico.esValidoRegistro(numeroMatriculasTarde))
                    {
                        mensaje = "Solo hay vacantes disponibles para el TURNO TARDE";
                        return true;
                    }
                }
            }

            mensaje = "SIN VACANTES DISPONIBLES";
            return false;
        }

        public bool verificarAlumnoMatriculado(string dni, CicloAcademico cicloAcademico)
        {
            /*CicloAcademico cicloAcademico = new CicloAcademico();
            gestorSQL.abrirConexion();
            cicloAcademico.Matriculas = cicloAcademicoDAO.listarMatriculasActuales();
            gestorSQL.cerrarConexion();*/
            if (cicloAcademico.estaAlumnoMatriculado(dni))
            {
                return true;
            }
            return false;
        }

        public List<Clase> obtenerClases(string periodo)
        {
            List<Clase> listaDeClases = new List<Clase>();
            gestorSQL.abrirConexion();
            listaDeClases = cicloAcademicoDAO.obtenerClasesDeUnCiclo(periodo);
            gestorSQL.cerrarConexion();
            return listaDeClases;
        }

        public void guardarMatricula(Matricula matricula, bool estaAlumnoRegistrado, string turno) {
            gestorSQL.abrirConexion();

            if (!estaAlumnoRegistrado)
            {
                gestorSQL.abrirConexion();
                alumnoDAO.guardarAlumno(matricula.Alumno);
                gestorSQL.cerrarConexion();
            }

            gestorSQL.abrirConexion();
            matriculaDAO.guardarMatricula(matricula,turno);

            gestorSQL.cerrarConexion(); 
        }
    }
}
