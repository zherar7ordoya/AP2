namespace Formulario
{
    partial class frmCalculadora
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
            this.txtOp1 = new System.Windows.Forms.TextBox();
            this.txtOp2 = new System.Windows.Forms.TextBox();
            this.txtRta = new System.Windows.Forms.TextBox();
            this.lblOp1 = new System.Windows.Forms.Label();
            this.lblOp2 = new System.Windows.Forms.Label();
            this.lblRta = new System.Windows.Forms.Label();
            this.btnSuma = new System.Windows.Forms.Button();
            this.btnResta = new System.Windows.Forms.Button();
            this.btnCoc = new System.Windows.Forms.Button();
            this.btnProd = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtOp1
            // 
            this.txtOp1.Location = new System.Drawing.Point(85, 6);
            this.txtOp1.Name = "txtOp1";
            this.txtOp1.Size = new System.Drawing.Size(100, 20);
            this.txtOp1.TabIndex = 0;
            // 
            // txtOp2
            // 
            this.txtOp2.Location = new System.Drawing.Point(85, 32);
            this.txtOp2.Name = "txtOp2";
            this.txtOp2.Size = new System.Drawing.Size(100, 20);
            this.txtOp2.TabIndex = 1;
            // 
            // txtRta
            // 
            this.txtRta.Location = new System.Drawing.Point(85, 58);
            this.txtRta.Name = "txtRta";
            this.txtRta.Size = new System.Drawing.Size(100, 20);
            this.txtRta.TabIndex = 2;
            // 
            // lblOp1
            // 
            this.lblOp1.AutoSize = true;
            this.lblOp1.Location = new System.Drawing.Point(12, 9);
            this.lblOp1.Name = "lblOp1";
            this.lblOp1.Size = new System.Drawing.Size(67, 13);
            this.lblOp1.TabIndex = 3;
            this.lblOp1.Text = "1er operador";
            // 
            // lblOp2
            // 
            this.lblOp2.AutoSize = true;
            this.lblOp2.Location = new System.Drawing.Point(9, 35);
            this.lblOp2.Name = "lblOp2";
            this.lblOp2.Size = new System.Drawing.Size(70, 13);
            this.lblOp2.TabIndex = 4;
            this.lblOp2.Text = "2do operador";
            // 
            // lblRta
            // 
            this.lblRta.AutoSize = true;
            this.lblRta.Location = new System.Drawing.Point(12, 61);
            this.lblRta.Name = "lblRta";
            this.lblRta.Size = new System.Drawing.Size(55, 13);
            this.lblRta.TabIndex = 5;
            this.lblRta.Text = "Resultado";
            // 
            // btnSuma
            // 
            this.btnSuma.Location = new System.Drawing.Point(191, 4);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(75, 23);
            this.btnSuma.TabIndex = 6;
            this.btnSuma.Text = "Suma";
            this.btnSuma.UseVisualStyleBackColor = true;
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
            // 
            // btnResta
            // 
            this.btnResta.Location = new System.Drawing.Point(191, 30);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(75, 23);
            this.btnResta.TabIndex = 7;
            this.btnResta.Text = "Resta";
            this.btnResta.UseVisualStyleBackColor = true;
            this.btnResta.Click += new System.EventHandler(this.btnResta_Click);
            // 
            // btnCoc
            // 
            this.btnCoc.Location = new System.Drawing.Point(191, 56);
            this.btnCoc.Name = "btnCoc";
            this.btnCoc.Size = new System.Drawing.Size(75, 23);
            this.btnCoc.TabIndex = 8;
            this.btnCoc.Text = "Cociente";
            this.btnCoc.UseVisualStyleBackColor = true;
            this.btnCoc.Click += new System.EventHandler(this.btnCoc_Click);
            // 
            // btnProd
            // 
            this.btnProd.Location = new System.Drawing.Point(190, 82);
            this.btnProd.Name = "btnProd";
            this.btnProd.Size = new System.Drawing.Size(75, 23);
            this.btnProd.TabIndex = 9;
            this.btnProd.Text = "Producto";
            this.btnProd.UseVisualStyleBackColor = true;
            this.btnProd.Click += new System.EventHandler(this.btnProd_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(15, 82);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(109, 82);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 11;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // frmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 113);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnProd);
            this.Controls.Add(this.btnCoc);
            this.Controls.Add(this.btnResta);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.lblRta);
            this.Controls.Add(this.lblOp2);
            this.Controls.Add(this.lblOp1);
            this.Controls.Add(this.txtRta);
            this.Controls.Add(this.txtOp2);
            this.Controls.Add(this.txtOp1);
            this.Name = "frmCalculadora";
            this.Text = "Calculadora Simple";
            this.Load += new System.EventHandler(this.frmCalculadora_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOp1;
        private System.Windows.Forms.TextBox txtOp2;
        private System.Windows.Forms.TextBox txtRta;
        private System.Windows.Forms.Label lblOp1;
        private System.Windows.Forms.Label lblOp2;
        private System.Windows.Forms.Label lblRta;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.Button btnResta;
        private System.Windows.Forms.Button btnCoc;
        private System.Windows.Forms.Button btnProd;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnLimpiar;
    }
}

