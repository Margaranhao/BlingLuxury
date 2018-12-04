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
using System.Security.Cryptography;
using BlingLuxury.Vistas;

namespace BlingLuxury
{
    public partial class fmRegistro : Form
    {
        #region variables
        //variables 
        int r = 1;//asignacion de rango basico a cliente nuevo        
        protected string sql;//variable para las consultas       
        string res;
        string last;
        char[] arregloUsuario = new char[10];
        #endregion
        public fmRegistro()
        {
            InitializeComponent();
        }
        private void fmRegistro_Load(object sender, EventArgs e)
        {
            //muestra los items de los combobox al cargar formulario
            mostrarNivel();
            mostrarEntidadFederativa();           
            mostrarLocalidad();
            mostrarMunicipio();
            mostrarRegistroUsuario();
            mostrarUsuario();    
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
            this.dataGridView2.ColumnHeadersDefaultCellStyle = cabecera;
            #endregion
        }
        private void fmRegistro_Shown(object sender, EventArgs e)//coloca en automatico activo el radio button de cliente
        {
            rbnClientes.Checked = true;
            rbnAdmin.Checked = false;
        }                        
        private void LimpiarRegistro()//para limpiar los campos del formulario
        {
            txtId.Clear();
            txtIdCliente.Clear();
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
        #region recuperar de dgv
        //para colocar los datos de una fila en el datagridview de la tabla Clientes  
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dataGridView1.Rows[e.RowIndex].Cells["idUsuario"].Value.ToString();
            txtIdCliente.Text = dataGridView1.Rows[e.RowIndex].Cells["idCliente"].Value.ToString();
            txtNombre.Text = dataGridView1.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
            txtUsuario.Text = dataGridView1.Rows[e.RowIndex].Cells["Nick"].Value.ToString();
            txtPass.Text = dataGridView1.Rows[e.RowIndex].Cells["Password"].Value.ToString();
            cbxNivel.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells["IdNivel"].Value;
            txtTelefono.Text = dataGridView1.Rows[e.RowIndex].Cells["Telefono"].Value.ToString();
            txtDireccion.Text = dataGridView1.Rows[e.RowIndex].Cells["Domicilio"].Value.ToString();
            cbxEntidadFederativa.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells["idEntFed"].Value;
            cbxMunicipio.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells["idMunicipio"].Value;
            cbxLocalidad.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells["idLocalidad"].Value;
        }
        // Para colocar los datos de una fila de datagridview en campos de texto
        private void dataGridView2_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dataGridView2.Rows[e.RowIndex].Cells["Id"].Value.ToString();
            txtNombre.Text = dataGridView2.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
            txtUsuario.Text = dataGridView2.Rows[e.RowIndex].Cells["Nick"].Value.ToString();
            txtPass.Text = dataGridView2.Rows[e.RowIndex].Cells["Pass"].Value.ToString();
            cbxNivel.SelectedValue = dataGridView2.Rows[e.RowIndex].Cells["id_nivel"].Value;            
        }
        #endregion
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
        public static DataTable BuscarCliente(string nombre)//para evitar nick duplicados
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = "select  usuario.id, usuario.nombre, usuario.nick, usuario.pass,usuario.id_nivel, nivel.nombre,cliente.id_rango, rango.nombre,"+
                            "cliente.telefono, cliente.calle, cliente.id_localidad, localidad.nombre, localidad.id_cp, codigo_postal.nombre, cliente.id_municipio, municipio.nombre, municipio.id_entidad_federativa, "+
                            "entidad_federativa.nombre from usuario inner join cliente on usuario.id = cliente.id_usuario inner join nivel on nivel.id = usuario.id_nivel "+
                            "inner join rango on rango.id = cliente.id_rango inner join localidad on localidad.id = cliente.id_localidad inner join municipio on municipio.id = cliente.id_municipio "+
                            "inner join entidad_federativa on entidad_federativa.id = municipio.id_entidad_federativa inner join codigo_postal on codigo_postal.id = localidad.id_cp; WHERE nick= @nombre;";
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

