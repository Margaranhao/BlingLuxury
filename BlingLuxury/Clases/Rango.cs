using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlingLuxury.Clases
{
   public class Rango
    {
        public int id { get; set; }
        public string nombre { get; set; }

        public Rango() //Constructor vacio
        {

        }
        //constructor con todos los parametros, muy util para listar
        public Rango(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }
        public Rango(string nombre)
        {
            this.nombre = nombre;
        }
    }
}
