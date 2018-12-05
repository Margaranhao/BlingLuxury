using BlingLuxury.Clases;
using BlingLuxury.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlingLuxury.Vistas
{
    public partial class frmCatalogo : Form
    {
        #region variables
        protected string sql; //variable para las consultas
        #endregion
        public frmCatalogo()
        {
            InitializeComponent();
        }

        private void dgvProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        #region Cargar Datos al dgv de Catalogo
        DataTable dr = new DataTable();//tabla para las busquedas

        public DataTable ListarCatalogo() // Metodo que obtiene en forma de lista
        {
            DataTable dt = new DataTable("Catalogo");
            dt.Columns.Add("Id");
            dt.Columns.Add("Descripción");
            dt.Columns.Add("Modelo");
            dt.Columns.Add("Marca");
            dt.Columns.Add("Precio");
            dt.Columns.Add("Color");
            dt.Columns.Add("Categoria");

            dgvCatalogo.DataSource = dt;
            //dr = dt;

            try
            {
                //sql = "select i.id, p.descripcion, m.nombre, ma.nombre,  pr.precio, c.nombre,  cat.nombre ";
                //sql += "FROM inventario i ";
                //sql += "INNER JOIN producto p ON i.id_producto = p.id ";
                //sql += "INNER JOIN modelo m ON p.id_modelo = m.id ";
                //sql += "INNER JOIN marca ma ON m.id_marca = ma.id ";
                //sql += "INNER JOIN color c ON p.id_color = c.id ";
                //sql += "INNER JOIN precio_adquisicion pr ON p.id_precio_adquisicion = pr.id ";
                //sql += "INNER JOIN categoria cat ON p.id_categoria = cat.id;
                sql = "select p.id, p.descripcion, mo.nombre, ma.nombre, pr.precio, co.nombre, cat.nombre ";
                sql += "FROM producto p ";
                sql += "INNER JOIN modelo mo ON p.id_modelo = mo.id ";
                sql += "INNER JOIN marca ma ON mo.id_marca = ma.id ";
                sql += "INNER JOIN color co ON p.id_color = co.id ";
                sql += "INNER JOIN precio_adquisicion pr ON p.id_precio_adquisicion = pr.id ";
                sql += "INNER JOIN categoria cat ON p.id_categoria = cat.id ";
                sql += "order by p.id desc ;";
                List<RegistroProducto> productoList = RegistroProductoDAO.getInstance().Listar2(sql);
                for (int i = 0; i < productoList.Count; i++)
                {
                    dt.Rows.Add(productoList[i].idProducto, productoList[i].descripcionProducto,
                                productoList[i].productoIdModelo.nombre, productoList[i].modeloIdMarca.nombre,
                                productoList[i].productoIdPrecio_adquisicion.precio, productoList[i].productoIdColor.nombre,
                                productoList[i].productoIdCategoria.nombre);
                }
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return dt;
            }
        }

        public void mostrarCatalogo() // metodo que muestra el inventario
        {
            try
            {
                dgvCatalogo.DataSource = ListarCatalogo();
                //dgvInventario.Columns[0].Visible = false;
                //dgvInventario.Columns[1].Visible = true;
                //dgvInventario.Columns[2].Visible = true;
                //dgvInventario.Columns[3].Visible = true;
                //dgvInventario.Columns[4].Visible = true;
                //dgvInventario.Columns[5].Visible = true;
                //dgvInventario.Columns[6].Visible = true;
                //dgvInventario.Columns[7].Visible = true;
                //dgvInventario.Columns[8].Visible = true;
            }
            catch
            {

            }
        }    
        #endregion
        #region Limpiar registro
        private void LimpiarInventario()// para limpiar los campos del formulario
        {
            txtId.Clear();
            txtModelo.Clear();
            txtMarca.Clear();
            txtColor.Clear();
            txtPrecio.Clear();
            txtCategoria.Clear();            
        }
        #endregion
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            //Para buscar por el codigo de barras en el Gridview
       
            BindingSource bs = new BindingSource();

            bs.DataSource = dgvCatalogo.DataSource;
            bs.Filter = $"Marca like '%" + txtBuscar.Text + "%'";
            dgvCatalogo.DataSource = bs;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCatalogo_Load(object sender, EventArgs e)
        {
            mostrarCatalogo();
            MostrarImagen();
        }
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
                pbxImagen.Image = System.Drawing.Image.FromFile("C:\\BlingPicture\\Default.png");
            }
        }

        private void dgvCatalogo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //txtId.Text = dgvProducto.Rows[e.RowIndex].Cells["Id"].Value.ToString();
            txtId.Text = dgvCatalogo.Rows[e.RowIndex].Cells["Id"].Value.ToString();
            txtDescripcion.Text = dgvCatalogo.Rows[e.RowIndex].Cells["Descripción"].Value.ToString();
            txtModelo.Text = dgvCatalogo.Rows[e.RowIndex].Cells["Modelo"].Value.ToString();
            txtMarca.Text = dgvCatalogo.Rows[e.RowIndex].Cells["Marca"].Value.ToString();
            txtPrecio.Text = dgvCatalogo.Rows[e.RowIndex].Cells["Precio"].Value.ToString();
            txtColor.Text = dgvCatalogo.Rows[e.RowIndex].Cells["Color"].Value.ToString();
            txtCategoria.Text = dgvCatalogo.Rows[e.RowIndex].Cells["Categoria"].Value.ToString();
            MostrarImagen();
            //id = Convert.ToInt32(txtId.Text);
        }
    }
}
