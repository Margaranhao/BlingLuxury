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
    public partial class frmLocalidad : Form
    {
        #region Variables
        //Funcionalidad para pasar datos de un formulario a otro en este caso de categoria a Producto
        //Por medio de eventos y delegados 
        /*Un delegado es un tipo que representa referencias a métodos con una lista de parámetros
        determinada y un tipo de valor devuelto. Cuando se crea una instancia de un delegado, 
        puede asociar su instancia a cualquier método mediante una firma y un tipo de valor devuelto compatibles.
        */
        public delegate void pasarLocalidad(string localidad); //Variable Delegado
        public event pasarLocalidad enviado; //Evento
        protected string sql;
        protected int id;
        //private static DatosTableAdapter adaptador = new DatosTableAdapter();
        #endregion
        public frmLocalidad()
        {
            InitializeComponent();
        }
        #region Localidad        
        public DataTable listarLocalidades() //Metodo que obtiene de forma de lista de Municipio
        {
            DataTable dt = new DataTable("Localidad");
            dt.Columns.Add("Id");
            dt.Columns.Add("Localidad");
            dt.Columns.Add("Municipio Id");
            dt.Columns.Add("Municipio");
            dt.Columns.Add("Tipo Id");
            dt.Columns.Add("Tipo Localidad");
            dt.Columns.Add("C.P id");
            dt.Columns.Add("Codigo Postal");
            try
            {
                sql = "SELECT lo.id, lo.nombre AS LOCALIDAD, mu.id, mu.nombre AS MUNICIPIO, ";
                sql += "tl.id, tl.nombre AS TIPO_LOCALIDAD, cp.id, cp.nombre AS CODIGO_POSTAL ";
                sql += "FROM localidad lo ";
                sql += "INNER JOIN municipio mu ON lo.id_municipio = mu.id ";
                sql += "INNER JOIN tipo_localidad tl ON lo.id_tipo_localidad = tl.id ";
                sql += "INNER JOIN codigo_postal cp ON lo.id_cp = cp.id ";
                sql += "ORDER BY lo.id;";

                List<Localidad> localidadLista = LocalidadDAO.getInstance().Listar2(sql);
                for (int i = 0; i < localidadLista.Count; i++)
                {
                    dt.Rows.Add(localidadLista[i].id, localidadLista[i].nombre, localidadLista[i].id_municipio.id, localidadLista[i].id_municipio.nombre,
                                localidadLista[i].id_tipo_localidad.id, localidadLista[i].id_tipo_localidad.nombre, localidadLista[i].id_cp.id,
                                localidadLista[i].id_cp.nombre);
                }
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return dt;
            }
        }
        public void mostrarLocalidades() //Muestra los datos en el dataGridView
        {
            try
            {
                #region
                dgvLocalidades.DataSource = listarLocalidades();
                id = Convert.ToInt32(txtId.Text);
                #endregion
            }
            catch
            {

            }
        }
        #endregion Localidad
        #region Tipo Localidad
        public DataTable listarTipoLocalidad() //Metodo que obtiene de forma de lista de Color
        {
            DataTable dt = new DataTable("Tipo Localidad");
            dt.Columns.Add("Id");
            dt.Columns.Add("Nombre");

            try
            {
                sql = "SELECT id, nombre FROM tipo_localidad;";
                List<TipoLocalidad> tipolocalidadLista = TipoLocalidadDAO.getInstance().Listar2(sql);
                for (int i = 0; i < tipolocalidadLista.Count; i++)
                {
                    dt.Rows.Add(tipolocalidadLista[i].id, tipolocalidadLista[i].nombre);
                }
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return dt;
            }
        }
        public void mostrarTipoLocalidad()
        {
            try
            {
                //Cargar los Atributos de Tipo Localidad
                #region
                cbxTipoLocalidad.DataSource = listarTipoLocalidad();
                cbxTipoLocalidad.DisplayMember = "Nombre";
                cbxTipoLocalidad.ValueMember = "id";
                cbxTipoLocalidad.SelectedIndex = 0;
                cbxTipoLocalidad.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cbxTipoLocalidad.AutoCompleteSource = AutoCompleteSource.ListItems;
                #endregion
            }
            catch
            {

            }
        }
        #endregion
        #region Insertar
        private void Insertar() //Metodo para Insertar Colores
        {
            try
            {
                LocalidadDAO.getInstance().Insertar(new Localidad(txtLocalidad.Text, new Municipio(Convert.ToInt32(txtMunicipioId.Text)), new TipoLocalidad(Convert.ToInt32(cbxTipoLocalidad.SelectedValue)), new CodigoPostal(txtCodigoPostal.Text)));
                //Manda mensaje de confirmacion cuando se agregan los datos
                MessageBox.Show("Localidad agregada correctamente", "Localidad Agregado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                mostrarLocalidades(); //Actualiza el DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion Insertar 
        private void frmLocalidad_Load(object sender, EventArgs e)
        {
            mostrarLocalidades();
            mostrarTipoLocalidad();
        }

        private void btnMuAgregar_Click(object sender, EventArgs e)
        {
            Insertar();
        }
    }
}
