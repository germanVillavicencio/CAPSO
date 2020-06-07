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

        private void button1_Click(object sender, EventArgs e)
        {
            
            RegistrarMatriculaServicio registrarMatriculaServicio = new RegistrarMatriculaServicio();
            
            try
            {
                CicloAcademico cicloActual = new CicloAcademico();
                Boolean vacantesDisponibles = false;
                String mensaje = "";
                int totalMatriculasMañana = 0;
                int totalMatriculasTarde = 0;
                vacantesDisponibles = registrarMatriculaServicio.verificarVacantes(ref cicloActual, ref mensaje, ref totalMatriculasMañana, ref totalMatriculasTarde);

                MessageBox.Show(mensaje);
                if (vacantesDisponibles == true)
                {
                    cicloActual.Clases = registrarMatriculaServicio.obtenerClases(cicloActual.Periodo);
                    FormRegistrarMatricula formRegistrarMatricula = new FormRegistrarMatricula(cicloActual, totalMatriculasMañana, totalMatriculasTarde);
                    formRegistrarMatricula.ShowDialog();
                }

            }
            catch (Exception err)
            {
                MessageBox.Show(this, err.Message, "Sistema AcademiaSoft", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
        }
    }
}
