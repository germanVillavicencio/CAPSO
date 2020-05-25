using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcademiaSoft.CapaDominio.Entidades;

namespace AcademiaSoft.CapaPersistencia.SQLServerDAO
{
    public class AlumnoDAO
    {
        private GestorSQL gestorSQL;

        public AlumnoDAO(GestorSQL gestorSQL)
        {
            this.gestorSQL = gestorSQL;
        }

        public Alumno buscarPorDni(string dni)
        {
            Alumno alumno;

            string consultaSQL = "select p.per_dni, p.per_nombre, p.per_apellido_pat, p.per_apellido_mat, p.per_direccion, p.per_celular, per_fecha_nac, p.per_correo, a.alu_id_card from Persona p inner join Alumno a on (p.per_dni = a.per_dni) where a.per_dni = '" + dni + "'";
            try
            {
                SqlDataReader resultadoSQL = gestorSQL.ejecutarConsulta(consultaSQL);
                if (resultadoSQL.Read())
                {
                    alumno = obtenerAlumno(resultadoSQL);
                }
                else
                {
                    throw new Exception("Alumno no encontrado. Ingrese sus datos para registrarlo");
                }
            }
            catch (Exception err)
            {
                throw err;
            }

            return alumno;
        }

        public void guardarAlumno(Alumno alumno)
        {
            string consultaSQL = "execute registrarAlumno @dni, @nombre, @apellidoP, @apellidoM, @direccion, @celular, @fechaDeNacimiento, @correo";
       
            try {
                SqlCommand comando;
                //Guardar la alumno
                comando = gestorSQL.obtenerComandoSQL(consultaSQL);
                comando.Parameters.AddWithValue("@idPago", alumno.Dni);
                comando.Parameters.AddWithValue("@nombre", alumno.Nombre);
                comando.Parameters.AddWithValue("@apellidoP", alumno.ApellidoPaterno);
                comando.Parameters.AddWithValue("@apellidoM", alumno.ApellidoMaterno);
                comando.Parameters.AddWithValue("@direccion", alumno.Direccion);
                comando.Parameters.AddWithValue("@celular", alumno.Celular);
                comando.Parameters.AddWithValue("@fechaDeNacimiento", alumno.FechaDeNacimiento);
                comando.Parameters.AddWithValue("@correo", alumno.Correo);
                comando.ExecuteNonQuery();
            }
            catch(Exception err)
            {
                throw new Exception("Ocurrio un problema al guardar el alumno.",err);
            }
        }

        private Alumno obtenerAlumno(SqlDataReader resultadoSQL)
        {
            Alumno alumno = new Alumno();
            alumno.Dni = resultadoSQL.GetString(0);
            alumno.Nombre = resultadoSQL.GetString(1);
            alumno.ApellidoPaterno = resultadoSQL.GetString(2);
            alumno.ApellidoMaterno = resultadoSQL.GetString(3);
            alumno.Direccion = resultadoSQL.GetString(4);
            alumno.Celular = resultadoSQL.GetString(5);
            alumno.FechaDeNacimiento = resultadoSQL.GetDateTime(6);
            alumno.Correo = resultadoSQL.GetString(7);
            alumno.IdCard = resultadoSQL.GetInt32(8);
            return alumno;
        }
    }
}
