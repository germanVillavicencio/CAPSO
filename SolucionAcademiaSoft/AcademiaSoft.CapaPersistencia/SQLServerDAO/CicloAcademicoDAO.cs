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
    public class CicloAcademicoDAO : ICicloAcademicoDAO
    {
        private GestorSQL gestorSQL;

        public CicloAcademicoDAO(IGestorDAO gestorSQL)
        {
            this.gestorSQL = (GestorSQL)gestorSQL;
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

        public List<Clase> obtenerClasesDeUnCiclo(string periodo)
        {
            List<Clase> listaDeClases = new List<Clase>();
            Clase clase = null;
            string consultaSQL = "select c.cla_codigo, cur.cur_nombre, p.per_nombre, p.per_apellido_pat, p.per_apellido_mat,h.hor_dia, h.hor_inicio, h.hor_fin from Clase c " +
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

            return clase;
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
