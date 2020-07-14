using AcademiaSoft.CapaAplicacion.Servicios;
using AcademiaSoft.CapaDominio.Entidades;
using System;
using System.Windows.Forms;

namespace AcademiaSoft.CapaPresentacion
{
    public partial class FormRegistrarAlumno : Form
    {
        public FormRegistrarAlumno()
        {
            InitializeComponent();
            MaximizeBox = false;
        }

        private void TextDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 8)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void TextTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 8)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Alumno alumno = new Alumno();
            alumno.Dni = textDni.Text;
            alumno.Nombre = textNombres.Text.Trim();
            alumno.ApellidoPaterno = textApellidoPaterno.Text.Trim();
            alumno.ApellidoMaterno = textApellidoMaterno.Text.Trim();
            alumno.Direccion = textDireccion.Text.Trim();
            alumno.Celular = textTelefono.Text;
            alumno.Correo = textCorreo.Text.Trim();
            alumno.FechaDeNacimiento = datePickerFechaNacimiento.Value;

            try
            {
                RegistrarAlumnoServicio registrarAlumnoServicio = new RegistrarAlumnoServicio();
                registrarAlumnoServicio.GuardarAlumno(alumno);
                MessageBox.Show("Se ha registrado correctamente al alumno.\n\n" + "Edad del Alumno: " + alumno.CalcularEdad(), "Sistema AcademiaSoft", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();

            }
            catch (Exception err)
            {
                MessageBox.Show(this, err.Message, "Sistema AcademiaSoft", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }
    }
}