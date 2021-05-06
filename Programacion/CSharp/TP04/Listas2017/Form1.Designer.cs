namespace Listas2017
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.listaNodos = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdAgregarAlPrincipio = new System.Windows.Forms.Button();
            this.cmdAgregarAlFinal = new System.Windows.Forms.Button();
            this.btnQuitarPrimero = new System.Windows.Forms.Button();
            this.btnQuitarUltimo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnQuitarSeleccionado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listaNodos
            // 
            this.listaNodos.FormattingEnabled = true;
            this.listaNodos.ItemHeight = 16;
            this.listaNodos.Location = new System.Drawing.Point(12, 25);
            this.listaNodos.Name = "listaNodos";
            this.listaNodos.Size = new System.Drawing.Size(197, 372);
            this.listaNodos.TabIndex = 0;
            this.listaNodos.SelectedIndexChanged += new System.EventHandler(this.listaNodos_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(240, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(204, 22);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(240, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // cmdAgregarAlPrincipio
            // 
            this.cmdAgregarAlPrincipio.Location = new System.Drawing.Point(240, 97);
            this.cmdAgregarAlPrincipio.Name = "cmdAgregarAlPrincipio";
            this.cmdAgregarAlPrincipio.Size = new System.Drawing.Size(204, 34);
            this.cmdAgregarAlPrincipio.TabIndex = 3;
            this.cmdAgregarAlPrincipio.Text = "Agregar al principio";
            this.cmdAgregarAlPrincipio.UseVisualStyleBackColor = true;
            this.cmdAgregarAlPrincipio.Click += new System.EventHandler(this.cmdAgregarAlPrincipio_Click);
            // 
            // cmdAgregarAlFinal
            // 
            this.cmdAgregarAlFinal.Location = new System.Drawing.Point(240, 137);
            this.cmdAgregarAlFinal.Name = "cmdAgregarAlFinal";
            this.cmdAgregarAlFinal.Size = new System.Drawing.Size(204, 34);
            this.cmdAgregarAlFinal.TabIndex = 4;
            this.cmdAgregarAlFinal.Text = "Agregar al final";
            this.cmdAgregarAlFinal.UseVisualStyleBackColor = true;
            this.cmdAgregarAlFinal.Click += new System.EventHandler(this.cmdAgregarAlFinal_Click);
            // 
            // btnQuitarPrimero
            // 
            this.btnQuitarPrimero.Location = new System.Drawing.Point(240, 217);
            this.btnQuitarPrimero.Name = "btnQuitarPrimero";
            this.btnQuitarPrimero.Size = new System.Drawing.Size(204, 34);
            this.btnQuitarPrimero.TabIndex = 5;
            this.btnQuitarPrimero.Text = "Quitar primero";
            this.btnQuitarPrimero.UseVisualStyleBackColor = true;
            this.btnQuitarPrimero.Click += new System.EventHandler(this.btnQuitarPrimero_Click);
            // 
            // btnQuitarUltimo
            // 
            this.btnQuitarUltimo.Location = new System.Drawing.Point(240, 257);
            this.btnQuitarUltimo.Name = "btnQuitarUltimo";
            this.btnQuitarUltimo.Size = new System.Drawing.Size(204, 34);
            this.btnQuitarUltimo.TabIndex = 6;
            this.btnQuitarUltimo.Text = "Quitar ultimo";
            this.btnQuitarUltimo.UseVisualStyleBackColor = true;
            this.btnQuitarUltimo.Click += new System.EventHandler(this.btnQuitarUltimo_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(240, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 34);
            this.button1.TabIndex = 7;
            this.button1.Text = "Intercambiar derecha";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(240, 337);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(204, 34);
            this.button2.TabIndex = 8;
            this.button2.Text = "Intercambiar Izquierda";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnQuitarSeleccionado
            // 
            this.btnQuitarSeleccionado.Location = new System.Drawing.Point(240, 177);
            this.btnQuitarSeleccionado.Name = "btnQuitarSeleccionado";
            this.btnQuitarSeleccionado.Size = new System.Drawing.Size(204, 34);
            this.btnQuitarSeleccionado.TabIndex = 9;
            this.btnQuitarSeleccionado.Text = "Quitar seleccionado";
            this.btnQuitarSeleccionado.UseVisualStyleBackColor = true;
            this.btnQuitarSeleccionado.Click += new System.EventHandler(this.btnQuitarSeleccionado_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 420);
            this.Controls.Add(this.btnQuitarSeleccionado);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnQuitarUltimo);
            this.Controls.Add(this.btnQuitarPrimero);
            this.Controls.Add(this.cmdAgregarAlFinal);
            this.Controls.Add(this.cmdAgregarAlPrincipio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listaNodos);
            this.Name = "Form1";
            this.Text = "Lista enlazada simple";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listaNodos;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdAgregarAlPrincipio;
        private System.Windows.Forms.Button cmdAgregarAlFinal;
        private System.Windows.Forms.Button btnQuitarPrimero;
        private System.Windows.Forms.Button btnQuitarUltimo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnQuitarSeleccionado;
    }
}

