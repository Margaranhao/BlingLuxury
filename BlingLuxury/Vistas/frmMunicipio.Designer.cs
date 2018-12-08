namespace BlingLuxury.Vistas
{
    partial class frmMunicipio
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMunicipio));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnMuCancelar = new System.Windows.Forms.Button();
            this.btnMuAgregar = new System.Windows.Forms.Button();
            this.dgvMunicipios = new System.Windows.Forms.DataGridView();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtMunicipio = new System.Windows.Forms.TextBox();
            this.lblMunicipio = new System.Windows.Forms.Label();
            this.errorMunicipio = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtEstado = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMunicipios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMunicipio)).BeginInit();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtId.Location = new System.Drawing.Point(269, 39);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(38, 20);
            this.txtId.TabIndex = 3;
            this.txtId.Visible = false;
            // 
            // btnMuCancelar
            // 
            this.btnMuCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnMuCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMuCancelar.BackgroundImage")));
            this.btnMuCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMuCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMuCancelar.FlatAppearance.BorderSize = 0;
            this.btnMuCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMuCancelar.Location = new System.Drawing.Point(280, 271);
            this.btnMuCancelar.Name = "btnMuCancelar";
            this.btnMuCancelar.Size = new System.Drawing.Size(102, 32);
            this.btnMuCancelar.TabIndex = 5;
            this.btnMuCancelar.UseVisualStyleBackColor = false;
            this.btnMuCancelar.Click += new System.EventHandler(this.btnMuCancelar_Click);
            // 
            // btnMuAgregar
            // 
            this.btnMuAgregar.BackColor = System.Drawing.Color.Transparent;
            this.btnMuAgregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMuAgregar.BackgroundImage")));
            this.btnMuAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMuAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMuAgregar.FlatAppearance.BorderSize = 0;
            this.btnMuAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMuAgregar.Location = new System.Drawing.Point(143, 271);
            this.btnMuAgregar.Name = "btnMuAgregar";
            this.btnMuAgregar.Size = new System.Drawing.Size(102, 32);
            this.btnMuAgregar.TabIndex = 4;
            this.btnMuAgregar.UseVisualStyleBackColor = false;
            this.btnMuAgregar.Click += new System.EventHandler(this.btnEsAgregar_Click);
            // 
            // dgvMunicipios
            // 
            this.dgvMunicipios.AllowUserToAddRows = false;
            this.dgvMunicipios.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvMunicipios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMunicipios.BackgroundColor = System.Drawing.Color.White;
            this.dgvMunicipios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMunicipios.Location = new System.Drawing.Point(35, 85);
            this.dgvMunicipios.Name = "dgvMunicipios";
            this.dgvMunicipios.ReadOnly = true;
            this.dgvMunicipios.Size = new System.Drawing.Size(347, 171);
            this.dgvMunicipios.TabIndex = 21;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(32, 59);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(55, 13);
            this.lblEstado.TabIndex = 19;
            this.lblEstado.Text = "Estado Id:";
            // 
            // txtMunicipio
            // 
            this.txtMunicipio.Location = new System.Drawing.Point(88, 25);
            this.txtMunicipio.MaxLength = 15;
            this.txtMunicipio.Name = "txtMunicipio";
            this.txtMunicipio.Size = new System.Drawing.Size(157, 20);
            this.txtMunicipio.TabIndex = 1;
            this.txtMunicipio.TextChanged += new System.EventHandler(this.txtMunicipio_TextChanged);
            this.txtMunicipio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMunicipio_KeyPress);
            this.txtMunicipio.Validating += new System.ComponentModel.CancelEventHandler(this.txtMunicipio_Validating);
            // 
            // lblMunicipio
            // 
            this.lblMunicipio.AutoSize = true;
            this.lblMunicipio.Location = new System.Drawing.Point(32, 28);
            this.lblMunicipio.Name = "lblMunicipio";
            this.lblMunicipio.Size = new System.Drawing.Size(55, 13);
            this.lblMunicipio.TabIndex = 25;
            this.lblMunicipio.Text = "Municipio:";
            // 
            // errorMunicipio
            // 
            this.errorMunicipio.ContainerControl = this;
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(88, 56);
            this.txtEstado.MaxLength = 15;
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(157, 20);
            this.txtEstado.TabIndex = 26;
            // 
            // frmMunicipio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(210)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(413, 315);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtMunicipio);
            this.Controls.Add(this.lblMunicipio);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnMuCancelar);
            this.Controls.Add(this.btnMuAgregar);
            this.Controls.Add(this.dgvMunicipios);
            this.Controls.Add(this.lblEstado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMunicipio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMunicipio";
            this.Load += new System.EventHandler(this.frmMunicipio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMunicipios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMunicipio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnMuCancelar;
        private System.Windows.Forms.Button btnMuAgregar;
        private System.Windows.Forms.DataGridView dgvMunicipios;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtMunicipio;
        private System.Windows.Forms.Label lblMunicipio;
        private System.Windows.Forms.ErrorProvider errorMunicipio;
        private System.Windows.Forms.TextBox txtEstado;
    }
}