using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlingLuxury.Clases
{
    class Rango
    {
        private int id { get; set; }
        private string nombre { get; set; }

        public Rango()
        {

        }
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
