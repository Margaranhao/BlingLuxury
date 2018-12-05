using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlingLuxury.Clases;
using BlingLuxury.Connection;
using MySql.Data.MySqlClient;
using BlingLuxury.CRUD;

namespace BlingLuxury.DAO
{
    public class TipoLocalidadDAO : CRUD<TipoLocalidad>

    {
        private static TipoLocalidadDAO tipoLocallidadDAO;
        protected string sql;
        public TipoLocalidadDAO()
        {

        }

        public static TipoLocalidadDAO getInstance()//Evitar que la clase se instancie más de una vez
        {
            if (tipoLocallidadDAO == null)
                tipoLocallidadDAO = new TipoLocalidadDAO();
            return tipoLocallidadDAO;
        }
        public void Actualizar(TipoLocalidad t, int id)// Actualizar se recibe en la clase a actualizar y el indice de busqueda
        {
            try
            {
                sql = "UPDATE tipo_localidad SET nombre = '" + t.nombre + "', id_localidad'" + t.id_localidad + "' WHERE id > 0 AND id = '" + id + "';";
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

        public TipoLocalidad Buscar(string query)//Recibe un query de busqueda
        {
            try
            {
                Conexion.getInstance().setCadenaConnection();
                using (MySqlCommand cmd = new MySqlCommand(query, Conexion.getInstance().getConnection()))
                {
                    // Se crea la clase del objeto a buscar y el DataReader que tomara la respuesta de la consulta
                    MySqlDataReader reader;
                    TipoLocalidad tipoLocalidad;
                    cmd.Prepare();
                    cmd.CommandTimeout = 60;
                    using (reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)//se comprueba que el reader tenga resultado
                        {
                            while (reader.Read())//se recorre cada elemento que obtuvo el reader
                            {
                                // Se crea un nuevo objeto de la clase y se retorna
                                tipoLocalidad = new TipoLocalidad(reader.GetInt32(0), reader.GetString(1), new Localidad(reader.GetInt32(2), reader.GetString(3), new Municipio(), new TipoLocalidad(), new CodigoPostal(reader.GetInt32(4))));
                                return tipoLocalidad;
                            }
                            // Se cierra la conexion y se retorna
                            Conexion.getInstance().getConnection().Close();
                            return new TipoLocalidad();
                        }
                        else
                        {
                            // Se cierra la conecion y se retorna un objeto de la clase vacio 
                            Conexion.getInstance().getConnection().Close();
                            return new TipoLocalidad();
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void CambiarEstado(int id, TipoLocalidad t)
        {
            throw new NotImplementedException();
        }

        public void Insertar(TipoLocalidad t) // Se recibe el objeto de la clase a insertar
        {
            try
            {
                sql = "INSERT INTO tipo_localidad (nombre, id_localidad) VALUES ('" + t.nombre + "','" + t.id_localidad + "');";
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

        public List<TipoLocalidad> Listar(string query)
        {
            List<TipoLocalidad> tipoLocalidadLista = new List<TipoLocalidad>();
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
                                tipoLocalidadLista.Add(new TipoLocalidad(reader.GetInt32(0), reader.GetString(1), new Localidad(reader.GetInt32(2), reader.GetString(3), new Municipio(), new TipoLocalidad(), new CodigoPostal())));
                            }
                            Conexion.getInstance().Desconectar();
                            reader.Close();
                            return tipoLocalidadLista;
                        }
                        else
                        {
                            Conexion.getInstance().Desconectar();
                            reader.Close();
                            return tipoLocalidadLista;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<TipoLocalidad> Listar2(string query)
        {
            List<TipoLocalidad> tipoLocalidadLista = new List<TipoLocalidad>();
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
                                string nombre = reader.GetString(1);
                                tipoLocalidadLista.Add(new TipoLocalidad(id, nombre));
                            }
                            Conexion.getInstance().Desconectar();
                            reader.Close();
                            return tipoLocalidadLista;
                        }
                        else
                        {
                            Conexion.getInstance().Desconectar();
                            reader.Close();
                            return tipoLocalidadLista;
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
