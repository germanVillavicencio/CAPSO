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
    }
}
