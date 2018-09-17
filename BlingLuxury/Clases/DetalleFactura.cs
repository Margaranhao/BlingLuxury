using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlingLuxury.Clases
{
    public class DetalleFactura
    {
        //variables 
        public int id { get; set; }
        public int cantidad { get; set; }
        public double precio { get; set; }

        public Factura id_factura { get; set; }
        public Inventario id_inventario { get; set; }

        // constructor por defecto
        public DetalleFactura()
        {

        }
        //constructor con todos los parametros
        public DetalleFactura(int id, int cantidad, double precio, 
            Factura id_factura, Inventario id_inventario)
        {
            this.id = id;
            this.cantidad = cantidad;
            this.precio = precio;
            this.id_factura = id_factura;
            this.id_inventario = id_inventario;
        }

        //constructor sin id, muy util para inserts
        public DetalleFactura(int cantidad, double precio, Factura id_factura,
            Inventario id_inventario)
        {
            this.cantidad = cantidad;
            this.precio = precio;
            this.id_factura = id_factura;
            this.id_inventario = id_inventario;
        }
    }
}
