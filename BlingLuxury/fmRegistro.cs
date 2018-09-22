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
using BlingLuxury.DAO;


namespace BlingLuxury
{
    public partial class fmRegistro : Form
    {
        protected string sql;//variable para las consultas
        public fmRegistro()
        {
            InitializeComponent();
        }


        private void fmRegistro_Load(object sender, EventArgs e)
        {
            mostrarNivel();
            mostrarEntidadFederativa();
            mostrarUsuario();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Insertar();

        }


        private void cbxNivel_SelectedIndexChanged(object sender, EventArgs e)
        {
            activarNivel();
        }
        private void LimpiarRegistro()
        {
            txtNombre.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtUsuario.Clear();
            txtPass.Clear();

        }
        
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarRegistro();
        }

        private void Insertar()//metodo para registrar usuarios
        {
            UsuarioDAO.getInstance().Insertar(new Usuario(txtNombre.Text, txtUsuario.Text, txtPass.Text, new Nivel(cbxNivel.ValueMember)));
        }
        #region Usuario
        public DataTable ListarUsuario()// Metodo que obtiene en forma de lista 
        {
            DataTable dt = new DataTable("Usuario");
            dt.Columns.Add("Id");
            dt.Columns.Add("Nombre");
            dt.Columns.Add("Nick");
            dt.Columns.Add("Pass");
            dt.Columns.Add("id_nivel");

            try
            {
                sql = "SELECT id, nombre, nick, pass, id_nivel from usuario ORDER BY nombre ASC;";
                List<Usuario> usuarioList = UsuarioDAO.getInstance().Listar(sql);
                for (int i = 0; i < usuarioList.Count; i++)
                {
                    dt.Rows.Add(usuarioList[i].id, usuarioList[i].nombre, usuarioList[i].nick, usuarioList[i].pass, usuarioList[i].id_nivel);
                }
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return dt;
            }
        }

        public void mostrarUsuario()//Metodo que muestra el usuario
        {
            try
            {
                #region
                dataGridView1.DataSource = ListarUsuario();
                dataGridView1.Columns[0].Visible = true;
                dataGridView1.Columns[1].Visible = true;
                dataGridView1.Columns[2].Visible = true;
                dataGridView1.Columns[3].Visible = true;
                dataGridView1.Columns[4].Visible = true;
                #endregion                
            }
            catch
            {

            }
        }
        #endregion

        #region Nivel
        public DataTable listarNivel()// Metodo que obtiene en forma de lista los niveles de usuario
        {
            DataTable dt = new DataTable("Nivel");
            dt.Columns.Add("Id");
            dt.Columns.Add("Nivel");

            try
            {
                sql = "SELECT id, nombre FROM nivel ORDER BY nombre ASC;";
                List<Nivel> nivelLista = NivelDAO.getInstance().Listar(sql);
                for (int i = 0; i < nivelLista.Count; i++)
                {
                    dt.Rows.Add(nivelLista[i].id, nivelLista[i].nombre);
                }
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return dt;
            }
        }
        private void mostrarNivel()//Metodo que muestra el nivel en un combobox cbx
        {
            try
            {
                //Cargar los atributos de nivel
                #region
                cbxNivel.DataSource = listarNivel();
                cbxNivel.ValueMember = "Id";
                cbxNivel.DisplayMember = "Nivel";
                cbxNivel.SelectedIndex = -1;
                cbxNivel.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cbxNivel.AutoCompleteSource = AutoCompleteSource.ListItems;
                #endregion
            }
            catch
            {

            }
        }
        private void activarNivel()
        {
            try
            {
                if (cbxNivel.Text == "Cliente")
                    groupBox2.Enabled = true;
                else if (cbxNivel.Text == "Administrador")
                    groupBox2.Enabled = false;
                else if (cbxNivel.Text == "Gestor")
                    groupBox2.Enabled = false;
            }
            catch
            {

            }
        }
        #endregion

