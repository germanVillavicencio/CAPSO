using AcademiaSoft.CapaDominio.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        private Matricula obtenerMatricula(SqlDataReader resultadoSQL)
        {
            Matricula matricula = new Matricula();
            matricula.Fecha = resultadoSQL.GetDateTime(0);
            matricula.Pago = resultadoSQL.GetDouble(1);
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
