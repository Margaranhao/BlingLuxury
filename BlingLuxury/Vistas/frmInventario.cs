using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using BlingLuxury.Clases;
using BlingLuxury.Connection;
using BlingLuxury.Validaciones;
using BlingLuxury.DAO;
using System.IO;

namespace BlingLuxury
{
    public partial class frmInventario : Form
    {
        #region variables

        protected string sql; //variable para las consultas

        #endregion

        #region eventos del formulario
        public frmInventario()
        {
            InitializeComponent();
        }

        private void frmInventario_Load(object sender, EventArgs e)
        {
            mostrarInvenario();
            mostrarRegistroProducto();
            MostrarImagen();
        }
        #region radiobuttons
        private void frmInventario_Shown(object sender, EventArgs e)// coloca en automatico activo el radiobutton de inventario
        {
            rbnInventario.Checked = true;
            rbnProductos.Checked = false;
        }

        private void rbnInventario_CheckedChanged(object sender, EventArgs e)// cambia el estado para mostrar la tabla de inventario
        {
            if (rbnInventario.Checked == true)
            {
                rbnProductos.Checked = false;
                dgvInventario.Visible = true;
                dgvProductos.Visible = false;
            }
        }
        private void rbnProductos_CheckedChanged(object sender, EventArgs e)// cambia el estado para mostrar la tabla de productos sin inventariar
        {
            if (rbnProductos.Checked == true)
            {
                rbnInventario.Checked = false;
                dgvInventario.Visible = false;
                dgvProductos.Visible = true;
            }
        }
        #endregion
        #endregion

        #region Limpiar registro
        private void LimpiarInventario()// para limpiar los campos del formulario
        {
            txtId.Clear();
            txtModelo.Clear();
            txtMarca.Clear();
            txtColor.Clear();
            txtPrecio.Clear();
            txtCantidad.Clear();
            txtFecha.Clear();
            txtCategoria.Clear();
            txtCodBarras.Clear();
            pbxImagen.Image = System.Drawing.Image.FromFile("C:\\BlingPicture\\default.png");

        }
        #endregion

        #region Cargar Datos al dgv de Inventario
        DataTable dr = new DataTable();//tabla para las busquedas

        public DataTable ListarInventario() // Metodo que obtiene en forma de lista
        {
            DataTable dt = new DataTable("Inventario");
            dt.Columns.Add("Id");
            dt.Columns.Add("Fecha");
            dt.Columns.Add("Cantidad");
            dt.Columns.Add("Codigo de Barras");
            dt.Columns.Add("Modelo");
            dt.Columns.Add("Marca");
            dt.Columns.Add("Precio");
            dt.Columns.Add("Color");
            dt.Columns.Add("Categoria");

            dgvInventario.DataSource = dt;
            dr = dt;

            try
            {
                sql = "select i.id, i.fecha, i.cantidad, p.codigo_de_barras, m.nombre, ma.nombre,  pr.precio, c.nombre,  cat.nombre "
                        + "FROM inventario i "
                        + "INNER JOIN producto p ON i.id_producto = p.id "
                        + "INNER JOIN modelo m ON p.id_modelo = m.id "
                        + "INNER JOIN marca ma ON m.id_marca = ma.id "
                        + "INNER JOIN color c ON p.id_color = c.id "
                        + "INNER JOIN precio_adquisicion pr ON p.id_precio_adquisicion = pr.id "
                        + "INNER JOIN categoria cat ON p.id_categoria = cat.id "
                        + "WHERE i.cantidad > 0;";
                List<Inventario> inventarioList = InventarioDAO.getInstance().Listar(sql);
                for (int i = 0; i < inventarioList.Count; i++)
                {
                    dt.Rows.Add(inventarioList[i].id, inventarioList[i].fecha, inventarioList[i].cantidad,
                                inventarioList[i].id_registroProducto.codigoProducto, inventarioList[i].id_modelo.nombre,
                                inventarioList[i].id_marca.nombre, inventarioList[i].id_precioAdquisicion.precio,
                                inventarioList[i].id_color.nombre, inventarioList[i].id_categoria.nombre);
                }
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return dt;
            }
        }

