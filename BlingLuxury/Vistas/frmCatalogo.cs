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
            dt.Columns.Add("Modelo");
            dt.Columns.Add("Marca");
            dt.Columns.Add("Precio");
            dt.Columns.Add("Color");
            dt.Columns.Add("Categoria");
            dt.Columns.Add("Descripción");

            dgvCatalogo.DataSource = dt;
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
                //List<Inventario> inventarioList = InventarioDAO.getInstance().Listar(sql);
                //for (int i = 0; i < inventarioList.Count; i++)
                //{
                //    dt.Rows.Add(inventarioList[i].id, inventarioList[i].fecha, inventarioList[i].cantidad,
                //                inventarioList[i].id_registroProducto.codigoProducto, inventarioList[i].id_modelo.nombre,
                //                inventarioList[i].id_marca.nombre, inventarioList[i].id_precioAdquisicion.precio,
                //                inventarioList[i].id_color.nombre, inventarioList[i].id_categoria.nombre);
                //}
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
            bs.Filter = $"CodigoBarras like '%" + txtBuscar.Text + "%'";
            dgvCatalogo.DataSource = bs;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
