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
            this.lblCategoria = new System.Windows.Forms.Label();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.btnCAgregar = new System.Windows.Forms.Button();
            this.btnCcancelar = new System.Windows.Forms.Button();
            this.dgvCategorias = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).BeginInit();
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
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(138, 20);
            this.txtCategoria.TabIndex = 3;
            this.txtCategoria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCategoria_KeyPress);
            // 
            // btnCAgregar
            // 
            this.btnCAgregar.Location = new System.Drawing.Point(44, 157);
            this.btnCAgregar.Name = "btnCAgregar";
            this.btnCAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnCAgregar.TabIndex = 6;
            this.btnCAgregar.Text = "Agregar";
            this.btnCAgregar.UseVisualStyleBackColor = true;
            this.btnCAgregar.Click += new System.EventHandler(this.btnCAgregar_Click);
            // 
            // btnCcancelar
            // 
            this.btnCcancelar.Location = new System.Drawing.Point(130, 157);
            this.btnCcancelar.Name = "btnCcancelar";
            this.btnCcancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCcancelar.TabIndex = 7;
            this.btnCcancelar.Text = "Cancelar";
            this.btnCcancelar.UseVisualStyleBackColor = true;
            // 
            // dgvCategorias
            // 
            this.dgvCategorias.AllowUserToAddRows = false;
            this.dgvCategorias.AllowUserToDeleteRows = false;
            this.dgvCategorias.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategorias.Location = new System.Drawing.Point(15, 42);
            this.dgvCategorias.Name = "dgvCategorias";
            this.dgvCategorias.ReadOnly = true;
            this.dgvCategorias.Size = new System.Drawing.Size(220, 110);
            this.dgvCategorias.TabIndex = 8;
            // 
            // frmCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Violet;
            this.ClientSize = new System.Drawing.Size(252, 185);
            this.Controls.Add(this.dgvCategorias);
            this.Controls.Add(this.btnCcancelar);
            this.Controls.Add(this.btnCAgregar);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.lblCategoria);
            this.Name = "frmCategoria";
            this.Text = "frmCategoria";
            this.Load += new System.EventHandler(this.frmCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.Button btnCAgregar;
        private System.Windows.Forms.Button btnCcancelar;
        private System.Windows.Forms.DataGridView dgvCategorias;
    }
}