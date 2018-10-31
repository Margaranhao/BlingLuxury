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
            this.lblModeloA = new System.Windows.Forms.Label();
            this.txtModeloA = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblModeloA
            // 
            this.lblModeloA.AutoSize = true;
            this.lblModeloA.Location = new System.Drawing.Point(21, 27);
            this.lblModeloA.Name = "lblModeloA";
            this.lblModeloA.Size = new System.Drawing.Size(45, 13);
            this.lblModeloA.TabIndex = 0;
            this.lblModeloA.Text = "Modelo:";
            // 
            // txtModeloA
            // 
            this.txtModeloA.Location = new System.Drawing.Point(63, 24);
            this.txtModeloA.Name = "txtModeloA";
            this.txtModeloA.Size = new System.Drawing.Size(121, 20);
            this.txtModeloA.TabIndex = 1;
            // 
            // frmModelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 185);
            this.Controls.Add(this.txtModeloA);
            this.Controls.Add(this.lblModeloA);
            this.Name = "frmModelo";
            this.Text = "frmModelo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblModeloA;
        private System.Windows.Forms.TextBox txtModeloA;
    }
}