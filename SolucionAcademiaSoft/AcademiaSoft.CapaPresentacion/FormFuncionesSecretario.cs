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
        public FormFuncionesSecretario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//para mostrar el formulario de registro de matrícula
        {
            
            RegistrarMatriculaServicio registrarMatriculaServicio = new RegistrarMatriculaServicio();
            try
            {
                CicloAcademico
                cicloActual = null;
                int vacantesDisponibles=0;
                cicloActual = registrarMatriculaServicio.obtenerCicloActual();
                if (cicloActual != null)
                {
                    cicloActual.ListaMatriculas = registrarMatriculaServicio.obtenerMatriculas(cicloActual.Periodo);
                    vacantesDisponibles = registrarMatriculaServicio.verificarVacantes(cicloActual);
                }
                else
                {
                    MessageBox.Show("no hay ciclo disponible");
                }
                if (vacantesDisponibles >= 0)
                {
                    MessageBox.Show("Si hay vacantes");
                    cicloActual.Clases = registrarMatriculaServicio.obtenerClases(cicloActual.Periodo);
                    FormRegistrarMatricula formRegistrarMatricula = new FormRegistrarMatricula(cicloActual);
                    formRegistrarMatricula.ShowDialog();
                }
                else
                    MessageBox.Show("No hay vacantes disponibles");

            }
            catch (Exception err)
            {
                MessageBox.Show(this, err.Message, "Sistema AcademiaSoft", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
        }
    }
}
