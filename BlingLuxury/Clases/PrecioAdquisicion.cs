using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlingLuxury.Clases
{
    class PrecioAdquisicion
    {
        private int id { get; set; }
        private double precio { get; set; }
        public PrecioAdquisicion()
        {

        }
        public PrecioAdquisicion(int id, double precio)
        {
            this.id = id;
            this.precio = precio;
        }
        public PrecioAdquisicion(double precio)
        {
            this.precio = precio;
        }
    }
}
