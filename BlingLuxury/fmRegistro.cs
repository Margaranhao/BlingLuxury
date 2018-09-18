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
        public fmRegistro()
        {
            InitializeComponent();
        }

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
                sql = "SELECT id, nombre, nick, pass, id_nivel from usuario;";
                List<Usuario> usuarioList = UsuarioDAO.getInstance().Listar(sql);
                for(int i = 0; i < usuarioList.Count; i++)
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
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].Visible = false;
                dataGridView1.Columns[2].Visible = false;
                dataGridView1.Columns[3].Visible = false;
                dataGridView1.Columns[4].Visible = false;
                #endregion
            }
            catch
            {

            }
        }


        protected string sql;
        public DataTable listarNivel()// Metodo que obtiene en forma de lista los niveles de usuario
        {
            DataTable dt = new DataTable("Nivel");
            dt.Columns.Add("Id");
            dt.Columns.Add("Nivel");

            try
            {
                sql = "SELECT id, nombre FROM nivel;";
                List<Nivel> nivelList = NivelDAO.getInstance().Listar(sql);
                for (int i = 0; i < nivelList.Count; i++)
                {
                    dt.Rows.Add(nivelList[i].id, nivelList[i].nombre);
                }
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return dt;
            }
        }

        public DataTable listarMunicipio()// Metodo que obtiene en forma de lista los municipios
        {
            DataTable dt = new DataTable("Municipio");
            dt.Columns.Add("Id");
            dt.Columns.Add("Municipio");
           

            try
            {
                sql = "SELECT id, nombre FROM municipio;";
                List<Municipio> municipioList = MunicipioDAO.getInstance().Listar(sql);
                for (int i = 0; i < municipioList.Count; i++)
                {
                    dt.Rows.Add(municipioList[i].id, municipioList[i].nombre, municipioList[i].id_localidad);
                }
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return dt;
            }
        }
        
        public DataTable listarEntidadFederativa()// Metodo que obtiene en forma de lista los niveles de usuario
        {
            DataTable dt = new DataTable("Entidad Federativa");
            dt.Columns.Add("Id");
            dt.Columns.Add("Entidad Federativa");

            try
            {
                sql = "SELECT id, nombre FROM entidad_federativa;";
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
        private void mostrarNivel()//Metodo que muestra el nivel en un combobox cbx
        {
            try
            {
                //Cargar los atributos de nivel
                #region
                cbxNivel.DataSource = listarNivel();
                cbxNivel.DisplayMember = "Nivel";
                cbxNivel.ValueMember = "id";
                cbxNivel.SelectedIndex = 0;
                cbxNivel.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cbxNivel.AutoCompleteSource = AutoCompleteSource.ListItems;
                #endregion
            }
            catch
            {

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

        private void mostrarEntidadFederativa()//Metodo que muestra el Municipio
        {
            try
            {
                //Cargar los atributos de municipio
                #region
                cbxEntidadFederativa.DataSource = listarMunicipio();
                cbxEntidadFederativa.DisplayMember = "Entidad Federativa";
                cbxEntidadFederativa.ValueMember = "id";
                cbxEntidadFederativa.SelectedIndex = 0;
                cbxEntidadFederativa.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cbxEntidadFederativa.AutoCompleteSource = AutoCompleteSource.ListItems;
                #endregion
            }
            catch
            {

            }
        }



        private void fmRegistro_Load(object sender, EventArgs e)
        {
            mostrarNivel();
            mostrarMunicipio();
            mostrarEntidadFederativa();
            mostrarUsuario();
        }
        
    }
}
