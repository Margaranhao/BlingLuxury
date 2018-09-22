using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlingLuxury.Clases
{
    public class Color
    {
        public int id { get; set; }
        public string nombre { get; set; } //nombre del color
        //constructor por default
        public Color()
        {

        }
        public Color(int id)
        {
            this.id = id;
        }
        //constructor con todos los parametros, muy util para listar
        public Color(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }
        //constructor sin id, muy util para inserts
        public Color(string nombre)
        {
            this.nombre = nombre;
        }
    }
}
