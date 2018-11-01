using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using BlingLuxury.Connection;
using BlingLuxury.DAO;

namespace BlingLuxury.Clases
{
    public class Nivel
    {
        public int id { get; set; }
        public string nombre { get; set; }//Nivel de acceso del usuario

        //constructor por default
        public Nivel()
        {

        }
        public Nivel(int id)
        {
            this.id = id;
        }
        //constructor con todos los parametros, muy util para listar
        public Nivel(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }
        public Nivel(string nombre)
        {
            this.nombre = nombre;
        }
    }
}
