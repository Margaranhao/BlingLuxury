using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using BlingLuxury.Clases;
using BlingLuxury.Connection;
using BlingLuxury.CRUD;

namespace BlingLuxury.DAO
{
    public class ProductoDAO : CRUD<Producto>
    {
        private static ProductoDAO productoDAO;
        protected string sql;
        public ProductoDAO()
        {

        }
        public static ProductoDAO getInstance()//evita que la clase se instancie más de una vez
        {
            if (productoDAO == null)
                productoDAO = new ProductoDAO();
            return productoDAO;
        }


        public void Actualizar(int id, Producto t)//Actualizar se recibe en la clase a actualizar y el indice de busqueda
        {
            try
            {
                sql = "UPDATE producto SET codigo_de_barras = '" + t.codigoDeBarras + "', peso = '" + t.peso + "', id_modelo ='" + t.id_modelo + "', id_precio_adquisicion = '" + t.id_precio_adquisicion + "', id_color = '" + t.id_color + "', id_categoria = '" + t.id_categoria + "' WHERE id > 0 AND id = '" + id + "';";
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

        public Producto Buscar(string query)//Recibe un query de busqueda
        {
            try
            {
                Conexion.getInstance().setCadenaConnection();
                using (MySqlCommand cmd = new MySqlCommand(query, Conexion.getInstance().getConnection()))
                {
                    // Se crea la clase del objeto a buscar y el DataReader que tomara la respuesta de la consulta
                    MySqlDataReader reader;
                    Producto producto;
                    cmd.Prepare();
                    cmd.CommandTimeout = 60;
                    using (reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)//se comprueba que el reader tenga resultado
                        {
                            while (reader.Read())//se recorre cada elemento que obtuvo el reader
                            {
                                // Se crea un nuevo objeto de la clase y se retorna
                                producto = new Producto(reader.GetInt32(0), reader.GetDouble(1), new Modelo(reader.GetString(2), new Marca(reader.GetString(3))), new PrecioAdquisicion(reader.GetDouble(4)), new Color(reader.GetString(5)), new Categoria(reader.GetString(6)));
                                return producto;
                            }
                            // Se cierra la conexion y se retorna
                            Conexion.getInstance().getConnection().Close();
                            return new Producto();
                        }
                        else
                        {
                            // Se cierra la conecion y se retorna un objeto de la clase vacio 
                            Conexion.getInstance().getConnection().Close();
                            return new Producto();
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void CambiarEstado(int id, Producto t)
        {
            throw new NotImplementedException();
        }

        public void Insertar(Producto t)// Se recibe el objeto de la clase a insertar
        {
            try
            {
                sql = "INSERT INTO producto(codigo_de_barras, peso, id_modelo, id_precio_adquisicion, id_color, id_categoria) VALUES ('" + t.codigoDeBarras + "','" + t.peso + "''" + t.id_modelo + "','" + t.id_precio_adquisicion + "', '" + t.id_color + "', '" + t.id_categoria + "');";
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

        public List<Producto> Listar(string query)
        {
            List<Producto> productoLista = new List<Producto>();
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
                                productoLista.Add(new Producto(reader.GetInt32(0), reader.GetDouble(1), new Modelo(reader.GetString(2), new Marca(reader.GetString(3))), new PrecioAdquisicion(reader.GetDouble(4)), new Color(reader.GetString(5)), new Categoria(reader.GetString(6))));
                            }
                            Conexion.getInstance().Desconectar();
                            reader.Close();
                            return productoLista;
                        }
                        else
                        {
                            Conexion.getInstance().Desconectar();
                            reader.Close();
                            return productoLista;
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

