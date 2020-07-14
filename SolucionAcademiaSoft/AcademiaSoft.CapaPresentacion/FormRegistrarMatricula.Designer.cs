namespace AcademiaSoft.CapaPresentacion
{
    partial class FormRegistrarMatricula
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupAlumno = new System.Windows.Forms.GroupBox();
            this.buttonBuscarAlumno = new System.Windows.Forms.Button();
            this.textDni = new System.Windows.Forms.TextBox();
            this.groupAlumnoContacto = new System.Windows.Forms.GroupBox();
            this.textCorreo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textTelefono = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textDireccion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupAlumnoDatosPersonales = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textNombres = new System.Windows.Forms.TextBox();
            this.datePickerFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.textApellidoMaterno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textApellidoPaterno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupMatricula = new System.Windows.Forms.GroupBox();
            this.textPrecio = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonRegistrarMatricula = new System.Windows.Forms.Button();
            this.dataGridClases = new System.Windows.Forms.DataGridView();
            this.dataCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataCurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDocente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataHorario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxTurno = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textPeriodoAcademico = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textInicioDeClases = new System.Windows.Forms.TextBox();
            this.textFinDeClases = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupAlumno.SuspendLayout();
            this.groupAlumnoContacto.SuspendLayout();
            this.groupAlumnoDatosPersonales.SuspendLayout();
            this.groupMatricula.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClases)).BeginInit();
            this.SuspendLayout();
            // 
            // groupAlumno
            // 
            this.groupAlumno.Controls.Add(this.buttonBuscarAlumno);
            this.groupAlumno.Controls.Add(this.textDni);
            this.groupAlumno.Controls.Add(this.groupAlumnoContacto);
            this.groupAlumno.Controls.Add(this.label1);
            this.groupAlumno.Controls.Add(this.groupAlumnoDatosPersonales);
            this.groupAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupAlumno.Location = new System.Drawing.Point(22, 124);
            this.groupAlumno.Margin = new System.Windows.Forms.Padding(2);
            this.groupAlumno.Name = "groupAlumno";
            this.groupAlumno.Padding = new System.Windows.Forms.Padding(2);
            this.groupAlumno.Size = new System.Drawing.Size(685, 322);
            this.groupAlumno.TabIndex = 0;
            this.groupAlumno.TabStop = false;
            this.groupAlumno.Text = "Datos del Alumno";
            // 
            // buttonBuscarAlumno
            // 
            this.buttonBuscarAlumno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBuscarAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscarAlumno.Location = new System.Drawing.Point(583, 47);
            this.buttonBuscarAlumno.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBuscarAlumno.Name = "buttonBuscarAlumno";
            this.buttonBuscarAlumno.Size = new System.Drawing.Size(85, 28);
            this.buttonBuscarAlumno.TabIndex = 2;
            this.buttonBuscarAlumno.Text = "Buscar";
            this.buttonBuscarAlumno.UseVisualStyleBackColor = true;
            this.buttonBuscarAlumno.Click += new System.EventHandler(this.ButtonBuscarAlumno_Click);
            // 
            // textDni
            // 
            this.textDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDni.Location = new System.Drawing.Point(416, 52);
            this.textDni.Margin = new System.Windows.Forms.Padding(2);
            this.textDni.MaxLength = 8;
            this.textDni.Name = "textDni";
            this.textDni.Size = new System.Drawing.Size(149, 23);
            this.textDni.TabIndex = 0;
            this.textDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextDni_KeyPress);
            // 
            // groupAlumnoContacto
            // 
            this.groupAlumnoContacto.Controls.Add(this.textCorreo);
            this.groupAlumnoContacto.Controls.Add(this.label8);
            this.groupAlumnoContacto.Controls.Add(this.textTelefono);
            this.groupAlumnoContacto.Controls.Add(this.label7);
            this.groupAlumnoContacto.Controls.Add(this.textDireccion);
            this.groupAlumnoContacto.Controls.Add(this.label6);
            this.groupAlumnoContacto.Enabled = false;
            this.groupAlumnoContacto.Location = new System.Drawing.Point(347, 87);
            this.groupAlumnoContacto.Margin = new System.Windows.Forms.Padding(2);
            this.groupAlumnoContacto.Name = "groupAlumnoContacto";
            this.groupAlumnoContacto.Padding = new System.Windows.Forms.Padding(2);
            this.groupAlumnoContacto.Size = new System.Drawing.Size(321, 216);
            this.groupAlumnoContacto.TabIndex = 11;
            this.groupAlumnoContacto.TabStop = false;
            this.groupAlumnoContacto.Text = "Contacto";
            // 
            // textCorreo
            // 
            this.textCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCorreo.Location = new System.Drawing.Point(20, 181);
            this.textCorreo.Margin = new System.Windows.Forms.Padding(2);
            this.textCorreo.MaxLength = 50;
            this.textCorreo.Name = "textCorreo";
            this.textCorreo.Size = new System.Drawing.Size(282, 23);
            this.textCorreo.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 162);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = "Correo:";
            // 
            // textTelefono
            // 
            this.textTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTelefono.Location = new System.Drawing.Point(20, 119);
            this.textTelefono.Margin = new System.Windows.Forms.Padding(2);
            this.textTelefono.MaxLength = 9;
            this.textTelefono.Name = "textTelefono";
            this.textTelefono.Size = new System.Drawing.Size(282, 23);
            this.textTelefono.TabIndex = 3;
            this.textTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextTelefono_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 101);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Teléfono:";
            // 
            // textDireccion
            // 
            this.textDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDireccion.Location = new System.Drawing.Point(20, 56);
            this.textDireccion.Margin = new System.Windows.Forms.Padding(2);
            this.textDireccion.MaxLength = 50;
            this.textDireccion.Name = "textDireccion";
            this.textDireccion.Size = new System.Drawing.Size(282, 23);
            this.textDireccion.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 37);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Dirección:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(364, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "DNI:";
            // 
            // groupAlumnoDatosPersonales
            // 
            this.groupAlumnoDatosPersonales.Controls.Add(this.label2);
            this.groupAlumnoDatosPersonales.Controls.Add(this.textNombres);
            this.groupAlumnoDatosPersonales.Controls.Add(this.datePickerFechaNacimiento);
            this.groupAlumnoDatosPersonales.Controls.Add(this.textApellidoMaterno);
            this.groupAlumnoDatosPersonales.Controls.Add(this.label5);
            this.groupAlumnoDatosPersonales.Controls.Add(this.textApellidoPaterno);
            this.groupAlumnoDatosPersonales.Controls.Add(this.label3);
            this.groupAlumnoDatosPersonales.Controls.Add(this.label4);
            this.groupAlumnoDatosPersonales.Enabled = false;
            this.groupAlumnoDatosPersonales.Location = new System.Drawing.Point(21, 41);
            this.groupAlumnoDatosPersonales.Margin = new System.Windows.Forms.Padding(2);
            this.groupAlumnoDatosPersonales.Name = "groupAlumnoDatosPersonales";
            this.groupAlumnoDatosPersonales.Padding = new System.Windows.Forms.Padding(2);
            this.groupAlumnoDatosPersonales.Size = new System.Drawing.Size(309, 264);
            this.groupAlumnoDatosPersonales.TabIndex = 11;
            this.groupAlumnoDatosPersonales.TabStop = false;
            this.groupAlumnoDatosPersonales.Text = "Personales";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 205);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fecha de Nacimiento:";
            // 
            // textNombres
            // 
            this.textNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNombres.Location = new System.Drawing.Point(21, 55);
            this.textNombres.Margin = new System.Windows.Forms.Padding(2);
            this.textNombres.MaxLength = 50;
            this.textNombres.Name = "textNombres";
            this.textNombres.Size = new System.Drawing.Size(274, 23);
            this.textNombres.TabIndex = 6;
            // 
            // datePickerFechaNacimiento
            // 
            this.datePickerFechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePickerFechaNacimiento.Location = new System.Drawing.Point(21, 228);
            this.datePickerFechaNacimiento.Margin = new System.Windows.Forms.Padding(2);
            this.datePickerFechaNacimiento.Name = "datePickerFechaNacimiento";
            this.datePickerFechaNacimiento.Size = new System.Drawing.Size(274, 23);
            this.datePickerFechaNacimiento.TabIndex = 3;
            // 
            // textApellidoMaterno
            // 
            this.textApellidoMaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textApellidoMaterno.Location = new System.Drawing.Point(21, 167);
            this.textApellidoMaterno.Margin = new System.Windows.Forms.Padding(2);
            this.textApellidoMaterno.MaxLength = 50;
            this.textApellidoMaterno.Name = "textApellidoMaterno";
            this.textApellidoMaterno.Size = new System.Drawing.Size(274, 23);
            this.textApellidoMaterno.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 145);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Apellido Materno";
            // 
            // textApellidoPaterno
            // 
            this.textApellidoPaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textApellidoPaterno.Location = new System.Drawing.Point(21, 113);
            this.textApellidoPaterno.Margin = new System.Windows.Forms.Padding(2);
            this.textApellidoPaterno.MaxLength = 50;
            this.textApellidoPaterno.Name = "textApellidoPaterno";
            this.textApellidoPaterno.Size = new System.Drawing.Size(274, 23);
            this.textApellidoPaterno.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nombres:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 89);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Apellido Paterno:";
            // 
            // groupMatricula
            // 
            this.groupMatricula.Controls.Add(this.textPrecio);
            this.groupMatricula.Controls.Add(this.label10);
            this.groupMatricula.Controls.Add(this.buttonRegistrarMatricula);
            this.groupMatricula.Controls.Add(this.dataGridClases);
            this.groupMatricula.Controls.Add(this.label9);
            this.groupMatricula.Controls.Add(this.comboBoxTurno);
            this.groupMatricula.Enabled = false;
            this.groupMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupMatricula.Location = new System.Drawing.Point(22, 463);
            this.groupMatricula.Margin = new System.Windows.Forms.Padding(2);
            this.groupMatricula.Name = "groupMatricula";
            this.groupMatricula.Padding = new System.Windows.Forms.Padding(2);
            this.groupMatricula.Size = new System.Drawing.Size(685, 287);
            this.groupMatricula.TabIndex = 1;
            this.groupMatricula.TabStop = false;
            this.groupMatricula.Text = "Datos de la Matricula";
            // 
            // textPrecio
            // 
            this.textPrecio.Enabled = false;
            this.textPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPrecio.Location = new System.Drawing.Point(548, 30);
            this.textPrecio.Margin = new System.Windows.Forms.Padding(2);
            this.textPrecio.MaxLength = 8;
            this.textPrecio.Name = "textPrecio";
            this.textPrecio.Size = new System.Drawing.Size(120, 23);
            this.textPrecio.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(492, 33);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 17);
            this.label10.TabIndex = 4;
            this.label10.Text = "Precio:";
            // 
            // buttonRegistrarMatricula
            // 
            this.buttonRegistrarMatricula.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRegistrarMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegistrarMatricula.Location = new System.Drawing.Point(508, 237);
            this.buttonRegistrarMatricula.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRegistrarMatricula.Name = "buttonRegistrarMatricula";
            this.buttonRegistrarMatricula.Size = new System.Drawing.Size(160, 46);
            this.buttonRegistrarMatricula.TabIndex = 3;
            this.buttonRegistrarMatricula.Text = "Registrar Matricula";
            this.buttonRegistrarMatricula.UseVisualStyleBackColor = true;
            this.buttonRegistrarMatricula.Click += new System.EventHandler(this.ButtonRegistrarMatricula_Click);
            // 
            // dataGridClases
            // 
            this.dataGridClases.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridClases.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridClases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridClases.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataCodigo,
            this.dataCurso,
            this.dataDocente,
            this.dataHorario});
            this.dataGridClases.Location = new System.Drawing.Point(21, 71);
            this.dataGridClases.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridClases.Name = "dataGridClases";
            this.dataGridClases.RowHeadersWidth = 51;
            this.dataGridClases.RowTemplate.Height = 24;
            this.dataGridClases.Size = new System.Drawing.Size(647, 152);
            this.dataGridClases.TabIndex = 2;
            // 
            // dataCodigo
            // 
            this.dataCodigo.HeaderText = "Codigo";
            this.dataCodigo.MinimumWidth = 6;
            this.dataCodigo.Name = "dataCodigo";
            this.dataCodigo.Width = 84;
            // 
            // dataCurso
            // 
            this.dataCurso.HeaderText = "Curso";
            this.dataCurso.MinimumWidth = 6;
            this.dataCurso.Name = "dataCurso";
            this.dataCurso.Width = 76;
            // 
            // dataDocente
            // 
            this.dataDocente.HeaderText = "Docente";
            this.dataDocente.MinimumWidth = 6;
            this.dataDocente.Name = "dataDocente";
            this.dataDocente.Width = 95;
            // 
            // dataHorario
            // 
            this.dataHorario.HeaderText = "Horario";
            this.dataHorario.MinimumWidth = 6;
            this.dataHorario.Name = "dataHorario";
            this.dataHorario.Width = 86;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(18, 33);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "Turno:";
            // 
            // comboBoxTurno
            // 
            this.comboBoxTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTurno.FormattingEnabled = true;
            this.comboBoxTurno.Location = new System.Drawing.Point(74, 33);
            this.comboBoxTurno.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxTurno.Name = "comboBoxTurno";
            this.comboBoxTurno.Size = new System.Drawing.Size(147, 24);
            this.comboBoxTurno.TabIndex = 0;
            this.comboBoxTurno.SelectionChangeCommitted += new System.EventHandler(this.ComboBoxTurno_SelectionChangeCommitted);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(26, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(288, 31);
            this.label11.TabIndex = 2;
            this.label11.Text = "NUEVA MATRICULA";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.Control;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Maroon;
            this.label12.Location = new System.Drawing.Point(383, 34);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(200, 24);
            this.label12.TabIndex = 11;
            this.label12.Text = "Periodo Académico:";
            // 
            // textPeriodoAcademico
            // 
            this.textPeriodoAcademico.Enabled = false;
            this.textPeriodoAcademico.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPeriodoAcademico.Location = new System.Drawing.Point(587, 34);
            this.textPeriodoAcademico.Margin = new System.Windows.Forms.Padding(2);
            this.textPeriodoAcademico.MaxLength = 8;
            this.textPeriodoAcademico.Name = "textPeriodoAcademico";
            this.textPeriodoAcademico.Size = new System.Drawing.Size(120, 23);
            this.textPeriodoAcademico.TabIndex = 13;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label13.Location = new System.Drawing.Point(39, 84);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(124, 20);
            this.label13.TabIndex = 14;
            this.label13.Text = "Inicio de Clases:";
            // 
            // textInicioDeClases
            // 
            this.textInicioDeClases.Enabled = false;
            this.textInicioDeClases.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textInicioDeClases.Location = new System.Drawing.Point(175, 81);
            this.textInicioDeClases.Margin = new System.Windows.Forms.Padding(2);
            this.textInicioDeClases.MaxLength = 8;
            this.textInicioDeClases.Name = "textInicioDeClases";
            this.textInicioDeClases.Size = new System.Drawing.Size(177, 23);
            this.textInicioDeClases.TabIndex = 15;
            // 
            // textFinDeClases
            // 
            this.textFinDeClases.Enabled = false;
            this.textFinDeClases.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFinDeClases.Location = new System.Drawing.Point(530, 81);
            this.textFinDeClases.Margin = new System.Windows.Forms.Padding(2);
            this.textFinDeClases.MaxLength = 8;
            this.textFinDeClases.Name = "textFinDeClases";
            this.textFinDeClases.Size = new System.Drawing.Size(177, 23);
            this.textFinDeClases.TabIndex = 17;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label14.Location = new System.Drawing.Point(417, 81);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(109, 20);
            this.label14.TabIndex = 16;
            this.label14.Text = "Fin de Clases:";
            // 
            // FormRegistrarMatricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 773);
            this.Controls.Add(this.textFinDeClases);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textInicioDeClases);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textPeriodoAcademico);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupMatricula);
            this.Controls.Add(this.groupAlumno);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(739, 812);
            this.MinimumSize = new System.Drawing.Size(739, 812);
            this.Name = "FormRegistrarMatricula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Matricula";
            this.groupAlumno.ResumeLayout(false);
            this.groupAlumno.PerformLayout();
            this.groupAlumnoContacto.ResumeLayout(false);
            this.groupAlumnoContacto.PerformLayout();
            this.groupAlumnoDatosPersonales.ResumeLayout(false);
            this.groupAlumnoDatosPersonales.PerformLayout();
            this.groupMatricula.ResumeLayout(false);
            this.groupMatricula.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClases)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupAlumno;
        private System.Windows.Forms.Button buttonBuscarAlumno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textDni;
        private System.Windows.Forms.DateTimePicker datePickerFechaNacimiento;
        private System.Windows.Forms.TextBox textApellidoPaterno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textNombres;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textApellidoMaterno;
        private System.Windows.Forms.GroupBox groupAlumnoContacto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textTelefono;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textDireccion;
        private System.Windows.Forms.TextBox textCorreo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupMatricula;
        private System.Windows.Forms.GroupBox groupAlumnoDatosPersonales;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxTurno;
        private System.Windows.Forms.DataGridView dataGridClases;
        private System.Windows.Forms.Button buttonRegistrarMatricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDocente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataHorario;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textPrecio;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textPeriodoAcademico;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textInicioDeClases;
        private System.Windows.Forms.TextBox textFinDeClases;
        private System.Windows.Forms.Label label14;
    }
}