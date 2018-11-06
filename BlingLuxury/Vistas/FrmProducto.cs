using BlingLuxury.Clases;
using BlingLuxury.Connection;
using BlingLuxury.DAO;
using BlingLuxury.Validaciones;
using BlingLuxury.Vistas;
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
        #region Variables
        protected string sql;
        protected int id;
        DataTable dt = new DataTable();
        #endregion
        /// <summary>
        /// hhhhhhhhhhhhhhhhhhhhhddddd
        /// </summary>
        #region Interaccion BD
        #region Modificar        
        private void Modificar()//metodo para Modificar 
        {
            //if (Convert.ToInt32(cbxNivel.SelectedValue) == 1 || Convert.ToInt32(cbxNivel.SelectedValue) == 2)
            //{
                if (txtPeso.Text.Length > 0 && txtCodigoBarras.Text.Length > 0)
                {
                    DataTable df = BuscarConId(Convert.ToInt32(txtId.Text), txtCodigoBarras.Text);//envia a buscar el producto

                    if (df.Rows.Count == 0)//si no hay resultados realiza la insercion
                    {
                    ProductoDAO.getInstance().Actualizar(new Producto(Convert.ToDouble(txtPeso.Text), new Modelo(Convert.ToInt32(cbxModelo.SelectedValue)), new PrecioAdquisicion(Convert.ToInt32(cbxPrecios.SelectedValue)), new Clases.Color(Convert.ToInt32(cbxColor.SelectedValue)), new Categoria(Convert.ToInt32(cbxCategoria.SelectedValue))), id);
                    MessageBox.Show("Producto modificado exitosamente", "Modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvProducto.DataSource = listarRegistroProducto();//actualiza el datagridview                    
                    }
                    if (df.Rows.Count >= 1)
                    {
                        MessageBox.Show("Ya existe un Producto con ese Código. Intente otro", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Falta agregar datos", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }            
        #endregion
        #region Insertar        
        private void Insertar()//Metodo para Insertar Productos
        {

            try
            {
                ProductoDAO.getInstance().Insertar(new Producto(Convert.ToString(txtCodigoBarras.Text), Convert.ToDouble(txtPeso.Text), new Modelo(Convert.ToInt32(cbxModelo.SelectedValue), new Marca(Convert.ToInt32(cbxMarca.SelectedValue))), new PrecioAdquisicion(Convert.ToInt32(cbxPrecios.SelectedValue)), new Clases.Color(Convert.ToInt32(cbxColor.SelectedValue)), new Categoria(Convert.ToInt32(cbxCategoria.SelectedValue))));
                MessageBox.Show("Producto agrego correctamente", "Producto Agregado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                mostrarRegistroProducto();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        #region busqueda para modificar        
        public static DataTable BuscarConId(int id, string codigoDeBarras)//para evitar duplicados
        {
            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT id, codigo_de_barras FROM producto WHERE codigo_de_barras = @codigo_de_barras AND NOT id = @id;";
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
        #region Buscar
        public static DataTable Buscar(string codigoDeBarras)//para evitar codigo de barras duplicados
        {
            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT id, codigo_de_barras FROM producto WHERE codigo_de_barras= @codigo_de_barras;";
                Conexion.getInstance().setCadenaConnection();
                MySqlCommand cmd = new MySqlCommand(sql, Conexion.getInstance().getConnection());
                cmd.Parameters.AddWithValue("@codigo_de_barras", codigoDeBarras);
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
        #endregion

        #region Metodos Formulario
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
                    //marcaLista[i].id,
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
        #region Producto
        DataTable dr = new DataTable();
        public DataTable listarRegistroProducto() //Metodo que obtiene en forma de lista
        {
            DataTable dt = new DataTable("Registro Productos");
            dt.Columns.Add("Id");
            dt.Columns.Add("CodigoBarras");
            dt.Columns.Add("Peso");
            dt.Columns.Add("Modelo Id");
            dt.Columns.Add("Modelo");
            dt.Columns.Add("Marca Id");
            dt.Columns.Add("Marca");
            dt.Columns.Add("Precio Adquisicion Id");
            dt.Columns.Add("Precio");
            dt.Columns.Add("Color Id");
            dt.Columns.Add("Color");
            dt.Columns.Add("Categoria Id");
            dt.Columns.Add("Categoria");

            dgvProducto.DataSource = dt;
            //dr = dt;

            try
            {
                sql = "select producto.id, producto.codigo_de_barras, producto.peso, producto.id_modelo, modelo.nombre, modelo.id_marca, marca.nombre, ";
                sql += "producto.id_precio_adquisicion, precio_adquisicion.precio, producto.id_color, color.nombre, producto.id_categoria, categoria.nombre ";
                sql += "from producto inner join modelo on modelo.id = producto.id_modelo inner join marca on marca.id = modelo.id_marca ";
                sql += "inner join precio_adquisicion on precio_adquisicion.id = producto.id_precio_adquisicion ";
                sql += "inner join color on color.id = producto.id_color inner join categoria on categoria.id = producto.id_categoria ";
                sql += "order by producto.id desc ;";
                //sql = "SELECT id, codigo_de_barras, peso, id_modelo, id_precio_adquisicion, id_color, id_categoria FROM producto;";
                //List<Producto> listaProducto = ProductoDAO.getInstance().Listar(sql);
                List<RegistroProducto> listarRegistroProducto = RegistroProductoDAO.getInstance().Listar(sql);
                for (int i = 0; i < listarRegistroProducto.Count; i++)
                {
                    dt.Rows.Add(listarRegistroProducto[i].idProducto, listarRegistroProducto[i].codigoProducto, listarRegistroProducto[i].pesoProducto,
                                listarRegistroProducto[i].productoIdModelo.id, listarRegistroProducto[i].productoIdModelo.nombre, listarRegistroProducto[i].modeloIdMarca.id, listarRegistroProducto[i].modeloIdMarca.nombre,
                                listarRegistroProducto[i].productoIdPrecio_adquisicion.id,
                                listarRegistroProducto[i].productoIdPrecio_adquisicion.precio, listarRegistroProducto[i].productoIdColor.id, listarRegistroProducto[i].productoIdColor.nombre,
                                listarRegistroProducto[i].productoIdCategoria.id, listarRegistroProducto[i].productoIdCategoria.nombre);
                    ////Solo para ver si lista el dgvProducto quite estos campos del dt.Rows.Add listarRegistroProducto[i].modeloIdMarca.id, listarRegistroProducto[i].modeloIdMarca.nombre,
                    //dt.Rows.Add(listaProducto[i].id, listaProducto[i].codigoDeBarras, listaProducto[i].peso, listaProducto[i].id_modelo.nombre,
                    //listaProducto[i].id_precio_adquisicion.precio, listaProducto[i].id_color.nombre, listaProducto[i].id_categoria.nombre);
                }
                return dt;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return dt;
            }
        }
        public void mostrarRegistroProducto()
        {
            try
            {

                #region
                dgvProducto.DataSource = listarRegistroProducto();
                //dgvProducto.Columns[0].Visible = true; // Id
                //dgvProducto.Columns[1].Visible = true; //CodigoBarras
                //dgvProducto.Columns[2].Visible = true; //Peso
                dgvProducto.Columns[3].Visible = false; // ModeloId
                //dgvProducto.Columns[4].Visible = true; //Modelo
                dgvProducto.Columns[5].Visible = false; //MarcaId
                //dgvProducto.Columns[6].Visible = true; //Marca
                dgvProducto.Columns[7].Visible = false; //PrecioIdAdquisicion 
                //dgvProducto.Columns[8].Visible = true; //Precio
                dgvProducto.Columns[9].Visible = false; // ColorId
                //dgvProducto.Columns[10].Visible = true; //Color
                dgvProducto.Columns[11].Visible = false; // CategoriaId
                //dgvProducto.Columns[12].Visible = true; //Categoria 
                #endregion
            }
            catch
            {

            }
        }

        //Para buscar por el codigo de barras en el Gridview
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();

            bs.DataSource = dgvProducto.DataSource;
            bs.Filter = $"CodigoBarras like '%" + txtBuscar.Text + "%'";
            dgvProducto.DataSource = bs;
        }
        //    foreach (DataGridViewRow Row in dgvProducto.Rows)
        //    {
        //        string strFila = Row.Index.ToString();
        //        string valor = Convert.ToString(Row.Cells["Id"].Value);

        //        if (valor == this.txtBuscar.Text)
        //        {
        //            dgvProducto.Rows[Convert.ToInt32(strFila)].DefaultCellStyle.BackColor = System.Drawing.Color.Red;
        //        }
        //    }
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
            mostrarRegistroProducto();
            mostrarMarca();
            mostrarCategoria();
            mostrarColor();
            mostrarModelo();
            mostrarPrecio();
            //this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            //this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }
        private void limpiarRegistro()
        {
            txtId.Clear();
            txtCodigoBarras.Clear();
            txtPeso.Clear();
            cbxPrecios.SelectedIndex = 0;
            cbxCategoria.SelectedIndex = 0;
            cbxColor.SelectedIndex = 0;
            cbxModelo.SelectedIndex = 0;
            cbxMarca.SelectedIndex = 0;
        }
        //Para colocar los datos en una fila del datagridview en los texbox y combobox
        private void dgvProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            //txtId.Text = dgvProducto.Rows[e.RowIndex].Cells["Id"].Value.ToString();
            txtId.Text = dgvProducto.CurrentRow.Cells[0].Value.ToString();
            txtCodigoBarras.Text = dgvProducto.Rows[e.RowIndex].Cells["CodigoBarras"].Value.ToString();
            txtPeso.Text = dgvProducto.Rows[e.RowIndex].Cells["Peso"].Value.ToString();
            cbxModelo.SelectedValue = dgvProducto.Rows[e.RowIndex].Cells["Modelo Id"].Value;
            //cbxModelo.SelectedValue = dgvProducto.Rows[e.RowIndex].Cells["Modelo"].Value;
            cbxMarca.SelectedValue = dgvProducto.Rows[e.RowIndex].Cells["Marca Id"].Value;
            //cbxMarca.SelectedValue = dgvProducto.Rows[e.RowIndex].Cells["Marca"].Value;
            cbxPrecios.SelectedValue = dgvProducto.Rows[e.RowIndex].Cells["Precio Adquisicion Id"].Value.ToString();
            //txtPrecio.Text = dgvProducto.Rows[e.RowIndex].Cells["Precio"].Value.ToString();
            cbxColor.SelectedValue = dgvProducto.Rows[e.RowIndex].Cells["Color Id"].Value;
            //cbxColor.SelectedValue = dgvProducto.Rows[e.RowIndex].Cells["Color"].Value;
            cbxCategoria.SelectedValue = dgvProducto.Rows[e.RowIndex].Cells["Categoria Id"].Value;
            //cbxCategoria.SelectedValue = dgvProducto.Rows[e.RowIndex].Cells["Categoria"].Value; 

            id = Convert.ToInt32(txtId.Text);
        }
        #endregion        

        #region Eventos
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
            // mostrarRegistroProducto();
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            Modificar();
            limpiarRegistro();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnMin_Click(object sender, EventArgs e)
        {
            //Minimizar
            WindowState = FormWindowState.Minimized;
        }
        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                //Maximizar
                WindowState = FormWindowState.Maximized;
            }
            else if (WindowState == FormWindowState.Maximized)
            {
                //Restaurar
                WindowState = FormWindowState.Normal;
            }
        }
        #endregion        

        #region Validaciones
        private void txtCodigoBarras_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
            //MessageBox.Show("Solo se admiten Números", "¡¡¡No Letras!!!"); 
            if (txtCodigoBarras.TextLength >= 13)
            {
                MessageBox.Show("El código de barras no tiene que sobre pasar 13 digitos. \n Verifique el campo", "ADVERTENCIA", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

                e.Handled = false;
            }
        }
        private void txtPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloDecimales(e);
            //if (e.KeyChar == 8)
            //{
            //    e.Handled = false;
            //    return;
            //}
            //bool IsDec = false;
            //int nroDec = 0;

            //for (int i = 0; i < txtPeso.Text.Length; i++)
            //{
            //    if (txtPeso.Text[i] == '.')
            //        IsDec = true;

            //    if (IsDec && nroDec++ >= 3)
            //    {
            //        e.Handled = true;
            //        return;
            //    }
            //}
            //if (e.KeyChar >= 48 && e.KeyChar <= 57)
            //    e.Handled = false;
            //else if (e.KeyChar == 46)
            //    e.Handled = (IsDec) ? true : false;
            //else
            //    e.Handled = true;
        }
        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloDecimales(e);
            //if (e.KeyChar == 8)
            //{
            //    e.Handled = false;
            //    return;
            //}
            //bool IsDec = false;
            //int nroDec = 0;

            //for (int i = 0; i < txtPeso.Text.Length; i++)
            //{
            //    if (txtPeso.Text[i] == '.')
            //        IsDec = true;

            //    if (IsDec && nroDec++ >= 2)
            //    {
            //        e.Handled = true;
            //        return;
            //    }
            //}
            //if (e.KeyChar >= 48 && e.KeyChar <= 57)
            //    e.Handled = false;
            //else if (e.KeyChar == 46)
            //    e.Handled = (IsDec) ? true : false;
            //else
            //    e.Handled = true;
        }
        //26 nuevos formularios
        private void btnCategoria_Click(object sender, EventArgs e)
        {
            mostrarCategoria();
            frmCategoria categoriafrm = new frmCategoria();            
            categoriafrm.enviado += new frmCategoria.pasarCategoria(realizar);            
            categoriafrm.Show();
                           
        }
        public void realizar(string categoria)
        {
            cbxCategoria.Text = categoria;                               
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            frmColor colorfrm = new frmColor();
            colorfrm.enviado += new frmColor.pasarColor(realizar1);
            colorfrm.Show();
            mostrarColor();
        }
        public void realizar1(string color)
        {
            cbxColor.Text = color;
        }

        private void cbxCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
           // mostrarCategoria();
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);

            if (txtBuscar.TextLength >= 13)
            {
                MessageBox.Show("!!!ERROR AL BUSCAR, SOLO NÚMEROS¡¡¡", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                e.Handled = false;
            }
        }

        private void btnModelo_Click(object sender, EventArgs e)
        {
            frmModelo modelofrm = new frmModelo();
            modelofrm.enviado += new frmModelo.pasarModelo(realizar2);
            modelofrm.Show();
            mostrarModelo();
        }
        public void realizar2(string modelo)
        {
            cbxModelo.Text = modelo;
        }

        private void btnMarca_Click(object sender, EventArgs e)
        {
            mostrarMarca();
            frmMarca marcafrm = new frmMarca();
            marcafrm.enviado += new frmMarca.pasarMarca(realizar3);
            marcafrm.Show();
        }
        public void realizar3(string marca)
        {
            cbxMarca.Text = marca;
        }
    }
}
#endregion
