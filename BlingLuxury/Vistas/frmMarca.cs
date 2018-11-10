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
    public partial class frmMarca : Form
    {
        #region Variables
        //Funcionalidad para pasar datos de un formulario a otro en este caso de categoria a Producto
        //Por medio de eventos y delegados 
        /*Un delegado es un tipo que representa referencias a métodos con una lista de parámetros
        determinada y un tipo de valor devuelto. Cuando se crea una instancia de un delegado, 
        puede asociar su instancia a cualquier método mediante una firma y un tipo de valor devuelto compatibles.
        */
        public delegate void pasarMarca(string marca); //Variable Delegado
        public event pasarMarca enviado; //Evento
        protected string sql;
        protected int id;
        //private static DatosTableAdapter adaptador = new DatosTableAdapter();
        #endregion

        public frmMarca()
        {
            InitializeComponent();
        }
        #region Insertar
        private void Insertar() //Metodo para Insertar Colores
        {
            try
            {
                MarcaDAO.getInstance().Insertar(new Marca(txtMarcaA.Text));
                //Manda mensaje de confirmacion cuando se agregan los datos
                MessageBox.Show("Marca se agrego correctamente", "Marca Agregada", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                mostrarMarca(); //Actualiza el DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion Insertar     
        #region Marca        
        public DataTable listarMarca() //Metodo que obtiene de forma de lista de Color
        {
            DataTable dt = new DataTable("Marca");
            dt.Columns.Add("Id");
            dt.Columns.Add("Marca");
                     
            try
            {
                sql = "SELECT id, nombre FROM marca;";
                List<Marca> marcaLista = MarcaDAO.getInstance().Listar(sql);
                for (int i = 0; i < marcaLista.Count; i++)
                {
                    dt.Rows.Add(marcaLista[i].id, marcaLista[i].nombre);
                }
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return dt;
            }
        }
        public void mostrarMarca() //Muestra los datos en el dataGridView
        {
            try
            {
                #region
                dgvMarcas.DataSource = listarMarca();
                //id = Convert.ToInt32(txtIdMa.Text);
                #endregion
            }
            catch
            {

            }
        }
        #endregion Color
        #region Validaciones
        private void txtMarcaA_KeyPress(object sender, KeyPressEventArgs e) //Valida que al ingresar datos solo acepta Letras
        {
            //Solo Acepta Letras
            Validar.SoloLetras(e);
        }

        private void txtMarcaA_Validating(object sender, CancelEventArgs e)
        {
            if (txtMarcaA.Text.Trim() == "") //Condicion para que el TextBox no este vacio
            {
                errorMarca.SetError(txtMarcaA, "Campo con Valor vacio"); //Mensaje en el icono de Error Provider
                txtMarcaA.Focus();
            }
            else
            {
                errorMarca.Clear(); //Limpia el icono cuando insertas datos
            }
        }

        private void txtMarcaA_TextChanged(object sender, EventArgs e) //Busca las coincidencias al momento de teclear datos en el TextBox
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dgvMarcas.DataSource;
            bs.Filter = $"Marca like '%" + txtMarcaA.Text + "%'";
            dgvMarcas.DataSource = bs;
        }

        #endregion

        private void frmMarca_Load(object sender, EventArgs e)
        {
            mostrarMarca();
        }

        private void btnAgregar_Click(object sender, EventArgs e) //Botón para Agregar Marcas
        {
            if (txtMarcaA.Text.Trim() == "") // Condición para no insertar si el TextBox esta vacio
            {
                errorMarca.SetError(txtMarcaA, "No se pueden dejar el campo vacio"); //Mensaje en que aparece en el icono del Error Provider
                //Mensaje en caso de que se cumpla la condicion del TextBox vacio
                MessageBox.Show("No se puede insertar un valor vacio", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMarcaA.Focus();
            }
            else
            {
                Insertar(); // Se Manda llamar el metodo para insertar los datos
                enviado(txtMarcaA.Text); //Envia de un TextBox los datos al formulario y los ubica en el ComboBox Color
                errorMarca.Clear(); // Limpia el Error
                this.Close(); //Cierra el formulario Marca
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e) //Botón para cancelar peticion y cerrar formulario
        {
            //Condicion donde pregunta si deceas cancelar y salir del formulario a travez de un mensaje en ventana emergente
            if (MessageBox.Show("¿Desea Cancelar?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close(); //si se cumple Se cierra el Formulario Marca
            }
        }
    }
}