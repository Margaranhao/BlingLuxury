using BlingLuxury.Clases;
using BlingLuxury.DAO;
using BlingLuxury.Validaciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlingLuxury.Vistas
{
    public partial class frmCategoria : Form
    {
        #region Variables
        //Funcionalidad para pasar datos de un formulario a otro en este caso de categoria a Producto
        //Por medio de eventos y delegados 
        /*Un delegado es un tipo que representa referencias a métodos con una lista de parámetros
        determinada y un tipo de valor devuelto. Cuando se crea una instancia de un delegado, 
        puede asociar su instancia a cualquier método mediante una firma y un tipo de valor devuelto compatibles.
        */
        public delegate void pasarCategoria(string categoria); //Variable Delegado
        public event pasarCategoria enviado; //Evento
        protected string sql;
        protected int id;
        #endregion
        public frmCategoria()
        {
            InitializeComponent();
        }
        #region Insertar
        private void Insertar() //Metodo para Insertar Categorias
        {
            try
            {
                CategoriaDAO.getInstance().Insertar(new Categoria(txtCategoria.Text));
                //Manda mensaje de confirmacion cuando se agregan los datos
                MessageBox.Show("Categoria se agrego correctamente", "Categoria Agregada", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                mostrarCategorias(); //Actualiza el DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion Insertar 
        private void btnCAgregar_Click(object sender, EventArgs e)
        {
            if (txtCategoria.Text.Trim() == "") // Condición para no insertar si el TextBox esta vacio
            {
                errorCategoria.SetError(txtCategoria, "No se pueden dejar el campo vacio"); //Mensaje en que aparece en el icono del Error Provider
                //Mensaje en caso de que se cumpla la condicion del TextBox vacio
                MessageBox.Show("No se puede insertar un valor vacio", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCategoria.Focus();
            }
            else
            {
                Insertar(); // Se Manda llamar el metodo para insertar los datos
                enviado(txtCategoria.Text); //Envia de un TextBox los datos al formulario y los ubica en el ComboBox Categoria
                errorCategoria.Clear(); // Limpia el Error
                this.Close(); //Cierra el formulario Categoria
            }
        }
        #region Categoria
        public DataTable listarCategoria() //Metodo que obtiene de forma de lista de Categoria
        {
            DataTable dt = new DataTable("Categoria");
            dt.Columns.Add("Id");
            dt.Columns.Add("Categiorias");
                        
            try
            {
                sql = "SELECT id, nombre FROM categoria ORDER BY id;";
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
        public void mostrarCategorias()
        {
            try
            {
                #region
                dgvCategorias.DataSource = listarCategoria();
                id = Convert.ToInt32(txtId.Text);
                #endregion
            }
            catch
            {

            }
        }
        #endregion Categoria       

        private void frmCategoria_Load(object sender, EventArgs e)
        {
            mostrarCategorias();
        }

        private void txtCategoria_KeyPress(object sender, KeyPressEventArgs e) //Valida que al ingresar datos solo acepta Letras
        {
            Validar.SoloLetras(e);
        }

        private void txtCategoria_TextChanged(object sender, EventArgs e) //Busca las coincidencias al momento de teclear datos en el TextBox
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dgvCategorias.DataSource;
            bs.Filter = $"Categiorias like '%" + txtCategoria.Text + "%'";
            dgvCategorias.DataSource = bs;
        }

        private void txtCategoria_Validating(object sender, CancelEventArgs e) //Metodo que valida el TextBox para que no se insete vacio
        {
            if (txtCategoria.Text.Trim() == "") //Condicion para que el TextBox no este vacio
            {
                errorCategoria.SetError(txtCategoria, "Campo con Valor vacio"); //Mensaje en el icono de Error Provider
                txtCategoria.Focus();
            }
            else
            {
                errorCategoria.Clear(); //Limpia el icono cuando insertas datos
            }
        }

        private void btnCcancelar_Click(object sender, EventArgs e) //Botón para cancelar peticion y cerrar formulario
        {
            //Condicion donde pregunta si deceas cancelar y salir del formulario a travez de un mensaje en ventana emergente
            if (MessageBox.Show("¿Desea Cancelar?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close(); //si se cumple Se cierra el Formulario Categoria
            }
        }
    }
}
