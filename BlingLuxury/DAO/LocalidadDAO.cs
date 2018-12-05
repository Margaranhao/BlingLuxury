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
    public class LocalidadDAO : CRUD<Localidad>
    {
        private static LocalidadDAO localidadDAO;
        protected string sql;
        public LocalidadDAO()
        {

        }
        public static LocalidadDAO getInstance()//evita que la clase se instancie más de una vez
        {
            if (localidadDAO == null)
                localidadDAO = new LocalidadDAO();
            return localidadDAO;
        }

        public void Actualizar(Localidad t,int id)//Actualizar se recibe en la clase a actualizar y el indice de busqueda
        {
            try
            {
                sql = "UPDATE localidad SET nombre = '" + t.nombre + "',id_municipio = " + t.id_municipio.id + ", id_tipo_localidad = " + t.id_tipo_localidad.id + ", id_cp = '" + t.id_cp.id + "' WHERE id > 0 AND id = '" + id + "';";
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

        public Localidad Buscar(string query)//Recibe un query de busqueda
        {
            try
            {
                Conexion.getInstance().setCadenaConnection();
                using (MySqlCommand cmd = new MySqlCommand(query, Conexion.getInstance().getConnection()))
                {
                    // Se crea la clase del objeto a buscar y el DataReader que tomara la respuesta de la consulta
                    MySqlDataReader reader;
                    Localidad localidad;
                    cmd.Prepare();
                    cmd.CommandTimeout = 60;
                    using (reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)//se comprueba que el reader tenga resultado
                        {
                            while (reader.Read())//se recorre cada elemento que obtuvo el reader
                            {
                                // Se crea un nuevo objeto de la clase y se retorna
                                localidad = new Localidad(reader.GetInt32(0), reader.GetString(1), new Municipio(), new TipoLocalidad(), new CodigoPostal());
                                return localidad;
                            }
                            // Se cierra la conexion y se retorna
                            Conexion.getInstance().getConnection().Close();
                            return new Localidad();
                        }
                        else
                        {
                            // Se cierra la conecion y se retorna un objeto de la clase vacio 
                            Conexion.getInstance().getConnection().Close();
                            return new Localidad();
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void CambiarEstado(int id, Localidad t)
        {
            throw new NotImplementedException();
        }

        public void Insertar(Localidad t)// Se recibe el objeto de la clase a insertar
        {
            try
            {
                sql = "INSERT INTO localidad(nombre, id_municipio, id_tipo_localidad, id_cp) VALUES ('" + t.nombre + "'," + t.id_municipio.id + "," + t.id_tipo_localidad.id + "," + t.id_cp.nombre + ");";
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

        public List<Localidad> Listar(string query)
        {
            List<Localidad> localidadLista = new List<Localidad>();
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
                                localidadLista.Add(new Localidad(reader.GetInt32(0), reader.GetString(1), new Municipio(), new TipoLocalidad(),new CodigoPostal()));
                            }
                            Conexion.getInstance().Desconectar();
                            reader.Close();
                            return localidadLista;
                        }
                        else
                        {
                            Conexion.getInstance().Desconectar();
                            reader.Close();
                            return localidadLista;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Localidad> Listar2(string query)
        {
            List<Localidad> localidadLista = new List<Localidad>();
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
                                Municipio id_municipio = new Municipio(reader.GetInt32(2), reader.GetString(3));
                                TipoLocalidad id_tipo_localidad = new TipoLocalidad(reader.GetInt32(4), reader.GetString(5));
                                CodigoPostal id_cp = new CodigoPostal(reader.GetInt32(6), reader.GetString(7));

                                localidadLista.Add(new Localidad(id, nombre, id_municipio, id_tipo_localidad, id_cp));
                            }
                            Conexion.getInstance().Desconectar();
                            reader.Close();
                            return localidadLista;
                        }
                        else
                        {
                            Conexion.getInstance().Desconectar();
                            reader.Close();
                            return localidadLista;
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
