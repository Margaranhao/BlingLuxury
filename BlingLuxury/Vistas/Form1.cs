using System;
using System.Drawing;
using System.Windows.Forms;


namespace BlingLuxury
{

    public partial class fmLogin : Form
    {
        
        
        public fmLogin()
        {
            InitializeComponent();
            
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            //placeholder para el campo usuario
            txtUser.GotFocus += new EventHandler(this.TextGotFocus);
            txtUser.LostFocus += new EventHandler(this.TextLostFocus);

            txtPass.GotFocus += new EventHandler(this.TextGotFocus1);
            txtPass.LostFocus += new EventHandler(this.TextLostFocus1);

        }
        #region Focus
        public void TextGotFocus(object sender, EventArgs e)
        {
            if(txtUser.Text == "usuario")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.Black;
            }
        }
        public void TextGotFocus1(object sender, EventArgs e)
        {
            if (txtPass.Text == "password")
            {
                txtPass.Text = "";
                txtPass.ForeColor = Color.Black;
            }
        }

        public void TextLostFocus(object sender, EventArgs e)
        {
            if(txtUser.Text == "")
            {
                txtUser.Text = "usuario";
                txtUser.ForeColor = Color.Gray;
            }
        }
        public void TextLostFocus1(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "password";
                txtPass.ForeColor = Color.Gray;
            }
        }

        #endregion
        //BaseDeDatos d = new BaseDeDatos();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            fmPrincipal principal = new fmPrincipal();
            principal.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fmRegistro registro = new fmRegistro();
            registro.Show();
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            // Close();
            Application.Exit();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
