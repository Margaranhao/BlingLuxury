using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BlingLuxury.Clases;
using BlingLuxury.DAO;
using BlingLuxury.Connection;
using MySql.Data.MySqlClient;

namespace BlingLuxury.Vistas
{
    public partial class frmCarteraDeClientes : Form
    {
        #region Eventos del formulario
        public frmCarteraDeClientes()
        {
            InitializeComponent();
        }
        private void frmCarteraDeClientes_Load(object sender, EventArgs e)
        {
            mostrarCartera();
        }
        #endregion

        #region RADIO BUTTONS
        private void frmCarteraDeClientes_Shown(object sender, EventArgs e)
        {
            rbnMunicipio.Checked = true;
            rbnEstado.Checked = false;
            rbnLocalidad.Checked = false;
        }

        private void rbnMunicipio_CheckedChanged(object sender, EventArgs e)// cambia el estado para mostrar la tabla de inventario
        {
            if (rbnMunicipio.Checked == true)
            {
                rbnEstado.Checked = false;
                rbnLocalidad.Checked = false;
            }
        }

        private void rbnEstado_CheckedChanged(object sender, EventArgs e)// cambia el estado para mostrar la tabla de inventario
        {
            if (rbnEstado.Checked == true)
            {
                rbnMunicipio.Checked = false;
                rbnLocalidad.Checked = false;
            }
        }

        private void rbnLocalidad_CheckedChanged(object sender, EventArgs e)// cambia el estado para mostrar la tabla de inventario
        {
            if (rbnLocalidad.Checked == true)
            {
                rbnEstado.Checked = false;
                rbnMunicipio.Checked = false;
            }
        }
        #endregion

        #region MOSTRAR CARTERA DE CLIENTES
        DataTable dr = new DataTable();
        public DataTable ListarCartera() // Metodo que obtiene en forma de lista
        {
            DataTable dt = new DataTable("CARTERA DE CLIENTES");
            
            dt.Columns.Add("Nombre");
            dt.Columns.Add("Rango");
            dt.Columns.Add("Telefono");
            dt.Columns.Add("Direccion");
            dt.Columns.Add("Localidad");        
            dt.Columns.Add("Tipo de Localidad");
            dt.Columns.Add("Codigo Postal");            
            dt.Columns.Add("Municipio");
            dt.Columns.Add("Estado");

            dgvCartera.DataSource = dt;
            dr = dt;

            try
            {
                string sql = "SELECT u.nombre, r.nombre, c.telefono, c.calle, l.nombre, tl.nombre, cp.nombre, m.nombre, e.nombre "
                            + "FROM cliente c INNER JOIN usuario u ON c.id_usuario = u.id "
                            + "INNER JOIN localidad l ON c.id_localidad = l.id "
                            + "INNER JOIN tipo_localidad tl ON l.id_tipo_localidad = tl.id "
                            + "INNER JOIN codigo_postal cp ON l.id_cp = cp.id "
                            + "INNER JOIN rango r ON c.id_rango = r.id "
                            + "INNER JOIN municipio m ON c.id_municipio = m.id "
                            + "INNER JOIN entidad_federativa e ON m.id_entidad_federativa = e.id;";

                List<RegistroUsuario> carteraList = RegistroUsuarioDAO.getInstance().Listar2(sql);
                for (int i = 0; i < carteraList.Count; i++)
                {
                    dt.Rows.Add(carteraList[i].nombreUsuario, carteraList[i].usuarioRango.nombre,
                        carteraList[i].telefonoCliente, carteraList[i].calleCliente, 
                        carteraList[i].idLocalidad.nombre, carteraList[i].idTipoLocalidad.nombre, 
                        carteraList[i].idCp.nombre, carteraList[i].idMunicipio.nombre,
                        carteraList[i].idEntidadFederativa.nombre);

                }
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return dt;
            }
        }

        public void mostrarCartera() // metodo que muestra el inventario
        {
            try
            {
                dgvCartera.DataSource = ListarCartera();
                //dgvCartera.Columns[0].Visible = true;
                //dgvCartera.Columns[1].Visible = true;
                //dgvCartera.Columns[2].Visible = true;
                //dgvCartera.Columns[3].Visible = true;
                //dgvCartera.Columns[4].Visible = true;
                //dgvCartera.Columns[5].Visible = true;
                //dgvCartera.Columns[6].Visible = true;
                //dgvCartera.Columns[7].Visible = true;
                //dgvCartera.Columns[8].Visible = true;
                
            }
            catch
            {

            }
        }
        #endregion

        #region BUSCAR 
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if(rbnEstado.Checked == true)
            {
                dr.DefaultView.RowFilter = $"Estado LIKE '%" + txtBuscar.Text + "%'";
            }

            if (rbnMunicipio.Checked == true)
            {
                dr.DefaultView.RowFilter = $"Municipio LIKE '%" + txtBuscar.Text + "%'";
            }

            if (rbnLocalidad.Checked == true)
            {
                dr.DefaultView.RowFilter = $"Localidad LIKE '%" + txtBuscar.Text + "%'";
            }
            
        }

        #endregion

        #region RANGO
        private void dgvCartera_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dgvCartera.Columns[e.ColumnIndex].Name == "Rango")
            {
                if (Convert.ToString(e.Value) == "BASICO")
                {
                    //e.CellStyle.ForeColor = System.Drawing.Color.Red;
                    e.CellStyle.BackColor = System.Drawing.Color.CornflowerBlue;
                }
                if (Convert.ToString(e.Value) == "MEDIO")
                {
                    //e.CellStyle.ForeColor = System.Drawing.Color.Red;
                    e.CellStyle.BackColor = System.Drawing.Color.Silver;
                }
                if (Convert.ToString(e.Value) == "PREMIUM")
                {
                    //e.CellStyle.ForeColor = System.Drawing.Color.Red;
                    e.CellStyle.BackColor = System.Drawing.Color.Gold;
                }
            }            
        }
        #endregion
    }
}
