namespace BlingLuxury.Vistas
{
    partial class frmLocalidad
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
            this.txtLocalidad = new System.Windows.Forms.TextBox();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.lblMunicipio = new System.Windows.Forms.Label();
            this.txtMunicipioId = new System.Windows.Forms.TextBox();
            this.lblTipoLocalidad = new System.Windows.Forms.Label();
            this.lblCodigoPostalId = new System.Windows.Forms.Label();
            this.txtCodigoPostal = new System.Windows.Forms.TextBox();
            this.dgvLocalidades = new System.Windows.Forms.DataGridView();
            this.btnMuCancelar = new System.Windows.Forms.Button();
            this.btnMuAgregar = new System.Windows.Forms.Button();
            this.cbxTipoLocalidad = new System.Windows.Forms.ComboBox();
            this.txtId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalidades)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLocalidad
            // 
            this.txtLocalidad.Location = new System.Drawing.Point(26, 45);
            this.txtLocalidad.Name = "txtLocalidad";
            this.txtLocalidad.Size = new System.Drawing.Size(144, 20);
            this.txtLocalidad.TabIndex = 0;
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Location = new System.Drawing.Point(26, 29);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(56, 13);
            this.lblLocalidad.TabIndex = 1;
            this.lblLocalidad.Text = "Localidad:";
            // 
            // lblMunicipio
            // 
            this.lblMunicipio.AutoSize = true;
            this.lblMunicipio.Location = new System.Drawing.Point(26, 78);
            this.lblMunicipio.Name = "lblMunicipio";
            this.lblMunicipio.Size = new System.Drawing.Size(67, 13);
            this.lblMunicipio.TabIndex = 3;
            this.lblMunicipio.Text = "Municipio Id:";
            // 
            // txtMunicipioId
            // 
            this.txtMunicipioId.Location = new System.Drawing.Point(26, 94);
            this.txtMunicipioId.Name = "txtMunicipioId";
            this.txtMunicipioId.Size = new System.Drawing.Size(144, 20);
            this.txtMunicipioId.TabIndex = 2;
            // 
            // lblTipoLocalidad
            // 
            this.lblTipoLocalidad.AutoSize = true;
            this.lblTipoLocalidad.Location = new System.Drawing.Point(26, 129);
            this.lblTipoLocalidad.Name = "lblTipoLocalidad";
            this.lblTipoLocalidad.Size = new System.Drawing.Size(80, 13);
            this.lblTipoLocalidad.TabIndex = 5;
            this.lblTipoLocalidad.Text = "Tipo Localidad:";
            // 
            // lblCodigoPostalId
            // 
            this.lblCodigoPostalId.AutoSize = true;
            this.lblCodigoPostalId.Location = new System.Drawing.Point(26, 172);
            this.lblCodigoPostalId.Name = "lblCodigoPostalId";
            this.lblCodigoPostalId.Size = new System.Drawing.Size(39, 13);
            this.lblCodigoPostalId.TabIndex = 7;
            this.lblCodigoPostalId.Text = "C.P Id:";
            // 
            // txtCodigoPostal
            // 
            this.txtCodigoPostal.Location = new System.Drawing.Point(26, 188);
            this.txtCodigoPostal.Name = "txtCodigoPostal";
            this.txtCodigoPostal.Size = new System.Drawing.Size(144, 20);
            this.txtCodigoPostal.TabIndex = 6;
            // 
            // dgvLocalidades
            // 
            this.dgvLocalidades.AllowUserToAddRows = false;
            this.dgvLocalidades.AllowUserToDeleteRows = false;
            this.dgvLocalidades.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgvLocalidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocalidades.Location = new System.Drawing.Point(191, 37);
            this.dgvLocalidades.Name = "dgvLocalidades";
            this.dgvLocalidades.ReadOnly = true;
            this.dgvLocalidades.Size = new System.Drawing.Size(347, 171);
            this.dgvLocalidades.TabIndex = 22;
            // 
            // btnMuCancelar
            // 
            this.btnMuCancelar.Location = new System.Drawing.Point(425, 230);
            this.btnMuCancelar.Name = "btnMuCancelar";
            this.btnMuCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnMuCancelar.TabIndex = 24;
            this.btnMuCancelar.Text = "Cancelar";
            this.btnMuCancelar.UseVisualStyleBackColor = true;
            // 
            // btnMuAgregar
            // 
            this.btnMuAgregar.Location = new System.Drawing.Point(230, 230);
            this.btnMuAgregar.Name = "btnMuAgregar";
            this.btnMuAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnMuAgregar.TabIndex = 23;
            this.btnMuAgregar.Text = "Agregar";
            this.btnMuAgregar.UseVisualStyleBackColor = true;
            this.btnMuAgregar.Click += new System.EventHandler(this.btnMuAgregar_Click);
            // 
            // cbxTipoLocalidad
            // 
            this.cbxTipoLocalidad.FormattingEnabled = true;
            this.cbxTipoLocalidad.Location = new System.Drawing.Point(26, 145);
            this.cbxTipoLocalidad.Name = "cbxTipoLocalidad";
            this.cbxTipoLocalidad.Size = new System.Drawing.Size(144, 21);
            this.cbxTipoLocalidad.TabIndex = 25;
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtId.Location = new System.Drawing.Point(26, 230);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(38, 20);
            this.txtId.TabIndex = 26;
            this.txtId.Visible = false;
            // 
            // frmLocalidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 265);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.cbxTipoLocalidad);
            this.Controls.Add(this.btnMuCancelar);
            this.Controls.Add(this.btnMuAgregar);
            this.Controls.Add(this.dgvLocalidades);
            this.Controls.Add(this.lblCodigoPostalId);
            this.Controls.Add(this.txtCodigoPostal);
            this.Controls.Add(this.lblTipoLocalidad);
            this.Controls.Add(this.lblMunicipio);
            this.Controls.Add(this.txtMunicipioId);
            this.Controls.Add(this.lblLocalidad);
            this.Controls.Add(this.txtLocalidad);
            this.Name = "frmLocalidad";
            this.Text = "frmLocalidad";
            this.Load += new System.EventHandler(this.frmLocalidad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalidades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLocalidad;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.Label lblMunicipio;
        private System.Windows.Forms.TextBox txtMunicipioId;
        private System.Windows.Forms.Label lblTipoLocalidad;
        private System.Windows.Forms.Label lblCodigoPostalId;
        private System.Windows.Forms.TextBox txtCodigoPostal;
        private System.Windows.Forms.DataGridView dgvLocalidades;
        private System.Windows.Forms.Button btnMuCancelar;
        private System.Windows.Forms.Button btnMuAgregar;
        private System.Windows.Forms.ComboBox cbxTipoLocalidad;
        private System.Windows.Forms.TextBox txtId;
    }
}