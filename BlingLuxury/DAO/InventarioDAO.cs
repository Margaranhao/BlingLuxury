using BlingLuxury.Clases;
using BlingLuxury.Connection;
using BlingLuxury.CRUD;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlingLuxury.DAO
{
    class InventarioDAO : CRUD<Inventario>
    {
        private static InventarioDAO inventarioDAO;
        protected string sql;

        public InventarioDAO()
        {

        }

        public static InventarioDAO getInstance() //Evita que la clase se instancie más de una vez
        {
            if (inventarioDAO == null)
                inventarioDAO = new InventarioDAO();
            return inventarioDAO;
        }
        public void Actualizar(Inventario t, int id) //Actualizar se recibe en la clase a actualizar y el indice de busqueda
        {
            try
            {
                sql = "UPDATE inventario SET fecha ='" + t.fecha + "', cantidad ='" + t.cantidad + "', id_producto ='" + t.id_registroProducto + "', id_usuario ='" + t.id_usuario + "' WHERE id > 0 AND id = '" + id + "';";
                Conexion.getInstance().setCadenaConnection();
                MySqlCommand cmd = new MySqlCommand(sql, Conexion.getInstance().getConnection());
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                Conexion.getInstance().getConnection().Close();
                throw new NotImplementedException();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public Inventario Buscar(string query) //Recibe un query de busqueda
        {
            try
            {
                Conexion.getInstance().setCadenaConnection();
                using (MySqlCommand cmd = new MySqlCommand(query, Conexion.getInstance().getConnection()))
                {
                    //Se crea la clase del objeto a buscar y el DataReader que tomara la respuesta de la consulta
                    MySqlDataReader reader;
                    Inventario inventario;
                    cmd.Prepare();
                    cmd.CommandTimeout = 60;
                    using (reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)//Se comprueba que el reader tenga resultado
                        {
                            while (reader.Read())//Se recorre cada elemento que obtuvo el reader
                            {
                                //Se crea un nuevo objeto de la clase y se retorna
                                int id = reader.GetInt32(0);
                                DateTime fecha = reader.GetDateTime(1);
                                int cantidad = reader.GetInt32(2);
                                RegistroProducto registroProducto = new RegistroProducto(reader.GetInt32(3), reader.GetString(4));
                                Modelo modelo = new Modelo(reader.GetInt32(6), reader.GetString(7));
                                Marca marca = new Clases.Marca(reader.GetInt32(8),reader.GetString(9));
                                PrecioAdquisicion precioAdquisicion = new PrecioAdquisicion(reader.GetInt32(10), reader.GetDouble(11));
                                Color color = new Color(reader.GetInt32(12), reader.GetString(13));
                                Categoria categoria = new Categoria(reader.GetInt32(14), reader.GetString(15));
                                //Usuario usuario = new Usuario(reader.GetInt32(16), reader.GetString(17), reader.GetString(18), reader.GetString(19), new Nivel());

                                inventario = new Inventario(id, fecha, cantidad, registroProducto ,modelo, marca, precioAdquisicion, color,
                                    categoria);
                            }
                            //Se Cierra la conexión y se retorna
                            Conexion.getInstance().getConnection().Close();
                            return new Inventario();
                        }
                        else
                        {
                            //Se cierra la conexión y se retorna una objeto de la clase vacio
                            Conexion.getInstance().getConnection().Close();
                            return new Inventario();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void CambiarEstado(int id, Inventario t)
        {
            throw new NotImplementedException();
        }

        public void Insertar(Inventario t) // Se recibe el objeto de la clase a insertar
        {
            try
            {
                sql = "INSERT INTO inventario(fecha, cantidad, id_producto, id_usuario)VALUES('" + t.fecha + "','" + t.cantidad + "','" + t.id_registroProducto + "','" + t.id_usuario + "');";
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

        public List<Inventario> Listar(string query) //Se recibe el query de busqueda
        {
            List<Inventario> inventarioLista = new List<Inventario>();
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
                                int id = reader.GetInt32(0);
                                DateTime fecha = reader.GetDateTime(1);
                                int cantidad = reader.GetInt32(2);
                                RegistroProducto registroProducto = new RegistroProducto(reader.GetString(3));
                                Modelo modelo = new Modelo(reader.GetString(4));
                                Marca marca = new Marca(reader.GetString(5));
                                PrecioAdquisicion precioAdquisicion = new PrecioAdquisicion(reader.GetDouble(6));
                                Color color = new Color(reader.GetString(7));
                                Categoria categoria = new Categoria(reader.GetString(8));
                                //Usuario usuario = new Usuario(reader.GetInt32(16), reader.GetString(17), reader.GetString(18), reader.GetString(19), new Nivel());

                                inventarioLista.Add(new Inventario(id, fecha, cantidad, registroProducto, modelo, marca, precioAdquisicion, 
                                    color, categoria));
                            }
                            Conexion.getInstance().Desconectar();
                            reader.Close();
                            return inventarioLista;
                        }
                        else
                        {
                            Conexion.getInstance().Desconectar();
                            reader.Close();
                            return inventarioLista;
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