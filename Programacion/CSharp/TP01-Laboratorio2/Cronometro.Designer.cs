namespace TP01_Laboratorio2 {
  partial class frmCronometro {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.components = new System.ComponentModel.Container();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.btnComenzar = new System.Windows.Forms.Button();
      this.btnParar = new System.Windows.Forms.Button();
      this.btnIniciar = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // timer1
      // 
      this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
      // 
      // btnComenzar
      // 
      this.btnComenzar.Location = new System.Drawing.Point(12, 75);
      this.btnComenzar.Name = "btnComenzar";
      this.btnComenzar.Size = new System.Drawing.Size(75, 23);
      this.btnComenzar.TabIndex = 0;
      this.btnComenzar.Text = "Comenzar";
      this.btnComenzar.UseVisualStyleBackColor = true;
      this.btnComenzar.Click += new System.EventHandler(this.btnComenzar_Click);
      // 
      // btnParar
      // 
      this.btnParar.Location = new System.Drawing.Point(93, 75);
      this.btnParar.Name = "btnParar";
      this.btnParar.Size = new System.Drawing.Size(75, 23);
      this.btnParar.TabIndex = 1;
      this.btnParar.Text = "Parar";
      this.btnParar.UseVisualStyleBackColor = true;
      this.btnParar.Click += new System.EventHandler(this.btnParar_Click);
      // 
      // btnIniciar
      // 
      this.btnIniciar.Location = new System.Drawing.Point(174, 75);
      this.btnIniciar.Name = "btnIniciar";
      this.btnIniciar.Size = new System.Drawing.Size(75, 23);
      this.btnIniciar.TabIndex = 2;
      this.btnIniciar.Text = "Inicializar";
      this.btnIniciar.UseVisualStyleBackColor = true;
      this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(12, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(245, 63);
      this.label1.TabIndex = 3;
      this.label1.Text = "00:00:00";
      // 
      // frmCronometro
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(263, 112);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.btnIniciar);
      this.Controls.Add(this.btnParar);
      this.Controls.Add(this.btnComenzar);
      this.Name = "frmCronometro";
      this.Text = "Cronómetro";
      this.Load += new System.EventHandler(this.frmCronometro_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Timer timer1;
    private System.Windows.Forms.Button btnComenzar;
    private System.Windows.Forms.Button btnParar;
    private System.Windows.Forms.Button btnIniciar;
    private System.Windows.Forms.Label label1;
  }
}