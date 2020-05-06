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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textNombres = new System.Windows.Forms.TextBox();
            this.datePickerFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.textApellidoMaterno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textApellidoPaterno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupMatricula = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxTurno = new System.Windows.Forms.ComboBox();
            this.dataGridClases = new System.Windows.Forms.DataGridView();
            this.buttonRegistrarMatricula = new System.Windows.Forms.Button();
            this.dataCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataCurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDocente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataHorario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupAlumno.SuspendLayout();
            this.groupAlumnoContacto.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.groupAlumno.Controls.Add(this.groupBox1);
            this.groupAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupAlumno.Location = new System.Drawing.Point(29, 24);
            this.groupAlumno.Name = "groupAlumno";
            this.groupAlumno.Size = new System.Drawing.Size(846, 396);
            this.groupAlumno.TabIndex = 0;
            this.groupAlumno.TabStop = false;
            this.groupAlumno.Text = "Datos del Alumno";
            // 
            // buttonBuscarAlumno
            // 
            this.buttonBuscarAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscarAlumno.Location = new System.Drawing.Point(717, 68);
            this.buttonBuscarAlumno.Name = "buttonBuscarAlumno";
            this.buttonBuscarAlumno.Size = new System.Drawing.Size(113, 35);
            this.buttonBuscarAlumno.TabIndex = 2;
            this.buttonBuscarAlumno.Text = "Buscar";
            this.buttonBuscarAlumno.UseVisualStyleBackColor = true;
            // 
            // textDni
            // 
            this.textDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDni.Location = new System.Drawing.Point(537, 70);
            this.textDni.MaxLength = 8;
            this.textDni.Name = "textDni";
            this.textDni.Size = new System.Drawing.Size(163, 26);
            this.textDni.TabIndex = 0;
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
            this.groupAlumnoContacto.Location = new System.Drawing.Point(461, 109);
            this.groupAlumnoContacto.Name = "groupAlumnoContacto";
            this.groupAlumnoContacto.Size = new System.Drawing.Size(369, 266);
            this.groupAlumnoContacto.TabIndex = 11;
            this.groupAlumnoContacto.TabStop = false;
            this.groupAlumnoContacto.Text = "Contacto";
            // 
            // textCorreo
            // 
            this.textCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCorreo.Location = new System.Drawing.Point(27, 223);
            this.textCorreo.Name = "textCorreo";
            this.textCorreo.Size = new System.Drawing.Size(318, 26);
            this.textCorreo.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(23, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "Correo:";
            // 
            // textTelefono
            // 
            this.textTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTelefono.Location = new System.Drawing.Point(27, 147);
            this.textTelefono.Name = "textTelefono";
            this.textTelefono.Size = new System.Drawing.Size(318, 26);
            this.textTelefono.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Teléfono:";
            // 
            // textDireccion
            // 
            this.textDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDireccion.Location = new System.Drawing.Point(27, 69);
            this.textDireccion.Name = "textDireccion";
            this.textDireccion.Size = new System.Drawing.Size(318, 26);
            this.textDireccion.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Dirección:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(467, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "DNI:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textNombres);
            this.groupBox1.Controls.Add(this.datePickerFechaNacimiento);
            this.groupBox1.Controls.Add(this.textApellidoMaterno);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textApellidoPaterno);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(28, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(408, 325);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personales";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fecha de Nacimiento:";
            // 
            // textNombres
            // 
            this.textNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNombres.Location = new System.Drawing.Point(28, 68);
            this.textNombres.Name = "textNombres";
            this.textNombres.Size = new System.Drawing.Size(358, 26);
            this.textNombres.TabIndex = 6;
            // 
            // datePickerFechaNacimiento
            // 
            this.datePickerFechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePickerFechaNacimiento.Location = new System.Drawing.Point(28, 280);
            this.datePickerFechaNacimiento.Name = "datePickerFechaNacimiento";
            this.datePickerFechaNacimiento.Size = new System.Drawing.Size(358, 27);
            this.datePickerFechaNacimiento.TabIndex = 3;
            // 
            // textApellidoMaterno
            // 
            this.textApellidoMaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textApellidoMaterno.Location = new System.Drawing.Point(28, 206);
            this.textApellidoMaterno.Name = "textApellidoMaterno";
            this.textApellidoMaterno.Size = new System.Drawing.Size(358, 26);
            this.textApellidoMaterno.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Apellido Materno";
            // 
            // textApellidoPaterno
            // 
            this.textApellidoPaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textApellidoPaterno.Location = new System.Drawing.Point(28, 139);
            this.textApellidoPaterno.Name = "textApellidoPaterno";
            this.textApellidoPaterno.Size = new System.Drawing.Size(358, 26);
            this.textApellidoPaterno.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nombres:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Apellido Paterno:";
            // 
            // groupMatricula
            // 
            this.groupMatricula.Controls.Add(this.buttonRegistrarMatricula);
            this.groupMatricula.Controls.Add(this.dataGridClases);
            this.groupMatricula.Controls.Add(this.label9);
            this.groupMatricula.Controls.Add(this.comboBoxTurno);
            this.groupMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupMatricula.Location = new System.Drawing.Point(29, 448);
            this.groupMatricula.Name = "groupMatricula";
            this.groupMatricula.Size = new System.Drawing.Size(846, 353);
            this.groupMatricula.TabIndex = 1;
            this.groupMatricula.TabStop = false;
            this.groupMatricula.Text = "Datos de la Matricula";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(24, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "Turno:";
            // 
            // comboBoxTurno
            // 
            this.comboBoxTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTurno.FormattingEnabled = true;
            this.comboBoxTurno.Location = new System.Drawing.Point(98, 41);
            this.comboBoxTurno.Name = "comboBoxTurno";
            this.comboBoxTurno.Size = new System.Drawing.Size(195, 28);
            this.comboBoxTurno.TabIndex = 0;
            // 
            // dataGridClases
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridClases.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridClases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridClases.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataCodigo,
            this.dataCurso,
            this.dataDocente,
            this.dataHorario});
            this.dataGridClases.Location = new System.Drawing.Point(28, 87);
            this.dataGridClases.Name = "dataGridClases";
            this.dataGridClases.RowHeadersWidth = 51;
            this.dataGridClases.RowTemplate.Height = 24;
            this.dataGridClases.Size = new System.Drawing.Size(802, 150);
            this.dataGridClases.TabIndex = 2;
            // 
            // buttonRegistrarMatricula
            // 
            this.buttonRegistrarMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegistrarMatricula.Location = new System.Drawing.Point(690, 258);
            this.buttonRegistrarMatricula.Name = "buttonRegistrarMatricula";
            this.buttonRegistrarMatricula.Size = new System.Drawing.Size(140, 77);
            this.buttonRegistrarMatricula.TabIndex = 3;
            this.buttonRegistrarMatricula.Text = "Registrar Matricula";
            this.buttonRegistrarMatricula.UseVisualStyleBackColor = true;
            // 
            // dataCodigo
            // 
            this.dataCodigo.HeaderText = "Codigo";
            this.dataCodigo.MinimumWidth = 6;
            this.dataCodigo.Name = "dataCodigo";
            // 
            // dataCurso
            // 
            this.dataCurso.HeaderText = "Curso";
            this.dataCurso.MinimumWidth = 6;
            this.dataCurso.Name = "dataCurso";
            this.dataCurso.Width = 150;
            // 
            // dataDocente
            // 
            this.dataDocente.HeaderText = "Docente";
            this.dataDocente.MinimumWidth = 6;
            this.dataDocente.Name = "dataDocente";
            this.dataDocente.Width = 150;
            // 
            // dataHorario
            // 
            this.dataHorario.HeaderText = "Horario";
            this.dataHorario.MinimumWidth = 6;
            this.dataHorario.Name = "dataHorario";
            this.dataHorario.Width = 150;
            // 
            // FormRegistrarMatricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 843);
            this.Controls.Add(this.groupMatricula);
            this.Controls.Add(this.groupAlumno);
            this.Name = "FormRegistrarMatricula";
            this.Text = "Registrar Matricula";
            this.groupAlumno.ResumeLayout(false);
            this.groupAlumno.PerformLayout();
            this.groupAlumnoContacto.ResumeLayout(false);
            this.groupAlumnoContacto.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupMatricula.ResumeLayout(false);
            this.groupMatricula.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClases)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxTurno;
        private System.Windows.Forms.DataGridView dataGridClases;
        private System.Windows.Forms.Button buttonRegistrarMatricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDocente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataHorario;
    }
}