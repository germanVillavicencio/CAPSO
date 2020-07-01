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
    public class MatriculaDAO : IMatriculaDAO
    {

        private GestorSQL gestorSQL;

        public MatriculaDAO(IGestorDAO gestorSQL)
        {
            this.gestorSQL = (GestorSQL)gestorSQL;
        }

        public void guardarMatricula(Matricula matricula, string turno) {

            string consultaSQL = "execute registrarMatricula @par_precio, @par_pago, @par_dni_secretario, @par_dni_alumno, @par_ciclo, @par_turno";

            try
            {
                SqlCommand comando;
                //Guardar la matricula
                comando = gestorSQL.obtenerComandoSQL(consultaSQL);
                comando.Parameters.AddWithValue("@par_precio", matricula.Precio);
                comando.Parameters.AddWithValue("@par_pago", matricula.Pago);
                comando.Parameters.AddWithValue("@par_dni_secretario", matricula.Secretario.Dni);
                comando.Parameters.AddWithValue("@par_dni_alumno", matricula.Alumno.Dni);
                comando.Parameters.AddWithValue("@par_ciclo", matricula.CicloAcademico.Periodo);
                comando.Parameters.AddWithValue("@par_turno", turno);
                comando.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Ocurrio un problema al guardar la matricula.", err);
            }
        }

        public List<Matricula> obtenerMatriculasDeUnCiclo(string periodo)
        {
            List<Matricula> listaMatricula = new List<Matricula>();
            Matricula matricula;
            string consultaSQL = "select m.mat_fecha, m.mat_pago, m.alu_dni, m.mat_turno from Ciclo_Academico ca inner join Matricula m on ca.cic_id = m.cic_id where ca.cic_periodo = '"+ periodo + "' ";

            try
            {
                SqlDataReader resultadoSQL = gestorSQL.ejecutarConsulta(consultaSQL);
                while (resultadoSQL.Read())
                {
                    matricula = obtenerMatricula(resultadoSQL);
                    listaMatricula.Add(matricula);
                }
            }
            catch (Exception err)
            {
                throw err;
            }

            return listaMatricula;
        }

        public List<Matricula> listarMatriculasActuales()
        {
            Matricula matricula = null;
            List<Matricula> listaMatriculas = new List<Matricula>();
            string consultaSQL = "SELECT m.mat_fecha, m.mat_pago, alu_dni, m.mat_turno FROM Matricula m inner join Ciclo_Academico ca ON (m.cic_id = ca.cic_id) WHERE ca.cic_fecha_inicio<=CONVERT(DATE,GETDATE()) and ca.cic_fecha_fin>=CONVERT(DATE,GETDATE())";

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
            matricula.Alumno = new Alumno();
            matricula.Fecha = resultadoSQL.GetDateTime(0);
            matricula.Pago = double.Parse(resultadoSQL.GetDecimal(1).ToString());
            matricula.Alumno.Dni = resultadoSQL.GetString(2);
            matricula.Turno = resultadoSQL.GetString(3);
            return matricula;
        }

    }
}
