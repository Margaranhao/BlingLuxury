﻿using BlingLuxury.Clases;
using BlingLuxury.DAO;
using BlingLuxury.Validaciones;
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
    public partial class frmMunicipio : Form
    {
        #region Variables
        //Funcionalidad para pasar datos de un formulario a otro en este caso de categoria a Producto
        //Por medio de eventos y delegados 
        /*Un delegado es un tipo que representa referencias a métodos con una lista de parámetros
        determinada y un tipo de valor devuelto. Cuando se crea una instancia de un delegado, 
        puede asociar su instancia a cualquier método mediante una firma y un tipo de valor devuelto compatibles.
        */
        public delegate void pasarMunicipio(string municipio); //Variable Delegado
        public event pasarMunicipio enviado; //Evento
        protected string sql;
        protected int id;
        //private static DatosTableAdapter adaptador = new DatosTableAdapter();
        #endregion
        public frmMunicipio()
        {
            InitializeComponent();
        }
        #region Interaccón BD
        #region Municipio        
        public DataTable listarMunicipios() //Metodo que obtiene de forma de lista de Municipio
        {
            DataTable dt = new DataTable("Municipio");
            dt.Columns.Add("Id");
            dt.Columns.Add("Municipio");
            dt.Columns.Add("Estado id");
            dt.Columns.Add("Estado");          
            try
            {
                sql = "SELECT mu.id, mu.nombre AS MUNICIPIO, enf.id, enf.nombre AS ESTADO FROM municipio mu INNER JOIN entidad_federativa enf ON mu.id_entidad_federativa = enf.id;";
                List<Municipio> municipioLista = MunicipioDAO.getInstance().Listar2(sql);
                for (int i = 0; i < municipioLista.Count; i++)
                {
                    dt.Rows.Add(municipioLista[i].id, municipioLista[i].nombre, municipioLista[i].id_entidad_federativa.id, municipioLista[i].id_entidad_federativa.nombre);
                }
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return dt;
            }
        }
        public void mostrarMunicipios() //Muestra los datos en el dataGridView
        {
            try
            {
                #region
                dgvMunicipios.DataSource = listarMunicipios();
                id = Convert.ToInt32(txtId.Text);
                #endregion
            }
            catch
            {

            }
        }
        #endregion Municipio    
        #region Insertar
        private void Insertar() //Metodo para Insertar Colores
        {
            try
            {
                MunicipioDAO.getInstance().Insertar(new Municipio(txtMunicipio.Text, new EntidadFederativa(txtEstado.Text)));
                //Manda mensaje de confirmacion cuando se agregan los datos
                MessageBox.Show("Municipio agregado correctamente", "Municipio Agregado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                mostrarMunicipios(); //Actualiza el DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion Insertar            
        #endregion Interacción BD
        #region Eventos        
        private void btnEsAgregar_Click(object sender, EventArgs e) // Condición para no insertar si el TextBox esta vacio
        {
            if (txtMunicipio.Text.Trim() == "" && txtEstado.Text.Trim() == "") // Condición para no insertar si el TextBox esta vacio
            {
               //errorMunicipio.SetError(txtEstado, "No se pueden dejar el campo vacio"); //Mensaje en que aparece en el icono del Error Provider
                errorMunicipio.SetError(txtMunicipio, "No se pueden dejar el campo vacio"); //Mensaje en que aparece en el icono del Error Provider
                //Mensaje en caso de que se cumpla la condicion del TextBox vacio
                MessageBox.Show("No se puede insertar un valor vacio", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMunicipio.Focus();
                //txtEstado.Focus();
            }
            else
            {
                Insertar(); // Se Manda llamar el metodo para insertar los datos
                enviado(txtMunicipio.Text); //Envia de un TextBox los datos al formulario y los ubica en el ComboBox Municipio
                errorMunicipio.Clear(); // Limpia el Error
                enviado(txtEstado.Text); //Envia de un TextBox los datos al formulario y los ubica en el ComboBox Estado
                errorMunicipio.Clear(); // Limpia el Error
                this.Close(); //Cierra el formulario Municipio
            }
        }

        private void btnMuCancelar_Click(object sender, EventArgs e) //Botón para cancelar peticion y cerrar formulario
        {
            //Condicion donde pregunta si deceas cancelar y salir del formulario a travez de un mensaje en ventana emergente
            if (MessageBox.Show("¿Desea Cancelar?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close(); //si se cumple Se cierra el Formulario Entidad Federativa
            }
        }
        #endregion Eventos        
        #region Interacción Formulario
        private void frmMunicipio_Load(object sender, EventArgs e)
        {
            mostrarMunicipios();
        }        
        #endregion Interacción Formulario        

        #region Validaciones    
        private void txtMunicipio_Validating(object sender, CancelEventArgs e) //Metodo que valida el TextBox para que no se insete vacio
        {
            if (txtMunicipio.Text.Trim() == "") //Condicion para que el TextBox no este vacio
            {
                errorMunicipio.SetError(txtMunicipio, "Campo con Valor vacio"); //Mensaje en el icono de Error Provider
                txtMunicipio.Focus();
            }
            else
            {
                errorMunicipio.Clear(); //Limpia el icono cuando insertas datos
            }
        }
        private void txtEstado_Validating(object sender, CancelEventArgs e) //Metodo que valida el TextBox para que no se insete vacio
        {
            if (txtEstado.Text.Trim() == "") //Condicion para que el TextBox no este vacio
            {
                errorMunicipio.SetError(txtEstado, "Campo con Valor vacio"); //Mensaje en el icono de Error Provider
                txtEstado.Focus();
            }
            else
            {
                errorMunicipio.Clear(); //Limpia el icono cuando insertas datos
            }
        }
        private void txtMunicipio_TextChanged(object sender, EventArgs e) //Busca las coincidencias al momento de teclear datos en el TextBox
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dgvMunicipios.DataSource;
            bs.Filter = $"Municipio like '%" + txtMunicipio.Text + "%'";
            dgvMunicipios.DataSource = bs;
        }
        private void txtEstado_TextChanged(object sender, EventArgs e) //Busca las coincidencias al momento de teclear datos en el TextBox
        {         
            BindingSource bs = new BindingSource();
            bs.DataSource = dgvMunicipios.DataSource;
            bs.Filter = $"Estado like '%" + txtEstado.Text + "%'";
            dgvMunicipios.DataSource = bs;
        }
        private void txtMunicipio_KeyPress(object sender, KeyPressEventArgs e) //Valida que al ingresar datos solo acepta Letras
        {
            //Solo Acepta Letras
            Validar.SoloLetras(e);
        }
        private void txtEstado_KeyPress(object sender, KeyPressEventArgs e) //Valida que al ingresar datos solo acepta Letras
        {
            //Solo Acepta Letras
            Validar.SoloNumeros(e);
        }      
    }
}
#endregion Validaciones
