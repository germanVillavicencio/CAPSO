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

        List<Clase> listaDeClasesMañana = new List<Clase>();
        List<Clase> listaDeClasesTarde = new List<Clase>();

        int numeroMatriculasMañana = 0;
        int numeroMatriculasTarde = 0;

        string turnoSeleccionado = "";
        string dniSecretario = "";

        RegistrarMatriculaServicio registrarMatriculaServicio;
        public FormRegistrarMatricula(CicloAcademico ciclo, string dni)
        {
            this.cicloAcademico = ciclo;
            this.dniSecretario = dni;
            this.numeroMatriculasMañana = ciclo.calcularMatriculasTurnoDia();
            this.numeroMatriculasTarde = ciclo.calcularMatriculasTurnoTarde();
            llenarListaDeClase();
            InitializeComponent();

            MaximizeBox = false;
            registrarMatriculaServicio = new RegistrarMatriculaServicio();
            textPrecio.Text = "S/." + this.cicloAcademico.Precio;
            textPeriodoAcademico.Text = this.cicloAcademico.Periodo;
            textInicioDeClases.Text = registrarMatriculaServicio.obtenerFechaDeInicioDeClases(ciclo);
            textFinDeClases.Text = registrarMatriculaServicio.obtenerFechaDeFinDeClases(ciclo);

            if (this.numeroMatriculasMañana < cicloAcademico.TotalDeAlumnos && this.numeroMatriculasTarde < cicloAcademico.TotalDeAlumnos)
            {
                this.comboBoxTurno.Items.AddRange(new object[] { "Mañana", "Tarde" });
            }
            else
            {
                if(this.numeroMatriculasMañana < this.cicloAcademico.TotalDeAlumnos)
                {
                    this.comboBoxTurno.Items.AddRange(new object[] { "Mañana"});
                }
                else
                {
                    if(this.numeroMatriculasTarde < cicloAcademico.TotalDeAlumnos)
                    {
                        this.comboBoxTurno.Items.AddRange(new object[] { "Tarde" });
                    }
                }
            }
        }

        private void buttonBuscarAlumno_Click(object sender, EventArgs e)//Busca alumnos
        {
            string dniAlumno = textDni.Text.Trim();
            try
            {
                alumno = new Alumno();
                alumno = registrarMatriculaServicio.buscarPorDni(dniAlumno);

                if(alumno != null)
                {
                    if(registrarMatriculaServicio.verificarAlumnoMatriculado(dniAlumno,this.cicloAcademico))
                    {   //si está matriculado
                        limpiarDatosDelAlumno();
                        groupAlumnoDatosPersonales.Enabled = false;
                        groupAlumnoContacto.Enabled = false;
                        groupMatricula.Enabled = false;
                        MessageBox.Show("El alumno ya se encuentra matriculado en este ciclo academico", "Sistema AcademiaSoft", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    else
                    {   //si no está matriculado en el ciclo actual
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
                        groupMatricula.Enabled = true;//se habilita para elegir el turno
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(this, err.Message, "Sistema AcademiaSoft", MessageBoxButtons.OK, MessageBoxIcon.Error);
                limpiarDatosDelAlumno();
                groupAlumnoDatosPersonales.Enabled = false;
                groupAlumnoContacto.Enabled = false;
                groupMatricula.Enabled = false;
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
            string horaFin;
            foreach(Clase clase in this.cicloAcademico.Clases)
            {
                horaFin = clase.Horario.Fin.Substring(0,2);
                if (String.Compare(horaFin, "13") < 0)
                {
                    this.listaDeClasesMañana.Add(clase);
                }
                else if (String.Compare(horaFin, "13") > 0)
                {
                    this.listaDeClasesTarde.Add(clase);
                }
            }
        }

        private void buttonRegistrarMatricula_Click(object sender, EventArgs e)
        {
            Matricula nuevaMatricula = new Matricula();
            nuevaMatricula.Secretario = new Secretario();
            nuevaMatricula.Alumno = this.alumno;
            nuevaMatricula.Secretario.Dni = this.dniSecretario;
            nuevaMatricula.Fecha = DateTime.Today;
            nuevaMatricula.CicloAcademico = this.cicloAcademico;

            try
            {
                
                registrarMatriculaServicio.guardarMatricula(nuevaMatricula, turnoSeleccionado);
                MessageBox.Show("Se ha matriculado correctamente al alumno");
                groupAlumnoDatosPersonales.Enabled = false;
                groupAlumnoContacto.Enabled = false;
                groupMatricula.Enabled = false;
                this.Close();

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
                this.turnoSeleccionado = "Mañana";
                dataGridClases.Rows.Clear();//Limpiar la tabla donde se muestran las clases
                foreach (Clase clase in this.listaDeClasesMañana)
                {
                    Object[] filaClase = { clase.Codigo, clase.Curso.Nombre, clase.Docente.Nombre + " " + clase.Docente.ApellidoPaterno + " " + clase.Docente.ApellidoMaterno, clase.Horario.Dia + " " + clase.Horario.Inicio + " - " +clase.Horario.Fin};
                    dataGridClases.Rows.Add(filaClase);
                }
            }
            else if (comboBoxTurno.Text == "Tarde")
            {
                this.turnoSeleccionado = "Tarde";
                dataGridClases.Rows.Clear();//Limpiar la tabla donde se muestran las clases
                foreach (Clase clase in this.listaDeClasesTarde)
                {
                    Object[] filaClase = { clase.Codigo, clase.Curso.Nombre, clase.Docente.Nombre + " " + clase.Docente.ApellidoPaterno + " " + clase.Docente.ApellidoMaterno, clase.Horario.Dia + " " + clase.Horario.Inicio + " - " + clase.Horario.Fin };
                    dataGridClases.Rows.Add(filaClase);
                }
            }
        }

        //SOLO PERMITE INGRESAR NUMEROS EN EL CAMPO DNI MIENTRAS SE ESCRIBE
        private void textDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar==8)
                e.Handled = false;
            else
                e.Handled = true;
        }

        //SOLO PERMITE INGRESAR NUMEROS EN EL CAMPO TELEFONO MIENTRAS SE ESCRIBE 
        private void textTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 8)
                e.Handled = false;
            else
                e.Handled = true;
        }
    }
}
