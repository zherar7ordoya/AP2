
namespace EjemploIDE
{
    partial class FormularioInicial
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Button");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Checkbox");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Label");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Root", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioInicial));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DireccionUsuario = new System.Windows.Forms.TextBox();
            this.NombreUsuario = new System.Windows.Forms.TextBox();
            this.Paises = new System.Windows.Forms.ListBox();
            this.UsuarioHombre = new System.Windows.Forms.RadioButton();
            this.UsuarioMujer = new System.Windows.Forms.RadioButton();
            this.LenguajeC = new System.Windows.Forms.CheckBox();
            this.LenguajeCSharp = new System.Windows.Forms.CheckBox();
            this.Enviar = new System.Windows.Forms.Button();
            this.Componentes = new System.Windows.Forms.TreeView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.DireccionUsuario);
            this.groupBox1.Controls.Add(this.NombreUsuario);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 113);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalles de usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dirección";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // DireccionUsuario
            // 
            this.DireccionUsuario.Location = new System.Drawing.Point(96, 71);
            this.DireccionUsuario.Name = "DireccionUsuario";
            this.DireccionUsuario.Size = new System.Drawing.Size(100, 23);
            this.DireccionUsuario.TabIndex = 1;
            // 
            // NombreUsuario
            // 
            this.NombreUsuario.Location = new System.Drawing.Point(96, 28);
            this.NombreUsuario.Name = "NombreUsuario";
            this.NombreUsuario.Size = new System.Drawing.Size(100, 23);
            this.NombreUsuario.TabIndex = 0;
            // 
            // Paises
            // 
            this.Paises.FormattingEnabled = true;
            this.Paises.ItemHeight = 15;
            this.Paises.Items.AddRange(new object[] {
            "Argentina",
            "Brasil",
            "México"});
            this.Paises.Location = new System.Drawing.Point(12, 156);
            this.Paises.Name = "Paises";
            this.Paises.Size = new System.Drawing.Size(218, 109);
            this.Paises.TabIndex = 1;
            this.Paises.SelectedIndexChanged += new System.EventHandler(this.Paises_SelectedIndexChanged);
            // 
            // UsuarioHombre
            // 
            this.UsuarioHombre.AutoSize = true;
            this.UsuarioHombre.Location = new System.Drawing.Point(311, 43);
            this.UsuarioHombre.Name = "UsuarioHombre";
            this.UsuarioHombre.Size = new System.Drawing.Size(69, 19);
            this.UsuarioHombre.TabIndex = 2;
            this.UsuarioHombre.TabStop = true;
            this.UsuarioHombre.Text = "Hombre";
            this.UsuarioHombre.UseVisualStyleBackColor = true;
            // 
            // UsuarioMujer
            // 
            this.UsuarioMujer.AutoSize = true;
            this.UsuarioMujer.Location = new System.Drawing.Point(311, 82);
            this.UsuarioMujer.Name = "UsuarioMujer";
            this.UsuarioMujer.Size = new System.Drawing.Size(56, 19);
            this.UsuarioMujer.TabIndex = 3;
            this.UsuarioMujer.TabStop = true;
            this.UsuarioMujer.Text = "Mujer";
            this.UsuarioMujer.UseVisualStyleBackColor = true;
            // 
            // LenguajeC
            // 
            this.LenguajeC.AutoSize = true;
            this.LenguajeC.Location = new System.Drawing.Point(311, 173);
            this.LenguajeC.Name = "LenguajeC";
            this.LenguajeC.Size = new System.Drawing.Size(34, 19);
            this.LenguajeC.TabIndex = 4;
            this.LenguajeC.Text = "C";
            this.LenguajeC.UseVisualStyleBackColor = true;
            // 
            // LenguajeCSharp
            // 
            this.LenguajeCSharp.AutoSize = true;
            this.LenguajeCSharp.Location = new System.Drawing.Point(311, 215);
            this.LenguajeCSharp.Name = "LenguajeCSharp";
            this.LenguajeCSharp.Size = new System.Drawing.Size(41, 19);
            this.LenguajeCSharp.TabIndex = 5;
            this.LenguajeCSharp.Text = "C#";
            this.LenguajeCSharp.UseVisualStyleBackColor = true;
            // 
            // Enviar
            // 
            this.Enviar.Location = new System.Drawing.Point(154, 323);
            this.Enviar.Name = "Enviar";
            this.Enviar.Size = new System.Drawing.Size(143, 23);
            this.Enviar.TabIndex = 6;
            this.Enviar.Text = "Enviar";
            this.Enviar.UseVisualStyleBackColor = true;
            this.Enviar.Click += new System.EventHandler(this.Enviar_Click);
            // 
            // Componentes
            // 
            this.Componentes.Location = new System.Drawing.Point(468, 40);
            this.Componentes.Name = "Componentes";
            treeNode1.Name = "Node1";
            treeNode1.Text = "Button";
            treeNode2.Name = "Node2";
            treeNode2.Text = "Checkbox";
            treeNode3.Name = "Node3";
            treeNode3.Text = "Label";
            treeNode4.Name = "Node0";
            treeNode4.Text = "Root";
            this.Componentes.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4});
            this.Componentes.Size = new System.Drawing.Size(173, 194);
            this.Componentes.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(349, 269);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(292, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // FormularioInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 361);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Componentes);
            this.Controls.Add(this.Enviar);
            this.Controls.Add(this.LenguajeCSharp);
            this.Controls.Add(this.LenguajeC);
            this.Controls.Add(this.UsuarioMujer);
            this.Controls.Add(this.UsuarioHombre);
            this.Controls.Add(this.Paises);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormularioInicial";
            this.Text = "Bienvenida";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DireccionUsuario;
        private System.Windows.Forms.TextBox NombreUsuario;
        private System.Windows.Forms.ListBox Paises;
        private System.Windows.Forms.RadioButton UsuarioHombre;
        private System.Windows.Forms.RadioButton UsuarioMujer;
        private System.Windows.Forms.CheckBox LenguajeC;
        private System.Windows.Forms.CheckBox LenguajeCSharp;
        private System.Windows.Forms.Button Enviar;
        private System.Windows.Forms.TreeView Componentes;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

