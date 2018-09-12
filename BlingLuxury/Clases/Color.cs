using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlingLuxury.Clases
{
    class Color
    {
        private int id { get; set; }
        private string nombre { get; set; }
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
