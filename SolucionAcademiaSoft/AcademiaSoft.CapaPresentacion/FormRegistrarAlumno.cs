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
        Alumno alumno;
        public FormRegistrarAlumno()
        {
            InitializeComponent();
            MaximizeBox = false;
        }

        private void buttonBuscarAlumno_Click(object sender, EventArgs e)
        {
            string dniAlumno = textDni.Text.Trim();
            try
            {
                RegistrarAlumnoServicio registrarMatriculaServicio = new RegistrarAlumnoServicio();
                alumno = new Alumno();
                alumno = registrarMatriculaServicio.buscarPorDni(dniAlumno);

                if (alumno != null)
                {
                    MessageBox.Show("El alumno ya se encuentra registrado en el sistema.", "Sistema AcademiaSoft", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    groupDatosAlumno.Enabled = false;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(this, err.Message, "Sistema AcademiaSoft", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiarDatosDelAlumno();
                groupDatosAlumno.Enabled = true;
                textDni.Enabled = false;
            }
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
                MessageBox.Show("Se ha registrado correctamente al alumno.", "Sistema AcademiaSoft", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();

            }
            catch (Exception err)
            {
                MessageBox.Show(this, err.Message, "Sistema AcademiaSoft", MessageBoxButtons.OK, MessageBoxIcon.Error);
                groupDatosAlumno.Enabled = true;
                return;
            }

        }
    } 
}