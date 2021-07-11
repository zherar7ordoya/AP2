
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
            this.lblAntes = new System.Windows.Forms.Label();
            this.lblDespues = new System.Windows.Forms.Label();
            this.grillaDespues = new System.Windows.Forms.ListView();
            this.grillaAntes = new System.Windows.Forms.ListView();
            this.SuspendLayout();
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
            this.lblDespues.Location = new System.Drawing.Point(427, 9);
            this.lblDespues.Name = "lblDespues";
            this.lblDespues.Size = new System.Drawing.Size(273, 13);
            this.lblDespues.TabIndex = 3;
            this.lblDespues.Text = "Listado de personas que ingresan después del mediodía";
            // 
            // grillaDespues
            // 
            this.grillaDespues.HideSelection = false;
            this.grillaDespues.Location = new System.Drawing.Point(430, 25);
            this.grillaDespues.Name = "grillaDespues";
            this.grillaDespues.Size = new System.Drawing.Size(370, 200);
            this.grillaDespues.TabIndex = 4;
            this.grillaDespues.UseCompatibleStateImageBehavior = false;
            // 
            // grillaAntes
            // 
            this.grillaAntes.HideSelection = false;
            this.grillaAntes.Location = new System.Drawing.Point(15, 25);
            this.grillaAntes.Name = "grillaAntes";
            this.grillaAntes.Size = new System.Drawing.Size(370, 200);
            this.grillaAntes.TabIndex = 5;
            this.grillaAntes.UseCompatibleStateImageBehavior = false;
            // 
            // Parcial2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 237);
            this.Controls.Add(this.grillaAntes);
            this.Controls.Add(this.grillaDespues);
            this.Controls.Add(this.lblDespues);
            this.Controls.Add(this.lblAntes);
            this.Name = "Parcial2";
            this.Text = "Parcial 2";
            this.Load += new System.EventHandler(this.Parcial2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblAntes;
        private System.Windows.Forms.Label lblDespues;
        private System.Windows.Forms.ListView grillaDespues;
        private System.Windows.Forms.ListView grillaAntes;
    }
}

