
namespace Parcial2
{
    partial class Parcial2
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
            this.grillaAntes = new System.Windows.Forms.DataGridView();
            this.grillaDespues = new System.Windows.Forms.DataGridView();
            this.lblAntes = new System.Windows.Forms.Label();
            this.lblDespues = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grillaAntes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaDespues)).BeginInit();
            this.SuspendLayout();
            // 
            // grillaAntes
            // 
            this.grillaAntes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaAntes.Location = new System.Drawing.Point(12, 25);
            this.grillaAntes.Name = "grillaAntes";
            this.grillaAntes.Size = new System.Drawing.Size(326, 150);
            this.grillaAntes.TabIndex = 0;
            // 
            // grillaDespues
            // 
            this.grillaDespues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaDespues.Location = new System.Drawing.Point(12, 232);
            this.grillaDespues.Name = "grillaDespues";
            this.grillaDespues.Size = new System.Drawing.Size(326, 150);
            this.grillaDespues.TabIndex = 1;
            // 
            // lblAntes
            // 
            this.lblAntes.AutoSize = true;
            this.lblAntes.Location = new System.Drawing.Point(12, 9);
            this.lblAntes.Name = "lblAntes";
            this.lblAntes.Size = new System.Drawing.Size(326, 13);
            this.lblAntes.TabIndex = 2;
            this.lblAntes.Text = "Promedio de hora de ingreso de cada empleado antes del mediodía";
            // 
            // lblDespues
            // 
            this.lblDespues.AutoSize = true;
            this.lblDespues.Location = new System.Drawing.Point(12, 216);
            this.lblDespues.Name = "lblDespues";
            this.lblDespues.Size = new System.Drawing.Size(273, 13);
            this.lblDespues.TabIndex = 3;
            this.lblDespues.Text = "Listado de personas que ingresan después del mediodía";
            // 
            // Parcial2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 400);
            this.Controls.Add(this.lblDespues);
            this.Controls.Add(this.lblAntes);
            this.Controls.Add(this.grillaDespues);
            this.Controls.Add(this.grillaAntes);
            this.Name = "Parcial2";
            this.Text = "Parcial 2";
            ((System.ComponentModel.ISupportInitialize)(this.grillaAntes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaDespues)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grillaAntes;
        private System.Windows.Forms.DataGridView grillaDespues;
        private System.Windows.Forms.Label lblAntes;
        private System.Windows.Forms.Label lblDespues;
    }
}

