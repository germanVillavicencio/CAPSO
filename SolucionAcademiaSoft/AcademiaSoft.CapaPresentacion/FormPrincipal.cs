using AcademiaSoft.CapaAplicacion.Servicios;
using AcademiaSoft.CapaDominio.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademiaSoft.CapaPresentacion
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            MaximizeBox = false;
        }

        private void buttonIniciarSesion_Click(object sender, EventArgs e)
        {
            Usuario usuario;
            string nick = textNick.Text.Trim();
            string password = textPassword.Text.Trim();
            
            try
            {
                IniciarSesionServicio iniciarSesionServicio = new IniciarSesionServicio();
                usuario = iniciarSesionServicio.buscarUsuario(nick);
                if (usuario.esUsuarioValido(nick, password))
                {
                    FormFuncionesSecretario formFuncionesSecretario = new FormFuncionesSecretario();
                    formFuncionesSecretario.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Ingrese las credenciales correctas");
                }
            }
            catch(Exception err)
            {
                MessageBox.Show(this, err.Message, "Sistema AcademiaSoft", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            /*FormFuncionesSecretario formFuncionesSecretario = new FormFuncionesSecretario();
            formFuncionesSecretario.ShowDialog();*/
        }

        private void buttonRegistrarUsuario_Click(object sender, EventArgs e)
        {
            FormRegistrarUsuario formRegistrarUsuario = new FormRegistrarUsuario();
            formRegistrarUsuario.ShowDialog();
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            textPassword.UseSystemPasswordChar = false;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            textPassword.UseSystemPasswordChar = true;
        }
    }
}
