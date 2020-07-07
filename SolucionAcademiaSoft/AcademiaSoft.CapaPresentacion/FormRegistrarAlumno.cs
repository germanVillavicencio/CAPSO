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
    public partial class FormRegistrarAlumno : Form
    {
        public FormRegistrarAlumno()
        {
            InitializeComponent();
            MaximizeBox = false;
        }

        private void limpiarDatosDelAlumno()
        {
            textNombres.Text = "";
            textApellidoPaterno.Text = "";
            textApellidoMaterno.Text = "";
            textDireccion.Text = "";
            textTelefono.Text = "";
            textCorreo.Text = "";
            datePickerFechaNacimiento.Value = DateTime.Now;
        }

        private void textDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 8)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void textTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 8)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
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
                registrarAlumnoServicio.guardarAlumno(alumno);
                MessageBox.Show("Se ha registrado correctamente al alumno.\n\n"+"Edad del Alumno: "+ alumno.calcularEdad(), "Sistema AcademiaSoft", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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