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
    public class PrecioMayoreoDAO : CRUD<PrecioMayoreo>
    {
        private static PrecioMayoreoDAO precioMayoreoDAO;
        protected string sql;
        public PrecioMayoreoDAO()
        {

        }
        public static PrecioMayoreoDAO getInstance()//evita que la clase se instancie más de una vez
        {
            if (precioMayoreoDAO == null)
                precioMayoreoDAO = new PrecioMayoreoDAO();
            return precioMayoreoDAO;
        }

        public void Actualizar(PrecioMayoreo t, int id)//Actualizar se recibe en la clase a actualizar y el indice de busqueda
        {
            try
            {
                sql = "UPDATE precio_mayoreo SET precio = '" + t.precio + "', id_precio_adquisicion = '" + t.id_precio_adquisicion + "' WHERE id > 0 AND id = '" + id + "';";
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

        public PrecioMayoreo Buscar(string query)//Recibe un query de busqueda
        {
            try
            {
                Conexion.getInstance().setCadenaConnection();
                using (MySqlCommand cmd = new MySqlCommand(query, Conexion.getInstance().getConnection()))
                {
                    // Se crea la clase del objeto a buscar y el DataReader que tomara la respuesta de la consulta
                    MySqlDataReader reader;
                    PrecioMayoreo precioMayoreo;
                    cmd.Prepare();
                    cmd.CommandTimeout = 60;
                    using (reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)//se comprueba que el reader tenga resultado
                        {
                            while (reader.Read())//se recorre cada elemento que obtuvo el reader
                            {
                                // Se crea un nuevo objeto de la clase y se retorna
                                precioMayoreo = new PrecioMayoreo(reader.GetInt32(0), reader.GetDouble(1), new PrecioAdquisicion(reader.GetDouble(4)));
                                return precioMayoreo;
                            }
                            // Se cierra la conexion y se retorna
                            Conexion.getInstance().getConnection().Close();
                            return new PrecioMayoreo();
                        }
                        else
                        {
                            // Se cierra la conecion y se retorna un objeto de la clase vacio 
                            Conexion.getInstance().getConnection().Close();
                            return new PrecioMayoreo();
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void CambiarEstado(int id, PrecioMayoreo t)
        {
            throw new NotImplementedException();
        }

        public void Insertar(PrecioMayoreo t)// Se recibe el objeto de la clase a insertar
        {
            try
            {
                sql = "INSERT INTO precio_mayoreo(precio, id_precio_adquisicion) VALUES ('" + t.precio + "','" + t.id_precio_adquisicion + "');";
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

        public List<PrecioMayoreo> Listar(string query)
        {
            List<PrecioMayoreo> precioMayoreoLista = new List<PrecioMayoreo>();
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
                                precioMayoreoLista.Add(new PrecioMayoreo(reader.GetInt32(0), reader.GetDouble(1), new PrecioAdquisicion(reader.GetDouble(4))));
                            }
                            Conexion.getInstance().Desconectar();
                            reader.Close();
                            return precioMayoreoLista;
                        }
                        else
                        {
                            Conexion.getInstance().Desconectar();
                            reader.Close();
                            return precioMayoreoLista;
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
