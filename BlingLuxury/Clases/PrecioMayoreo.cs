using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlingLuxury.Clases
{
    public class PrecioMayoreo
    {
        public int id { get; set; }
        public double precio { get; set; }
        public PrecioAdquisicion id_precio_adquisicion { get; set; }

        public PrecioMayoreo()
        {

        }
        public PrecioMayoreo(int id, double precio, PrecioAdquisicion id_precio_adquisicion)
        {
            this.id = id;
            this.precio = precio;
            this.id_precio_adquisicion = id_precio_adquisicion;
        }
        public PrecioMayoreo(double precio, PrecioAdquisicion id_precio_adquisicion)
        {
            this.precio = precio;
            this.id_precio_adquisicion = id_precio_adquisicion;
        }
    }
}
