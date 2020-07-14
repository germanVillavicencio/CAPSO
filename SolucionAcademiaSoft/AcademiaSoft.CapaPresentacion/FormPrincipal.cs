using AcademiaSoft.CapaAplicacion.Servicios;
using AcademiaSoft.CapaDominio.Entidades;
using System;
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

        private void ButtonIniciarSesion_Click(object sender, EventArgs e)
        {
            Usuario usuario;
            string nick = textNick.Text.Trim();
            string password = textPassword.Text.Trim();

            if (nick == "")
            {
                MessageBox.Show("Ingrese un nombre de usuario, por favor.", "Sistema AcademiaSoft", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (password == "")
                {
                    MessageBox.Show("Ingrese una contraseña, por favor.", "Sistema AcademiaSoft", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        IniciarSesionServicio iniciarSesionServicio = new IniciarSesionServicio();
                        usuario = iniciarSesionServicio.BuscarUsuario(nick, password);
                        FormFuncionesSecretario formFuncionesSecretario = new FormFuncionesSecretario(usuario.Persona.Dni);
                        formFuncionesSecretario.ShowDialog();
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(this, err.Message, "Sistema AcademiaSoft", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void PictureBox2_MouseHover(object sender, EventArgs e)
        {
            textPassword.UseSystemPasswordChar = false;
        }

        private void PictureBox2_MouseLeave(object sender, EventArgs e)
        {
            textPassword.UseSystemPasswordChar = true;
        }
    }
}
