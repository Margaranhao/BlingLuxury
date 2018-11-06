namespace BlingLuxury.Vistas
{
    partial class frmModelo
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
            this.lblModeloA = new System.Windows.Forms.Label();
            this.txtModeloA = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.dgvModelos = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.errorModelo = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtIdMarca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModelos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorModelo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblModeloA
            // 
            this.lblModeloA.AutoSize = true;
            this.lblModeloA.Location = new System.Drawing.Point(21, 15);
            this.lblModeloA.Name = "lblModeloA";
            this.lblModeloA.Size = new System.Drawing.Size(45, 13);
            this.lblModeloA.TabIndex = 0;
            this.lblModeloA.Text = "Modelo:";
            // 
            // txtModeloA
            // 
            this.txtModeloA.Location = new System.Drawing.Point(63, 12);
            this.txtModeloA.Name = "txtModeloA";
            this.txtModeloA.Size = new System.Drawing.Size(121, 20);
            this.txtModeloA.TabIndex = 1;
            this.txtModeloA.TextChanged += new System.EventHandler(this.txtModeloA_TextChanged);
            this.txtModeloA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtModeloA_KeyPress);
            this.txtModeloA.Validating += new System.ComponentModel.CancelEventHandler(this.txtModeloA_Validating);
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.Plum;
            this.txtId.Location = new System.Drawing.Point(140, 156);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(41, 20);
            this.txtId.TabIndex = 2;
            this.txtId.Visible = false;
            // 
            // dgvModelos
            // 
            this.dgvModelos.AllowUserToAddRows = false;
            this.dgvModelos.AllowUserToDeleteRows = false;
            this.dgvModelos.BackgroundColor = System.Drawing.Color.Plum;
            this.dgvModelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModelos.Location = new System.Drawing.Point(20, 38);
            this.dgvModelos.Name = "dgvModelos";
            this.dgvModelos.ReadOnly = true;
            this.dgvModelos.Size = new System.Drawing.Size(274, 110);
            this.dgvModelos.TabIndex = 15;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(44, 154);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 16;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(193, 154);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorModelo
            // 
            this.errorModelo.ContainerControl = this;
            // 
            // txtIdMarca
            // 
            this.txtIdMarca.Location = new System.Drawing.Point(245, 12);
            this.txtIdMarca.Name = "txtIdMarca";
            this.txtIdMarca.Size = new System.Drawing.Size(50, 20);
            this.txtIdMarca.TabIndex = 18;
            this.txtIdMarca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdMarca_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Id_Marca:";
            // 
            // frmModelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Violet;
            this.ClientSize = new System.Drawing.Size(309, 185);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIdMarca);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvModelos);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtModeloA);
            this.Controls.Add(this.lblModeloA);
            this.Name = "frmModelo";
            this.Text = "frmModelo";
            this.Load += new System.EventHandler(this.frmModelo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvModelos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorModelo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblModeloA;
        private System.Windows.Forms.TextBox txtModeloA;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.DataGridView dgvModelos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ErrorProvider errorModelo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdMarca;
    }
}