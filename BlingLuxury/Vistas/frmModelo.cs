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
    public partial class frmModelo : Form
    {
        #region Variables
        //Funcionalidad para pasar datos de un formulario a otro en este caso de categoria a Producto
        //Por medio de eventos y delegados 
        /*Un delegado es un tipo que representa referencias a métodos con una lista de parámetros
        determinada y un tipo de valor devuelto. Cuando se crea una instancia de un delegado, 
        puede asociar su instancia a cualquier método mediante una firma y un tipo de valor devuelto compatibles.
        */
        public delegate void pasarModelo(string modelo); //Variable Delegado
        public event pasarModelo enviado; //Evento
        protected string sql;
        protected int id;
        //private static DatosTableAdapter adaptador = new DatosTableAdapter();
        #endregion
        public frmModelo()
        {
            InitializeComponent();
        }
        #region Eventos
        private void button1_Click(object sender, EventArgs e) //Botón para cancelar peticion y cerrar formulario
        {
            //Condicion donde pregunta si deceas cancelar y salir del formulario a travez de un mensaje en ventana emergente
            if (MessageBox.Show("¿Desea Cancelar?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close(); //si se cumple Se cierra el Formulario Modelo
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e) //Botón para Agregar Modelos
        {
            if (txtModeloA.Text.Trim() == "") // Condición para no insertar si el TextBox esta vacio
            {
                errorModelo.SetError(txtModeloA, "No se pueden dejar el campo vacio"); //Mensaje en que aparece en el icono del Error Provider
                //Mensaje en caso de que se cumpla la condicion del TextBox vacio
                MessageBox.Show("No se puede insertar un valor vacio", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtModeloA.Focus();
            }
            else
            {
                Insertar(); // Se Manda llamar el metodo para insertar los datos
                enviado(txtModeloA.Text); //Envia de un TextBox los datos al formulario y los ubica en el ComboBox Modelo
                errorModelo.Clear(); // Limpia el Error
                this.Close(); //Cierra el formulario Modelo
            }
        }
        #endregion
        #region Interaccion BD          
        #region Modelo        
        public DataTable listarModelo() //Metodo que obtiene de forma de lista de Color
        {
            DataTable dt = new DataTable("Modelo");
            dt.Columns.Add("Id");
            dt.Columns.Add("Modelo");
            try
            {
                sql = "SELECT id, nombre FROM modelo ORDER BY id;";
                List<Modelo> modeloLista = ModeloDAO.getInstance().Listar(sql);
                for (int i = 0; i < modeloLista.Count; i++)
                {
                    dt.Rows.Add(modeloLista[i].id, modeloLista[i].nombre);
                }
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return dt;
            }
        }
        public void mostrarModelos() //Muestra los datos en el dataGridView
        {
            try
            {
                #region
                dgvModelos.DataSource = listarModelo();
                id = Convert.ToInt32(txtId.Text);
                #endregion
            }
            catch
            {

            }
        }
        #endregion Modelo     
        #endregion
        #region Interaccion Formulario
        private void frmModelo_Load(object sender, EventArgs e)
        {
            mostrarModelos();
        }
        #region Insertar
        private void Insertar() //Metodo para Insertar Modelos
        {
            try
            {
                ModeloDAO.getInstance().Insertar(new Modelo(txtModeloA.Text));
                //Manda mensaje de confirmacion cuando se agregan los datos
                MessageBox.Show("Modelo agrego correctamente", "Modelo Agregado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                mostrarModelos(); //Actualiza el DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion Insertar 
        #endregion
        #region Validaciones
        private void txtModeloA_Validating(object sender, CancelEventArgs e) //Metodo que valida el TextBox para que no se insete vacio 
        {
            if (txtModeloA.Text.Trim() == "") //Condicion para que el TextBox no este vacio
            {
                errorModelo.SetError(txtModeloA, "Campo con Valor vacio"); //Mensaje en el icono de Error Provider
                txtModeloA.Focus();
            }
            else
            {
                errorModelo.Clear(); //Limpia el icono cuando insertas datos
            }
        }

        private void txtModeloA_TextChanged(object sender, EventArgs e) //Busca las coincidencias al momento de teclear datos en el TextBox
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dgvModelos.DataSource;
            bs.Filter = $"Modelo like '%" + txtModeloA.Text + "%'";
            dgvModelos.DataSource = bs;
        }

        private void txtModeloA_KeyPress(object sender, KeyPressEventArgs e) //Valida que al ingresar datos solo acepta Letras
        {
            //Solo Acepta Letras
            Validar.SoloLetras(e);
        }
    }
}

#endregion
