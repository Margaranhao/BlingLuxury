using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace BlingLuxury.CONEXION
{
    class Conexion
    {
        private static Conexion conexion;
        private MySqlConnection connection;

        protected string cadenaConexion = "Server = localhost; port = 3306; database = bling_luxury; Uid = root; Pwd = root;";

        public Conexion()
        {

        }

        public static Conexion getInstance()
        {
            if (conexion == null)
                conexion = new CONEXION.Conexion();
            conexion.Conectar();
            return conexion;
        }

        private void Conectar()
        {
            try
            {
                connection.Close();
            }
            catch (Exception)
            {

            }
            connection = new MySqlConnection(getCadenaConnection());
            connection.Open();
            MessageBox.Show("Conexión Establecida");
        }

        public void Desconectar()
        {
            try
            {
                connection.Close();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public MySqlConnection getConnection()
        {
            return connection;

        }
        public Boolean isConnection()
        {
            return connection != null;
        }
        public string getCadenaConnection()
        {
            return cadenaConexion;
        }
        public void setCadenaConnection()
        {
            this.cadenaConexion = "Server = localhost; port = 3306; database = bling_luxury; Uid = root; Pwd = root;";
        }
    }
}
