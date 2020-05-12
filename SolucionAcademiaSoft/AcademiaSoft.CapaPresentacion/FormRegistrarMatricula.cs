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
                    textApellidoMaterno.Text = alumno.ApellidoMaterno;
                }
                else
                {
                    groupAlumnoDatosPersonales.Enabled = true;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(this, err.Message, "Sistema VentaPasajeSoft", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


        }
    }
}
