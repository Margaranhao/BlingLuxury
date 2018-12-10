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
    public partial class frmCajaChica : Form
    {
        #region EVENTOS DEL FORMULARIO
        public frmCajaChica()
        {
            InitializeComponent();
        }

        private void frmCajaChica_Load(object sender, EventArgs e)
        {
            mostrarDeposito();
            mostrarEstado();
        }
        #endregion

        #region LIMPIAR CAMPOS

        private void LimpiarCaja()// para limpiar los campos del formulario
        {
            txtIdDeposito.Clear();
            txtDeposito.Clear();
            txtFecha.Clear();
            txtUsuario.Clear();
            cbxEstado.SelectedIndex = 0;

            txtIdRetiro.Clear();
            txtRetiro.Clear();
            txtRazon.Clear();                                              


        }
        
        #endregion

        #region RADIOBUTTONS
        private void frmCajaChica_Shown_1(object sender, EventArgs e)
        {
            rbnDeposito.Checked = true;
            rbnRetiro.Checked = false;
        }

        private void rbnDeposito_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rbnDeposito.Checked == true)
            {
                rbnRetiro.Checked = false;
                dgvDeposito.Visible = true;
                dgvRetiro.Visible = false;
            }
        }

        private void rbnRetiro_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rbnRetiro.Checked == true)
            {
                rbnDeposito.Checked = false;
                dgvDeposito.Visible = false;
                dgvRetiro.Visible = true;
            }
        }

        #endregion

        #region CARGA A COMBOBOX

        public DataTable listarEstado()// Metodo que obtiene en forma de lista las localidades
        {
            DataTable dt = new DataTable("Estado");
            dt.Columns.Add("Id");
            dt.Columns.Add("Nombre");

            try
            {
                string sql = "SELECT id, nombre FROM estado;";
                List<Estado> estadoList = EstadoDAO.getInstance().Listar(sql);
                for (int i = 0; i < estadoList.Count; i++)
                {
                    dt.Rows.Add(estadoList[i].id, estadoList[i].nombre);
                }
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return dt;
            }
        }

        private void mostrarEstado()//Metodo que muestra la lista de estado
        {
            try
            {
                //Cargar los atributos de localidad
                #region
                cbxEstado.DataSource = listarEstado();
                cbxEstado.DisplayMember = "Nombre";
                cbxEstado.ValueMember = "id";
                cbxEstado.SelectedIndex = 0;
                cbxEstado.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cbxEstado.AutoCompleteSource = AutoCompleteSource.ListItems;
                #endregion

            }
            catch
            {

            }
        }

        #endregion

        #region CARGA DE DGV DEPOSITO A TEXTBOX

        private void dgvDeposito_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdDeposito.Text = dgvDeposito.Rows[e.RowIndex].Cells["Id"].Value.ToString();
            txtDeposito.Text = dgvDeposito.Rows[e.RowIndex].Cells["Cantidad"].Value.ToString();
            txtFecha.Text = dgvDeposito.Rows[e.RowIndex].Cells["Fecha"].Value.ToString();
            cbxEstado.SelectedValue = dgvDeposito.Rows[e.RowIndex].Cells["id_estado"].Value;
            txtUsuario.Text = dgvDeposito.Rows[e.RowIndex].Cells["Usuario"].Value.ToString();            
                        
        }

        private void dataGridView2_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        #endregion

        #region BOTONES
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region CARGAR DATOS AL DGV DEPOSITO
        public DataTable listarDeposito()//metodo que enlista los productos
        {
            DataTable dt = new DataTable("Deposito");
            dt.Columns.Add("Id");
            dt.Columns.Add("Cantidad");
            dt.Columns.Add("Fecha");
            dt.Columns.Add("id_estado");        
            dt.Columns.Add("Estado");
            dt.Columns.Add("Usuario");
            

            dgvDeposito.DataSource = dt;

            try
            {
                string sql = "SELECT d.id , d.cantidad , d.fecha ,e.id, e.nombre , u.nick "
                            +"from deposito d "
                            +"INNER JOIN estado e ON d.id_estado = e.id "
                            +"INNER JOIN usuario u ON d.id_usuario = u.id; ";
                List<Deposito> depositoList = DepositoDAO.getInstance().Listar(sql);
                for (int i = 0; i < depositoList.Count; i++)
                {
                    dt.Rows.Add(depositoList[i].id, depositoList[i].cantidad, depositoList[i].fecha, 
                                depositoList[i].id_estado.id, depositoList[i].id_estado.nombre, 
                                depositoList[i].id_usuario.nick);
                }
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return dt;
            }
        }

        private void mostrarDeposito()// Metodo que muestra el producto
        {
            try
            {
                dgvDeposito.DataSource = listarDeposito();
                dgvDeposito.Columns[0].Visible = false;
                dgvDeposito.Columns[1].Visible = true;
                dgvDeposito.Columns[2].Visible = true;
                dgvDeposito.Columns[3].Visible = false;
                dgvDeposito.Columns[4].Visible = true;
                dgvDeposito.Columns[5].Visible = true;
            }
            catch
            {

            }
        }

        private void dgvDeposito_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Marca en color los diferentes tipos de estado
            if (this.dgvDeposito.Columns[e.ColumnIndex].Name == "Estado")
            {
                if (Convert.ToString(e.Value) == "REALIZADO")
                {
                    e.CellStyle.BackColor = System.Drawing.Color.LightGreen;
                }

                if (Convert.ToString(e.Value) == "NO REALIZADO")
                {
                    e.CellStyle.BackColor = System.Drawing.Color.Yellow;
                }

                if (Convert.ToString(e.Value) == "CANCELADO")
                {
                    e.CellStyle.BackColor = System.Drawing.Color.Red;
                }
            }
        }
        #endregion

        #region CARGAR DATOS AL DGV RETIRO
        public DataTable listarRetiro()//metodo que enlista los productos
        {
            DataTable dt = new DataTable("Retiro");
            dt.Columns.Add("Id");
            dt.Columns.Add("Fecha");
            dt.Columns.Add("Cantidad");
            dt.Columns.Add("Razon");
            dt.Columns.Add("Usuario");


            dgvDeposito.DataSource = dt;

            try
            {
                string sql = "SELECT d.id , d.cantidad , d.fecha , e.nombre , u.nick "
                            + "from deposito d "
                            + "INNER JOIN estado e ON d.id_estado = e.id "
                            + "INNER JOIN usuario u ON d.id_usuario = u.id; ";
                List<Deposito> depositoList = DepositoDAO.getInstance().Listar(sql);
                for (int i = 0; i < depositoList.Count; i++)
                {
                    dt.Rows.Add(depositoList[i].id, depositoList[i].cantidad, depositoList[i].fecha,
                                depositoList[i].id_estado.nombre, depositoList[i].id_usuario.nick);
                }
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return dt;
            }
        }

        private void mostrarRetiro()// Metodo que muestra el producto
        {
            try
            {
                dgvDeposito.DataSource = listarDeposito();
                dgvDeposito.Columns[0].Visible = false;
                dgvDeposito.Columns[1].Visible = true;
                dgvDeposito.Columns[2].Visible = true;
                dgvDeposito.Columns[3].Visible = true;
                dgvDeposito.Columns[4].Visible = true;
            }
            catch
            {

            }
        }

        private void dgvRetiro_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Marca en color rojo las columnas donde ya no hay productos inventariados
            if (this.dgvRetiro.Columns[e.ColumnIndex].Name == "Estado")
            {
                if (Convert.ToString(e.Value) == "REALIZADO")
                {
                    e.CellStyle.BackColor = System.Drawing.Color.LightGreen;
                }

                if (Convert.ToString(e.Value) == "NO REALIZADO")
                {
                    e.CellStyle.BackColor = System.Drawing.Color.Yellow;
                }

                if (Convert.ToString(e.Value) == "CANCELADO")
                {
                    e.CellStyle.BackColor = System.Drawing.Color.Red;
                }
            }

        }





        #endregion

        
    }
}
