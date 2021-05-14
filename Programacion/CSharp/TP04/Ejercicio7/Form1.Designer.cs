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
      this.btnIntercambiarDerecha = new System.Windows.Forms.Button();
      this.btnIntercambiarIzquierda = new System.Windows.Forms.Button();
      this.btnQuitarSeleccionado = new System.Windows.Forms.Button();
      this.btnIntercambiar = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // listaNodos
      // 
      this.listaNodos.FormattingEnabled = true;
      this.listaNodos.Location = new System.Drawing.Point(9, 20);
      this.listaNodos.Margin = new System.Windows.Forms.Padding(2);
      this.listaNodos.Name = "listaNodos";
      this.listaNodos.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
      this.listaNodos.Size = new System.Drawing.Size(149, 303);
      this.listaNodos.TabIndex = 0;
      this.listaNodos.SelectedIndexChanged += new System.EventHandler(this.listaNodos_SelectedIndexChanged);
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(180, 46);
      this.textBox1.Margin = new System.Windows.Forms.Padding(2);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(154, 20);
      this.textBox1.TabIndex = 1;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(180, 27);
      this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(44, 13);
      this.label1.TabIndex = 2;
      this.label1.Text = "Nombre";
      // 
      // cmdAgregarAlPrincipio
      // 
      this.cmdAgregarAlPrincipio.Location = new System.Drawing.Point(180, 79);
      this.cmdAgregarAlPrincipio.Margin = new System.Windows.Forms.Padding(2);
      this.cmdAgregarAlPrincipio.Name = "cmdAgregarAlPrincipio";
      this.cmdAgregarAlPrincipio.Size = new System.Drawing.Size(153, 28);
      this.cmdAgregarAlPrincipio.TabIndex = 3;
      this.cmdAgregarAlPrincipio.Text = "Agregar al principio";
      this.cmdAgregarAlPrincipio.UseVisualStyleBackColor = true;
      this.cmdAgregarAlPrincipio.Click += new System.EventHandler(this.cmdAgregarAlPrincipio_Click);
      // 
      // cmdAgregarAlFinal
      // 
      this.cmdAgregarAlFinal.Location = new System.Drawing.Point(180, 111);
      this.cmdAgregarAlFinal.Margin = new System.Windows.Forms.Padding(2);
      this.cmdAgregarAlFinal.Name = "cmdAgregarAlFinal";
      this.cmdAgregarAlFinal.Size = new System.Drawing.Size(153, 28);
      this.cmdAgregarAlFinal.TabIndex = 4;
      this.cmdAgregarAlFinal.Text = "Agregar al final";
      this.cmdAgregarAlFinal.UseVisualStyleBackColor = true;
      this.cmdAgregarAlFinal.Click += new System.EventHandler(this.cmdAgregarAlFinal_Click);
      // 
      // btnQuitarPrimero
      // 
      this.btnQuitarPrimero.Location = new System.Drawing.Point(180, 176);
      this.btnQuitarPrimero.Margin = new System.Windows.Forms.Padding(2);
      this.btnQuitarPrimero.Name = "btnQuitarPrimero";
      this.btnQuitarPrimero.Size = new System.Drawing.Size(153, 28);
      this.btnQuitarPrimero.TabIndex = 5;
      this.btnQuitarPrimero.Text = "Quitar primero";
      this.btnQuitarPrimero.UseVisualStyleBackColor = true;
      this.btnQuitarPrimero.Click += new System.EventHandler(this.btnQuitarPrimero_Click);
      // 
      // btnQuitarUltimo
      // 
      this.btnQuitarUltimo.Location = new System.Drawing.Point(180, 209);
      this.btnQuitarUltimo.Margin = new System.Windows.Forms.Padding(2);
      this.btnQuitarUltimo.Name = "btnQuitarUltimo";
      this.btnQuitarUltimo.Size = new System.Drawing.Size(153, 28);
      this.btnQuitarUltimo.TabIndex = 6;
      this.btnQuitarUltimo.Text = "Quitar ultimo";
      this.btnQuitarUltimo.UseVisualStyleBackColor = true;
      this.btnQuitarUltimo.Click += new System.EventHandler(this.btnQuitarUltimo_Click);
      // 
      // btnIntercambiarDerecha
      // 
      this.btnIntercambiarDerecha.Location = new System.Drawing.Point(180, 241);
      this.btnIntercambiarDerecha.Margin = new System.Windows.Forms.Padding(2);
      this.btnIntercambiarDerecha.Name = "btnIntercambiarDerecha";
      this.btnIntercambiarDerecha.Size = new System.Drawing.Size(153, 28);
      this.btnIntercambiarDerecha.TabIndex = 7;
      this.btnIntercambiarDerecha.Text = "Intercambiar derecha";
      this.btnIntercambiarDerecha.UseVisualStyleBackColor = true;
      this.btnIntercambiarDerecha.Click += new System.EventHandler(this.btnIntercambiarDerecha_Click);
      // 
      // btnIntercambiarIzquierda
      // 
      this.btnIntercambiarIzquierda.Location = new System.Drawing.Point(180, 274);
      this.btnIntercambiarIzquierda.Margin = new System.Windows.Forms.Padding(2);
      this.btnIntercambiarIzquierda.Name = "btnIntercambiarIzquierda";
      this.btnIntercambiarIzquierda.Size = new System.Drawing.Size(153, 28);
      this.btnIntercambiarIzquierda.TabIndex = 8;
      this.btnIntercambiarIzquierda.Text = "Intercambiar Izquierda";
      this.btnIntercambiarIzquierda.UseVisualStyleBackColor = true;
      this.btnIntercambiarIzquierda.Click += new System.EventHandler(this.btnIntercambiarIzquierda_Click);
      // 
      // btnQuitarSeleccionado
      // 
      this.btnQuitarSeleccionado.Location = new System.Drawing.Point(180, 144);
      this.btnQuitarSeleccionado.Margin = new System.Windows.Forms.Padding(2);
      this.btnQuitarSeleccionado.Name = "btnQuitarSeleccionado";
      this.btnQuitarSeleccionado.Size = new System.Drawing.Size(153, 28);
      this.btnQuitarSeleccionado.TabIndex = 9;
      this.btnQuitarSeleccionado.Text = "Quitar seleccionado";
      this.btnQuitarSeleccionado.UseVisualStyleBackColor = true;
      this.btnQuitarSeleccionado.Click += new System.EventHandler(this.btnQuitarSeleccionado_Click);
      // 
      // btnIntercambiar
      // 
      this.btnIntercambiar.Location = new System.Drawing.Point(180, 306);
      this.btnIntercambiar.Margin = new System.Windows.Forms.Padding(2);
      this.btnIntercambiar.Name = "btnIntercambiar";
      this.btnIntercambiar.Size = new System.Drawing.Size(153, 28);
      this.btnIntercambiar.TabIndex = 10;
      this.btnIntercambiar.Text = "Intercambiar";
      this.btnIntercambiar.UseVisualStyleBackColor = true;
      this.btnIntercambiar.Click += new System.EventHandler(this.btnIntercambiar_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(358, 341);
      this.Controls.Add(this.btnIntercambiar);
      this.Controls.Add(this.btnQuitarSeleccionado);
      this.Controls.Add(this.btnIntercambiarIzquierda);
      this.Controls.Add(this.btnIntercambiarDerecha);
      this.Controls.Add(this.btnQuitarUltimo);
      this.Controls.Add(this.btnQuitarPrimero);
      this.Controls.Add(this.cmdAgregarAlFinal);
      this.Controls.Add(this.cmdAgregarAlPrincipio);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.listaNodos);
      this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.Button btnIntercambiarDerecha;
        private System.Windows.Forms.Button btnIntercambiarIzquierda;
        private System.Windows.Forms.Button btnQuitarSeleccionado;
    private System.Windows.Forms.Button btnIntercambiar;
  }
}

