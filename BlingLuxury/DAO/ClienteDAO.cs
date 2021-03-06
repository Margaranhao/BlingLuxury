﻿using BlingLuxury.Clases;
using BlingLuxury.Connection;
using BlingLuxury.CRUD;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlingLuxury.DAO
{
    public class ClienteDAO : CRUD<Cliente>
    {
        private static ClienteDAO clienteDAO;
        protected string sql;

        public ClienteDAO()
        {

        }

        public static ClienteDAO getInstance() //Evita que la clase se instancie más de una vez
        {
            if (clienteDAO == null)
                clienteDAO = new ClienteDAO();
            return clienteDAO;
        }
        public void Actualizar(Cliente t, int id) //Actualizar se recibe en la clase a actualizar y el indice de busqueda
        {
            try
            {
                sql = "UPDATE cliente SET telefono = '" + t.telefono + "', calle = '" + t.calle + "', id_localidad = " + t.id_localidad.id + ", id_rango = " + t.id_rango.id + ", id_municipio = " + t.id_municipio.id + ", id_usuario = " + t.id_usuario.id + " WHERE id > 0 AND id = " + id + ";";
                Conexion.getInstance().setCadenaConnection();
                MySqlCommand cmd = new MySqlCommand(sql, Conexion.getInstance().getConnection());
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                Conexion.getInstance().getConnection().Close();
            }
            catch (Exception )
            {

                //throw new Exception(ex.Message);
            }
        }
       
        public Cliente Buscar(string query) //Recibe un query de busqueda
        {
            try
            {
                Conexion.getInstance().setCadenaConnection();
                using (MySqlCommand cmd = new MySqlCommand(query, Conexion.getInstance().getConnection()))
                {
                    //Se crea la clase del objeto a buscar y el DataReader que tomara la respuesta de la consulta
                    MySqlDataReader reader;
                    Cliente cliente;
                    cmd.Prepare();
                    cmd.CommandTimeout = 60;
                    using (reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)//Se comprueba que el reader tenga resultado
                        {
                            while (reader.Read())//Se recorre cada elemento que obtuvo el reader
                            {
                                //Se crea un nuevo objeto de la clase y se retorna
                                cliente = new Cliente(reader.GetInt32(0),reader.GetString(1), reader.GetString(2),new Localidad(), new Rango(), new Municipio(), new Usuario());
                                return cliente;
                            }
                            //Se Cierra la conexión y se retorna
                            Conexion.getInstance().getConnection().Close();
                            return new Cliente();
                        }
                        else
                        {
                            //Se cierra la conexión y se retorna una objeto de la clase vacio
                            Conexion.getInstance().getConnection().Close();
                            return new Cliente();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void CambiarEstado(int id, Cliente t)
        {
            throw new NotImplementedException();
        }
        public void Insertar(Cliente t) // Se recibe el objeto de la clase a insertar
        {
            try
            {               
                sql = "insert into cliente(telefono, calle, id_localidad, id_rango, id_municipio, id_usuario)values('" + t.telefono + "','" + t.calle + "'," + t.id_localidad.id + "," + t.id_rango.id + "," + t.id_municipio.id + ", last_insert_id());";
                Conexion.getInstance().setCadenaConnection();
                MySqlCommand cmd = new MySqlCommand(sql, Conexion.getInstance().getConnection());
                cmd.Prepare();
                cmd.CommandTimeout = 60;
                cmd.ExecuteNonQuery();
                Conexion.getInstance().getConnection().Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error");
            }
        }
        public List<Cliente> Listar(string query) //Se recibe el query de busqueda
        {
            List<Cliente> clienteLista = new List<Cliente>();
            try
            {
                Conexion.getInstance().setCadenaConnection();
                using (MySqlCommand cmd = new MySqlCommand(query, Conexion.getInstance().getConnection()))
                {
                    MySqlDataReader reader;
                    cmd.Prepare();
                    cmd.CommandTimeout = 60;
                    using (reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                clienteLista.Add(new Cliente(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), new Localidad(), new Rango(), new Municipio(), new Usuario()));
                            }
                            Conexion.getInstance().Desconectar();
                            reader.Close();
                            return clienteLista;
                        }
                        else
                        {
                            Conexion.getInstance().Desconectar();
                            reader.Close();
                            return clienteLista;
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }        
    }
}

