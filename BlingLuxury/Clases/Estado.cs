using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlingLuxury.Clases
{
    class Estado
    {
        private int id { get; set; }
        private string nombre { get; set; }

        public Estado()
        {

        }
        public Estado(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }
        public Estado(string nombre)
        {
            this.nombre = nombre;
        }

    }
}
