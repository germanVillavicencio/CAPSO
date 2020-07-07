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

        public int verificarVacantes(CicloAcademico cicloAcademico)
        {
            int numero = -1;//no hay vacantes por defecto
            int totalMatriculasDia = 0;
            int totalMatriculasTarde = 0;

            gestorDAO.abrirConexion();
            totalMatriculasDia = cicloAcademico.calcularMatriculasTurnoDia();
            totalMatriculasTarde = cicloAcademico.calcularMatriculasTurnoTarde();
            gestorDAO.cerrarConexion();

            if (cicloAcademico.esValidoRegistro(totalMatriculasDia) && cicloAcademico.esValidoRegistro(totalMatriculasTarde))
            {
                numero = 0;//vacantes en ambos turnos
            }
            else
            {
                if (cicloAcademico.esValidoRegistro(totalMatriculasDia))
                {
                    numero = 1;//vacantes solo en la mañana
                }

                if (cicloAcademico.esValidoRegistro(totalMatriculasTarde))
                {
                    numero = 2;//vacantes solo en la tarde
                }
            }

            return numero;//no hay vacantes
        }

        public CicloAcademico obtenerCicloActual()
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

        public List<Matricula> obtenerMatriculas(string periodo)
        {
            List<Matricula> matriculas;
            gestorDAO.abrirConexion();
            matriculas = matriculaDAO.obtenerMatriculasDeUnCiclo(periodo);
            gestorDAO.cerrarConexion();

            return matriculas;
        }

        public List<Clase> obtenerClases(string periodo)
        {
            List<Clase> listaDeClases = new List<Clase>();
            gestorDAO.abrirConexion();
            listaDeClases = cicloAcademicoDAO.obtenerClasesDeUnCiclo(periodo);
            gestorDAO.cerrarConexion();
            return listaDeClases;
        }

        public void guardarMatricula(Matricula matricula, string turno) {

            matricula.Pago = matricula.calcularPago(matricula.CicloAcademico.Precio);
            gestorDAO.abrirConexion();
            matriculaDAO.guardarMatricula(matricula,turno);
            gestorDAO.cerrarConexion();
        }

        public string obtenerFechaDeInicioDeClases(CicloAcademico ciclo)
        {
            return ciclo.calcularFechaInicioClases().ToShortDateString();
        }

        public string obtenerFechaDeFinDeClases(CicloAcademico ciclo)
        {
            return ciclo.calcularFechaTerminoClases().ToShortDateString();
        }

    }
}
