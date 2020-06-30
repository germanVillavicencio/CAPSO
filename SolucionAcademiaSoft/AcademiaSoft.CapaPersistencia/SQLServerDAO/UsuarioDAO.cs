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
        private GestorSQL gestorSQL;

        public UsuarioDAO(IGestorDAO gestorSQL)
        {
            this.gestorSQL = (GestorSQL)gestorSQL;
        }

        public Usuario buscarUsuario(string nickname)
        {
            Usuario usuario = null;

            string consultaSQL = "select usu_nick, usu_password, usu_tipo from usuario where usu_nick = '" + nickname + "'";

            try
            {
                SqlDataReader resultadoSQL = gestorSQL.ejecutarConsulta(consultaSQL);
                if (resultadoSQL.Read())
                {
                    usuario = obtenerAlumno(resultadoSQL);
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

        public Usuario obtenerAlumno(SqlDataReader resultadoSQL)
        {
            Usuario usuario = new Usuario();
            usuario.Nickname = resultadoSQL.GetString(0);
            usuario.Password = resultadoSQL.GetString(1);
            usuario.Tipo = resultadoSQL.GetByte(2);

            return usuario;
        }
    }
}
