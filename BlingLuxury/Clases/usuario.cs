using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using BlingLuxury.Connection;
using System.Windows.Forms;

namespace BlingLuxury.Clases
{
    public class Usuario
    {

        //Las variables de tipo enteras que no requieran operaciones se deben considerar string
        public int id { set; get; }
        public string nombre { set; get; }
        public string nick { set; get; }
        public string pass { set; get; }
        public Nivel id_nivel { set; get; }


        public Usuario()//Toda clase debe tener un constructor vacio
        {

        }
        public Usuario(int id)
        {
            this.id = id;
        }
        public Usuario(int id, string nombre, string nick, string pass, Nivel id_nivel)//Constructor con todos los valores es muy util para listar
        {
            this.id = id;
            this.nombre = nombre;
            this.nick = nick;
            this.pass = pass;
            this.id_nivel = id_nivel;
        }
        public Usuario(string nombre, string nick, string pass, Nivel id_nivel)//Constructor sin id es muy util cuando no se necesita el id como en los insert
        {
            this.nombre = nombre;
            this.nick = nick;
            this.pass = pass;
            this.id_nivel = id_nivel;
        }
        //public bool iniciarSesion(string nick, string pass)
        //{
        //    try
        //    {
        //        string sql = "SELECT id, nombre, nick, pass, id_nivel FROM usuario WHERE nick= @usuario AND pass = @password;";
        //        Conexion.getInstance().setCadenaConnection();
        //        MySqlCommand cmd = new MySqlCommand(sql, Conexion.getInstance().getConnection());
        //        cmd.Parameters.AddWithValue("@usuario", nick);
        //        cmd.Parameters.AddWithValue("@password", pass);
        //        MySqlDataReader dr; 
        //        dr = cmd.ExecuteReader();
        //        dr.Read();
        //        //return dt;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //        //return dt;
        //    }
        //}
    }    
}
