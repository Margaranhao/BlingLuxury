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
using BlingLuxury.Validaciones;
using System.Globalization;
using System.Text.RegularExpressions;

namespace BlingLuxury
{
    public partial class fmRegistro : Form
    {
        //variables 
        int r = 1;//asignacion de rango basico a cliente nuevo        
        protected string sql;//variable para las consultas
        string user;


        public fmRegistro()
        {
            InitializeComponent();
        }

        private void fmRegistro_Load(object sender, EventArgs e)
        {
            //muestra los items de los combobox al cargar formulario
            mostrarNivel();
            mostrarEntidadFederativa();
            mostrarUsuario();
            mostrarLocalidad();
            mostrarMunicipio();

            #region dtv1
            //propiedades para el font del datagridview
            DataGridViewCellStyle cabecera;
            cabecera = new DataGridViewCellStyle();
            cabecera.BackColor = System.Drawing.Color.LightBlue;
            cabecera.ForeColor = System.Drawing.Color.Black;
            cabecera.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
            cabecera.Alignment = DataGridViewContentAlignment.BottomCenter;

            //asignamos el estilo a todas las cabeceras
            this.dataGridView1.ColumnHeadersDefaultCellStyle = cabecera;
            #endregion
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();// cierra el formulario actual
        }

        private void btnAgregar_Click(object sender, EventArgs e)// para realizar el insert de usuarios y limpiar el formulario
        {
            Insertar();
            LimpiarRegistro();
        }

        private void cbxNivel_SelectedIndexChanged(object sender, EventArgs e) //para activar el nivel de usuario
        {
            activarNivel();
        }
        private void LimpiarRegistro()//para limpiar los campos del formulario
        {
            txtNombre.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtUsuario.Clear();
            txtPass.Clear();
            cbxNivel.SelectedIndex = 0;
            cbxEntidadFederativa.SelectedIndex = 0;
            cbxLocalidad.SelectedIndex = 0;
            cbxMunicipio.SelectedIndex = 0;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarRegistro();
        }
        

        // Para colocar los datos de una fila de datagridview en campos de texto
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dataGridView1.Rows[e.RowIndex].Cells["Id"].Value.ToString();
            txtNombre.Text = dataGridView1.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
            txtUsuario.Text = dataGridView1.Rows[e.RowIndex].Cells["Nick"].Value.ToString();
            txtPass.Text = dataGridView1.Rows[e.RowIndex].Cells["Pass"].Value.ToString();
            cbxNivel.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells["id_nivel"].Value;
            //cbxEntidadFederativa.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells["Entidad Federativa"].Value;
            //cbxMunicipio.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells["Municipio"].Value;
            //bxLocalidad.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells["Localidad"].Value;
        }
        #region buscar
        public static DataTable Buscar(string nombre)//para evitar nick duplicados
        {
            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT id, nombre FROM usuario WHERE nick= @nombre;";
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
        #endregion
        #region busqueda para modificar
        public static DataTable BuscarConId(int id, string nombre)//para evitar nick duplicados
        {
            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT id, nombre FROM usuario WHERE nick= @nombre AND NOT id= @id;";
                Conexion.getInstance().setCadenaConnection();
                MySqlCommand cmd = new MySqlCommand(sql, Conexion.getInstance().getConnection());
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@id", id);
                MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                adap.Fill(dt);
                return dt;
            }
            catch (Exception )
            {
                //MessageBox.Show(ex.Message);
                return dt;
            }
        }
        #endregion

        #region Usuario
        DataTable dr = new DataTable();


