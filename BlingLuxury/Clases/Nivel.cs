using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlingLuxury.Clases
{
    class Nivel
    {
        private int id { get; set; }
        private string nombre { get; set; }
        public Nivel()
        {

        }
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
