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
    public class DepositoDAO : CRUD<Deposito>
    {
        private static DepositoDAO depositoDAO;
        protected string sql;

        public DepositoDAO()
        {

        }

        public static DepositoDAO getInstance() //Evita que la clase se instancie más de una vez
        {
            if (depositoDAO == null)
                depositoDAO = new DepositoDAO();
            return depositoDAO;
        }
        public void Actualizar(int id, Deposito t) //Actualizar se recibe en la clase a actualizar y el indice de busqueda
        {
            try
            {
                sql = "UPDATE deposito SET cantidad = '" + t.cantidad + "', fecha = '" + t.fecha + "', id_estado = '" + t.id_estado + "', id_usuario = '" + t.id_usuario + "' WHERE id > 0 AND id = '" + id + "';";
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

        public Deposito Buscar(string query) //Recibe un query de busqueda
        {
            try
            {
                Conexion.getInstance().setCadenaConnection();
                using (MySqlCommand cmd = new MySqlCommand(query, Conexion.getInstance().getConnection()))
                {
                    MySqlDataReader reader;
                    Deposito deposito;
                    cmd.Prepare();
                    cmd.CommandTimeout = 60;
                    using (reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)//Se comprueba que el reader tenga resultado
                        {
                            while (reader.Read())//Se recorre cada elemento que obtuvo el reader
                            {
                               //Se crea un nuevo objeto de la clase y se retorna
                                deposito = new Deposito(reader.GetInt32(0), reader.GetDouble(1), reader.GetDateTime(2), new Estado(reader.GetString(3)), new Usuario(reader.GetString(4), reader.GetString(5), reader.GetString(6), new Nivel(reader.GetString(7))));
                                return deposito;
                            }
                            // Se cierra la conexion y se retorna
                            Conexion.getInstance().getConnection().Close();
                            return new Deposito();
                        }
                        else
                        {
                            // Se cierra la conecion y se retorna un objeto de la clase vacio
                            Conexion.getInstance().getConnection().Close();
                            return new Deposito();
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public void CambiarEstado(int id, Deposito t)
        {
            throw new NotImplementedException();
        }

        public void Insertar(Deposito t) // Se recibe el objeto de la clase a insertar
        {
            try
            {
                sql = "INSERT INTO deposito(cantidad, fecha, id_estado, id_usuario)VALUES('" + t.cantidad + "','" + t.fecha + "','" + t.id_estado + "','" + t.id_usuario + "');";
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

        public List<Deposito> Listar(string query) //Se recibe el query de busqueda
        {
            List<Deposito> depositoLista = new List<Deposito>();
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
                                depositoLista.Add(new Deposito(reader.GetInt32(0), reader.GetDouble(1), reader.GetDateTime(2), new Estado(reader.GetString(3)), new Usuario(reader.GetString(4), reader.GetString(5), reader.GetString(6), new Nivel(reader.GetString(7))))); 
                            }
                            Conexion.getInstance().Desconectar();
                            reader.Close();
                            return depositoLista;
                        }
                        else
                        {
                            Conexion.getInstance().Desconectar();
                            reader.Close();
                            return depositoLista;
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