        public DataTable ListarUsuario()// Metodo que obtiene en forma de lista 
        {
            DataTable dt = new DataTable("Usuario");
            dt.Columns.Add("Id");
            dt.Columns.Add("Nombre");
            dt.Columns.Add("Nick");
            dt.Columns.Add("Pass");
            dt.Columns.Add("id_nivel");

            dataGridView1.DataSource = dt;
            dr = dt;
            try
            {
                sql = "SELECT id, nombre, nick, pass, id_nivel from usuario ORDER BY nombre ASC;";
                List<Usuario> usuarioList = UsuarioDAO.getInstance().Listar(sql);
                for (int i = 0; i < usuarioList.Count; i++)
                {
                    dt.Rows.Add(usuarioList[i].id, usuarioList[i].nombre, usuarioList[i].nick, usuarioList[i].pass, usuarioList[i].id_nivel.nombre);
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
                dataGridView1.Columns[1].Visible = true;
                dataGridView1.Columns[2].Visible = true;
                dataGridView1.Columns[3].Visible = false;
                dataGridView1.Columns[4].Visible = false;
                #endregion
            }
            catch
            {

            }
        }
        public DataTable ListarCliente()
        {
            DataTable dt = new DataTable("Cliente");
            dt.Columns.Add("Id");
            dt.Columns.Add("Nombre");
            dt.Columns.Add("Nick");
            dt.Columns.Add("Pass");
            dt.Columns.Add("id_nivel");

            dataGridView1.DataSource = dt;
            dr = dt;
            try
            {
                sql = "SELECT id, nombre, nick, pass, id_nivel from usuario ORDER BY nombre ASC;";
                List<Usuario> usuarioList = UsuarioDAO.getInstance().Listar(sql);
                for (int i = 0; i < usuarioList.Count; i++)
                {
                    dt.Rows.Add(usuarioList[i].id, usuarioList[i].nombre, usuarioList[i].nick, usuarioList[i].pass, usuarioList[i].id_nivel.nombre);
                }
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return dt;
            }
        }

        public void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            dr.DefaultView.RowFilter = $"Nombre LIKE '%" + txtBuscar.Text + "%'";// para buscar coincidencias de el campo nombre
        }
        #endregion
        #region registro
        private void Insertar()//metodo para registrar usuarios
        {

            //registrar usuarios Administrador y vendedor
            if (Convert.ToInt32(cbxNivel.SelectedValue) == 1 || Convert.ToInt32(cbxNivel.SelectedValue) == 2)
            {
                if ((txtNombre.Text.Length > 0 && txtUsuario.Text.Length > 0) && txtPass.Text.Length > 0)
                {
                    DataTable df = Buscar(txtUsuario.Text);//envia a buscar el usuario

                    if (df.Rows.Count == 0)//si no hay resultados realiza la insercion
                    {
                        UsuarioDAO.getInstance().Insertar(new Usuario(txtNombre.Text, txtUsuario.Text, txtPass.Text, new Nivel(Convert.ToInt32(cbxNivel.SelectedValue))));
                        MessageBox.Show("Usuario registrado");
                        dataGridView1.DataSource = ListarUsuario();//actualiza el datagridview                    
                    }
                    if (df.Rows.Count >= 1)
                    {
                        MessageBox.Show("Ya existe un Usuario con ese nombre. Intente otro");
                    }
                }
                else
                {
                    MessageBox.Show("Falta agregar datos");
                }
            }

            // registrar usuarios cliente
            if (Convert.ToInt32(cbxNivel.SelectedValue) == 3)
            {
                string min = txtTelefono.Text;
                if (min.Length < 10)
                {
                    MessageBox.Show("El telefono debe contener 10 digitos");
                }
                if ((txtNombre.Text.Length > 0 && txtUsuario.Text.Length > 0) && (txtPass.Text.Length > 0 && txtTelefono.Text.Length > 0) && txtDireccion.Text.Length > 0)
                {
                    DataTable df = Buscar(txtUsuario.Text);//envia a buscar el usuario
                    if (df.Rows.Count == 0)//si no hay resultados realiza la insercion
                    {
                        UsuarioDAO.getInstance().Insertar(new Usuario(txtNombre.Text, txtUsuario.Text, txtPass.Text, new Nivel(Convert.ToInt32(cbxNivel.SelectedValue))));
                        {
                            ClienteDAO.getInstance().Insertar(new Cliente(txtTelefono.Text, txtDireccion.Text, new Localidad(Convert.ToInt32(cbxLocalidad.SelectedValue)), new Rango(r), new Municipio(Convert.ToInt32(cbxMunicipio.SelectedValue)), new Usuario()));
                            MessageBox.Show("Usuario registrado");
                            dataGridView1.DataSource = ListarUsuario();
                        }
                    }
                    if (df.Rows.Count >= 1)
                    {
                        MessageBox.Show("Ya existe un Usuario con ese nombre. Intente otro");
                    }
                }
                else
                {
                    MessageBox.Show("Falta agregar datos");
                }
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
                cbxNivel.ValueMember = "Id";
                cbxNivel.DisplayMember = "Nivel";
                cbxNivel.DataSource = listarNivel();
                cbxNivel.SelectedIndex = 0;
                cbxNivel.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cbxNivel.AutoCompleteSource = AutoCompleteSource.ListItems;
                #endregion
               
            }
            catch
            {

            }
        }
        private void activarNivel() // Para habilitar o deshabilitar el groupbox de datos de agregar cliente
        {
            try
            {
                if (cbxNivel.Text == "Cliente")
                {
                    groupBox2.Enabled = true;
                    groupBox3.Enabled = true;
                }

                if (cbxNivel.Text == "Administrador" || cbxNivel.Text == "Vendedor")
                {
                    groupBox2.Enabled = false;
                    groupBox3.Enabled = true;

                }
            }
            catch
            {

            }
        }
        #endregion