        public void mostrarInvenario() // metodo que muestra el inventario
        {
            try
            {
                dgvInventario.DataSource = ListarInventario();
                dgvInventario.Columns[0].Visible = false;
                dgvInventario.Columns[1].Visible = true;
                dgvInventario.Columns[2].Visible = true;
                dgvInventario.Columns[3].Visible = true;
                dgvInventario.Columns[4].Visible = true;
                dgvInventario.Columns[5].Visible = true;
                dgvInventario.Columns[6].Visible = true;
                dgvInventario.Columns[7].Visible = true;
                dgvInventario.Columns[8].Visible = true;

                

            }
            catch
            {

            }
        }

        private void dgvInventario_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Remarca en color verde las columnas donde se encuentran gran cantidad de productos disponibles
            if (this.dgvInventario.Columns[e.ColumnIndex].Name == "Cantidad")
            {
                if (Convert.ToInt32(e.Value) <= 10)
                {
                    //e.CellStyle.ForeColor = System.Drawing.Color.Red;
                    e.CellStyle.BackColor = System.Drawing.Color.Orange;
                }
                if (Convert.ToInt32(e.Value) > 10)
                {
                    e.CellStyle.BackColor = System.Drawing.Color.Green;
                }
            }
        }

        #endregion

        #region Cargar Datos al dgv de Productos

        public DataTable listarProducto()//metodo que enlista los productos
        {
            DataTable dt = new DataTable("Producto");
            dt.Columns.Add("Id");
            dt.Columns.Add("Fecha");
            dt.Columns.Add("Cantidad");
            dt.Columns.Add("Codigo de Barras");
            dt.Columns.Add("Modelo");
            dt.Columns.Add("Marca");
            dt.Columns.Add("Precio");
            dt.Columns.Add("Color");
            dt.Columns.Add("Categoria");

            dgvProductos.DataSource = dt;
            dr = dt;

            try
            {
                sql = "select i.id, i.fecha, i.cantidad, p.codigo_de_barras, m.nombre, ma.nombre,  pr.precio, c.nombre,  cat.nombre "
                        + "FROM inventario i "
                        + "INNER JOIN producto p ON i.id_producto = p.id "
                        + "INNER JOIN modelo m ON p.id_modelo = m.id "
                        + "INNER JOIN marca ma ON m.id_marca = ma.id "
                        + "INNER JOIN color c ON p.id_color = c.id "
                        + "INNER JOIN precio_adquisicion pr ON p.id_precio_adquisicion = pr.id "
                        + "INNER JOIN categoria cat ON p.id_categoria = cat.id "
                        + "WHERE i.cantidad = 0;";
                List<Inventario> inventarioList = InventarioDAO.getInstance().Listar(sql);
                for (int i = 0; i < inventarioList.Count; i++)
                {
                    dt.Rows.Add(inventarioList[i].id, inventarioList[i].fecha, inventarioList[i].cantidad,
                                inventarioList[i].id_registroProducto.codigoProducto, inventarioList[i].id_modelo.nombre,
                                inventarioList[i].id_marca.nombre, inventarioList[i].id_precioAdquisicion.precio,
                                inventarioList[i].id_color.nombre, inventarioList[i].id_categoria.nombre);
                }
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return dt;
            }
        }

        private void mostrarRegistroProducto()// Metodo que muestra el producto
        {
            try
            {
                dgvProductos.DataSource = listarProducto();
                dgvProductos.Columns[0].Visible = false;
                dgvProductos.Columns[1].Visible = true;
                dgvProductos.Columns[2].Visible = true;
                dgvProductos.Columns[3].Visible = true;
                dgvProductos.Columns[4].Visible = true;
                dgvProductos.Columns[5].Visible = true;
                dgvProductos.Columns[6].Visible = true;
                dgvProductos.Columns[7].Visible = true;
                dgvProductos.Columns[8].Visible = true;
            }
            catch
            {

            }
        }

