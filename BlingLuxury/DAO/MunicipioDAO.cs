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
    public class MunicipioDAO : CRUD<Municipio>
    {
        private static MunicipioDAO municipioDAO;
        protected string sql;
        public MunicipioDAO()
        {

        }
        public static MunicipioDAO getInstance()//evita que la clase se instancie más de una vez
        {
            if (municipioDAO == null)
                municipioDAO = new MunicipioDAO();
            return municipioDAO;
        }

        public void Actualizar(int id, Municipio t)//Actualizar se recibe en la clase a actualizar y el indice de busqueda
        {
            try
            {
                sql = "UPDATE municipio SET nombre = '" + t.nombre + "', id entidad_federativa= '" + t.id_entidad_federativa + "' WHERE id > 0 AND id = '" + id + "';";
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

        public Municipio Buscar(string query)//Recibe un query de busqueda
        {
            try
            {
                Conexion.getInstance().setCadenaConnection();
                using (MySqlCommand cmd = new MySqlCommand(query, Conexion.getInstance().getConnection()))
                {
                    // Se crea la clase del objeto a buscar y el DataReader que tomara la respuesta de la consulta
                    MySqlDataReader reader;
                    Municipio municipio;
                    cmd.Prepare();
                    cmd.CommandTimeout = 60;
                    using (reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)//se comprueba que el reader tenga resultado
                        {
                            while (reader.Read())//se recorre cada elemento que obtuvo el reader
                            {
                                // Se crea un nuevo objeto de la clase y se retorna
                                municipio = new Municipio(reader.GetInt32(0), reader.GetString(1), new EntidadFederativa());
                                return municipio;
                            }
                            // Se cierra la conexion y se retorna
                            Conexion.getInstance().getConnection().Close();
                            return new Municipio();
                        }
                        else
                        {
                            // Se cierra la conecion y se retorna un objeto de la clase vacio 
                            Conexion.getInstance().getConnection().Close();
                            return new Municipio();
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void CambiarEstado(int id, Municipio t)
        {
            throw new NotImplementedException();
        }

        public void Insertar(Municipio t)// Se recibe el objeto de la clase a insertar
        {
            try
            {
                sql = "INSERT INTO municipio(nombre, id_entidad_federativa) VALUES ('" + t.nombre + "','" + t.id_entidad_federativa + "');";
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

        public List<Municipio> Listar(string query)
        {
            List<Municipio> municipioLista = new List<Municipio>();
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
                                
                                municipioLista.Add(new Municipio(reader.GetInt32(0), reader.GetString(1), new EntidadFederativa()));
                                //municipioLista.Add(new Municipio(reader.GetInt32(0), reader.GetString(1), new Localidad(reader.GetInt32(2), reader.GetString(3), new CodigoPostal())));

                            }
                            Conexion.getInstance().Desconectar();
                            reader.Close();
                            return municipioLista;
                        }
                        else
                        {
                            Conexion.getInstance().Desconectar();
                            reader.Close();
                            return municipioLista;
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
