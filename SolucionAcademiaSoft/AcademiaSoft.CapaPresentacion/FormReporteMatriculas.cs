using AcademiaSoft.CapaAplicacion.Servicios;
using AcademiaSoft.CapaDominio.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademiaSoft.CapaPresentacion
{
    public partial class FormReporteMatriculas : Form
    {
        List<CicloAcademico> ciclosAcademicos;
        List<Matricula> listaDeMatriculas = new List<Matricula>();
        string turno;
        public FormReporteMatriculas(List<CicloAcademico> ciclos)
        {
            ciclosAcademicos = ciclos;

            InitializeComponent();

            comboBoxTurn.Items.AddRange(new object[] {"Todos", "Mañana", "Tarde" });
            
            foreach(CicloAcademico ciclo in ciclosAcademicos)
            {
                comboBoxCiclo.Items.Add(ciclo.Periodo);
            }
            MaximizeBox = false;
        }

        private void ComboBoxCiclo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string periodo = comboBoxCiclo.Text;
            GenerarReporteDeMatriculasServicio listarMatriculasServicio = new GenerarReporteDeMatriculasServicio();
            listaDeMatriculas = listarMatriculasServicio.ObtenerMatriculasDeUnCiclo(periodo);

            turno = comboBoxTurn.Text;

            if(listaDeMatriculas.Count==0)
            {
                MessageBox.Show(this, "No existen matriculas registradas en este ciclo académico.", "Sistema AcademiaSoft", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dataGridMatriculas.Rows.Clear();
            }
            else
            {
                if(turno=="Mañana" || turno == "Tarde")
                    LlenarTablaPorTurno(turno);
                else
                    LlenarTabla();
            }
            
        }

        private void LlenarTabla()
        {
            dataGridMatriculas.Rows.Clear();//Limpiar la tabla donde se muestran las Matriculas
            foreach (Matricula matricula in listaDeMatriculas)
            {
                    Object[] filaMatricula = { matricula.Codigo, matricula.Fecha.ToShortDateString(), matricula.Pago, matricula.Turno, matricula.Alumno.Dni, matricula.Alumno.Nombre + " " + matricula.Alumno.ApellidoPaterno + " " + matricula.Alumno.ApellidoMaterno };
                    dataGridMatriculas.Rows.Add(filaMatricula);
            }
        }

        private void LlenarTablaPorTurno(string turno)
        {
            dataGridMatriculas.Rows.Clear();//Limpiar la tabla donde se muestran las Matriculas
            foreach (Matricula matricula in listaDeMatriculas)
            {
                if (matricula.Turno == turno)
                {
                    Object[] filaMatricula = { matricula.Codigo, matricula.Fecha.ToShortDateString(), matricula.Pago, matricula.Turno, matricula.Alumno.Dni, matricula.Alumno.Nombre + " " + matricula.Alumno.ApellidoPaterno + " " + matricula.Alumno.ApellidoMaterno };
                    dataGridMatriculas.Rows.Add(filaMatricula);
                }
            }
        }

        private void ComboBoxTurn_SelectionChangeCommitted(object sender, EventArgs e)
        {
            turno = comboBoxTurn.Text;

            if (listaDeMatriculas.Count == 0)
            {
                MessageBox.Show(this, "La lista de matriculas está vacía.", "Sistema AcademiaSoft", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dataGridMatriculas.Rows.Clear();
            }
            else
            {
                if (turno == "Mañana" || turno == "Tarde")
                    LlenarTablaPorTurno(turno);
                else
                    LlenarTabla();
            }
        }
    }
}
