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
        public string nombre { get; set; }
        public Color()
        {

        }
        public Color(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }
        public Color(string nombre)
        {
            this.nombre = nombre;
        }
    }
}
