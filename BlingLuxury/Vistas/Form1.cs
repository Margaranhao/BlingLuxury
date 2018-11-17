using BlingLuxury.Connection;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;


namespace BlingLuxury
{

    public partial class fmLogin : Form
    {
        protected string sql;
        private MySqlConnection connection;

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
            if (txtUser.Text == "usuario")
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
            if (txtUser.Text == "")
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


        private void btnLogin_Click(object sender, EventArgs e)
        {
            sql = "SELECT nombre, nick, pass, id_nivel FROM usuario WHERE nick='" + txtUser.Text + "'AND pass='" + txtPass.Text + "';";
            MySqlCommand cmd = new MySqlCommand(sql, Conexion.getInstance().getConnection()); //Realizamos una selecion de la tabla usuarios.
            MySqlDataReader leer = cmd.ExecuteReader();
            if (leer.Read()) //Si el usuario es correcto nos abrira la otra ventana.
            {
                //if ((txtUser.Text != "") && (txtPass.Text != ""))
                //{
                //    MessageBox.Show("Ingresa Usuario y contraseña", "CAMPOS BASIOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //}
                //else if ((txtUser.Text == nick) && (txtPass.Text == pass))
                //{
                this.Hide();
                MessageBox.Show("Acceso Correcto", "Bienvenido");
                fmPrincipal principal = new fmPrincipal();
                principal.Show();
            }
            else //Si no lo es mostrara este mensaje.
                MessageBox.Show("Error - Ingrese sus datos correctamente");            
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
