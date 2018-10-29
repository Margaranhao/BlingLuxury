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
        #endregion
        public frmCategoria()
        {
            InitializeComponent();
        }
        private void btnCAgregar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Agregar nueva categoria?", "Categoria", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
            enviado(txtCategoria.Text);
            CategoriaDAO.getInstance().Insertar(new Categoria(txtCategoria.Text));                                                                                                                   
        }
        #region Categoria
        public DataTable listarCategoria() //Metodo que obtiene de forma de lista de Categoria
        {
            DataTable dt = new DataTable("Categoria");
            dt.Columns.Add("Id");
            dt.Columns.Add("Nombre");

            
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
                //dgvProducto.Columns[0].Visible = true; // Id
                //dgvProducto.Columns[1].Visible = true; //CodigoBarras
                //dgvProducto.Columns[2].Visible = true; //Peso
                //dgvProducto.Columns[3].Visible = false; // ModeloId
                //dgvProducto.Columns[4].Visible = true; //Modelo
                //dgvProducto.Columns[5].Visible = false; //MarcaId
                //dgvProducto.Columns[6].Visible = true; //Marca
                //dgvProducto.Columns[7].Visible = false; //PrecioIdAdquisicion 
                //dgvProducto.Columns[8].Visible = true; //Precio
                //dgvProducto.Columns[9].Visible = false; // ColorId
                //dgvProducto.Columns[10].Visible = true; //Color
                //dgvProducto.Columns[11].Visible = false; // CategoriaId
                //dgvProducto.Columns[12].Visible = true; //Categoria 
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

        private void txtCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);
        }
    }
}
