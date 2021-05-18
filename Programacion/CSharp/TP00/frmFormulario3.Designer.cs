namespace EjemploClaseN3.Winform1
{
    partial class frmFormulario3
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
            this.components = new System.ComponentModel.Container();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.btnVerFecha = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.btnAgregarNodo = new System.Windows.Forms.Button();
            this.txtNodo = new System.Windows.Forms.TextBox();
            this.btnAgregarNodo2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progress1 = new System.Windows.Forms.ProgressBar();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(68, 46);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(220, 22);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(68, 170);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            // 
            // btnVerFecha
            // 
            this.btnVerFecha.Location = new System.Drawing.Point(105, 95);
            this.btnVerFecha.Name = "btnVerFecha";
            this.btnVerFecha.Size = new System.Drawing.Size(140, 47);
            this.btnVerFecha.TabIndex = 2;
            this.btnVerFecha.Text = "Ver fecha";
            this.btnVerFecha.UseVisualStyleBackColor = true;
            this.btnVerFecha.Click += new System.EventHandler(this.btnVerFecha_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(418, 72);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(310, 250);
            this.treeView1.TabIndex = 3;
            // 
            // btnAgregarNodo
            // 
            this.btnAgregarNodo.Location = new System.Drawing.Point(418, 400);
            this.btnAgregarNodo.Name = "btnAgregarNodo";
            this.btnAgregarNodo.Size = new System.Drawing.Size(152, 38);
            this.btnAgregarNodo.TabIndex = 4;
            this.btnAgregarNodo.Text = "Agregar nodo raiz";
            this.btnAgregarNodo.UseVisualStyleBackColor = true;
            this.btnAgregarNodo.Click += new System.EventHandler(this.btnAgregarNodo_Click);
            // 
            // txtNodo
            // 
            this.txtNodo.Location = new System.Drawing.Point(418, 354);
            this.txtNodo.Name = "txtNodo";
            this.txtNodo.Size = new System.Drawing.Size(310, 22);
            this.txtNodo.TabIndex = 5;
            // 
            // btnAgregarNodo2
            // 
            this.btnAgregarNodo2.Location = new System.Drawing.Point(591, 400);
            this.btnAgregarNodo2.Name = "btnAgregarNodo2";
            this.btnAgregarNodo2.Size = new System.Drawing.Size(137, 38);
            this.btnAgregarNodo2.TabIndex = 6;
            this.btnAgregarNodo2.Text = "Agregar otro nodo";
            this.btnAgregarNodo2.UseVisualStyleBackColor = true;
            this.btnAgregarNodo2.Click += new System.EventHandler(this.btnAgregarNodo2_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // progress1
            // 
            this.progress1.Location = new System.Drawing.Point(49, 475);
            this.progress1.Name = "progress1";
            this.progress1.Size = new System.Drawing.Size(702, 23);
            this.progress1.TabIndex = 7;
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(49, 437);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(95, 32);
            this.btnIniciar.TabIndex = 8;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // frmFormulario3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 510);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.progress1);
            this.Controls.Add(this.btnAgregarNodo2);
            this.Controls.Add(this.txtNodo);
            this.Controls.Add(this.btnAgregarNodo);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.btnVerFecha);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "frmFormulario3";
            this.Text = "Formulario3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button btnVerFecha;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button btnAgregarNodo;
        private System.Windows.Forms.TextBox txtNodo;
        private System.Windows.Forms.Button btnAgregarNodo2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar progress1;
        private System.Windows.Forms.Button btnIniciar;
    }
}