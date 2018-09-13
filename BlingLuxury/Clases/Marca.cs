using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlingLuxury.Clases
{
    public class Marca
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public Marca()
        {

        }
        public Marca(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }
        public Marca(string nombre)
        {
            this.nombre = nombre;
        }
    }
}
