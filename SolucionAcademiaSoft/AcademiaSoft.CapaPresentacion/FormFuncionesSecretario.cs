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
    public partial class FormFuncionesSecretario : Form
    {
        string dniSecretario;
        public FormFuncionesSecretario(string dni)
        {
            InitializeComponent();
            dniSecretario = dni;
            MaximizeBox = false;
        }

        private void Button1_Click(object sender, EventArgs e)//para mostrar el formulario de registro de matrícula
        {
            
            RegistrarMatriculaServicio registrarMatriculaServicio = new RegistrarMatriculaServicio();
            try
            {
                CicloAcademico
                cicloActual = null;
                int vacantesDisponibles=0;
                cicloActual = registrarMatriculaServicio.ObtenerCicloActual();
                if (cicloActual != null)
                {
                    cicloActual.ListaMatriculas = registrarMatriculaServicio.ObtenerMatriculas(cicloActual.Periodo);
                    vacantesDisponibles = registrarMatriculaServicio.VerificarVacantes(cicloActual);
                    if (vacantesDisponibles >= 0)
                    {
                        cicloActual.Clases = registrarMatriculaServicio.ObtenerClases(cicloActual.Periodo);
                        FormRegistrarMatricula formRegistrarMatricula = new FormRegistrarMatricula(cicloActual, dniSecretario);
                        formRegistrarMatricula.ShowDialog();
                    }
                    else
                        MessageBox.Show("No hay vacantes disponibles", "Sistema AcademiaSoft");
                }
                else
                {
                    MessageBox.Show("No existe un ciclo disponible para matricular.", "Sistema AcademiaSoft");
                }

            }
            catch (Exception err)
            {
                MessageBox.Show(this, err.Message, "Sistema AcademiaSoft", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            List<CicloAcademico> ciclos = new List<CicloAcademico>();
            GenerarReporteDeMatriculasServicio listarMatriculasServicio = new GenerarReporteDeMatriculasServicio();

            try
            {
                ciclos = listarMatriculasServicio.ObtenerCiclosAcademicos();

                if(ciclos.Count == 0)
                {
                    MessageBox.Show("No existen ciclos académicos registrados.", "Sistema AcademiaSoft", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    FormReporteMatriculas formReporteMatriculas = new FormReporteMatriculas(ciclos);
                    formReporteMatriculas.ShowDialog();
                }

                
            }
            catch (Exception err)
            {
                MessageBox.Show(this, err.Message, "Sistema AcademiaSoft", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            FormRegistrarAlumno formRegistrarAlumno = new FormRegistrarAlumno();
            formRegistrarAlumno.ShowDialog();
        }
    }
}
