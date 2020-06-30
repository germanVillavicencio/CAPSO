using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AcademiaSoft.CapaDominio.Entidades;
using AcademiaSoft.CapaDominio.Contratos;
using AcademiaSoft.CapaPersistencia.SQLServerDAO;

namespace AcademiaSoft.CapaAplicacion.Servicios
{
    public class IniciarSesionServicio
    {
        private IGestorDAO gestorDAO;
        private IUsuarioDAO usuarioDAO;

        public IniciarSesionServicio()
        {
            gestorDAO = new GestorSQL();
            usuarioDAO = new UsuarioDAO(gestorDAO);
        }

        public Usuario buscarUsuario(string nickname)
        {
            gestorDAO.abrirConexion();
            Usuario usuario = usuarioDAO.buscarUsuario(nickname);
            gestorDAO.cerrarConexion();
            
            return usuario;
        }
    }
}
