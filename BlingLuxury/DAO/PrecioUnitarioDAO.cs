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
    public class PrecioUnitarioDAO : CRUD<PrecioUnitario>
    {
        private static PrecioUnitarioDAO precioUnitarioDAO;
        protected string sql;
        public PrecioUnitarioDAO()
        {

        }
        public static PrecioUnitarioDAO getInstance()//evita que la clase se instancie más de una vez
        {
            if (precioUnitarioDAO == null)
                precioUnitarioDAO = new PrecioUnitarioDAO();
            return precioUnitarioDAO;
        }


        public void Actualizar(PrecioUnitario t, int id)//Actualizar se recibe en la clase a actualizar y el indice de busqueda
        {
            try
            {
                sql = "UPDATE precio_unitario SET precio = '" + t.precio + "', id_precio_adquisicion = '" + t.id_precio_adquisicion + "' WHERE id > 0 AND id = '" + id + "';";
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

        public PrecioUnitario Buscar(string query)//Recibe un query de busqueda
        {
            try
            {
                Conexion.getInstance().setCadenaConnection();
                using (MySqlCommand cmd = new MySqlCommand(query, Conexion.getInstance().getConnection()))
                {
                    // Se crea la clase del objeto a buscar y el DataReader que tomara la respuesta de la consulta
                    MySqlDataReader reader;
                    PrecioUnitario precioUnitario;
                    cmd.Prepare();
                    cmd.CommandTimeout = 60;
                    using (reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)//se comprueba que el reader tenga resultado
                        {
                            while (reader.Read())//se recorre cada elemento que obtuvo el reader
                            {
                                // Se crea un nuevo objeto de la clase y se retorna
                                precioUnitario = new PrecioUnitario(reader.GetInt32(0), reader.GetDouble(1), new PrecioAdquisicion(reader.GetDouble(4)));
                                return precioUnitario;
                            }
                            // Se cierra la conexion y se retorna
                            Conexion.getInstance().getConnection().Close();
                            return new PrecioUnitario();
                        }
                        else
                        {
                            // Se cierra la conecion y se retorna un objeto de la clase vacio 
                            Conexion.getInstance().getConnection().Close();
                            return new PrecioUnitario();
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void CambiarEstado(int id, PrecioUnitario t)
        {
            throw new NotImplementedException();
        }

        public void Insertar(PrecioUnitario t)// Se recibe el objeto de la clase a insertar
        {
            try
            {
                sql = "INSERT INTO precio_unitario(precio, id_precio_adquisicion) VALUES ('" + t.precio + "','" + t.id_precio_adquisicion + "');";
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

        public List<PrecioUnitario> Listar(string query)
        {
            List<PrecioUnitario> precioUnitarioLista = new List<PrecioUnitario>();
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
                                precioUnitarioLista.Add(new PrecioUnitario(reader.GetInt32(0), reader.GetDouble(1), new PrecioAdquisicion(reader.GetDouble(4))));
                            }
                            Conexion.getInstance().Desconectar();
                            reader.Close();
                            return precioUnitarioLista;
                        }
                        else
                        {
                            Conexion.getInstance().Desconectar();
                            reader.Close();
                            return precioUnitarioLista;
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
