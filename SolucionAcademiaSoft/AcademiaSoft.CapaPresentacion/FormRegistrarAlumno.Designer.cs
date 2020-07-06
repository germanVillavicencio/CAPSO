namespace AcademiaSoft.CapaPresentacion
{
    partial class FormRegistrarAlumno
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
            this.buttonBuscarAlumno = new System.Windows.Forms.Button();
            this.textDni = new System.Windows.Forms.TextBox();
            this.textCorreo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textTelefono = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textDireccion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupDatosAlumno = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textNombres = new System.Windows.Forms.TextBox();
            this.datePickerFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.textApellidoMaterno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textApellidoPaterno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupDatosAlumno.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonBuscarAlumno
            // 
            this.buttonBuscarAlumno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBuscarAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscarAlumno.Location = new System.Drawing.Point(243, 52);
            this.buttonBuscarAlumno.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBuscarAlumno.Name = "buttonBuscarAlumno";
            this.buttonBuscarAlumno.Size = new System.Drawing.Size(85, 28);
            this.buttonBuscarAlumno.TabIndex = 2;
            this.buttonBuscarAlumno.Text = "Buscar";
            this.buttonBuscarAlumno.UseVisualStyleBackColor = true;
            this.buttonBuscarAlumno.Click += new System.EventHandler(this.buttonBuscarAlumno_Click);
            // 
            // textDni
            // 
            this.textDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDni.Location = new System.Drawing.Point(80, 57);
            this.textDni.Margin = new System.Windows.Forms.Padding(2);
            this.textDni.MaxLength = 8;
            this.textDni.Name = "textDni";
            this.textDni.Size = new System.Drawing.Size(149, 23);
            this.textDni.TabIndex = 0;
            this.textDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textDni_KeyPress);
            // 
            // textCorreo
            // 
            this.textCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCorreo.Location = new System.Drawing.Point(20, 344);
            this.textCorreo.Margin = new System.Windows.Forms.Padding(2);
            this.textCorreo.MaxLength = 50;
            this.textCorreo.Name = "textCorreo";
            this.textCorreo.Size = new System.Drawing.Size(274, 23);
            this.textCorreo.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 327);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = "Correo:";
            // 
            // textTelefono
            // 
            this.textTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTelefono.Location = new System.Drawing.Point(20, 296);
            this.textTelefono.Margin = new System.Windows.Forms.Padding(2);
            this.textTelefono.MaxLength = 9;
            this.textTelefono.Name = "textTelefono";
            this.textTelefono.Size = new System.Drawing.Size(274, 23);
            this.textTelefono.TabIndex = 3;
            this.textTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textTelefono_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 278);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Teléfono:";
            // 
            // textDireccion
            // 
            this.textDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDireccion.Location = new System.Drawing.Point(20, 247);
            this.textDireccion.Margin = new System.Windows.Forms.Padding(2);
            this.textDireccion.MaxLength = 50;
            this.textDireccion.Name = "textDireccion";
            this.textDireccion.Size = new System.Drawing.Size(274, 23);
            this.textDireccion.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 229);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Dirección:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "DNI:";
            // 
            // groupDatosAlumno
            // 
            this.groupDatosAlumno.Controls.Add(this.button1);
            this.groupDatosAlumno.Controls.Add(this.textCorreo);
            this.groupDatosAlumno.Controls.Add(this.label8);
            this.groupDatosAlumno.Controls.Add(this.label2);
            this.groupDatosAlumno.Controls.Add(this.textNombres);
            this.groupDatosAlumno.Controls.Add(this.textTelefono);
            this.groupDatosAlumno.Controls.Add(this.label7);
            this.groupDatosAlumno.Controls.Add(this.datePickerFechaNacimiento);
            this.groupDatosAlumno.Controls.Add(this.textApellidoMaterno);
            this.groupDatosAlumno.Controls.Add(this.textDireccion);
            this.groupDatosAlumno.Controls.Add(this.label6);
            this.groupDatosAlumno.Controls.Add(this.label5);
            this.groupDatosAlumno.Controls.Add(this.textApellidoPaterno);
            this.groupDatosAlumno.Controls.Add(this.label3);
            this.groupDatosAlumno.Controls.Add(this.label4);
            this.groupDatosAlumno.Enabled = false;
            this.groupDatosAlumno.Location = new System.Drawing.Point(19, 96);
            this.groupDatosAlumno.Margin = new System.Windows.Forms.Padding(2);
            this.groupDatosAlumno.Name = "groupDatosAlumno";
            this.groupDatosAlumno.Padding = new System.Windows.Forms.Padding(2);
            this.groupDatosAlumno.Size = new System.Drawing.Size(309, 425);
            this.groupDatosAlumno.TabIndex = 11;
            this.groupDatosAlumno.TabStop = false;
            this.groupDatosAlumno.Text = "Datos";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(108, 380);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 28);
            this.button1.TabIndex = 12;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 175);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fecha de Nacimiento:";
            // 
            // textNombres
            // 
            this.textNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNombres.Location = new System.Drawing.Point(20, 50);
            this.textNombres.Margin = new System.Windows.Forms.Padding(2);
            this.textNombres.MaxLength = 50;
            this.textNombres.Name = "textNombres";
            this.textNombres.Size = new System.Drawing.Size(274, 23);
            this.textNombres.TabIndex = 6;
            // 
            // datePickerFechaNacimiento
            // 
            this.datePickerFechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePickerFechaNacimiento.Location = new System.Drawing.Point(20, 194);
            this.datePickerFechaNacimiento.Margin = new System.Windows.Forms.Padding(2);
            this.datePickerFechaNacimiento.Name = "datePickerFechaNacimiento";
            this.datePickerFechaNacimiento.Size = new System.Drawing.Size(274, 23);
            this.datePickerFechaNacimiento.TabIndex = 3;
            // 
            // textApellidoMaterno
            // 
            this.textApellidoMaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textApellidoMaterno.Location = new System.Drawing.Point(20, 145);
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
            this.label5.Location = new System.Drawing.Point(16, 126);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Apellido Materno";
            // 
            // textApellidoPaterno
            // 
            this.textApellidoPaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textApellidoPaterno.Location = new System.Drawing.Point(20, 97);
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
            this.label4.Location = new System.Drawing.Point(17, 78);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Apellido Paterno:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(91, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(203, 26);
            this.label11.TabIndex = 13;
            this.label11.Text = "NUEVO ALUMNO";
            // 
            // FormRegistrarAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 550);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.buttonBuscarAlumno);
            this.Controls.Add(this.textDni);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupDatosAlumno);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(378, 589);
            this.MinimumSize = new System.Drawing.Size(378, 589);
            this.Name = "FormRegistrarAlumno";
            this.Text = "Registrar Alumno";
            this.groupDatosAlumno.ResumeLayout(false);
            this.groupDatosAlumno.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBuscarAlumno;
        private System.Windows.Forms.TextBox textDni;
        private System.Windows.Forms.TextBox textCorreo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textTelefono;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textDireccion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupDatosAlumno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textNombres;
        private System.Windows.Forms.DateTimePicker datePickerFechaNacimiento;
        private System.Windows.Forms.TextBox textApellidoMaterno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textApellidoPaterno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label11;
    }
}