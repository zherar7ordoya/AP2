namespace DataGridView {
  partial class frmPrincipal {
    /// <summary>
    /// Variable del diseñador necesaria.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Limpiar los recursos que se estén usando.
    /// </summary>
    /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Código generado por el Diseñador de Windows Forms

    /// <summary>
    /// Método necesario para admitir el Diseñador. No se puede modificar
    /// el contenido de este método con el editor de código.
    /// </summary>
    private void InitializeComponent() {
      this.dtgvProductos = new System.Windows.Forms.DataGridView();
      this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.lblCodigo = new System.Windows.Forms.Label();
      this.txtCodigo = new System.Windows.Forms.TextBox();
      this.txtNombre = new System.Windows.Forms.TextBox();
      this.lblNombre = new System.Windows.Forms.Label();
      this.txtPrecio = new System.Windows.Forms.TextBox();
      this.lblPrecio = new System.Windows.Forms.Label();
      this.btnAgregar = new System.Windows.Forms.Button();
      this.btnEliminar = new System.Windows.Forms.Button();
      this.lblInformacion = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.dtgvProductos)).BeginInit();
      this.SuspendLayout();
      // 
      // dtgvProductos
      // 
      this.dtgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dtgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Precio});
      this.dtgvProductos.Location = new System.Drawing.Point(15, 87);
      this.dtgvProductos.Name = "dtgvProductos";
      this.dtgvProductos.Size = new System.Drawing.Size(344, 278);
      this.dtgvProductos.TabIndex = 0;
      this.dtgvProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvProductos_CellClick);
      // 
      // Codigo
      // 
      this.Codigo.HeaderText = "Código del Producto";
      this.Codigo.Name = "Codigo";
      // 
      // Nombre
      // 
      this.Nombre.HeaderText = "Nombre del Producto";
      this.Nombre.Name = "Nombre";
      // 
      // Precio
      // 
      this.Precio.HeaderText = "Precio del Producto";
      this.Precio.Name = "Precio";
      // 
      // lblCodigo
      // 
      this.lblCodigo.AutoSize = true;
      this.lblCodigo.Location = new System.Drawing.Point(12, 9);
      this.lblCodigo.Name = "lblCodigo";
      this.lblCodigo.Size = new System.Drawing.Size(103, 13);
      this.lblCodigo.TabIndex = 1;
      this.lblCodigo.Text = "Código del Producto";
      // 
      // txtCodigo
      // 
      this.txtCodigo.Location = new System.Drawing.Point(121, 6);
      this.txtCodigo.Name = "txtCodigo";
      this.txtCodigo.Size = new System.Drawing.Size(100, 20);
      this.txtCodigo.TabIndex = 2;
      // 
      // txtNombre
      // 
      this.txtNombre.Location = new System.Drawing.Point(121, 32);
      this.txtNombre.Name = "txtNombre";
      this.txtNombre.Size = new System.Drawing.Size(100, 20);
      this.txtNombre.TabIndex = 4;
      // 
      // lblNombre
      // 
      this.lblNombre.AutoSize = true;
      this.lblNombre.Location = new System.Drawing.Point(12, 35);
      this.lblNombre.Name = "lblNombre";
      this.lblNombre.Size = new System.Drawing.Size(107, 13);
      this.lblNombre.TabIndex = 3;
      this.lblNombre.Text = "Nombre del Producto";
      // 
      // txtPrecio
      // 
      this.txtPrecio.Location = new System.Drawing.Point(121, 58);
      this.txtPrecio.Name = "txtPrecio";
      this.txtPrecio.Size = new System.Drawing.Size(100, 20);
      this.txtPrecio.TabIndex = 6;
      // 
      // lblPrecio
      // 
      this.lblPrecio.AutoSize = true;
      this.lblPrecio.Location = new System.Drawing.Point(12, 61);
      this.lblPrecio.Name = "lblPrecio";
      this.lblPrecio.Size = new System.Drawing.Size(100, 13);
      this.lblPrecio.TabIndex = 5;
      this.lblPrecio.Text = "Precio del Producto";
      // 
      // btnAgregar
      // 
      this.btnAgregar.Location = new System.Drawing.Point(284, 29);
      this.btnAgregar.Name = "btnAgregar";
      this.btnAgregar.Size = new System.Drawing.Size(75, 23);
      this.btnAgregar.TabIndex = 7;
      this.btnAgregar.Text = "Agregar";
      this.btnAgregar.UseVisualStyleBackColor = true;
      this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
      // 
      // btnEliminar
      // 
      this.btnEliminar.Location = new System.Drawing.Point(284, 58);
      this.btnEliminar.Name = "btnEliminar";
      this.btnEliminar.Size = new System.Drawing.Size(75, 23);
      this.btnEliminar.TabIndex = 8;
      this.btnEliminar.Text = "Eliminar";
      this.btnEliminar.UseVisualStyleBackColor = true;
      this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
      // 
      // lblInformacion
      // 
      this.lblInformacion.AutoSize = true;
      this.lblInformacion.Location = new System.Drawing.Point(297, 9);
      this.lblInformacion.Name = "lblInformacion";
      this.lblInformacion.Size = new System.Drawing.Size(62, 13);
      this.lblInformacion.TabIndex = 9;
      this.lblInformacion.Text = "Información";
      // 
      // frmPrincipal
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(375, 380);
      this.Controls.Add(this.lblInformacion);
      this.Controls.Add(this.btnEliminar);
      this.Controls.Add(this.btnAgregar);
      this.Controls.Add(this.txtPrecio);
      this.Controls.Add(this.lblPrecio);
      this.Controls.Add(this.txtNombre);
      this.Controls.Add(this.lblNombre);
      this.Controls.Add(this.txtCodigo);
      this.Controls.Add(this.lblCodigo);
      this.Controls.Add(this.dtgvProductos);
      this.Name = "frmPrincipal";
      this.Text = "Tutorial DataGridView (dtgv)";
      ((System.ComponentModel.ISupportInitialize)(this.dtgvProductos)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.DataGridView dtgvProductos;
    private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
    private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
    private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
    private System.Windows.Forms.Label lblCodigo;
    private System.Windows.Forms.TextBox txtCodigo;
    private System.Windows.Forms.TextBox txtNombre;
    private System.Windows.Forms.Label lblNombre;
    private System.Windows.Forms.TextBox txtPrecio;
    private System.Windows.Forms.Label lblPrecio;
    private System.Windows.Forms.Button btnAgregar;
    private System.Windows.Forms.Button btnEliminar;
    private System.Windows.Forms.Label lblInformacion;
  }
}

