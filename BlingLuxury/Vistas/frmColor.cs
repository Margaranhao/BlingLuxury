using BlingLuxury.DAO;
using BlingLuxury.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BlingLuxury.Validaciones;
using BlingLuxury.Connection;
using MySql.Data.MySqlClient;

namespace BlingLuxury.Vistas
{
    public partial class frmColor : Form
    {
        #region Variables
        //Funcionalidad para pasar datos de un formulario a otro en este caso de categoria a Producto
        //Por medio de eventos y delegados 
        /*Un delegado es un tipo que representa referencias a métodos con una lista de parámetros
        determinada y un tipo de valor devuelto. Cuando se crea una instancia de un delegado, 
        puede asociar su instancia a cualquier método mediante una firma y un tipo de valor devuelto compatibles.
        */
        public delegate void pasarColor(string color); //Variable Delegado
        public event pasarColor enviado; //Evento
        protected string sql;
        protected int id;
        #endregion
        public frmColor()
        {
            InitializeComponent();
        }
        #region Insertar
        private void Insertar()
        {
            try
            {
                ColorDAO.getInstance().Insertar(new Clases.Color(txtColor.Text));
                MessageBox.Show("Color agrego correctamente", "Color Agregado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                mostrarColores();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        #endregion Insertar

        #region Actualizar
        private void Actualizar()
        {
            try
            {
                ColorDAO.getInstance().Actualizar(new Clases.Color(txtColor.Text), id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion Actualizar

        #region Buscar
        public static DataTable BuscarConId(int id, string nombre)//para evitar duplicados
        {
            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT id, nombre FROM color WHERE nombre = @nombre AND NOT id = @id;";
                Conexion.getInstance().setCadenaConnection();
                MySqlCommand cmd = new MySqlCommand(sql, Conexion.getInstance().getConnection());
                cmd.Parameters.AddWithValue("@codigo_de_barras", nombre);
                cmd.Parameters.AddWithValue("@id", id);
                MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                adap.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return dt;
            }
        }
        #endregion Buscar

        private void btnCoAgregar_Click(object sender, EventArgs e)
        {
            Insertar();
            enviado(txtColor.Text);
            if (!ValidarCampos()) return;
            if (!ValidarCampos())            
            {
                Insertar();
            }
            else
            {
                Actualizar();
            }
            
            dgvColores.DataSource = null;                        
        }    
        #region Color
        public DataTable listarColor() //Metodo que obtiene de forma de lista de Color
        {
            DataTable dt = new DataTable("Color");
            dt.Columns.Add("Id");
            dt.Columns.Add("Color");


            try
            {
                sql = "SELECT id, nombre FROM color ORDER BY id;";
                List<Categoria> categoriaLista = CategoriaDAO.getInstance().Listar(sql);
                for (int i = 0; i < categoriaLista.Count; i++)
                {
                    dt.Rows.Add(categoriaLista[i].id, categoriaLista[i].nombre);
                }
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return dt;
            }
        }
        public void mostrarColores()
        {
            try
            {

                #region
                dgvColores.DataSource = listarColor();
                id = Convert.ToInt32(txtId.Text);
                #endregion
            }
            catch
            {

            }
        }
        #endregion Color      

        private void frmColor_Load(object sender, EventArgs e)
        {
            mostrarColores();
        }
        private void txtColor_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);
        }

        private void txtColor_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();

            bs.DataSource = dgvColores.DataSource;
            bs.Filter = $"Color like '%" + txtColor.Text + "%'";
            dgvColores.DataSource = bs;
        }

        private bool ValidarCampos()
        {
            if (txtColor.Text == "")
            {
                errorColor.SetError(txtColor, "Debe ingresar un Color");
                txtColor.Focus();
                return false;
            }
            errorColor.SetError(txtColor, "");

           if (txtColor.Text == txtColor.Text)
            {
                errorColor.SetError(txtColor, "El Color ya existe");
                txtColor.Focus();
                return false;
            }
            errorColor.Clear();
            return true;
        }
    }
}

    
        //private void txtColor_Validating(object sender, CancelEventArgs e)
        //{
        //    if (txtColor.Text.Trim() == "")
        //    {
        //        errorColor.SetError(txtColor, "Ingresa un color en este recuadro");
        //        txtColor.Focus();
        //    }
        //    else
        //    {
        //        errorColor.Clear();
        //    }
        
    

