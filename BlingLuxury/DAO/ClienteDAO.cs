using BlingLuxury.Clases;
using BlingLuxury.CONEXION;
using BlingLuxury.CRUD;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlingLuxury.DAO
{
    public class ClienteDAO : CRUD<Cliente>
    {
        private static ClienteDAO clienteDAO;
        protected string sql;

        public ClienteDAO()
        {

        }

        public static ClienteDAO getInstance()
        {
            if (clienteDAO == null)
                clienteDAO = new ClienteDAO();
            return clienteDAO;
        }
        public void Actualizar(int id, Cliente t)
        {
            try
            {
                sql = "UPDATE cliente SET telefono = '" + t.telefono + "' WHERE id > 0 AND id = '" + id + "';";
                Conexion.getInstance().setCadenaConnection();
                MySqlCommand cmd = new MySqlCommand(sql, Conexion.getInstance().getConnection());
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                Conexion.getInstance().getConnection().Close();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public Cliente Buscar(string query)
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
                                cliente = new Cliente(); //Falta Código reader.GetInt32(0).....
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

        public void Insertar(Cliente t)
        {
            try
            {
                sql = "INSERT INTO cliente(telefono, calle , colonia, id_rango, id_municipio, id_usuario)VALUES('" + t.telefono + "','" + t.calle + "','" + t.colonia + "','" + t.id_rango + "','" + t.id_municipio + "','" + t.id_usuario + "');";
                Conexion.getInstance().setCadenaConnection();
                MySqlCommand cmd = new MySqlCommand(sql, Conexion.getInstance().getConnection());
                cmd.Prepare();
                cmd.CommandTimeout = 60;
                cmd.ExecuteNonQuery();
                Conexion.getInstance().getConnection().Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Cliente> Listar(string query)
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
                                clienteLista.Add(new Cliente()); //Falta Código reader.GetInt32(0).....
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

