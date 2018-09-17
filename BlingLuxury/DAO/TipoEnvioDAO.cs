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
    public class TipoEnvioDAO : CRUD<TipoEnvio>
    {
        private static TipoEnvioDAO tipoEnvioDAO;
        protected string sql;
        public TipoEnvioDAO()
        {

        }
        public static TipoEnvioDAO getInstance()//evita que la clase se instancie más de una vez
        {
            if (tipoEnvioDAO == null)
                tipoEnvioDAO = new TipoEnvioDAO();
            return tipoEnvioDAO;
        }
        public void Actualizar(int id, TipoEnvio t)//Actualizar se recibe en la clase a actualizar y el indice de busqueda
        {
            try
            {
                sql = "UPDATE tipo_envio SET nombre = '" + t.nombre + "', fecha = '" + t.fecha + "' WHERE id > 0 AND id = '" + id + "';";
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
        public TipoEnvio Buscar(string query)//Recibe un query de busqueda
        {
            try
            {
                Conexion.getInstance().setCadenaConnection();
                using (MySqlCommand cmd = new MySqlCommand(query, Conexion.getInstance().getConnection()))
                {
                    // Se crea la clase del objeto a buscar y el DataReader que tomara la respuesta de la consulta
                    MySqlDataReader reader;
                    TipoEnvio tipoEnvio;
                    cmd.Prepare();
                    cmd.CommandTimeout = 60;
                    using (reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)//se comprueba que el reader tenga resultado
                        {
                            while (reader.Read())//se recorre cada elemento que obtuvo el reader
                            {
                                // Se crea un nuevo objeto de la clase y se retorna
                                tipoEnvio = new TipoEnvio(reader.GetInt32(0), reader.GetString(1), reader.GetDateTime(2));
                                return tipoEnvio;
                            }
                            // Se cierra la conexion y se retorna
                            Conexion.getInstance().getConnection().Close();
                            return new TipoEnvio();
                        }
                        else
                        {
                            // Se cierra la conecion y se retorna un objeto de la clase vacio 
                            Conexion.getInstance().getConnection().Close();
                            return new TipoEnvio();
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void CambiarEstado(int id, TipoEnvio t)
        {
            throw new NotImplementedException();
        }

        public void Insertar(TipoEnvio t)// Se recibe el objeto de la clase a insertar
        {
            try
            {
                sql = "INSERT INTO tipo_envio(nombre, fecha) VALUES ('" + t.nombre + "','" + t.fecha + "');";
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


        public List<TipoEnvio> Listar(string query)
        {
            List<TipoEnvio> tipoEnvioLista = new List<TipoEnvio>();
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
                                tipoEnvioLista.Add(new TipoEnvio(reader.GetInt32(0), reader.GetString(1), reader.GetDateTime(2)));
                            }
                            Conexion.getInstance().Desconectar();
                            reader.Close();
                            return tipoEnvioLista;
                        }
                        else
                        {
                            Conexion.getInstance().Desconectar();
                            reader.Close();
                            return tipoEnvioLista;
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

