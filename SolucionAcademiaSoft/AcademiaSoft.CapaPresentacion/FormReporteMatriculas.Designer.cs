namespace AcademiaSoft.CapaPresentacion
{
    partial class FormReporteMatriculas
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
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxCiclo = new System.Windows.Forms.ComboBox();
            this.comboBoxTurn = new System.Windows.Forms.ComboBox();
            this.dataGridMatriculas = new System.Windows.Forms.DataGridView();
            this.dataCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataCurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDocente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataHorario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDniAlumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataAlumnoNombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMatriculas)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(118, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(395, 31);
            this.label11.TabIndex = 3;
            this.label11.Text = "REPORTE DE MATRICULAS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ciclo Académico:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(360, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Turno:";
            // 
            // comboBoxCiclo
            // 
            this.comboBoxCiclo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCiclo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCiclo.FormattingEnabled = true;
            this.comboBoxCiclo.Location = new System.Drawing.Point(166, 97);
            this.comboBoxCiclo.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxCiclo.Name = "comboBoxCiclo";
            this.comboBoxCiclo.Size = new System.Drawing.Size(147, 24);
            this.comboBoxCiclo.TabIndex = 6;
            this.comboBoxCiclo.SelectionChangeCommitted += new System.EventHandler(this.comboBoxCiclo_SelectionChangeCommitted);
            // 
            // comboBoxTurn
            // 
            this.comboBoxTurn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTurn.FormattingEnabled = true;
            this.comboBoxTurn.Location = new System.Drawing.Point(419, 96);
            this.comboBoxTurn.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxTurn.Name = "comboBoxTurn";
            this.comboBoxTurn.Size = new System.Drawing.Size(147, 24);
            this.comboBoxTurn.TabIndex = 7;
            this.comboBoxTurn.SelectionChangeCommitted += new System.EventHandler(this.comboBoxTurn_SelectionChangeCommitted);
            // 
            // dataGridMatriculas
            // 
            this.dataGridMatriculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMatriculas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataCodigo,
            this.dataCurso,
            this.dataDocente,
            this.dataHorario,
            this.dataDniAlumno,
            this.dataAlumnoNombres});
            this.dataGridMatriculas.Location = new System.Drawing.Point(35, 143);
            this.dataGridMatriculas.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridMatriculas.Name = "dataGridMatriculas";
            this.dataGridMatriculas.RowHeadersWidth = 51;
            this.dataGridMatriculas.RowTemplate.Height = 24;
            this.dataGridMatriculas.Size = new System.Drawing.Size(531, 382);
            this.dataGridMatriculas.TabIndex = 8;
            // 
            // dataCodigo
            // 
            this.dataCodigo.HeaderText = "Codigo";
            this.dataCodigo.MinimumWidth = 6;
            this.dataCodigo.Name = "dataCodigo";
            this.dataCodigo.Width = 125;
            // 
            // dataCurso
            // 
            this.dataCurso.HeaderText = "Fecha";
            this.dataCurso.MinimumWidth = 6;
            this.dataCurso.Name = "dataCurso";
            this.dataCurso.Width = 150;
            // 
            // dataDocente
            // 
            this.dataDocente.HeaderText = "Pago";
            this.dataDocente.MinimumWidth = 6;
            this.dataDocente.Name = "dataDocente";
            this.dataDocente.Width = 150;
            // 
            // dataHorario
            // 
            this.dataHorario.HeaderText = "Turno";
            this.dataHorario.MinimumWidth = 6;
            this.dataHorario.Name = "dataHorario";
            this.dataHorario.Width = 150;
            // 
            // dataDniAlumno
            // 
            this.dataDniAlumno.HeaderText = "DNI Alumno";
            this.dataDniAlumno.Name = "dataDniAlumno";
            // 
            // dataAlumnoNombres
            // 
            this.dataAlumnoNombres.HeaderText = "Nombres";
            this.dataAlumnoNombres.Name = "dataAlumnoNombres";
            // 
            // FormReporteMatriculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 555);
            this.Controls.Add(this.dataGridMatriculas);
            this.Controls.Add(this.comboBoxTurn);
            this.Controls.Add(this.comboBoxCiclo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label11);
            this.Name = "FormReporteMatriculas";
            this.Text = "Reporte de Matriculas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMatriculas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxCiclo;
        private System.Windows.Forms.ComboBox comboBoxTurn;
        private System.Windows.Forms.DataGridView dataGridMatriculas;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDocente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataHorario;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDniAlumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataAlumnoNombres;
    }
}