﻿using AcademiaSoft.CapaDominio.Contratos;
using AcademiaSoft.CapaDominio.Entidades;
using AcademiaSoft.CapaPersistencia.SQLServerDAO;
using System;

namespace AcademiaSoft.CapaAplicacion.Servicios
{
    public class IniciarSesionServicio
    {
        private readonly IGestorDAO gestorDAO;
        private readonly IUsuarioDAO usuarioDAO;

        public IniciarSesionServicio()
        {
            gestorDAO = new GestorSQL();
            usuarioDAO = new UsuarioDAO(gestorDAO);
        }

        public Usuario BuscarUsuario(string nickname, string password)
        {
            gestorDAO.AbrirConexion();
            Usuario usuario = usuarioDAO.BuscarUsuario(nickname);
            if (!usuario.EsUsuarioValido(nickname, password))
                throw new Exception("Contraseña Incorrecta.");

            gestorDAO.CerrarConexion();

            return usuario;
        }
    }
}
