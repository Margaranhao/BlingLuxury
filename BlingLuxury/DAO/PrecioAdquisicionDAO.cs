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
    public class PrecioAdquisicionDAO : CRUD<PrecioAdquisicion>
    {
        private static PrecioAdquisicionDAO precioAdquisicionDAO;
        protected string sql;
        public PrecioAdquisicionDAO()
        {

        }
        public static PrecioAdquisicionDAO getInstance()//evita que la clase se instancie más de una vez
        {
            if (precioAdquisicionDAO == null)
                precioAdquisicionDAO = new PrecioAdquisicionDAO();
            return precioAdquisicionDAO;
        }

        public void Actualizar(int id, PrecioAdquisicion t)//Actualizar se recibe en la clase a actualizar y el indice de busqueda
        {
            try
            {
                sql = "UPDATE precio_adquisicion SET precio = '" + t.precio + "' WHERE id > 0 AND id = '" + id + "';";
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

        public PrecioAdquisicion Buscar(string query)//Recibe un query de busqueda
        {
            try
            {
                Conexion.getInstance().setCadenaConnection();
                using (MySqlCommand cmd = new MySqlCommand(query, Conexion.getInstance().getConnection()))
                {
                    // Se crea la clase del objeto a buscar y el DataReader que tomara la respuesta de la consulta
                    MySqlDataReader reader;
                    PrecioAdquisicion precioAdquisicion;
                    cmd.Prepare();
                    cmd.CommandTimeout = 60;
                    using (reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)//se comprueba que el reader tenga resultado
                        {
                            while (reader.Read())//se recorre cada elemento que obtuvo el reader
                            {
                                // Se crea un nuevo objeto de la clase y se retorna
                                precioAdquisicion = new PrecioAdquisicion(reader.GetInt32(0), reader.GetDouble(1));
                                return precioAdquisicion;
                            }
                            // Se cierra la conexion y se retorna
                            Conexion.getInstance().getConnection().Close();
                            return new PrecioAdquisicion();
                        }
                        else
                        {
                            // Se cierra la conecion y se retorna un objeto de la clase vacio 
                            Conexion.getInstance().getConnection().Close();
                            return new PrecioAdquisicion();
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void CambiarEstado(int id, PrecioAdquisicion t)
        {
            throw new NotImplementedException();
        }

        public void Insertar(PrecioAdquisicion t)// Se recibe el objeto de la clase a insertar
        {
            try
            {
                sql = "INSERT INTO precio_adquisicion(precio_adquisicion) VALUES ('" + t.precio + "');";
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


        public List<PrecioAdquisicion> Listar(string query)
        {
            List<PrecioAdquisicion> precioAdquisicionLista = new List<PrecioAdquisicion>();
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
                                precioAdquisicionLista.Add(new PrecioAdquisicion(reader.GetInt32(0), reader.GetDouble(1)));
                            }
                            Conexion.getInstance().Desconectar();
                            reader.Close();
                            return precioAdquisicionLista;
                        }
                        else
                        {
                            Conexion.getInstance().Desconectar();
                            reader.Close();
                            return precioAdquisicionLista;
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
