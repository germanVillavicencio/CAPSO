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
    public partial class FormRegistrarUsuario : Form
    {
        public FormRegistrarUsuario()
        {
            InitializeComponent();
        }

        private int tipoUsuario = 0;

        private void comboBoxTipoUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*if(comboBoxTipoUsuario.Text == "Secretario")
            {
                button1.Enabled = true;
                button2.Enabled = false;
            }
            else if(comboBoxTipoUsuario.Text == "Docente")
            {
                button1.Enabled = false;
                button2.Enabled = true;
            }*/
        }

        private void comboBoxTipoUsuario_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBoxTipoUsuario.Text == "Secretario")
            {
                labelSueldo.Visible = true;
                textSueldo.Visible = true;
                labelPagoHora.Visible = false;
                textPagoHora.Visible = false;
                labelEspecialidad.Visible = false;
                textEspecialidad.Visible = false;
                tipoUsuario = 1;
            }
            else if (comboBoxTipoUsuario.Text == "Docente")
            {
                labelSueldo.Visible = false;
                textSueldo.Visible = false;
                labelPagoHora.Visible = true;
                textPagoHora.Visible = true;
                labelEspecialidad.Visible = true;
                textEspecialidad.Visible = true;
                tipoUsuario = 2;
            }
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            textPassword.UseSystemPasswordChar = false;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            textPassword.UseSystemPasswordChar = true;
        }

        private void textDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 8)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void textCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 8)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void textSueldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 8)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void textPagoHora_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 8)
                e.Handled = false;
            else
                e.Handled = true;
        }
    }
}
