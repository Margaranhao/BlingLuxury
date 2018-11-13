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

namespace BlingLuxury
{
    public partial class frmInventario : Form
    {
        #region variables

        protected string sql; //variable para las consultas

        #endregion
        public frmInventario()
        {
            InitializeComponent();
        }

        private void frmInventario_Load(object sender, EventArgs e)
        {
            mostrarInvenario();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtCodBarras_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
           // Validar.SoloLetras(e); //Solo aceptar letras
        }

        #region Cargar Datos al dgv

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

            try
            {
                sql = "select i.id, i.fecha, i.cantidad, p.codigo_de_barras, m.nombre, ma.nombre,  pr.precio, c.nombre,  cat.nombre "
                        + "FROM inventario i "
                        + "INNER JOIN producto p ON i.id_producto = p.id "
                        + "INNER JOIN modelo m ON p.id_modelo = m.id "
                        + "INNER JOIN marca ma ON m.id_marca = ma.id "
                        + "INNER JOIN color c ON p.id_color = c.id "
                        + "INNER JOIN precio_adquisicion pr ON p.id_precio_adquisicion = pr.id "
                        + "INNER JOIN categoria cat ON p.id_categoria = cat.id;";
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
                /*dgvInventario.Columns[0].Visible = true;
                dgvInventario.Columns[1].Visible = true;
                dgvInventario.Columns[2].Visible = true;
                dgvInventario.Columns[3].Visible = true;
                dgvInventario.Columns[4].Visible = true;
                dgvInventario.Columns[5].Visible = true;
                dgvInventario.Columns[6].Visible = true;
                dgvInventario.Columns[7].Visible = true;
                dgvInventario.Columns[8].Visible = true;
                */
            }
            catch
            {

            }
        }

        #endregion

        private void dgvInventario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
