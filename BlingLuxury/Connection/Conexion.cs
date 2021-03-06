﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace BlingLuxury.Connection
{
    public class Conexion
    {
        public static Conexion conexion;
        public MySqlConnection connection;

        public string cadenaConexion = "Server = 127.0.0.1; port = 3306; database = bling_luxury; Uid = root; Pwd = root;";

        public static MySqlConnection Connection { get; internal set; }

        public Conexion()
        {

        }

        public static Conexion getInstance()
        {
            if (conexion == null)
                conexion = new Connection.Conexion();
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

            //MessageBox.Show("Conexión Establecida");

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

        internal void setCadenaConnetion()
        {
            throw new NotImplementedException();
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
