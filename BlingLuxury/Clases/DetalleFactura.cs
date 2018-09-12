using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlingLuxury.Clases
{
    class DetalleFactura
    {
        private int id { get; set; }
        private int cantidad { get; set; }
        private double precio { get; set; }
        private int id_factura { get; set; }
        private int id_inventario { get; set; }

        public DetalleFactura()
        {

        }
        public DetalleFactura(int id, int cantidad, double precio, 
            int id_factura, int id_inventario)
        {
            this.id = id;
            this.cantidad = cantidad;
            this.precio = precio;
            this.id_factura = id_factura;
            this.id_inventario = id_inventario;
        }
        public DetalleFactura(int cantidad, double precio, int id_factura,
            int id_inventario)
        {
            this.cantidad = cantidad;
            this.precio = precio;
            this.id_factura = id_factura;
            this.id_inventario = id_inventario;
        }
    }
}
