using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcademiaSoft.CapaDominio.Entidades;
using AcademiaSoft.CapaDominio.Contratos;

namespace AcademiaSoft.CapaPersistencia.SQLServerDAO
{
    public class UsuarioDAO : IUsuarioDAO
    {
        private readonly GestorSQL gestorSQL;

        public UsuarioDAO(IGestorDAO gestorSQL)
        {
            this.gestorSQL = (GestorSQL)gestorSQL;
        }

        public Usuario BuscarUsuario(string nickname)
        {
            Usuario usuario = null;

            string consultaSQL = "select u.usu_nick, u.usu_password, u.usu_tipo, p.per_dni from usuario u inner join Persona p on u.per_dni = p.per_dni where usu_nick = '" + nickname + "'";

            try
            {
                SqlDataReader resultadoSQL = gestorSQL.EjecutarConsulta(consultaSQL);
                if (resultadoSQL.Read())
                {
                    usuario = ObtenerAlumno(resultadoSQL);
                }
                else
                {
                    throw new Exception("Usuario no encontrado.");
                }
            }
            catch (Exception err)
            {
                throw err;
            }

            return usuario;
        }

        public Usuario ObtenerAlumno(SqlDataReader resultadoSQL)
        {
            Usuario usuario = new Usuario();
            usuario.Persona = new Persona();
            usuario.Nickname = resultadoSQL.GetString(0);
            usuario.Password = resultadoSQL.GetString(1);
            usuario.Tipo = resultadoSQL.GetByte(2);
            usuario.Persona.Dni = resultadoSQL.GetString(3);

            return usuario;
        }
    }
}
