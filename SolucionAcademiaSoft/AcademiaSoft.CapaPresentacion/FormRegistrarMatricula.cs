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
        CicloAcademico cicloAcademico;
        int estadoDeVacantes = 0;
        List<Clase> listaDeClasesMañana = new List<Clase>();
        List<Clase> listaDeClasesTarde = new List<Clase>();
        Boolean estaAlumnoRegistrado = false;
        double precioPagar = 0.0;
        string turnoSeleccionado = "";
        string dniSecretario = "11111111";
        public FormRegistrarMatricula(CicloAcademico ciclo)
        {
            this.cicloAcademico = ciclo;
            llenarListaDeClase();
            InitializeComponent();
            if (this.cicloAcademico.MatriculasMañana.Count()< cicloAcademico.TotalDeAlumnos && this.cicloAcademico.MatriculasTarde.Count() < cicloAcademico.TotalDeAlumnos)
            {
                this.comboBoxTurno.Items.AddRange(new object[] { "Mañana", "Tarde" });
                this.estadoDeVacantes = 1;
            }
            else
            {
                if(this.cicloAcademico.MatriculasMañana.Count() < this.cicloAcademico.TotalDeAlumnos)
                {
                    this.comboBoxTurno.Items.AddRange(new object[] { "Mañana"});
                    this.estadoDeVacantes = 2;
                }
                else
                {
                    if(this.cicloAcademico.MatriculasTarde.Count() < cicloAcademico.TotalDeAlumnos)
                    {
                        this.comboBoxTurno.Items.AddRange(new object[] { "Tarde" });
                        this.estadoDeVacantes = 3;
                    }
                }
            }
        }

        private void buttonBuscarAlumno_Click(object sender, EventArgs e)
        {
            string dniAlumno = textDni.Text.Trim();
            try
            {
                RegistrarMatriculaServicio registrarMatriculaServicio = new RegistrarMatriculaServicio();
                alumno = new Alumno();
                alumno = registrarMatriculaServicio.buscarPorDni(dniAlumno);

                if(alumno != null)
                {
                    if(registrarMatriculaServicio.verificarAlumnoMatriculado(dniAlumno,this.cicloAcademico))
                    {
                        limpiarDatosDelAlumno();
                        groupAlumnoDatosPersonales.Enabled = false;
                        groupAlumnoContacto.Enabled = false;
                        groupMatricula.Enabled = false;
                        this.estaAlumnoRegistrado = true;
                        MessageBox.Show("El alumno ya se encuentra matriculado en este ciclo academico");
                        
                    }
                    else
                    {
                        alumno.Dni = textDni.Text;
                        textNombres.Text = alumno.Nombre;
                        textApellidoPaterno.Text = alumno.ApellidoPaterno;
                        textApellidoMaterno.Text = alumno.ApellidoMaterno;
                        textDireccion.Text = alumno.Direccion;
                        textTelefono.Text = alumno.Celular;
                        textCorreo.Text = alumno.Correo;
                        datePickerFechaNacimiento.Value = alumno.FechaDeNacimiento;
                        groupAlumnoDatosPersonales.Enabled = false;
                        groupAlumnoContacto.Enabled = false;
                        groupMatricula.Enabled = true;
                        this.estaAlumnoRegistrado = true;
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(this, err.Message, "Sistema AcademiaSoft", MessageBoxButtons.OK, MessageBoxIcon.Error);
                limpiarDatosDelAlumno();
                groupAlumnoDatosPersonales.Enabled = true;
                groupAlumnoContacto.Enabled = true;
                groupMatricula.Enabled = true;
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

        private void llenarListaDeClase()
        {
            foreach(Clase clase in this.cicloAcademico.Clases)
            {
                if (clase.Horario.Turno.Equals("Mañana"))
                    this.listaDeClasesMañana.Add(clase);
                else
                {
                    if (clase.Horario.Turno.Equals("Tarde"))
                        this.listaDeClasesTarde.Add(clase);
                }
                    
            }
        }

        private void buttonRegistrarMatricula_Click(object sender, EventArgs e)
        {
            if(this.estaAlumnoRegistrado==false)
            {
                this.alumno.Dni = textDni.Text;
                this.alumno.Nombre = textNombres.Text.Trim();
                this.alumno.ApellidoPaterno = textApellidoPaterno.Text.Trim();
                this.alumno.ApellidoMaterno = textApellidoMaterno.Text.Trim();
                this.alumno.Direccion = textDireccion.Text.Trim();
                this.alumno.Celular = textTelefono.Text;
                this.alumno.Correo = textCorreo.Text.Trim();
                this.alumno.FechaDeNacimiento = datePickerFechaNacimiento.Value;
            }

            Matricula nuevaMatricula = new Matricula();
            nuevaMatricula.Secretario = new Secretario();
            nuevaMatricula.Alumno = this.alumno;
            nuevaMatricula.Secretario.Dni = this.dniSecretario;
            nuevaMatricula.Pago = this.precioPagar;
            nuevaMatricula.Fecha = DateTime.Today;
            nuevaMatricula.CicloAcademico = this.cicloAcademico;

            try
            {
                RegistrarMatriculaServicio registrarMatriculaServicio = new RegistrarMatriculaServicio();
                registrarMatriculaServicio.guardarMatricula(nuevaMatricula, estaAlumnoRegistrado, turnoSeleccionado);
                MessageBox.Show("Se ha matriculado correctamente al alumno");
                groupAlumnoDatosPersonales.Enabled = false;
                groupAlumnoContacto.Enabled = false;
                groupMatricula.Enabled = false;

            }
            catch (Exception err)
            {
                MessageBox.Show(this, err.Message, "Sistema AcademiaSoft", MessageBoxButtons.OK, MessageBoxIcon.Error);
                groupAlumnoDatosPersonales.Enabled = true;
                groupAlumnoContacto.Enabled = true;
                groupMatricula.Enabled = true;
                return;
            }
        }

        private void comboBoxTurno_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBoxTurno.Text == "Mañana")
            {
                textPrecio.Text = "S/.500.00";
                this.precioPagar = 500.00;
                this.turnoSeleccionado = "Mañana";
                dataGridClases.Rows.Clear();
                foreach (Clase clase in this.listaDeClasesMañana)
                {
                    Object[] filaClase = { clase.Codigo, clase.Curso.Nombre, clase.Docente.Nombre + " " + clase.Docente.ApellidoPaterno + " " + clase.Docente.ApellidoMaterno, clase.Horario.Dia + " " + clase.Horario.Inicio + " - " +clase.Horario.Fin};
                    dataGridClases.Rows.Add(filaClase);
                }
            }
            else if (comboBoxTurno.Text == "Tarde")
            {
                textPrecio.Text = "S/.600.00";
                this.precioPagar = 600.00;
                this.turnoSeleccionado = "Tarde";
                dataGridClases.Rows.Clear();
                foreach (Clase clase in this.listaDeClasesTarde)
                {
                    Object[] filaClase = { clase.Codigo, clase.Curso.Nombre, clase.Docente.Nombre + " " + clase.Docente.ApellidoPaterno + " " + clase.Docente.ApellidoMaterno, clase.Horario.Dia + " " + clase.Horario.Inicio + " - " + clase.Horario.Fin };
                    dataGridClases.Rows.Add(filaClase);
                }
            }
        }

        //SOLO PERMITE INGRESAR NUMEROS EN EL CAMPO DNI
        private void textDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar==8)
                e.Handled = false;
            else
                e.Handled = true;
        }

        //SOLO PERMITE INGRESAR NUMEROS EN EL CAMPO TELEFONO
        private void textTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 8)
                e.Handled = false;
            else
                e.Handled = true;
        }
    }
}
