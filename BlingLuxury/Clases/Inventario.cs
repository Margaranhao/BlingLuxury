using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlingLuxury.Clases
{
    class Inventario
    {
        private int id { get; set; }
        private DateTime fecha { get; set; }
        private int cantidad { get; set; }
        private int id_producto { get; set; }
        private int id_usuario { get; set; }

        public Inventario()
        {

        }
        public Inventario(int id, DateTime fecha, int cantidad, 
            int id_producto, int id_usuario)
        {
            this.id = id;
            this.fecha = fecha;
            this.cantidad = cantidad;
            this.id_producto = id_producto;
            this.id_usuario = id_usuario;
        }
        public Inventario(DateTime fecha, int cantidad, int id_producto,
            int id_usuario)
        {
            this.fecha = fecha;
            this.cantidad = cantidad;
            this.id_producto = id_producto;
            this.id_usuario = id_usuario;
        }
    }
}
