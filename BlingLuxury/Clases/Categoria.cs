using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlingLuxury.Clases
{
    public class Categoria
    {
        public int id { get; set; }
        public string nombre { get; set; }

        public Categoria()
        {

        }
        public Categoria(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }
        public Categoria(string nombre)
        {
            this.nombre = nombre;
        }
    }
}
