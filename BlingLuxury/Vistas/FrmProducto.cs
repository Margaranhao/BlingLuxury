using BlingLuxury.Clases;
using BlingLuxury.Connection;
using BlingLuxury.DAO;
using BlingLuxury.Validaciones;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
        protected string sql;
        private void Insertar()//Metodo para Insertar Productos
        {
            try
            {             
                ProductoDAO.getInstance().Insertar(new Producto(Convert.ToInt32(txtCodigoBarras.Text), Convert.ToDouble(txtPeso.Text), new Modelo(Convert.ToInt32(cbxModelo.SelectedValue)), new PrecioAdquisicion(Convert.ToInt32(txtPrecio.Text)), new Clases.Color(Convert.ToInt32(cbxColor.SelectedValue)), new Categoria(Convert.ToInt32(cbxCategoria.SelectedValue))));        
                MessageBox.Show("Se agrego correctamente", "Agregado");
                mostrarProducto();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        #region busqueda para modificar
        public static DataTable BuscarConId(int id, int codigoDeBarras)//para evitar duplicados
        {
            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT id, codigo_de_barras FROM producto WHERE codigo_de_barras = @codigo_de_barras, AND NOT id= @id;";
                Conexion.getInstance().setCadenaConnection();
                MySqlCommand cmd = new MySqlCommand(sql, Conexion.getInstance().getConnection());
                cmd.Parameters.AddWithValue("@codigo_de_barras", codigoDeBarras);
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


        #region Producto
        public DataTable listarProducto()
        {
            DataTable dt = new DataTable("Productos");
            dt.Columns.Add("Id");
            dt.Columns.Add("Codigo de Barras");
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
                    dt.Rows.Add(listaProducto[i].id, listaProducto[i].codigoDeBarras, listaProducto[i].peso, listaProducto[i].id_modelo.nombre, listaProducto[i].id_precio_adquisicion.precio, listaProducto[i].id_color.nombre, listaProducto[i].id_categoria.nombre);
                }
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return dt;
            }
        }

        public void mostrarProducto()
        {
            try
            {

                #region
                dgvProducto.DataSource = listarProducto();
                dgvProducto.Columns[0].Visible = true;
                dgvProducto.Columns[1].Visible = true;
                dgvProducto.Columns[2].Visible = true;
                dgvProducto.Columns[3].Visible = true;
                dgvProducto.Columns[4].Visible = true;
                dgvProducto.Columns[5].Visible = true;
                dgvProducto.Columns[6].Visible = true;
                #endregion
            }
            catch
            {

            }
        }
        #endregion Producto

        #region Categoria

        public DataTable listarCategoria() //Metodo que obtiene de forma de lista de Categoria
        {
            DataTable dt = new DataTable("Categoria");
            dt.Columns.Add("Id");
            dt.Columns.Add("Nombre");

            try
            {
                sql = "SELECT id, nombre FROM categoria ORDER BY nombre;";
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

        public void mostrarCategoria()
        {
            try
            {
                //Cargar los Atributos de Categoria
                #region
                cbxCategoria.DataSource = listarCategoria();
                cbxCategoria.DisplayMember = "Nombre";
                cbxCategoria.ValueMember = "id";
                cbxCategoria.SelectedIndex = 0;
                cbxCategoria.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cbxCategoria.AutoCompleteSource = AutoCompleteSource.ListItems;
                #endregion
            }
            catch
            {

            }
        }
        #endregion Categoria

        #region Color
        public DataTable listarColor() //Metodo que obtiene de forma de lista de Color
        {
            DataTable dt = new DataTable("Color");
            dt.Columns.Add("Id");
            dt.Columns.Add("Nombre");

            try
            {
                sql = "SELECT id, nombre FROM color ORDER BY nombre;";
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

        public void mostrarColor()
        {
            try
            {
                //Cargar los Atributos de Color
                #region
                cbxColor.DataSource = listarColor();
                cbxColor.DisplayMember = "Nombre";
                cbxColor.ValueMember = "id";
                cbxColor.SelectedIndex = 0;
                cbxColor.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cbxColor.AutoCompleteSource = AutoCompleteSource.ListItems;
                #endregion
            }
            catch
            {

            }
        }
        #endregion Color

        #region Modelo
        public DataTable listarModelo() //Metodo que obtiene de forma de lista de Modelo
        {
            DataTable dt = new DataTable("Modelo");
            dt.Columns.Add("Id");
            dt.Columns.Add("Nombre");

            try
            {
                sql = "SELECT id, nombre FROM modelo ORDER BY nombre;";
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

        public void mostrarModelo()
        {
            try
            {
                //Cargar los Atributos de Modelo
                #region
                cbxModelo.DataSource = listarModelo();
                cbxModelo.DisplayMember = "Nombre";
                cbxModelo.ValueMember = "id";
                cbxModelo.SelectedIndex = 0;
                cbxModelo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cbxModelo.AutoCompleteSource = AutoCompleteSource.ListItems;
                #endregion
            }
            catch
            {

            }
        }
        #endregion Modelo
        private void FrmProducto_Load(object sender, EventArgs e)
        {
            mostrarProducto();
            mostrarMarca();
            mostrarCategoria();
            mostrarColor();
            mostrarModelo();
            mostrarPrecio();
        }

        #region Marca
        public DataTable listarMarca()
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

        public void mostrarMarca()
        {
            try
            {
                //Cargar los Atributos de Marca
                #region
                cbxMarca.DataSource = listarMarca();
                cbxMarca.DisplayMember = "Nombre";
                cbxMarca.ValueMember = "id";
                cbxMarca.SelectedIndex = 0;
                cbxMarca.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cbxMarca.AutoCompleteSource = AutoCompleteSource.ListItems;
                #endregion
            }
            catch
            {

            }
        }
        #endregion Marca

        #region Precios


        public DataTable listarPrecio()
        {
            DataTable dt = new DataTable("Precio Adquisicion");
            dt.Columns.Add("Id");
            dt.Columns.Add("Precio");

            try
            {
                sql = "SELECT id, precio FROM precio_adquisicion;";
                List<PrecioAdquisicion> precioLista = PrecioAdquisicionDAO.getInstance().Listar(sql);
                for (int i = 0; i < precioLista.Count; i++)
                {
                    dt.Rows.Add(precioLista[i].id, precioLista[i].precio);
                }
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return dt;
            }
        }

        public void mostrarPrecio()
        {
            try
            {
                //Cargar los Atributos de Precio Adquisicion
                #region
                cbxPrecios.DataSource = listarPrecio();
                cbxPrecios.DisplayMember = "Precio";
                cbxPrecios.ValueMember = "id";
                cbxPrecios.SelectedIndex = 0;
                cbxPrecios.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cbxPrecios.AutoCompleteSource = AutoCompleteSource.ListItems;
                #endregion
            }
            catch
            {

            }
        }

        #endregion Precios
        private void limpiarRegistro()
        {
            txtId.Clear();
            txtCodigoBarras.Clear();
            txtPeso.Clear();
            txtPrecio.Clear();
            cbxCategoria.SelectedIndex = 0;
            cbxColor.SelectedIndex = 0;
            cbxModelo.SelectedIndex = 0;
            cbxMarca.SelectedIndex = 0;
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            limpiarRegistro();
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            Insertar();
            limpiarRegistro();
        }

        private void Modificar()//metodo para Modificar 
        {
            //ProductoDAO.getInstance().Actualizar(new Producto(Convert.ToInt32(txtCodigoBarras.Text), Convert.ToDouble(txtPeso.Text), new Modelo(Convert.ToInt32(cbxModelo.SelectedValue)), new PrecioAdquisicion(Convert.ToInt32(txtPrecio.Text)), new Clases.Color(Convert.ToInt32(cbxColor.SelectedValue)), new Categoria(Convert.ToInt32(cbxCategoria.SelectedValue))));
            //if (Convert.ToInt32(cbxModelo.SelectedValue) <= 0)
            //{
            //    MessageBox.Show("No se ha seleccionado ningun modelo");
            //}
            if ((txtCodigoBarras.Text.Length > 0 && txtPeso.Text.Length > 0) && txtPrecio.Text.Length > 0)
            {
                DataTable df = BuscarConId(Convert.ToInt32(txtId.Text), Convert.ToInt32(txtCodigoBarras.Text));//envia a buscar el producto 

                if (df.Rows.Count == 0)//si no hay resultados realiza la insercion
                {
                    ProductoDAO.getInstance().Insertar(new Producto(Convert.ToInt32(txtCodigoBarras.Text), Convert.ToDouble(txtPeso.Text), new Modelo(Convert.ToInt32(cbxModelo.SelectedValue)), new PrecioAdquisicion(Convert.ToInt32(txtPrecio.Text)), new Clases.Color(Convert.ToInt32(cbxColor.SelectedValue)), new Categoria(Convert.ToInt32(cbxCategoria.SelectedValue))));
                    MessageBox.Show("Producto modificado exitosamente");
                    dgvProducto.DataSource = listarProducto();//actualiza el datagridview                    
                }
                if (df.Rows.Count >= 1)
                {
                    MessageBox.Show("Ya existe un producto con ese codigo. Intente otro");
                }
            }
        }
        //Para colocar los datos en una fila del datagridview en los texbox y combobox
        private void dgvProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvProducto.Rows[e.RowIndex].Cells["Id"].Value.ToString();
            txtCodigoBarras.Text = dgvProducto.Rows[e.RowIndex].Cells["Codigo de Barras"].Value.ToString();
            txtPeso.Text = dgvProducto.Rows[e.RowIndex].Cells["Peso"].Value.ToString();
            txtPrecio.Text = dgvProducto.Rows[e.RowIndex].Cells["PrecioIdAdquisicion"].Value.ToString();
            cbxCategoria.SelectedValue = dgvProducto.Rows[e.RowIndex].Cells["CategoriaId"].Value;
            cbxModelo.SelectedValue = dgvProducto.Rows[e.RowIndex].Cells["ModeloId"].Value;
            cbxColor.SelectedValue = dgvProducto.Rows[e.RowIndex].Cells["ColorId"].Value;
            //cbxMarca.SelectedValue = dgvProducto.Rows[e.RowIndex].Cells["MarcaId"].Value;

        }

        private void gbxProducto_Enter(object sender, EventArgs e)
        {

        }

        private void gbxProducto1_Enter(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pbxImagen_Click(object sender, EventArgs e)
        {

        }

        private void lblMarca_Click(object sender, EventArgs e)
        {

        }

        private void txtCodigoBarras_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCodigoBarras_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);

            if (txtCodigoBarras.TextLength >= 13)
            {
                MessageBox.Show("el código de barras debe tener 13 digitos. \n Verifique el campo.", "!!!ERROR¡¡¡");

                e.Handled = false;

            }
        }

        private void txtPeso_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == 8)
            {
                e.Handled = false;
                return;
            }


            bool IsDec = false;
            int nroDec = 0;

            for (int i = 0; i < txtPeso.Text.Length; i++)
            {
                if (txtPeso.Text[i] == '.')
                    IsDec = true;

                if (IsDec && nroDec++ >= 3)
                {
                    e.Handled = true;
                    return;
                }


            }

            if (e.KeyChar >= 48 && e.KeyChar <= 57)
                e.Handled = false;
            else if (e.KeyChar == 46)
                e.Handled = (IsDec) ? true : false;
            else
                e.Handled = true;

        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8)
            {
                e.Handled = false;
                return;
            }


            bool IsDec = false;
            int nroDec = 0;

            for (int i = 0; i < txtPeso.Text.Length; i++)
            {
                if (txtPeso.Text[i] == '.')
                    IsDec = true;

                if (IsDec && nroDec++ >= 2)
                {
                    e.Handled = true;
                    return;
                }


            }

            if (e.KeyChar >= 48 && e.KeyChar <= 57)
                e.Handled = false;
            else if (e.KeyChar == 46)
                e.Handled = (IsDec) ? true : false;
            else
                e.Handled = true;

        }

        private void flpProducto_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Modificar();
        }
    }
}


