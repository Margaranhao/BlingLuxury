﻿using BlingLuxury.Vistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlingLuxury
{
    public partial class fmPrincipal : Form
    {
        public fmPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmProducto producto = new FrmProducto();
            producto.Show();
            this.Hide();
        }

        private void fmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnCatalogo_Click(object sender, EventArgs e)
        {
            frmCatalogo catalogo = new frmCatalogo();
            catalogo.Show();
            this.Hide();
        }
    }
}
