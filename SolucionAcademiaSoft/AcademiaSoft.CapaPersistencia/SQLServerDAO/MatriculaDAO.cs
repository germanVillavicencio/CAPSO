using AcademiaSoft.CapaDominio.Contratos;
using AcademiaSoft.CapaDominio.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace AcademiaSoft.CapaPersistencia.SQLServerDAO
{
    public class MatriculaDAO : IMatriculaDAO
    {

        private readonly GestorSQL gestorSQL;

        public MatriculaDAO(IGestorDAO gestorSQL)
        {
            this.gestorSQL = (GestorSQL)gestorSQL;
        }

        public void GuardarMatricula(Matricula matricula, string turno)
        {

            string consultaSQL = "execute registrarMatricula @par_pago, @par_dni_secretario, @par_dni_alumno, @par_ciclo, @par_turno";

            try
            {
                SqlCommand comando;
                //Guardar la matricula
                comando = gestorSQL.ObtenerComandoSQL(consultaSQL);
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

        public List<Matricula> ObtenerMatriculasDeUnCiclo(string periodo)
        {
            List<Matricula> listaMatricula = new List<Matricula>();
            Matricula matricula;
            string consultaSQL = "select m.mat_codigo, m.mat_fecha, m.mat_pago, m.mat_turno, p.per_dni, p.per_nombre, p.per_apellido_mat, p.per_apellido_pat " +
                                    "from Matricula m inner join Ciclo_Academico c on m.cic_id = c.cic_id inner join Persona p on m.alu_dni = p.per_dni " +
                                    "where c.cic_periodo = '" + periodo + "' ";

            try
            {
                SqlDataReader resultadoSQL = gestorSQL.EjecutarConsulta(consultaSQL);
                while (resultadoSQL.Read())
                {
                    matricula = ObtenerMatricula(resultadoSQL);
                    listaMatricula.Add(matricula);
                }
            }
            catch (Exception err)
            {
                throw err;
            }

            return listaMatricula;
        }

        private Matricula ObtenerMatricula(SqlDataReader resultadoSQL)
        {
            Matricula matricula = new Matricula
            {
                Alumno = new Alumno(),

                Codigo = resultadoSQL.GetInt32(0),
                Fecha = resultadoSQL.GetDateTime(1),
                Pago = double.Parse(resultadoSQL.GetDecimal(2).ToString()),
                Turno = resultadoSQL.GetString(3)
            };
            matricula.Alumno.Dni = resultadoSQL.GetString(4);
            matricula.Alumno.Nombre = resultadoSQL.GetString(5);
            matricula.Alumno.ApellidoPaterno = resultadoSQL.GetString(6);
            matricula.Alumno.ApellidoMaterno = resultadoSQL.GetString(7);

            return matricula;
        }

    }
}
