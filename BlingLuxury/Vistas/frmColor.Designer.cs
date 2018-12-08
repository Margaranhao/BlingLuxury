namespace BlingLuxury.Vistas
{
    partial class frmColor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmColor));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCoCancelar = new System.Windows.Forms.Button();
            this.btnCoAgregar = new System.Windows.Forms.Button();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.dgvColores = new System.Windows.Forms.DataGridView();
            this.txtId = new System.Windows.Forms.TextBox();
            this.errorColor = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvColores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorColor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCoCancelar
            // 
            this.btnCoCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCoCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCoCancelar.BackgroundImage")));
            this.btnCoCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCoCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCoCancelar.FlatAppearance.BorderSize = 0;
            this.btnCoCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCoCancelar.Location = new System.Drawing.Point(141, 159);
            this.btnCoCancelar.Name = "btnCoCancelar";
            this.btnCoCancelar.Size = new System.Drawing.Size(95, 32);
            this.btnCoCancelar.TabIndex = 13;
            this.btnCoCancelar.UseVisualStyleBackColor = false;
            this.btnCoCancelar.Click += new System.EventHandler(this.btnCoCancelar_Click);
            // 
            // btnCoAgregar
            // 
            this.btnCoAgregar.BackColor = System.Drawing.Color.Transparent;
            this.btnCoAgregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCoAgregar.BackgroundImage")));
            this.btnCoAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCoAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCoAgregar.FlatAppearance.BorderSize = 0;
            this.btnCoAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCoAgregar.Location = new System.Drawing.Point(16, 159);
            this.btnCoAgregar.Name = "btnCoAgregar";
            this.btnCoAgregar.Size = new System.Drawing.Size(95, 32);
            this.btnCoAgregar.TabIndex = 12;
            this.btnCoAgregar.UseVisualStyleBackColor = false;
            this.btnCoAgregar.Click += new System.EventHandler(this.btnCoAgregar_Click);
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(58, 17);
            this.txtColor.MaxLength = 15;
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(138, 20);
            this.txtColor.TabIndex = 9;
            this.txtColor.TextChanged += new System.EventHandler(this.txtColor_TextChanged);
            this.txtColor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtColor_KeyPress);
            this.txtColor.Validating += new System.ComponentModel.CancelEventHandler(this.txtColor_Validating);
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.ForeColor = System.Drawing.Color.Black;
            this.lblColor.Location = new System.Drawing.Point(12, 20);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(40, 13);
            this.lblColor.TabIndex = 8;
            this.lblColor.Text = "Color:";
            // 
            // dgvColores
            // 
            this.dgvColores.AllowUserToAddRows = false;
            this.dgvColores.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvColores.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvColores.BackgroundColor = System.Drawing.Color.White;
            this.dgvColores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvColores.Location = new System.Drawing.Point(16, 43);
            this.dgvColores.Name = "dgvColores";
            this.dgvColores.ReadOnly = true;
            this.dgvColores.Size = new System.Drawing.Size(220, 110);
            this.dgvColores.TabIndex = 14;
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtId.Location = new System.Drawing.Point(190, 17);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(46, 20);
            this.txtId.TabIndex = 15;
            this.txtId.Visible = false;
            // 
            // errorColor
            // 
            this.errorColor.ContainerControl = this;
            // 
            // frmColor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(210)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(252, 203);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.dgvColores);
            this.Controls.Add(this.btnCoCancelar);
            this.Controls.Add(this.btnCoAgregar);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.lblColor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmColor";
            this.Text = "frmColor";
            this.Load += new System.EventHandler(this.frmColor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvColores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorColor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCoCancelar;
        private System.Windows.Forms.Button btnCoAgregar;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.DataGridView dgvColores;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.ErrorProvider errorColor;
    }
}