using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlingLuxury.Clases
{
    public class Inventario
    {
        public int id { get; set; }
        public DateTime fecha { get; set; }
        public int cantidad { get; set; }
        public Producto id_producto { get; set; }
        public Usuario id_usuario { get; set; }

        public Inventario()
        {

        }
        public Inventario(int id, DateTime fecha, int cantidad, 
            Producto id_producto, Usuario id_usuario)
        {
            this.id = id;
            this.fecha = fecha;
            this.cantidad = cantidad;
            this.id_producto = id_producto;
            this.id_usuario = id_usuario;
        }
        public Inventario(DateTime fecha, int cantidad, Producto id_producto,
            Usuario id_usuario)
        {
            this.fecha = fecha;
            this.cantidad = cantidad;
            this.id_producto = id_producto;
            this.id_usuario = id_usuario;
        }
    }
}