        #region Entidad Federativa
        public DataTable listarEntidadFederativa()// Metodo que obtiene en forma de lista entidades federativas
        {
            DataTable dt = new DataTable("Entidad Federativa");
            dt.Columns.Add("Id");
            dt.Columns.Add("Entidad Federativa");

            try
            {
                sql = "SELECT id, nombre FROM entidad_federativa ORDER BY nombre ASC;";//lista y ordena alfabeticamente
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

        private void mostrarEntidadFederativa()//Metodo que muestra la entidad
        {
            try
            {
                //Cargar los atributos Entidad Federativa al combobox
                #region
                cbxEntidadFederativa.DataSource = listarEntidadFederativa();
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
                //Cargar los atributos de localidad
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

        #region modificar
        private void modificar()
        {
            //registrar usuarios Administrador y vendedor
            if (Convert.ToInt32(cbxNivel.SelectedValue) == 1 || Convert.ToInt32(cbxNivel.SelectedValue) == 2)
            {


                if ((txtNombre.Text.Length > 0 && txtUsuario.Text.Length > 0) && txtPass.Text.Length > 0)
                {
                    DataTable df = BuscarConId(Convert.ToInt32(txtId.Text), txtUsuario.Text);//envia a buscar el usuario

                    if (df.Rows.Count == 0)//si no hay resultados realiza la insercion
                    {
                        UsuarioDAO.getInstance().Actualizar(Convert.ToInt32(txtId.Text), new Usuario(txtNombre.Text, txtUsuario.Text, txtPass.Text, new Nivel(Convert.ToInt32(cbxNivel.SelectedValue))));
                        MessageBox.Show("Usuario modificado exitosamente");
                        dataGridView1.DataSource = ListarUsuario();//actualiza el datagridview                    
                    }
                    if (df.Rows.Count >= 1)
                    {
                        MessageBox.Show("Ya existe un Usuario con ese nombre. Intente otro");
                    }
                }
                else
                {
                    MessageBox.Show("Falta agregar datos");
                }
            }       
    
            // registrar usuarios cliente
            if (Convert.ToInt32(cbxNivel.SelectedValue) == 3)
            {
                
                if ((txtNombre.Text.Length > 0 && txtUsuario.Text.Length > 0) && (txtPass.Text.Length > 0 && txtTelefono.Text.Length > 0) && txtDireccion.Text.Length > 0)
                {
                    string min = txtTelefono.Text;
                    if (min.Length < 10)
                    {
                        MessageBox.Show("El telefono debe contener 10 digitos");
                    }
                    DataTable df = BuscarConId(Convert.ToInt32(txtId.Text),txtUsuario.Text);//envia a buscar el usuario
                    if (df.Rows.Count == 0)//si no hay resultados realiza la insercion
                    {                        
                        UsuarioDAO.getInstance().Actualizar(Convert.ToInt32(txtId.Text), new Usuario(txtNombre.Text, txtUsuario.Text, txtPass.Text, new Nivel(Convert.ToInt32(cbxNivel.SelectedValue))));
                        {
                            ClienteDAO.getInstance().Actualizar(new Cliente(txtTelefono.Text, txtDireccion.Text, new Localidad(Convert.ToInt32(cbxLocalidad.SelectedValue)), new Rango(r), new Municipio(Convert.ToInt32(cbxMunicipio.SelectedValue)), new Usuario()));
                            MessageBox.Show("Usuario modificado exitosamente");
                            dataGridView1.DataSource = ListarUsuario();
                        }
                    }
                    if (df.Rows.Count >= 1)
                    {
                        MessageBox.Show("Ya existe un Usuario con ese nombre. Intente otro");
                    }
                }
                else
                {
                    MessageBox.Show("Falta agregar datos");
                }
            }
        }
        #endregion
        private void btnClose_Click(object sender, EventArgs e) // Cierra el formulario frmRegistro
        {
            Close();
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)//metodo para validar numero telefonico
        {
            Validar.SoloNumeros(e);
        }      

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)//metodo para validar solo letras 
        {
            Validar.SoloLetras(e);
            //toma la primer letra de cada palabra para convertirla a mayuscula
            txtNombre.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtNombre.Text);
            txtNombre.SelectionStart = txtNombre.Text.Length;
            user = txtNombre.Text;
            user = Regex.Replace(user, @"\s+", "");
            
        }
        
        private void btnModificar_Click(object sender, EventArgs e)
        {
            modificar();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtDireccion.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtDireccion.Text);
            txtDireccion.SelectionStart = txtDireccion.Text.Length;
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SinEspacios(e);
            txtUsuario.Text = txtUsuario.Text.Trim();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("El campo de Nombre esta vacio");
            }
            else
            {
                txtUsuario.Text = user;
            }
                
        }
        
    }
}