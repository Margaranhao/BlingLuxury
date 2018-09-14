using BlingLuxury.Clases;
using BlingLuxury.CONEXION;
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

        public static DepositoDAO getInstance()
        {
            if (depositoDAO == null)
                depositoDAO = new DepositoDAO();
            return depositoDAO;
        }
        public void Actualizar(int id, Deposito t)
        {
            try
            {
                sql = "UPDATE deposito SET fecha = '" + t.fecha + "' WHERE id > 0 AND id = '" + id + "';";
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

        public Deposito Buscar(string query)
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
                                deposito = new Deposito();// reader.GetInt32(0), reader.GetString(1), reader.GetDouble(2), reader.GetDateTime(3), new Estado(reader.GetString(4), new Usuario(reader.GetString(5)));
                                return deposito;
                            }
                            Conexion.getInstance().getConnection().Close();
                            return new Deposito();
                        }
                        else
                        {
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

        public void Insertar(Deposito t)
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

        public List<Deposito> Listar(string query)
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
                                depositoLista.Add(new Deposito());// reader.GetInt32(0), reader.GetString(1), reader.GetString(2), new Estado(reader.GetString(3)), new Usuario(reader.GetString(4)));
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
