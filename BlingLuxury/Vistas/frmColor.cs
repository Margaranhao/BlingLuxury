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
        //private static DatosTableAdapter adaptador = new DatosTableAdapter();
        #endregion
        public frmColor()
        {
            InitializeComponent();
        }               
        #region Insertar
        private void Insertar() //Metodo para Insertar Colores
        {
            try
            {
                ColorDAO.getInstance().Insertar(new Clases.Color(txtColor.Text)); 
                //Manda mensaje de confirmacion cuando se agregan los datos
                MessageBox.Show("Color agrego correctamente", "Color Agregado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                mostrarColores(); //Actualiza el DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion Insertar        
        private void btnCoAgregar_Click(object sender, EventArgs e) //Botón para Agregar colores
        {
            if (txtColor.Text.Trim() == "") // Condición para no insertar si el TextBox esta vacio
            {
                errorColor.SetError(txtColor, "No se pueden dejar el campo vacio"); //Mensaje en que aparece en el icono del Error Provider
                //Mensaje en caso de que se cumpla la condicion del TextBox vacio
                MessageBox.Show("No se puede insertar un valor vacio", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
                txtColor.Focus();
            }
            else
            {                
                    Insertar(); // Se Manda llamar el metodo para insertar los datos
                    enviado(txtColor.Text); //Envia de un TextBox los datos al formulario y los ubica en el ComboBox Color
                    errorColor.Clear(); // Limpia el Error
                    this.Close(); //Cierra el formulario Color
                }
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
                List<Clases.Color> colorLista = ColorDAO.getInstance().Listar(sql);
                for (int i = 0; i < colorLista.Count; i++)
                {
                    dt.Rows.Add(colorLista[i].id, colorLista[i].nombre);
                }
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return dt;
            }
        }
        public void mostrarColores() //Muestra los datos en el dataGridView
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
        private void txtColor_KeyPress(object sender, KeyPressEventArgs e) //Valida que al ingresar datos solo acepta Letras
        {
            //Solo Acepta Letras
            Validar.SoloLetras(e);
        }

        private void txtColor_TextChanged(object sender, EventArgs e) //Busca las coincidencias al momento de teclear datos en el TextBox
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dgvColores.DataSource;
            bs.Filter = $"Color like '%" + txtColor.Text + "%'";
            dgvColores.DataSource = bs;
        }

        private void txtColor_Validating(object sender, CancelEventArgs e) //Metodo que valida el TextBox para que no se insete vacio 
        {
            if (txtColor.Text.Trim() == "") //Condicion para que el TextBox no este vacio
            {
                errorColor.SetError(txtColor, "Campo con Valor vacio"); //Mensaje en el icono de Error Provider
                txtColor.Focus();
            }
            else
            {
                errorColor.Clear(); //Limpia el icono cuando insertas datos
            }            
        }
        private void btnCoCancelar_Click(object sender, EventArgs e) //Botón para cancelar peticion y cerrar formulario
        {
            //Condicion donde pregunta si deceas cancelar y salir del formulario a travez de un mensaje en ventana emergente
            if (MessageBox.Show("¿Desea Cancelar?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close(); //si se cumple Se cierra el Formulario Color
            }
        }        
    }
}
   
        
    

