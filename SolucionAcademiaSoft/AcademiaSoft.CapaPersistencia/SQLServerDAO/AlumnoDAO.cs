using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcademiaSoft.CapaDominio.Entidades;
using AcademiaSoft.CapaDominio.Contratos;

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
            string consultaSQL = "execute registrarAlumno @par_dni, @par_nombre, @par_apellido_pat, @par_apellido_mat, @par_direccion, @par_celular, @par_fecha_nac, @par_correo";
       
            try {
                SqlCommand comando;
                //Guardar la alumno
                comando = gestorSQL.obtenerComandoSQL(consultaSQL);
                comando.Parameters.AddWithValue("@par_dni", alumno.Dni);
                comando.Parameters.AddWithValue("@par_nombre", alumno.Nombre);
                comando.Parameters.AddWithValue("@par_apellido_pat", alumno.ApellidoPaterno);
                comando.Parameters.AddWithValue("@par_apellido_mat", alumno.ApellidoMaterno);
                comando.Parameters.AddWithValue("@par_direccion", alumno.Direccion);
                comando.Parameters.AddWithValue("@par_celular", alumno.Celular);
                comando.Parameters.AddWithValue("@par_fecha_nac", alumno.FechaDeNacimiento.Date);
                comando.Parameters.AddWithValue("@par_correo", alumno.Correo);
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