        #region busqueda de cliente
        public static DataTable BuscarClienteConId(int id, string nombre)//para evitar nick duplicados
        {
            DataTable dt = new DataTable();
            try
            {
               string sql = "select  usuario.id, usuario.nombre, usuario.nick, usuario.pass,usuario.id_nivel, " +
                        "nivel.nombre,cliente.id_rango, rango.nombre," +
                        "cliente.telefono, cliente.calle, cliente.id_localidad, localidad.nombre, localidad.id_cp," +
                        " codigo_postal.nombre, cliente.id_municipio, municipio.nombre, municipio.id_entidad_federativa," +
                        " entidad_federativa.nombre from usuario inner join cliente on usuario.id = cliente.id_usuario " +
                        "inner join nivel on nivel.id = usuario.id_nivel inner join rango on rango.id = cliente.id_rango " +
                        "inner join localidad on localidad.id = cliente.id_localidad inner join municipio on municipio.id = cliente.id_municipio " +
                        "inner join entidad_federativa on entidad_federativa.id = municipio.id_entidad_federativa inner join codigo_postal on " +
                        "codigo_postal.id = localidad.id_cp WHERE nick= @nombre AND NOT id= @id;";
                Conexion.getInstance().setCadenaConnection();
                MySqlCommand cmd = new MySqlCommand(sql, Conexion.getInstance().getConnection());
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@id", id);
                MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                adap.Fill(dt);
                return dt;
            }
            catch (Exception)
            {
                //MessageBox.Show(ex.Message);
                return dt;
            }
        }
        #endregion

