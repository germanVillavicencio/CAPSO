using AcademiaSoft.CapaDominio.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcademiaSoft.CapaDominio.Contratos;

namespace AcademiaSoft.CapaPersistencia.SQLServerDAO
{
    public class CicloAcademicoDAO
    {
        private GestorSQL gestorSQL;

        public CicloAcademicoDAO(GestorSQL gestorSQL)
        {
            this.gestorSQL = gestorSQL;
        }
        public List<CicloAcademico> buscarCiclosAcademicos()
        {

            List<CicloAcademico> ciclosAcademicos = new List<CicloAcademico>();
            CicloAcademico cicloAcademico;

            string consultaSQL = "select cic_periodo, cic_max_alum, cic_inicio_matricula from Ciclo_Academico";
            try
            {
                SqlDataReader resultadoSQL = gestorSQL.ejecutarConsulta(consultaSQL);
                while (resultadoSQL.Read())
                {
                    cicloAcademico = obtenerCicloAcademico(resultadoSQL);
                    ciclosAcademicos.Add(cicloAcademico);
                }
            }
            catch (Exception err)
            {
                throw err;
            }
            return ciclosAcademicos;
        }

        public List<Matricula> listarMatriculasActuales()
        {
            Matricula matricula = null;
            List<Matricula> listaMatriculas = new List<Matricula>();
            string consultaSQL = "SELECT m.mat_fecha, m.mat_pago, alu_dni FROM Matricula m inner join Ciclo_Academico ca ON (m.cic_id = ca.cic_id) WHERE ca.cic_fecha_inicio<=CONVERT(DATE,GETDATE()) and ca.cic_fecha_fin>=CONVERT(DATE,GETDATE())";

            try
            {
                SqlDataReader resultadoSQL = gestorSQL.ejecutarConsulta(consultaSQL);
                while (resultadoSQL.Read())
                {
                    matricula = obtenerMatricula(resultadoSQL);
                    listaMatriculas.Add(matricula);
                }
            }
            catch (Exception err)
            {
                throw err;
            }

            return listaMatriculas;
        }

        public CicloAcademico obtenerMatriculasDeUnCiclo(CicloAcademico cicloAcademico)
        {
            Matricula matricula = null;
            String turno = "";
            //List<Matricula> listaMatriculas = new List<Matricula>();
            string consultaSQL = "select m.mat_fecha, m.mat_pago, m.alu_dni,h.hor_turno from Registro_Clases rc inner join Clase c on rc.cla_id = c.cla_id " +
                                    "inner join Horario h on h.hor_id = c.hor_id " +
                                    "inner join Ciclo_Academico ca on ca.cic_id = c.cic_id " +
                                    "inner join Matricula m on m.mat_codigo = rc.mat_codigo " +
                                    "where ca.cic_periodo = '"+  cicloAcademico.Periodo +"' "+
                                    "group by rc.mat_codigo, h.hor_turno, m.alu_dni, m.mat_fecha, m.mat_pago";

            try
            {
                SqlDataReader resultadoSQL = gestorSQL.ejecutarConsulta(consultaSQL);
                while (resultadoSQL.Read())
                {
                    turno = resultadoSQL.GetString(3);
                    matricula = obtenerMatricula(resultadoSQL);
                    if(turno.Equals("Mañana"))
                    {
                        cicloAcademico.MatriculasMañana.Add(matricula);
                    }
                    else
                    {
                        if(turno.Equals("Tarde"))
                            cicloAcademico.MatriculasTarde.Add(matricula);
                    }
                }
            }
            catch (Exception err)
            {
                throw err;
            }

            return cicloAcademico;
        }

        public List<Clase> obtenerClasesDeUnCiclo(string periodo)
        {
            List<Clase> listaDeClases = new List<Clase>();
            Clase clase = null;
            //List<Matricula> listaMatriculas = new List<Matricula>();
            string consultaSQL = "select c.cla_codigo, cur.cur_nombre, p.per_nombre, p.per_apellido_pat, p.per_apellido_mat,h.hor_dia, h.hor_inicio, h.hor_fin, h.hor_turno from Clase c " +
                                    "inner join Horario h on c.hor_id = h.hor_id " +
                                    "inner join Curso cur on c.cur_id = cur.cur_id " +
                                    "inner join Docente d on c.doc_dni = d.per_dni " +
                                    "inner join Persona p on d.per_dni = p.per_dni " +
                                    "inner join Ciclo_Academico ca on c.cic_id = ca.cic_id " +
                                    "where ca.cic_periodo = '" + periodo + "' ";

            try
            {
                SqlDataReader resultadoSQL = gestorSQL.ejecutarConsulta(consultaSQL);
                while (resultadoSQL.Read())
                {
                    clase = obtenerClase(resultadoSQL);
                    listaDeClases.Add(clase);
                }
            }
            catch (Exception err)
            {
                throw err;
            }

            return listaDeClases;
        }

        private Clase obtenerClase(SqlDataReader resultadoSQL)
        {
            Clase clase = new Clase();

            clase.Codigo = resultadoSQL.GetString(0);
            clase.Curso.Nombre = resultadoSQL.GetString(1);
            clase.Docente.Nombre = resultadoSQL.GetString(2);
            clase.Docente.ApellidoPaterno = resultadoSQL.GetString(3);
            clase.Docente.ApellidoMaterno = resultadoSQL.GetString(4);
            clase.Horario.Dia = resultadoSQL.GetString(5);
            clase.Horario.Inicio = resultadoSQL.GetString(6);
            clase.Horario.Fin = resultadoSQL.GetString(7);
            clase.Horario.Turno = resultadoSQL.GetString(8);

            return clase;
        }
        private Matricula obtenerMatricula(SqlDataReader resultadoSQL)
        {
            Matricula matricula = new Matricula();
            matricula.Alumno = new Alumno();
            matricula.Fecha = resultadoSQL.GetDateTime(0);
            matricula.Pago = double.Parse(resultadoSQL.GetDecimal(1).ToString());
            matricula.Alumno.Dni = resultadoSQL.GetString(2);
            return matricula;
        }

        private CicloAcademico obtenerCicloAcademico(SqlDataReader resultadoSQL)
        {
            CicloAcademico cicloAcademico = new CicloAcademico();
            cicloAcademico.Periodo = resultadoSQL.GetString(0);
            cicloAcademico.TotalDeAlumnos = resultadoSQL.GetInt32(1);
            cicloAcademico.FechaInicioMatricula = resultadoSQL.GetDateTime(2);
            return cicloAcademico;
        }
    }
}
