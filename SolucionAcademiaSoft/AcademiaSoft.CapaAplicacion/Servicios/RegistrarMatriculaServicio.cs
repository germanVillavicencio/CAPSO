﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AcademiaSoft.CapaDominio.Entidades;
using AcademiaSoft.CapaDominio.Contratos;
using AcademiaSoft.CapaPersistencia.SQLServerDAO;

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

        public Boolean verificarVacantes(ref CicloAcademico cicloAcademico, ref String mensaje)
        {
            gestorDAO.abrirConexion();
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
                gestorDAO.iniciarTransaccion();
                cicloAcademico.MatriculasMañana = new List<Matricula>();
                cicloAcademico.MatriculasTarde = new List<Matricula>();
                cicloAcademico = cicloAcademicoDAO.obtenerMatriculasDeUnCiclo(cicloAcademico);
                gestorDAO.cerrarConexion();

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
            gestorDAO.abrirConexion();
            listaDeClases = cicloAcademicoDAO.obtenerClasesDeUnCiclo(periodo);
            gestorDAO.cerrarConexion();
            return listaDeClases;
        }

        public void guardarMatricula(Matricula matricula, bool estaAlumnoRegistrado, string turno) {
            gestorDAO.abrirConexion();

            if (!estaAlumnoRegistrado)
            {
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
