using BlingLuxury.Vistas;
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
            //this.Hide();
        }

        private void fmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnCatalogo_Click(object sender, EventArgs e)
        {
            frmCatalogo catalogo = new frmCatalogo();
            catalogo.Show();
		//this.Hide();
		}
        private void btnInventario_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmInventario());
        }

		
        private void button1_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario(new frmCarteraDeClientes());
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new fmRegistro());
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        #region Panel
        //permite mostrar el formulario en el panel 2
        private void AbrirFormulario(object formHijo)
        {
            if(this.splitContainer1.Panel2.Controls.Count > 0)            
                this.splitContainer1.Panel2.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.splitContainer1.Panel2.Controls.Add(fh);
            this.splitContainer1.Panel2.Tag = fh;
            fh.Show();
        }

        #endregion

        #region Botones de ventana
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar1_Click(object sender, EventArgs e)
        {
            Close();

            fmLogin login = new fmLogin();
            login.Show();
        }
        #endregion
    }
}
