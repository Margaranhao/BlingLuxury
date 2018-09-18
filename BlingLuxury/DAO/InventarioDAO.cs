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
        public void Actualizar(int id, Inventario t)//Actualizar se recibe en la clase a actualizar y el indice de busqueda
        {
            try
            {
                sql = "UPDATE inventario SET fecha = '" + t.fecha + "', cantidad = '" + t.cantidad + "', id_producto = '" + t.id_producto + "', id_usuario = '" + t.id_usuario + "' WHERE id > 0 AND id = '" + id + "';";
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
                                inventario = new Inventario(reader.GetInt32(0), reader.GetDateTime(1), reader.GetInt32(2), new Producto(reader.GetInt32(3), reader.GetDouble(4), new Modelo(reader.GetString(5), new Marca(reader.GetString(6))), new PrecioAdquisicion(reader.GetDouble(7)), new Color(reader.GetString(8)), new Categoria(reader.GetString(9))), new Usuario(reader.GetString(10), reader.GetString(12), reader.GetString(13), new Nivel(reader.GetString(14))));
                                return inventario;
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
                sql = "INSERT INTO inventario(fecha, cantidad, id_producto, id_usuario)VALUES('" + t.fecha + "','" + t.cantidad + "','" + t.id_producto + "','" + t.id_usuario + "');";
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
                                inventarioLista.Add(new Inventario(reader.GetInt32(0), reader.GetDateTime(1), reader.GetInt32(2), new Producto(reader.GetInt32(3), reader.GetDouble(4), new Modelo(reader.GetString(5), new Marca(reader.GetString(6))), new PrecioAdquisicion(reader.GetDouble(7)), new Color(reader.GetString(8)), new Categoria(reader.GetString(9))), new Usuario(reader.GetString(10), reader.GetString(12), reader.GetString(13), new Nivel(reader.GetString(14)))));
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
