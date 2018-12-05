namespace BlingLuxury.Vistas
{
    partial class frmEntidadFederativa
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
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.dgvEntidades = new System.Windows.Forms.DataGridView();
            this.btnEsCancelar = new System.Windows.Forms.Button();
            this.btnEsAgregar = new System.Windows.Forms.Button();
            this.errorEstado = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntidades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorEstado)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(75, 24);
            this.txtEstado.MaxLength = 15;
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(138, 20);
            this.txtEstado.TabIndex = 11;
            this.txtEstado.TextChanged += new System.EventHandler(this.txtEstado_TextChanged);
            this.txtEstado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEstado_KeyPress);
            this.txtEstado.Validating += new System.ComponentModel.CancelEventHandler(this.txtEstado_Validating);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(33, 27);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(43, 13);
            this.lblEstado.TabIndex = 10;
            this.lblEstado.Text = "Estado:";
            // 
            // dgvEntidades
            // 
            this.dgvEntidades.AllowUserToAddRows = false;
            this.dgvEntidades.AllowUserToDeleteRows = false;
            this.dgvEntidades.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgvEntidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntidades.Location = new System.Drawing.Point(36, 59);
            this.dgvEntidades.Name = "dgvEntidades";
            this.dgvEntidades.ReadOnly = true;
            this.dgvEntidades.Size = new System.Drawing.Size(220, 110);
            this.dgvEntidades.TabIndex = 15;
            // 
            // btnEsCancelar
            // 
            this.btnEsCancelar.Location = new System.Drawing.Point(159, 186);
            this.btnEsCancelar.Name = "btnEsCancelar";
            this.btnEsCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnEsCancelar.TabIndex = 17;
            this.btnEsCancelar.Text = "Cancelar";
            this.btnEsCancelar.UseVisualStyleBackColor = true;
            this.btnEsCancelar.Click += new System.EventHandler(this.btnEsCancelar_Click);
            // 
            // btnEsAgregar
            // 
            this.btnEsAgregar.Location = new System.Drawing.Point(62, 186);
            this.btnEsAgregar.Name = "btnEsAgregar";
            this.btnEsAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnEsAgregar.TabIndex = 16;
            this.btnEsAgregar.Text = "Agregar";
            this.btnEsAgregar.UseVisualStyleBackColor = true;
            this.btnEsAgregar.Click += new System.EventHandler(this.btnEsAgregar_Click);
            // 
            // errorEstado
            // 
            this.errorEstado.ContainerControl = this;
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtId.Location = new System.Drawing.Point(218, 24);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(38, 20);
            this.txtId.TabIndex = 18;
            this.txtId.Visible = false;
            // 
            // frmEntidadFederativa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 222);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnEsCancelar);
            this.Controls.Add(this.btnEsAgregar);
            this.Controls.Add(this.dgvEntidades);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.lblEstado);
            this.Name = "frmEntidadFederativa";
            this.Text = "frmEntidadFederativa";
            this.Load += new System.EventHandler(this.frmEntidadFederativa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntidades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorEstado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.DataGridView dgvEntidades;
        private System.Windows.Forms.Button btnEsCancelar;
        private System.Windows.Forms.Button btnEsAgregar;
        private System.Windows.Forms.ErrorProvider errorEstado;
        private System.Windows.Forms.TextBox txtId;
    }
}