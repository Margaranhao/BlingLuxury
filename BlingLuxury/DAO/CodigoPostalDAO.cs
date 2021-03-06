﻿using BlingLuxury.Clases;
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
    public class CodigoPostalDAO : CRUD<CodigoPostal>
    {
        private static CodigoPostalDAO codigopostalDAO;
        protected string sql;

        public CodigoPostalDAO()
        {

        }

        public static CodigoPostalDAO getInstance() //Evita que la clase se instancie más de una vez
        {
            if (codigopostalDAO == null)
                codigopostalDAO = new CodigoPostalDAO();
            return codigopostalDAO;
        }
        public void Actualizar(CodigoPostal t, int id) //Actualizar se recibe en la clase a actualizar y el indice de busqueda
        {
            try
            {
                sql = "UPDATE codigo_postal SET nombre = '" + t.nombre + "' WHERE id > 0 AND id = '" + id + "';";
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

        public CodigoPostal Buscar(string query) //Recibe un query de busqueda
        {
            try
            {
                Conexion.getInstance().setCadenaConnection();
                using (MySqlCommand cmd = new MySqlCommand(query, Conexion.getInstance().getConnection()))
                {
                    //Se crea la clase del objeto a buscar y el DataReader que tomara la respuesta de la consulta
                    MySqlDataReader reader;
                    CodigoPostal codigopostal;
                    cmd.Prepare();
                    cmd.CommandTimeout = 60;
                    using (reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)//Se comprueba que el reader tenga resultado
                        {
                            while (reader.Read())//Se recorre cada elemento que obtuvo el reader
                            {
                                //Se crea un nuevo objeto de la clase y se retorna
                                codigopostal = new CodigoPostal(reader.GetInt32(0), reader.GetString(1));
                                return codigopostal;
                            }
                            //Se Cierra la conexión y se retorna
                            Conexion.getInstance().getConnection().Close();
                            return new CodigoPostal();
                        }
                        else
                        {
                            //Se cierra la conexión y se retorna una objeto de la clase vacio
                            Conexion.getInstance().getConnection().Close();
                            return new CodigoPostal();
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public void CambiarEstado(int id, CodigoPostal t)
        {
            throw new NotImplementedException();
        }

        public void Insertar(CodigoPostal t) // Se recibe el objeto de la clase a insertar
        {
            try
            {
                sql = "INSERT INTO codigo_postal(nombre)VALUES('" + t.nombre + "');";
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

        public List<CodigoPostal> Listar(string query) // Recibe el query de busqueda
        {
            List<CodigoPostal> codigopostalLista = new List<CodigoPostal>();
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
                                codigopostalLista.Add(new CodigoPostal(reader.GetInt32(0), reader.GetString(1)));
                            }
                            Conexion.getInstance().Desconectar();
                            reader.Close();
                            return codigopostalLista;
                        }
                        else
                        {
                            Conexion.getInstance().Desconectar();
                            reader.Close();
                            return codigopostalLista;
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
