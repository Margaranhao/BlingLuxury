namespace BlingLuxury.Vistas
{
    partial class frmPrecios
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
            this.lblAdquisicion = new System.Windows.Forms.Label();
            this.lblMayoreo = new System.Windows.Forms.Label();
            this.lblUnitario = new System.Windows.Forms.Label();
            this.txtAdquisicion = new System.Windows.Forms.TextBox();
            this.txtMayoreo = new System.Windows.Forms.TextBox();
            this.txtUnitario = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAdquisicion
            // 
            this.lblAdquisicion.AutoSize = true;
            this.lblAdquisicion.Location = new System.Drawing.Point(13, 30);
            this.lblAdquisicion.Name = "lblAdquisicion";
            this.lblAdquisicion.Size = new System.Drawing.Size(64, 13);
            this.lblAdquisicion.TabIndex = 0;
            this.lblAdquisicion.Text = "Adquisición:";
            // 
            // lblMayoreo
            // 
            this.lblMayoreo.AutoSize = true;
            this.lblMayoreo.Location = new System.Drawing.Point(101, 30);
            this.lblMayoreo.Name = "lblMayoreo";
            this.lblMayoreo.Size = new System.Drawing.Size(51, 13);
            this.lblMayoreo.TabIndex = 1;
            this.lblMayoreo.Text = "Mayoreo:";
            // 
            // lblUnitario
            // 
            this.lblUnitario.AutoSize = true;
            this.lblUnitario.Location = new System.Drawing.Point(186, 30);
            this.lblUnitario.Name = "lblUnitario";
            this.lblUnitario.Size = new System.Drawing.Size(46, 13);
            this.lblUnitario.TabIndex = 2;
            this.lblUnitario.Text = "Unitario:";
            // 
            // txtAdquisicion
            // 
            this.txtAdquisicion.Location = new System.Drawing.Point(12, 52);
            this.txtAdquisicion.Name = "txtAdquisicion";
            this.txtAdquisicion.Size = new System.Drawing.Size(64, 20);
            this.txtAdquisicion.TabIndex = 3;
            // 
            // txtMayoreo
            // 
            this.txtMayoreo.Location = new System.Drawing.Point(94, 52);
            this.txtMayoreo.Name = "txtMayoreo";
            this.txtMayoreo.Size = new System.Drawing.Size(64, 20);
            this.txtMayoreo.TabIndex = 4;
            // 
            // txtUnitario
            // 
            this.txtUnitario.Location = new System.Drawing.Point(176, 52);
            this.txtUnitario.Name = "txtUnitario";
            this.txtUnitario.Size = new System.Drawing.Size(64, 20);
            this.txtUnitario.TabIndex = 5;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(26, 121);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(146, 121);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // frmPrecios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 185);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtUnitario);
            this.Controls.Add(this.txtMayoreo);
            this.Controls.Add(this.txtAdquisicion);
            this.Controls.Add(this.lblUnitario);
            this.Controls.Add(this.lblMayoreo);
            this.Controls.Add(this.lblAdquisicion);
            this.Name = "frmPrecios";
            this.Text = "frmPrecios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdquisicion;
        private System.Windows.Forms.Label lblMayoreo;
        private System.Windows.Forms.Label lblUnitario;
        private System.Windows.Forms.TextBox txtAdquisicion;
        private System.Windows.Forms.TextBox txtMayoreo;
        private System.Windows.Forms.TextBox txtUnitario;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
    }
}