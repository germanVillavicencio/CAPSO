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
        private readonly IGestorDAO gestorDAO;
        private readonly IAlumnoDAO alumnoDAO;
        private readonly ICicloAcademicoDAO cicloAcademicoDAO;
        private readonly IMatriculaDAO matriculaDAO;

        public RegistrarMatriculaServicio()
        {
            gestorDAO = new GestorSQL();
            alumnoDAO = new AlumnoDAO(gestorDAO);
            cicloAcademicoDAO = new CicloAcademicoDAO(gestorDAO);
            matriculaDAO = new MatriculaDAO(gestorDAO);
        }

        public Alumno BuscarPorDni(string dni)
        {
            gestorDAO.AbrirConexion();
            Alumno alumno = alumnoDAO.BuscarPorDni(dni);
            gestorDAO.CerrarConexion();
            return alumno;
        }

        public int VerificarVacantes(CicloAcademico cicloAcademico)
        {
            int numero = -1;//no hay vacantes por defecto
            int totalMatriculasDia = 0;
            int totalMatriculasTarde = 0;

            gestorDAO.AbrirConexion();
            totalMatriculasDia = cicloAcademico.CalcularMatriculasPorTurno("Mañana");
            totalMatriculasTarde = cicloAcademico.CalcularMatriculasPorTurno("Tarde");
            gestorDAO.CerrarConexion();

            if (cicloAcademico.EsValidoRegistro(totalMatriculasDia) && cicloAcademico.EsValidoRegistro(totalMatriculasTarde))
            {
                numero = 0;//vacantes en ambos turnos
            }
            else
            {
                if (cicloAcademico.EsValidoRegistro(totalMatriculasDia))
                {
                    numero = 1;//vacantes solo en la mañana
                }

                if (cicloAcademico.EsValidoRegistro(totalMatriculasTarde))
                {
                    numero = 2;//vacantes solo en la tarde
                }
            }

            return numero;//no hay vacantes
        }

        public CicloAcademico ObtenerCicloActual()
        {
            gestorDAO.AbrirConexion();
            CicloAcademico cicloAcademico;
            cicloAcademico = null;// ciclo academico actual
            List<CicloAcademico> ciclosAcademicos = cicloAcademicoDAO.BuscarCiclosAcademicos();
            foreach (CicloAcademico ciclo in ciclosAcademicos)
            {
                if (ciclo.EsValidoFechaMatricula())
                {
                    cicloAcademico = ciclo;
                    break;
                }

            }
            gestorDAO.CerrarConexion();

            return cicloAcademico;
        }
        //Verifica si el alumno ya está matricula en el ciclo actual
        public bool VerificarAlumnoMatriculado(string dni, CicloAcademico cicloAcademico)
        {
            if (cicloAcademico.EstaAlumnoMatriculado(dni))
            {
                return true;
            }
            return false;
        }

        public List<Matricula> ObtenerMatriculas(string periodo)
        {
            List<Matricula> matriculas;
            gestorDAO.AbrirConexion();
            matriculas = matriculaDAO.ObtenerMatriculasDeUnCiclo(periodo);
            gestorDAO.CerrarConexion();

            return matriculas;
        }

        public List<Clase> ObtenerClases(string periodo)
        {
            List<Clase> listaDeClases = new List<Clase>();
            gestorDAO.AbrirConexion();
            listaDeClases = cicloAcademicoDAO.ObtenerClasesDeUnCiclo(periodo);
            gestorDAO.CerrarConexion();
            return listaDeClases;
        }

        public void GuardarMatricula(Matricula matricula, string turno) {

            if(turno=="")
            {
                throw new Exception ("No se ha escogido ningún turno para el horario de clases.");
            }
            matricula.Pago = matricula.CalcularPago(matricula.CicloAcademico.Precio);
            gestorDAO.AbrirConexion();
            matriculaDAO.GuardarMatricula(matricula,turno);
            gestorDAO.CerrarConexion();
        }

        public string ObtenerFechaDeInicioDeClases(CicloAcademico ciclo)
        {
            return ciclo.CalcularFechaInicioClases().ToShortDateString();
        }

        public string ObtenerFechaDeFinDeClases(CicloAcademico ciclo)
        {
            return ciclo.CalcularFechaTerminoClases().ToShortDateString();
        }

    }
}
