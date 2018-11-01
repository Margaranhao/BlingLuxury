namespace BlingLuxury.Vistas
{
    partial class frmMarca
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
            this.lblMarcaA = new System.Windows.Forms.Label();
            this.txtMarcaA = new System.Windows.Forms.TextBox();
            this.txtIdMa = new System.Windows.Forms.TextBox();
            this.dgvMarcas = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.errorMarca = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMarca)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMarcaA
            // 
            this.lblMarcaA.AutoSize = true;
            this.lblMarcaA.Location = new System.Drawing.Point(14, 16);
            this.lblMarcaA.Name = "lblMarcaA";
            this.lblMarcaA.Size = new System.Drawing.Size(40, 13);
            this.lblMarcaA.TabIndex = 0;
            this.lblMarcaA.Text = "Marca:";
            // 
            // txtMarcaA
            // 
            this.txtMarcaA.Location = new System.Drawing.Point(51, 13);
            this.txtMarcaA.Name = "txtMarcaA";
            this.txtMarcaA.Size = new System.Drawing.Size(136, 20);
            this.txtMarcaA.TabIndex = 1;
            this.txtMarcaA.TextChanged += new System.EventHandler(this.txtMarcaA_TextChanged);
            this.txtMarcaA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMarcaA_KeyPress);
            this.txtMarcaA.Validating += new System.ComponentModel.CancelEventHandler(this.txtMarcaA_Validating);
            // 
            // txtIdMa
            // 
            this.txtIdMa.Location = new System.Drawing.Point(193, 13);
            this.txtIdMa.Name = "txtIdMa";
            this.txtIdMa.Size = new System.Drawing.Size(43, 20);
            this.txtIdMa.TabIndex = 2;
            this.txtIdMa.Visible = false;
            // 
            // dgvMarcas
            // 
            this.dgvMarcas.AllowUserToAddRows = false;
            this.dgvMarcas.AllowUserToDeleteRows = false;
            this.dgvMarcas.BackgroundColor = System.Drawing.Color.Plum;
            this.dgvMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarcas.Location = new System.Drawing.Point(16, 39);
            this.dgvMarcas.Name = "dgvMarcas";
            this.dgvMarcas.ReadOnly = true;
            this.dgvMarcas.Size = new System.Drawing.Size(220, 110);
            this.dgvMarcas.TabIndex = 16;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(28, 155);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 17;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(144, 155);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 18;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // errorMarca
            // 
            this.errorMarca.ContainerControl = this;
            // 
            // frmMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 185);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvMarcas);
            this.Controls.Add(this.txtIdMa);
            this.Controls.Add(this.txtMarcaA);
            this.Controls.Add(this.lblMarcaA);
            this.Name = "frmMarca";
            this.Text = "frmMarca";
            this.Load += new System.EventHandler(this.frmMarca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMarca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMarcaA;
        private System.Windows.Forms.TextBox txtMarcaA;
        private System.Windows.Forms.TextBox txtIdMa;
        private System.Windows.Forms.DataGridView dgvMarcas;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ErrorProvider errorMarca;
    }
}