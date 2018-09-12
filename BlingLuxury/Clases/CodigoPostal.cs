using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlingLuxury.Clases
{
    class CodigoPostal
    {
        private int id { get; set; }
        private string nombre { get; set; }

        public CodigoPostal()
        {

        }
        public CodigoPostal(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }
        public CodigoPostal(string nombre)
        {
            this.nombre = nombre;
        }
    }
}
