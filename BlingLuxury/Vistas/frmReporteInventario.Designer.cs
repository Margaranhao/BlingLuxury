﻿namespace BlingLuxury.Vistas
{
    partial class frmReporteInventario
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
            this.crystalReportViewerInventario = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportViewerInventario
            // 
            this.crystalReportViewerInventario.ActiveViewIndex = -1;
            this.crystalReportViewerInventario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerInventario.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerInventario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewerInventario.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewerInventario.Name = "crystalReportViewerInventario";
            this.crystalReportViewerInventario.Size = new System.Drawing.Size(669, 466);
            this.crystalReportViewerInventario.TabIndex = 0;
            this.crystalReportViewerInventario.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmReporteInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 466);
            this.Controls.Add(this.crystalReportViewerInventario);
            this.Name = "frmReporteInventario";
            this.Text = "frmReporteInventario";
            this.Load += new System.EventHandler(this.frmReporteInventario_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerInventario;
    }
}