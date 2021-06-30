
namespace Apareo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.numLegajo1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.btnGuardarAlumno = new System.Windows.Forms.Button();
            this.numNota = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numLegajo2 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGuardarNota = new System.Windows.Forms.Button();
            this.btnPromedios = new System.Windows.Forms.Button();
            this.grillaAlumnos = new System.Windows.Forms.DataGridView();
            this.grillaNotas = new System.Windows.Forms.DataGridView();
            this.grillaPromedios = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numLegajo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLegajo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaAlumnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaNotas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaPromedios)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Legajo";
            // 
            // numLegajo1
            // 
            this.numLegajo1.Location = new System.Drawing.Point(69, 13);
            this.numLegajo1.Name = "numLegajo1";
            this.numLegajo1.Size = new System.Drawing.Size(203, 23);
            this.numLegajo1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellido";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(69, 41);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(203, 23);
            this.txtApellido.TabIndex = 3;
            // 
            // btnGuardarAlumno
            // 
            this.btnGuardarAlumno.Location = new System.Drawing.Point(69, 70);
            this.btnGuardarAlumno.Name = "btnGuardarAlumno";
            this.btnGuardarAlumno.Size = new System.Drawing.Size(203, 23);
            this.btnGuardarAlumno.TabIndex = 4;
            this.btnGuardarAlumno.Text = "Guardar Alumno";
            this.btnGuardarAlumno.UseVisualStyleBackColor = true;
            this.btnGuardarAlumno.Click += new System.EventHandler(this.btnGuardarAlumno_Click);
            // 
            // numNota
            // 
            this.numNota.Location = new System.Drawing.Point(69, 264);
            this.numNota.Name = "numNota";
            this.numNota.Size = new System.Drawing.Size(203, 23);
            this.numNota.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nota";
            // 
            // numLegajo2
            // 
            this.numLegajo2.Location = new System.Drawing.Point(69, 235);
            this.numLegajo2.Name = "numLegajo2";
            this.numLegajo2.Size = new System.Drawing.Size(203, 23);
            this.numLegajo2.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Legajo";
            // 
            // btnGuardarNota
            // 
            this.btnGuardarNota.Location = new System.Drawing.Point(69, 293);
            this.btnGuardarNota.Name = "btnGuardarNota";
            this.btnGuardarNota.Size = new System.Drawing.Size(203, 23);
            this.btnGuardarNota.TabIndex = 9;
            this.btnGuardarNota.Text = "Guardar Nota";
            this.btnGuardarNota.UseVisualStyleBackColor = true;
            this.btnGuardarNota.Click += new System.EventHandler(this.btnGuardarNota_Click);
            // 
            // btnPromedios
            // 
            this.btnPromedios.Location = new System.Drawing.Point(278, 11);
            this.btnPromedios.Name = "btnPromedios";
            this.btnPromedios.Size = new System.Drawing.Size(343, 23);
            this.btnPromedios.TabIndex = 10;
            this.btnPromedios.Text = "Obtener Promedios";
            this.btnPromedios.UseVisualStyleBackColor = true;
            this.btnPromedios.Click += new System.EventHandler(this.btnPromedios_Click);
            // 
            // grillaAlumnos
            // 
            this.grillaAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaAlumnos.Location = new System.Drawing.Point(12, 99);
            this.grillaAlumnos.Name = "grillaAlumnos";
            this.grillaAlumnos.RowTemplate.Height = 25;
            this.grillaAlumnos.Size = new System.Drawing.Size(260, 130);
            this.grillaAlumnos.TabIndex = 11;
            // 
            // grillaNotas
            // 
            this.grillaNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaNotas.Location = new System.Drawing.Point(12, 322);
            this.grillaNotas.Name = "grillaNotas";
            this.grillaNotas.RowTemplate.Height = 25;
            this.grillaNotas.Size = new System.Drawing.Size(260, 130);
            this.grillaNotas.TabIndex = 12;
            // 
            // grillaPromedios
            // 
            this.grillaPromedios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaPromedios.Location = new System.Drawing.Point(278, 40);
            this.grillaPromedios.Name = "grillaPromedios";
            this.grillaPromedios.RowTemplate.Height = 25;
            this.grillaPromedios.Size = new System.Drawing.Size(343, 412);
            this.grillaPromedios.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 470);
            this.Controls.Add(this.grillaPromedios);
            this.Controls.Add(this.grillaNotas);
            this.Controls.Add(this.grillaAlumnos);
            this.Controls.Add(this.btnPromedios);
            this.Controls.Add(this.btnGuardarNota);
            this.Controls.Add(this.numLegajo2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numNota);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGuardarAlumno);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numLegajo1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Apareo de archivos y corte de control en C#";
            ((System.ComponentModel.ISupportInitialize)(this.numLegajo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLegajo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaAlumnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaNotas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaPromedios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numLegajo1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Button btnGuardarAlumno;
        private System.Windows.Forms.NumericUpDown numNota;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numLegajo2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGuardarNota;
        private System.Windows.Forms.Button btnPromedios;
        private System.Windows.Forms.DataGridView grillaAlumnos;
        private System.Windows.Forms.DataGridView grillaNotas;
        private System.Windows.Forms.DataGridView grillaPromedios;
    }
}

