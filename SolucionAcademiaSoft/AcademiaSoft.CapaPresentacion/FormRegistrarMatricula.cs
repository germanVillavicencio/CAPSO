﻿using System;
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

        Boolean estaAlumnoRegistrado = false;
        double precioPagar = 0.0;
        string turnoSeleccionado = "";
        string dniSecretario = "11111111";
        public FormRegistrarMatricula(CicloAcademico ciclo)
        {
            this.cicloAcademico = ciclo;
            this.numeroMatriculasMañana = ciclo.calcularMatriculasTurnoDia();
            this.numeroMatriculasTarde = ciclo.calcularMatriculasTurnoTarde();
            llenarListaDeClase();
            InitializeComponent();
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
                RegistrarMatriculaServicio registrarMatriculaServicio = new RegistrarMatriculaServicio();
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
                        this.estaAlumnoRegistrado = true;
                        MessageBox.Show("El alumno ya se encuentra matriculado en este ciclo academico");
                        
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
            RegistrarMatriculaServicio registrarMatriculaServicio = new RegistrarMatriculaServicio();

            Matricula nuevaMatricula = new Matricula();
            nuevaMatricula.Secretario = new Secretario();
            nuevaMatricula.Alumno = this.alumno;
            nuevaMatricula.Secretario.Dni = this.dniSecretario;
            nuevaMatricula.Precio = this.precioPagar;
            nuevaMatricula.Fecha = DateTime.Today;
            nuevaMatricula.CicloAcademico = this.cicloAcademico;

            try
            {
                
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
                dataGridClases.Rows.Clear();//Limpiar la tabla donde se muestran las clases
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
