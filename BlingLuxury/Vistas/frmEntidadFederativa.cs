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
    public partial class frmEntidadFederativa : Form
    {
        #region Variables
        //Funcionalidad para pasar datos de un formulario a otro en este caso de categoria a Producto
        //Por medio de eventos y delegados 
        /*Un delegado es un tipo que representa referencias a métodos con una lista de parámetros
        determinada y un tipo de valor devuelto. Cuando se crea una instancia de un delegado, 
        puede asociar su instancia a cualquier método mediante una firma y un tipo de valor devuelto compatibles.
        */
        public delegate void pasarEntidad(string entidad); //Variable Delegado
        public event pasarEntidad enviado; //Evento
        protected string sql;
        protected int id;
        //private static DatosTableAdapter adaptador = new DatosTableAdapter();
        #endregion
        public frmEntidadFederativa()
        {
            InitializeComponent();
        }
        #region Interaccón BD

        #region Insertar
        private void Insertar() //Metodo para Insertar Colores
        {
            try
            {
                EntidadFederativaDAO.getInstance().Insertar(new EntidadFederativa(txtEstado.Text));
                //Manda mensaje de confirmacion cuando se agregan los datos
                MessageBox.Show("Entidad Federativa agregada correctamente", "Estado Agregado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                mostrarEntidad(); //Actualiza el DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion Insertar     
        private void txtEstado_TextChanged(object sender, EventArgs e) //Busca las coincidencias al momento de teclear datos en el TextBox
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dgvEntidades.DataSource;
            bs.Filter = $"Estado like '%" + txtEstado.Text + "%'";
            dgvEntidades.DataSource = bs;
        }
        #endregion Interacción BD
        #region Eventos        
        private void btnEsAgregar_Click(object sender, EventArgs e) //Botón para Agregar
        {
            if (txtEstado.Text.Trim() == "") // Condición para no insertar si el TextBox esta vacio
            {
                errorEstado.SetError(txtEstado, "No se pueden dejar el campo vacio"); //Mensaje en que aparece en el icono del Error Provider
                //Mensaje en caso de que se cumpla la condicion del TextBox vacio
                MessageBox.Show("No se puede insertar un valor vacio", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEstado.Focus();
            }
            else
            {
                Insertar(); // Se Manda llamar el metodo para insertar los datos
                enviado(txtEstado.Text); //Envia de un TextBox los datos al formulario y los ubica en el ComboBox Estado
                errorEstado.Clear(); // Limpia el Error
                this.Close(); //Cierra el formulario Color
            }
        }        
        private void btnEsCancelar_Click(object sender, EventArgs e) //Botón para cancelar peticion y cerrar formulario
        {
            //Condicion donde pregunta si deceas cancelar y salir del formulario a travez de un mensaje en ventana emergente
            if (MessageBox.Show("¿Desea Cancelar?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close(); //si se cumple Se cierra el Formulario Entidad Federativa
            }
        }
        #endregion Eventos
        #region Estado        
        public DataTable listarEntidad() //Metodo que obtiene de forma de lista de Entidad Federativa
        {
            DataTable dt = new DataTable("Entidad");
            dt.Columns.Add("Id");
            dt.Columns.Add("Estado");
            try
            {
                sql = "SELECT id, nombre FROM entidad_federativa ORDER BY id;";
                List<EntidadFederativa> estadoLista = EntidadFederativaDAO.getInstance().Listar(sql);
                for (int i = 0; i < estadoLista.Count; i++)
                {
                    dt.Rows.Add(estadoLista[i].id, estadoLista[i].nombre);
                }
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return dt;
            }
        }
        public void mostrarEntidad() //Muestra los datos en el dataGridView
        {
            try
            {
                #region
                dgvEntidades.DataSource = listarEntidad();
                id = Convert.ToInt32(txtId.Text);
                #endregion
            }
            catch
            {

            }
        }
        #endregion Estado
        #region Interacción Formulario
        private void frmEntidadFederativa_Load(object sender, EventArgs e)
        {
            mostrarEntidad();
        }
        #endregion Interacción Formulario
    
        #region Validaciones
        private void txtEstado_KeyPress(object sender, KeyPressEventArgs e) //Valida que al ingresar datos solo acepta Letras
        {
            //Solo Acepta Letras
            Validar.SoloLetras(e);
        }
        private void txtEstado_Validating(object sender, CancelEventArgs e) //Metodo que valida el TextBox para que no se insete vacio
        {
            if (txtEstado.Text.Trim() == "") //Condicion para que el TextBox no este vacio
            {
                errorEstado.SetError(txtEstado, "Campo con Valor vacio"); //Mensaje en el icono de Error Provider
                txtEstado.Focus();
            }
            else
            {
                errorEstado.Clear(); //Limpia el icono cuando insertas datos
            }
        }
    }
}
#endregion Validaciones 