        #region Usuario
        DataTable dr = new DataTable();
        DataTable dc = new DataTable();
        public DataTable ListarUsuario()// Metodo que obtiene en forma de lista 
        {
            DataTable dt = new DataTable("Usuario");
            dt.Columns.Add("Id");
            dt.Columns.Add("Nombre");
            dt.Columns.Add("Nick");
            dt.Columns.Add("Pass");
            dt.Columns.Add("id_nivel");

            dataGridView2.DataSource = dt;
            dr = dt;
            try
            {
                sql = "SELECT id, nombre, nick, pass, id_nivel from usuario WHERE NOT id_nivel=3;";
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
                dataGridView2.DataSource = ListarUsuario();
                dataGridView2.Columns[0].Visible = false;
                dataGridView2.Columns[1].Visible = true;
                dataGridView2.Columns[2].Visible = true;
                dataGridView2.Columns[3].Visible = false;
                dataGridView2.Columns[4].Visible = false;
                #endregion
            }
            catch
            {

            }
        }
        #region RegistroClientes
        public DataTable ListarRegistroCliente()// metodo para listar toda la info del cliente
        {
            DataTable dt = new DataTable("Registros");
            dt.Columns.Add("idUsuario");
            dt.Columns.Add("Nombre");
            dt.Columns.Add("Nick");
            dt.Columns.Add("Password");
            dt.Columns.Add("IdNivel");
            dt.Columns.Add("Nivel");
            dt.Columns.Add("IdRango");
            dt.Columns.Add("Rango");
            dt.Columns.Add("idCliente");
            dt.Columns.Add("Telefono");
            dt.Columns.Add("Domicilio");
            dt.Columns.Add("IdLocalidad");
            dt.Columns.Add("Localidad");
            dt.Columns.Add("IdCodigoPostal");
            dt.Columns.Add("Codigo Postal");
            dt.Columns.Add("idMunicipio");
            dt.Columns.Add("Municipio");
            dt.Columns.Add("idEntFed");
            dt.Columns.Add("Estado");

            dataGridView1.DataSource = dt;
            dc = dt;

            try
            {
                sql = "select  usuario.id, usuario.nombre, usuario.nick, usuario.pass,usuario.id_nivel, "+
                        "nivel.nombre,cliente.id_rango, rango.nombre, cliente.id,"+
                        "cliente.telefono, cliente.calle, cliente.id_localidad, localidad.nombre, localidad.id_cp,"+
                        " codigo_postal.nombre, cliente.id_municipio, municipio.nombre, municipio.id_entidad_federativa,"+
                        " entidad_federativa.nombre from usuario inner join cliente on usuario.id = cliente.id_usuario "+
                        "inner join nivel on nivel.id = usuario.id_nivel inner join rango on rango.id = cliente.id_rango "+
                        "inner join localidad on localidad.id = cliente.id_localidad inner join municipio on municipio.id = cliente.id_municipio "+
                        "inner join entidad_federativa on entidad_federativa.id = municipio.id_entidad_federativa inner join codigo_postal on "+
                        "codigo_postal.id = localidad.id_cp;";
                List<RegistroUsuario> registroUsuarioList = RegistroUsuarioDAO.getInstance().Listar(sql);
                for (int i = 0; i < registroUsuarioList.Count; i++)
                {
                    dt.Rows.Add(registroUsuarioList[i].idUsuario, registroUsuarioList[i].nombreUsuario, registroUsuarioList[i].nickUsuario, registroUsuarioList[i].pass, registroUsuarioList[i].usuarioIdNivel.id,
                        registroUsuarioList[i].usuarioIdNivel.nombre, registroUsuarioList[i].usuarioRango.id, registroUsuarioList[i].usuarioRango.nombre,
                       registroUsuarioList[i].idCliente, registroUsuarioList[i].telefonoCliente, registroUsuarioList[i].calleCliente, registroUsuarioList[i].idLocalidad.id, registroUsuarioList[i].idLocalidad.nombre,
                        registroUsuarioList[i].idCp, registroUsuarioList[i].idCp.nombre, registroUsuarioList[i].idMunicipio.id, registroUsuarioList[i].idMunicipio.nombre,
                        registroUsuarioList[i].idEntidadFederativa.id, registroUsuarioList[i].idEntidadFederativa.nombre);                                   
                }
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return dt;
            }
        }
        public void mostrarRegistroUsuario()//Metodo que muestra el usuario
        {
            try
            {
                #region
                dataGridView1.DataSource = ListarRegistroCliente();
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].Visible = true;
                dataGridView1.Columns[2].Visible = true;
                dataGridView1.Columns[3].Visible = true;
                dataGridView1.Columns[4].Visible = false;
                dataGridView1.Columns[5].Visible = true;
                dataGridView1.Columns[6].Visible = false;
                dataGridView1.Columns[7].Visible = true;
                dataGridView1.Columns[8].Visible = false;
                dataGridView1.Columns[9].Visible = true;
                dataGridView1.Columns[10].Visible = true;
                dataGridView1.Columns[11].Visible = false;
                dataGridView1.Columns[12].Visible = true;
                dataGridView1.Columns[13].Visible = false;
                dataGridView1.Columns[14].Visible = true;
                dataGridView1.Columns[15].Visible = false;
                dataGridView1.Columns[16].Visible = true;
                dataGridView1.Columns[17].Visible = false;
                dataGridView1.Columns[18].Visible = true;
                

                #endregion
            }
            catch
            {

            }
        }
        #endregion
        #region Codigo comentado
        /*public DataTable ListarCliente()
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
        }*/
        #endregion
        public void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            dr.DefaultView.RowFilter = $"Nombre LIKE '%" + txtBuscar.Text + "%'";// para buscar coincidencias de el campo nombre
            dc.DefaultView.RowFilter = $"Nombre LIKE '%" + txtBuscar.Text + "%'";            
        }
        #endregion

        #region registro
        private void Insertar()//metodo para registrar usuarios
        {
            //registrar usuarios Administrador y vendedor
            if (Convert.ToInt32(cbxNivel.SelectedValue) == 1 || Convert.ToInt32(cbxNivel.SelectedValue) == 2)
            {
                if (((txtNombre.Text.Length > 0 && txtUsuario.Text.Length > 0) && txtPass.Text.Length > 0)&&(txtUsuario.Text.Length <= 20 && txtPass.Text.Length <=20))
                {
                    DataTable df = Buscar(txtUsuario.Text);//envia a buscar el usuario

                    if (df.Rows.Count == 0)//si no hay resultados realiza la insercion
                    {
                        UsuarioDAO.getInstance().Insertar(new Usuario(txtNombre.Text, txtUsuario.Text, SeguridadDAO.getInstance().Encriptar(txtPass.Text), new Nivel(Convert.ToInt32(cbxNivel.SelectedValue))));
                        MessageBox.Show("Usuario registrado");
                        dataGridView2.DataSource = ListarUsuario();//actualiza el datagridview                    
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
                if (((txtNombre.Text.Length > 0 && txtUsuario.Text.Length > 0) && txtPass.Text.Length > 0) && (txtUsuario.Text.Length <= 20 && txtPass.Text.Length <= 20))
                {
                    DataTable df = Buscar(txtUsuario.Text);//envia a buscar el usuario
                    if (df.Rows.Count == 0)//si no hay resultados realiza la insercion
                    {
                        UsuarioDAO.getInstance().Insertar(new Usuario(txtNombre.Text, txtUsuario.Text, SeguridadDAO.getInstance().Encriptar(txtPass.Text), new Nivel(Convert.ToInt32(cbxNivel.SelectedValue))));
                        {
                            ClienteDAO.getInstance().Insertar(new Cliente(txtTelefono.Text, txtDireccion.Text, new Localidad(Convert.ToInt32(cbxLocalidad.SelectedValue)), new Rango(r), new Municipio(Convert.ToInt32(cbxMunicipio.SelectedValue)), new Usuario()));
                            MessageBox.Show("Usuario registrado");
                            dataGridView1.DataSource = ListarRegistroCliente();
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
        private void cbxNivel_SelectedIndexChanged(object sender, EventArgs e) //para activar el nivel de usuario
        {
            activarNivel();
        }
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
                        UsuarioDAO.getInstance().Actualizar(new Usuario(txtNombre.Text, txtUsuario.Text, SeguridadDAO.getInstance().Encriptar(txtPass.Text), new Nivel(Convert.ToInt32(cbxNivel.SelectedValue))), Convert.ToInt32(txtId.Text));
                        MessageBox.Show("Usuario modificado exitosamente");
                        dataGridView2.DataSource = ListarUsuario();//actualiza el datagridview                    
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
                        UsuarioDAO.getInstance().Actualizar(new Usuario(txtNombre.Text, txtUsuario.Text, SeguridadDAO.getInstance().Encriptar(txtPass.Text), new Nivel(Convert.ToInt32(cbxNivel.SelectedValue))), Convert.ToInt32(txtId.Text));
                        {
                            ClienteDAO.getInstance().Actualizar(new Cliente(txtTelefono.Text, txtDireccion.Text, new Localidad(Convert.ToInt32(cbxLocalidad.SelectedValue)), new Rango(r), new Municipio(Convert.ToInt32(cbxMunicipio.SelectedValue)), new Usuario()), Convert.ToInt32(txtIdCliente.Text));
                            MessageBox.Show("Usuario modificado exitosamente");
                            dataGridView1.DataSource = ListarRegistroCliente();
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

        #region botones
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarRegistro();
        }
        private void btnClose_Click(object sender, EventArgs e) // Cierra el formulario frmRegistro
        {
            Close();
        }
        private void btnModificar_Click(object sender, EventArgs e)//boton para modificar los registros
        {
            modificar();
        }
        private void btnUsuario_Click(object sender, EventArgs e)//genera el usuario automaticamente con el campo de nombre
        {            
            guardarCaracteres();
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("El campo de Nombre esta vacio");
            }
            else
            {
                txtUsuario.Text = res + last + CrearUsuario(4);
                txtPass.Text = res + last + CrearPassword(6);
            }
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
        #endregion

        #region textBox

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
        }
        public void guardarCaracteres() {
           res= txtNombre.Text.Split(' ').First();
            last = txtNombre.Text.Split(' ').Last();
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
        #endregion              
        private void rbnClientes_CheckedChanged(object sender, EventArgs e)//cambia el estado para mostrar la tabla de clientes
        {
            if (rbnClientes.Checked == true)
            {
                rbnAdmin.Checked = false;
                dataGridView1.Visible = true;
                dataGridView2.Visible = false;
            }           
        }
        private void rbnAdmin_CheckedChanged(object sender, EventArgs e)//cambia el estado para mostrar la tabla de administradores
        {
            if (rbnAdmin.Checked == true)
            {
                rbnClientes.Checked = false;
                dataGridView2.Visible = true;
                dataGridView1.Visible = false;
            }
        }
        public string CrearUsuario(int longitud)//random para crear usuario y password
        {
            string caracteres = "abcdefghijklmnopqrstuvwxyz0123456789?!";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while(0 < longitud--)
            {
                res.Append(caracteres[rnd.Next(caracteres.Length)]);
            }
            return res.ToString();
        }
        public string CrearPassword(int longitud)
        {
            string caracteres = "abcdefghijklmnopqrstuvwxyz0123456789?!";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < longitud--)
            {
                res.Append(caracteres[rnd.Next(caracteres.Length)]);
            }
            return res.ToString();
        }
        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Solo aceptara letras
            Validar.SoloLetras(e);
        }
        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                //Maximizar
                WindowState = FormWindowState.Maximized;
            }
            else if (WindowState == FormWindowState.Maximized)
            {
                //Restaurar
                WindowState = FormWindowState.Normal;
            }
        }
        private void btnMin_Click(object sender, EventArgs e)
        {
            //Minimizar
            WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            frmEntidadFederativa entidadFed = new frmEntidadFederativa();
            entidadFed.enviado += new frmEntidadFederativa.pasarEntidad(realizar);
            entidadFed.Show();
            mostrarEntidadFederativa();
        }
        public void realizar(string entidad)
        {
            cbxEntidadFederativa.Text = entidad;
            mostrarEntidadFederativa();
        }

        private void btnMunicipio_Click(object sender, EventArgs e)
        {
            frmMunicipio muni = new frmMunicipio();
            muni.enviado += new frmMunicipio.pasarMunicipio(realizar1);
            muni.Show();
            mostrarMunicipio();
        }
        public void realizar1(string municipio)
        {
            cbxMunicipio.Text = municipio;
            mostrarMunicipio();
        }

        private void btnLocalidad_Click(object sender, EventArgs e)
        {
            frmLocalidad loca = new frmLocalidad();
            loca.enviado += new frmLocalidad.pasarLocalidad(realizar2);
            loca.Show();
            mostrarLocalidad();
        }
        public void realizar2(string localidad)
        {
            cbxLocalidad.Text = localidad;
            mostrarLocalidad();
        }
    }
}