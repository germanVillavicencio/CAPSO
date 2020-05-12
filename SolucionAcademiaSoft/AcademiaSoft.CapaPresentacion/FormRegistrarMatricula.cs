using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AcademiaSoft.CapaAplicacion.Servicios;
using AcademiaSoft.CapaDominio.Entidades;

namespace AcademiaSoft.CapaPresentacion
{
    public partial class FormRegistrarMatricula : Form
    {
        Alumno alumno;
        public FormRegistrarMatricula()
        {
            InitializeComponent();
        }

        private void buttonBuscarAlumno_Click(object sender, EventArgs e)
        {
            string dniAlumno = textDni.Text.Trim();
            try
            {
                RegistrarMatriculaServicio registrarMatriculaServicio = new RegistrarMatriculaServicio();
                alumno = registrarMatriculaServicio.buscarPorDni(dniAlumno);

                if(alumno != null)
                {
                    textNombres.Text = alumno.Nombre;
                    textApellidoPaterno.Text = alumno.ApellidoPaterno;
                    textApellidoMaterno.Text = alumno.ApellidoMaterno;
                    textDireccion.Text = alumno.Direccion;
                    textTelefono.Text = alumno.Celular;
                    textCorreo.Text = alumno.Correo;
                    datePickerFechaNacimiento.Value = alumno.FechaDeNacimiento;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(this, err.Message, "Sistema AcademiaSoft", MessageBoxButtons.OK, MessageBoxIcon.Error);
                limpiarDatosDelAlumno();
                groupAlumnoDatosPersonales.Enabled = true;
                groupAlumnoContacto.Enabled = true;
                return;

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
    }
}
