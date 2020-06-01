using AcademiaSoft.CapaDominio.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaSoft.CapaPersistencia.SQLServerDAO
{
    public class MatriculaDAO
    {

        private GestorSQL gestorSQL;

        public MatriculaDAO(GestorSQL gestorSQL)
        {
            this.gestorSQL = gestorSQL;
        }

        public int calcularAlumnosRegistrados(string periodo)
        {
            int totalAlumnos = 0;
            List<Matricula> matriculas = new List<Matricula>();
            //string consultaSQL = "select count(rc.mat_codigo) from Registro_Clases rc inner join Matricula m on rc.mat_codigo = m.mat_codigo inner join Ciclo_Academico ca on m.cic_id = ca.cic_id where ca.cic_periodo='"+periodo+"'";
            string consultaSQL = "select rc.mat_codigo as Codigo_Matricula, h.hor_turno as Turno from Registro_Clases rc inner join Clase c on rc.cla_id = c.cla_id" +
                                                            "inner join Horario h on h.hor_id = c.hor_id" +
                                                            "inner join Ciclo_Academico ca on ca.cic_id = c.cic_id" +
                                                            "where ca.cic_periodo = " + periodo +
                                                            "group by rc.mat_codigo, h.hor_turno";


            try
            {
                SqlDataReader resultadoSQL = gestorSQL.ejecutarConsulta(consultaSQL);
                while (resultadoSQL.Read())
                {
                    /*matricula = obtenerMatricula(resultadoSQL);
                    listaMatriculas.Add(matricula);*/
                }
            }
            catch(Exception err)
            {
                throw err;
            }
            return totalAlumnos;
        }

        public void guardarMatricula(Matricula matricula, string turno) {

            string consultaSQL = "execute registrarMatricula @par_pago, @par_dni_secretario, @par_dni_alumno, @par_ciclo, @par_turno";

            try
            {
                SqlCommand comando;
                //Guardar la matricula
                comando = gestorSQL.obtenerComandoSQL(consultaSQL);
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
       
        /*private int obtenerNumerosAlumnosRegistrados(SqlDataReader resultadoSQL)
        {         
            return resultadoSQL.GetInt32(0);
        }*/
    }
}
