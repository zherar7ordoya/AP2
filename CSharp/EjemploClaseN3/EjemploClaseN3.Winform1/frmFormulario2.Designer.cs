namespace EjemploClaseN3.Winform1
{
    partial class frmFormulario2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdRojo = new System.Windows.Forms.RadioButton();
            this.rdAzul = new System.Windows.Forms.RadioButton();
            this.rdVerde = new System.Windows.Forms.RadioButton();
            this.btnVerSeleccionado = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.cboListaColor = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnVerSeleccionado);
            this.groupBox1.Controls.Add(this.rdVerde);
            this.groupBox1.Controls.Add(this.rdAzul);
            this.groupBox1.Controls.Add(this.rdRojo);
            this.groupBox1.Location = new System.Drawing.Point(101, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(209, 216);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione color";
            // 
            // rdRojo
            // 
            this.rdRojo.AutoSize = true;
            this.rdRojo.Location = new System.Drawing.Point(55, 52);
            this.rdRojo.Name = "rdRojo";
            this.rdRojo.Size = new System.Drawing.Size(58, 21);
            this.rdRojo.TabIndex = 0;
            this.rdRojo.Text = "Rojo";
            this.rdRojo.UseVisualStyleBackColor = true;
            // 
            // rdAzul
            // 
            this.rdAzul.AutoSize = true;
            this.rdAzul.Checked = true;
            this.rdAzul.Location = new System.Drawing.Point(55, 80);
            this.rdAzul.Name = "rdAzul";
            this.rdAzul.Size = new System.Drawing.Size(56, 21);
            this.rdAzul.TabIndex = 1;
            this.rdAzul.TabStop = true;
            this.rdAzul.Text = "Azul";
            this.rdAzul.UseVisualStyleBackColor = true;
            // 
            // rdVerde
            // 
            this.rdVerde.AutoSize = true;
            this.rdVerde.Location = new System.Drawing.Point(55, 108);
            this.rdVerde.Name = "rdVerde";
            this.rdVerde.Size = new System.Drawing.Size(67, 21);
            this.rdVerde.TabIndex = 2;
            this.rdVerde.Text = "Verde";
            this.rdVerde.UseVisualStyleBackColor = true;
            // 
            // btnVerSeleccionado
            // 
            this.btnVerSeleccionado.Location = new System.Drawing.Point(29, 158);
            this.btnVerSeleccionado.Name = "btnVerSeleccionado";
            this.btnVerSeleccionado.Size = new System.Drawing.Size(142, 38);
            this.btnVerSeleccionado.TabIndex = 3;
            this.btnVerSeleccionado.Text = "Ver seleccionado";
            this.btnVerSeleccionado.UseVisualStyleBackColor = true;
            this.btnVerSeleccionado.Click += new System.EventHandler(this.btnVerSeleccionado_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(130, 312);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(98, 21);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(130, 340);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(98, 21);
            this.checkBox2.TabIndex = 2;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(130, 368);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(98, 21);
            this.checkBox3.TabIndex = 3;
            this.checkBox3.Text = "checkBox3";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // cboListaColor
            // 
            this.cboListaColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboListaColor.FormattingEnabled = true;
            this.cboListaColor.Items.AddRange(new object[] {
            "Azul",
            "Rojo",
            "Verde",
            "Amarillo"});
            this.cboListaColor.Location = new System.Drawing.Point(397, 82);
            this.cboListaColor.Name = "cboListaColor";
            this.cboListaColor.Size = new System.Drawing.Size(297, 24);
            this.cboListaColor.TabIndex = 4;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "item 1",
            "item 2",
            "item 3",
            "item 4",
            "item 5"});
            this.listBox1.Location = new System.Drawing.Point(397, 148);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox1.Size = new System.Drawing.Size(297, 244);
            this.listBox1.TabIndex = 5;
            // 
            // frmFormulario2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.cboListaColor);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmFormulario2";
            this.Text = "Formulario 2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdVerde;
        private System.Windows.Forms.RadioButton rdAzul;
        private System.Windows.Forms.RadioButton rdRojo;
        private System.Windows.Forms.Button btnVerSeleccionado;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.ComboBox cboListaColor;
        private System.Windows.Forms.ListBox listBox1;
    }
}