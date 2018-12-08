namespace BlingLuxury.Vistas
{
    partial class frmCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCategoria));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.btnCAgregar = new System.Windows.Forms.Button();
            this.btnCcancelar = new System.Windows.Forms.Button();
            this.dgvCategorias = new System.Windows.Forms.DataGridView();
            this.txtId = new System.Windows.Forms.TextBox();
            this.errorCategoria = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(12, 19);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(55, 13);
            this.lblCategoria.TabIndex = 1;
            this.lblCategoria.Text = "Categoria:";
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(67, 16);
            this.txtCategoria.MaxLength = 35;
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(138, 20);
            this.txtCategoria.TabIndex = 3;
            this.txtCategoria.TextChanged += new System.EventHandler(this.txtCategoria_TextChanged);
            this.txtCategoria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCategoria_KeyPress);
            this.txtCategoria.Validating += new System.ComponentModel.CancelEventHandler(this.txtCategoria_Validating);
            // 
            // btnCAgregar
            // 
            this.btnCAgregar.BackColor = System.Drawing.Color.Transparent;
            this.btnCAgregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCAgregar.BackgroundImage")));
            this.btnCAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCAgregar.FlatAppearance.BorderSize = 0;
            this.btnCAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCAgregar.Location = new System.Drawing.Point(29, 168);
            this.btnCAgregar.Name = "btnCAgregar";
            this.btnCAgregar.Size = new System.Drawing.Size(95, 33);
            this.btnCAgregar.TabIndex = 6;
            this.btnCAgregar.UseVisualStyleBackColor = false;
            this.btnCAgregar.Click += new System.EventHandler(this.btnCAgregar_Click);
            // 
            // btnCcancelar
            // 
            this.btnCcancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCcancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCcancelar.BackgroundImage")));
            this.btnCcancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCcancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCcancelar.FlatAppearance.BorderSize = 0;
            this.btnCcancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCcancelar.Location = new System.Drawing.Point(130, 168);
            this.btnCcancelar.Name = "btnCcancelar";
            this.btnCcancelar.Size = new System.Drawing.Size(95, 33);
            this.btnCcancelar.TabIndex = 7;
            this.btnCcancelar.UseVisualStyleBackColor = false;
            this.btnCcancelar.Click += new System.EventHandler(this.btnCcancelar_Click);
            // 
            // dgvCategorias
            // 
            this.dgvCategorias.AllowUserToAddRows = false;
            this.dgvCategorias.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvCategorias.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCategorias.BackgroundColor = System.Drawing.Color.White;
            this.dgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategorias.Location = new System.Drawing.Point(15, 42);
            this.dgvCategorias.Name = "dgvCategorias";
            this.dgvCategorias.ReadOnly = true;
            this.dgvCategorias.Size = new System.Drawing.Size(220, 110);
            this.dgvCategorias.TabIndex = 8;
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtId.Location = new System.Drawing.Point(211, 16);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(35, 20);
            this.txtId.TabIndex = 9;
            this.txtId.Visible = false;
            // 
            // errorCategoria
            // 
            this.errorCategoria.ContainerControl = this;
            // 
            // frmCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(210)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(252, 213);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.dgvCategorias);
            this.Controls.Add(this.btnCcancelar);
            this.Controls.Add(this.btnCAgregar);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.lblCategoria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCategoria";
            this.Text = "frmCategoria";
            this.Load += new System.EventHandler(this.frmCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCategoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.Button btnCAgregar;
        private System.Windows.Forms.Button btnCcancelar;
        private System.Windows.Forms.DataGridView dgvCategorias;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.ErrorProvider errorCategoria;
    }
}