        #region Entidad Federativa
        public DataTable listarEntidadFederativa()// Metodo que obtiene en forma de lista los niveles de usuario
        {
            DataTable dt = new DataTable("Entidad Federativa");
            dt.Columns.Add("Id");
            dt.Columns.Add("Entidad Federativa");

            try
            {
                sql = "SELECT id, nombre FROM entidad_federativa ORDER BY nombre ASC;";
                List<EntidadFederativa> entidadFederativaList = EntidadFederativaDAO.getInstance().Listar(sql);
                for (int i = 0; i < entidadFederativaList.Count; i++)
                {
                    dt.Rows.Add(entidadFederativaList[i].id, entidadFederativaList[i].nombre);
                }
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return dt;
            }
        }

        private void mostrarEntidadFederativa()//Metodo que muestra el Municipio
        {
            try
            {
                //Cargar los atributos de municipio
                #region
                cbxEntidadFederativa.DataSource = listarEntidadFederativa();
                cbxEntidadFederativa.DisplayMember = "Entidad Federativa";
                cbxEntidadFederativa.ValueMember = "id";
                cbxEntidadFederativa.SelectedIndex = -1;
                cbxEntidadFederativa.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cbxEntidadFederativa.AutoCompleteSource = AutoCompleteSource.ListItems;
                #endregion
            }
            catch
            {

            }
        }

        private void cbxEntidadFederativa_SelectedIndexChanged(object sender, EventArgs e)
        {
            mostrarMunicipio();
        }

        #endregion

        #region Municipio
        public DataTable listarMunicipio()// Metodo que obtiene en forma de lista los municipios
        {
            DataTable dt = new DataTable("Municipio");
            dt.Columns.Add("Id");
            dt.Columns.Add("Municipio");

            try
            {
                sql = "SELECT id, nombre FROM municipio where id_entidad_federativa='" + cbxEntidadFederativa.SelectedValue + "'ORDER BY nombre ASC;";
                List<Municipio> municipioLista = MunicipioDAO.getInstance().Listar(sql);
                for (int i = 0; i < municipioLista.Count; i++)
                {
                    dt.Rows.Add(municipioLista[i].id, municipioLista[i].nombre);
                }
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return dt;
            }
        }

        private void mostrarMunicipio()//Metodo que muestra el Municipio
        {
            try
            {
                //Cargar los atributos de municipio
                #region
                cbxMunicipio.DataSource = listarMunicipio();
                cbxMunicipio.DisplayMember = "Municipio";
                cbxMunicipio.ValueMember = "id";
                cbxMunicipio.SelectedIndex = 0;
                cbxMunicipio.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cbxMunicipio.AutoCompleteSource = AutoCompleteSource.ListItems;
                #endregion
            }
            catch
            {

            }
        }
        private void cbxMunicipio_SelectedIndexChanged(object sender, EventArgs e)
        {
            mostrarLocalidad();
        }
        #endregion

        #region Localidad
        public DataTable listarLocalidad()// Metodo que obtiene en forma de lista las localidades
        {
            DataTable dt = new DataTable("Localidad");
            dt.Columns.Add("Id");
            dt.Columns.Add("Localidad");

            try
            {
                sql = "SELECT id, nombre, id_cp FROM localidad where id_municipio= '" + cbxMunicipio.SelectedValue + "'ORDER BY nombre ASC;";
                List<Localidad> localidadList = LocalidadDAO.getInstance().Listar(sql);
                for (int i = 0; i < localidadList.Count; i++)
                {
                    dt.Rows.Add(localidadList[i].id, localidadList[i].nombre);
                }
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return dt;
            }
        }

        private void mostrarLocalidad()//Metodo que muestra la localidad
        {
            try
            {
                //Cargar los atributos de municipio
                #region
                cbxLocalidad.DataSource = listarLocalidad();
                cbxLocalidad.DisplayMember = "Localidad";
                cbxLocalidad.ValueMember = "id";
                cbxLocalidad.SelectedIndex = 0;
                cbxLocalidad.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cbxLocalidad.AutoCompleteSource = AutoCompleteSource.ListItems;
                #endregion

            }
            catch
            {

            }
        }

        #endregion
    }
}