using BlingLuxury.Clases;
using BlingLuxury.DAO;
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
    public partial class FrmProducto : Form
    {
        public FrmProducto()
        {
            InitializeComponent();
        }

        #region Variables

        #endregion

        #region BD
        private void Insertar()
        {
            try
            {
                ProductoDAO.getInstance().Insertar(new Producto(Convert.ToInt32(txtCodigoBarras.Text), Convert.ToDouble(txtPeso.Text), new Modelo(Convert.ToInt32(cbxModelo.SelectedValue)), new PrecioAdquisicion(Convert.ToDouble(txtPrecio.Text)), new Clases.Color(Convert.ToInt32(cbxColor.SelectedValue)), new Categoria(Convert.ToInt32(cbxCategoria.SelectedValue))));
                MessageBox.Show("Producto insertado de manera correcta", "Proceso exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                throw new Exception (ex.Message);
            }
        }
        #endregion

        #region Formulario
        private void insertarProducto()
        {
           // Insertar();
        }
        #endregion

        #region Eventos
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            insertarProducto();
        }
        #endregion
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbxMarca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

<<<<<<< HEAD:BlingLuxury/FrmProducto.cs
        protected string sql;

        private DataTable listarProducto()
        {
            DataTable dt = new DataTable("Productos");
            dt.Columns.Add("Id");
            dt.Columns.Add("CodigoBarras");
            dt.Columns.Add("Peso");
            dt.Columns.Add("ModeloId");
            dt.Columns.Add("PrecioIdAdquisicion");
            dt.Columns.Add("ColorId");
            dt.Columns.Add("CategoriaId");

            try
            {
                sql = "SELECT id, codigo_de_barras, peso, id_modelo, id_precio_adquisicion, id_color, id_categoria FROM producto;";
                List<Producto> listaProducto = ProductoDAO.getInstance().Listar(sql);
                for (int i = 0; i < listaProducto.Count; i++)
                {
                    dt.Rows.Add(listaProducto[i].id, listaProducto[i].codigoDeBarras, listaProducto[i].peso, listaProducto[i].id_modelo, listaProducto[i].id_precio_adquisicion, listaProducto[i].id_color, listaProducto[i].id_categoria);
                }
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return dt;
            }
        }

        private void mostrarProducto()
        {

        }
        private DataTable listarModelo() //Metodo que obtiene de forma de lista de Categoria
        {
            DataTable dt = new DataTable("Modelo");
            dt.Columns.Add("Id");
            dt.Columns.Add("Nombre");

            try
            {
                sql = "SELECT id, nombre FROM modelo;";
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

        private void mostrarModelo()
        {
            try
            {
                //Cargar los Atributos de Categoria
                #region
                cbxModelo.DataSource = listarModelo();
                cbxModelo.DisplayMember = "Nombre";
                cbxModelo.ValueMember = "Id";
                cbxModelo.SelectedIndex = 0;
                cbxModelo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cbxModelo.AutoCompleteSource = AutoCompleteSource.ListItems;
                #endregion

                #region
                dgvProducto.DataSource = listarModelo();
                dgvProducto.Columns[0].Visible = false;
                dgvProducto.Columns[1].Visible = false;
                dgvProducto.Columns[2].Visible = false;
                dgvProducto.Columns[3].Visible = false;
                dgvProducto.Columns[4].Visible = false;
                #endregion
            }
            catch
            {

            }
        }

        private DataTable listarCategoria() //Metodo que obtiene de forma de lista de Categoria
        {
            DataTable dt = new DataTable("Categoria");
            dt.Columns.Add("Id");
            dt.Columns.Add("Nombre");

            try
            {
                sql = "SELECT id, nombre FROM categoria;";
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

        private void mostrarCategoria()
        {
            try
            {
                //Cargar los Atributos de Categoria
                #region
                cbxCategoria.DataSource = listarCategoria();
                cbxCategoria.DisplayMember = "Nombre";
                cbxCategoria.ValueMember = "Id";
                cbxCategoria.SelectedIndex = 0;
                cbxCategoria.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cbxCategoria.AutoCompleteSource = AutoCompleteSource.ListItems;
                #endregion

                #region
                dgvProducto.DataSource = listarCategoria();
                dgvProducto.Columns[0].Visible = false;
                dgvProducto.Columns[1].Visible = false;
                dgvProducto.Columns[2].Visible = false;
                dgvProducto.Columns[3].Visible = false;
                dgvProducto.Columns[4].Visible = false;
                #endregion
            }
            catch
            {

            }
        }

        private DataTable listarColor() //Metodo que obtiene de forma de lista de Categoria
        {
            DataTable dt = new DataTable("Color");
            dt.Columns.Add("Id");
            dt.Columns.Add("Nombre");

            try
            {
                sql = "SELECT id, nombre FROM color;";
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

        private void mostrarColor()
        {
            try
            {
                //Cargar los Atributos de Categoria
                #region
                cbxColor.DataSource = listarColor();
                cbxColor.DisplayMember = "Nombre";
                cbxColor.ValueMember = "Id";
                cbxColor.SelectedIndex = 0;
                cbxColor.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cbxColor.AutoCompleteSource = AutoCompleteSource.ListItems;
                #endregion

                #region
                dgvProducto.DataSource = listarColor();
                dgvProducto.Columns[0].Visible = false;
                dgvProducto.Columns[1].Visible = false;
                dgvProducto.Columns[2].Visible = false;
                dgvProducto.Columns[3].Visible = false;
                dgvProducto.Columns[4].Visible = false;
                #endregion
            }
            catch
            {

            }
        }
        private void FrmProducto_Load(object sender, EventArgs e)
        {
            mostrarModelo();
            mostrarMarca();
            mostrarProducto();
            mostrarCategoria();
            mostrarColor();
        }

        private DataTable listarMarca()
        {
            DataTable dt = new DataTable("Marca");
            dt.Columns.Add("Id");
            dt.Columns.Add("Marca");

            try
            {
                sql = "SELECT nombre FROM marca;";
                List<Marca> marcaLista = MarcaDAO.getInstance().Listar(sql);
                for (int i = 0; i < marcaLista.Count; i++)
                {
                    dt.Rows.Add(marcaLista[i].nombre);
                }
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return dt;
            }
        }

        private void mostrarMarca()
        {
            try
            {
                //Cargar los Atributos de Categoria
                #region
                cbxMarca.DataSource = listarMarca();
                cbxMarca.DisplayMember = "Nombre";
                cbxMarca.ValueMember = "Id";
                cbxMarca.SelectedIndex = 0;
                cbxMarca.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cbxMarca.AutoCompleteSource = AutoCompleteSource.ListItems;
                #endregion

                #region
                dgvProducto.DataSource = listarMarca();
                dgvProducto.Columns[0].Visible = false;
                dgvProducto.Columns[1].Visible = false;
                dgvProducto.Columns[2].Visible = false;
                dgvProducto.Columns[3].Visible = false;
                dgvProducto.Columns[4].Visible = false;
                #endregion
            }
            catch
            {

            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void limpiarRegistro()
        {
            txtId.Clear();
            txtCodigoBarras.Clear();
            txtPeso.Clear();
            txtPrecio.Clear();
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {

            limpiarRegistro();
        }

        
=======
        private void FrmProducto_Load(object sender, EventArgs e)
        {

        }
>>>>>>> origin/Registro:BlingLuxury/Vistas/FrmProducto.cs
    }
}
