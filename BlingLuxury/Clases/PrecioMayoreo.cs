using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlingLuxury.Clases
{
    class PrecioMayoreo
    {
        private int id { get; set; }
        private double precio { get; set; }
        private int id_precio_adquisicion { get; set; }

        public PrecioMayoreo()
        {

        }
        public PrecioMayoreo(int id, double precio, int id_precio_adquisicion)
        {
            this.id = id;
            this.precio = precio;
            this.id_precio_adquisicion = id_precio_adquisicion;
        }
        public PrecioMayoreo(double precio, int id_precio_adquisicion)
        {
            this.precio = precio;
            this.id_precio_adquisicion = id_precio_adquisicion;
        }
    }
}