        private void dgvProductos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Marca en color rojo las columnas donde ya no hay productos inventariados
            if (this.dgvProductos.Columns[e.ColumnIndex].Name == "Cantidad")
            {
                if (Convert.ToInt32(e.Value) == 0)
                {
                    e.CellStyle.BackColor = System.Drawing.Color.Red;
                }
            }

        }

        #endregion

        #region Cargar datos del dgvInventario al frm
        private void dgvInventario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvInventario.Rows[e.RowIndex].Cells["Id"].Value.ToString();
            txtModelo.Text = dgvInventario.Rows[e.RowIndex].Cells["Modelo"].Value.ToString();
            txtMarca.Text = dgvInventario.Rows[e.RowIndex].Cells["Marca"].Value.ToString();
            txtColor.Text = dgvInventario.Rows[e.RowIndex].Cells["Color"].Value.ToString();
            txtPrecio.Text = dgvInventario.Rows[e.RowIndex].Cells["Precio"].Value.ToString();
            txtCantidad.Text = dgvInventario.Rows[e.RowIndex].Cells["Cantidad"].Value.ToString();
            txtFecha.Text = dgvInventario.Rows[e.RowIndex].Cells["Fecha"].Value.ToString();
            txtCategoria.Text = dgvInventario.Rows[e.RowIndex].Cells["Categoria"].Value.ToString();
            txtCodBarras.Text = dgvInventario.Rows[e.RowIndex].Cells["Codigo de Barras"].Value.ToString();
            MostrarImagen();
        }
        #endregion

        #region Cargar datos del dgvProductos al frm
        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvProductos.Rows[e.RowIndex].Cells["Id"].Value.ToString();
            txtModelo.Text = dgvProductos.Rows[e.RowIndex].Cells["Modelo"].Value.ToString();
            txtMarca.Text = dgvProductos.Rows[e.RowIndex].Cells["Marca"].Value.ToString();
            txtColor.Text = dgvProductos.Rows[e.RowIndex].Cells["Color"].Value.ToString();
            txtPrecio.Text = dgvProductos.Rows[e.RowIndex].Cells["Precio"].Value.ToString();
            txtCantidad.Text = dgvProductos.Rows[e.RowIndex].Cells["Cantidad"].Value.ToString();
            txtFecha.Text = dgvProductos.Rows[e.RowIndex].Cells["Fecha"].Value.ToString();
            txtCategoria.Text = dgvProductos.Rows[e.RowIndex].Cells["Categoria"].Value.ToString();
            txtCodBarras.Text = dgvProductos.Rows[e.RowIndex].Cells["Codigo de Barras"].Value.ToString();
            MostrarImagen();
        }

        #endregion

        #region Buscar en Inventario

        public static DataTable BuscarProducto(string nombre)//busqueda de producto en el dgv
        {
            DataTable dt = new DataTable();

            try
            {
                string sql = "select i.id, i.fecha, i.cantidad, p.codigo_de_barras, m.nombre, ma.nombre,  pr.precio, c.nombre,  cat.nombre "
                        + "FROM inventario i "
                        + "INNER JOIN producto p ON i.id_producto = p.id "
                        + "INNER JOIN modelo m ON p.id_modelo = m.id "
                        + "INNER JOIN marca ma ON m.id_marca = ma.id "
                        + "INNER JOIN color c ON p.id_color = c.id "
                        + "INNER JOIN precio_adquisicion pr ON p.id_precio_adquisicion = pr.id "
                        + "INNER JOIN categoria cat ON p.id_categoria = cat.id WHERE m.nombre= @nombre;";
                Conexion.getInstance().setCadenaConnection();
                MySqlCommand cmd = new MySqlCommand(sql, Conexion.getInstance().getConnection());
                cmd.Parameters.AddWithValue("@nombre", nombre);
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

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            dr.DefaultView.RowFilter = $"Modelo LIKE '%" + txtBuscar.Text + "%'";// para buscar coincidencias en el campo nombre
        }

        #endregion

        #region Modificar
        private void Modificar() // Metodo que modifica la cantidad y fecha de el producto inventariado
        {
            if (txtCantidad.Text.Length > 0)
            {
                InventarioDAO.getInstance().Actualizar(new Clases.Inventario(DateTime.Now, Convert.ToInt32(txtCantidad.Text), new RegistroProducto()), Convert.ToInt32(txtId.Text));
                MessageBox.Show("Productos agregados");
                dgvInventario.DataSource = ListarInventario();
                dgvProductos.DataSource = listarProducto();
                LimpiarInventario();
            }
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            Modificar();
        }

        #endregion

        #region botones
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarInventario();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }


        #endregion

        #region TextBox
        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        #endregion

        #region Imagen

        private void MostrarImagen()
        {
            if (File.Exists("C:\\BlingPicture\\" + txtId.Text + ".jpg"))
            {
                //Verificamos si existe la imagen que corresponda al usuario seleccionado 
                pbxImagen.Image = Image.FromFile("C:\\BlingPicture\\" + txtId.Text + ".jpg");
                pbxImagen.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
            {
                pbxImagen.Image = System.Drawing.Image.FromFile("C:\\BlingPicture\\default.png");
            }
        }
 
        #endregion
    }
}