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
        public RegistroProducto id_registroProducto { get; set; }
        public Modelo id_modelo { get; set; }
        public Marca id_marca { get; set; }
        public PrecioAdquisicion id_precioAdquisicion { get; set;}
        public Color id_color { get; set; }
        public Categoria id_categoria { get; set; }
        public Usuario id_usuario { get; set; }

        //constructor por default
        public Inventario()
        {

        }

        //constructor con todos los parametros, muy util para listar
        public Inventario(int id, DateTime fecha, int cantidad, 
            RegistroProducto id_registroProducto, Modelo id_modelo, Marca id_marca,
            PrecioAdquisicion id_precioAdquisicion, Color id_color,
            Categoria id_categoria, Usuario id_usuario)
        {
            this.id = id;
            this.fecha = fecha;
            this.cantidad = cantidad;
            this.id_registroProducto = id_registroProducto;
            this.id_modelo = id_modelo;
            this.id_marca = id_marca;
            this.id_precioAdquisicion = id_precioAdquisicion;
            this.id_color = id_color;
            this.id_categoria = id_categoria;
            this.id_usuario = id_usuario;
        }

        //constructor sin id, muy util para inserts
        public Inventario(DateTime fecha, int cantidad,
            RegistroProducto id_registroProducto, Modelo id_modelo, Marca id_marca,
            PrecioAdquisicion id_precioAdquisicion, Color id_color,
            Categoria id_categoria, Usuario id_usuario)
        {
            this.fecha = fecha;
            this.cantidad = cantidad;
            this.id_registroProducto = id_registroProducto;
            this.id_modelo = id_modelo;
            this.id_marca = id_marca;
            this.id_precioAdquisicion = id_precioAdquisicion;
            this.id_color = id_color;
            this.id_categoria = id_categoria;
            this.id_usuario = id_usuario;
        }
        public Inventario(int id,DateTime fecha, int cantidad,
            RegistroProducto id_registroProducto, Modelo id_modelo, Marca id_marca,
            PrecioAdquisicion id_precioAdquisicion, Color id_color,
            Categoria id_categoria)
        {
            this.id = id;
            this.fecha = fecha;
            this.cantidad = cantidad;
            this.id_registroProducto = id_registroProducto;
            this.id_modelo = id_modelo;
            this.id_marca = id_marca;
            this.id_precioAdquisicion = id_precioAdquisicion;
            this.id_color = id_color;
            this.id_categoria = id_categoria;
        }
        public Inventario(DateTime fecha,int cantidad, RegistroProducto id_registroProducto)
        {
            this.fecha = fecha;
            this.cantidad = cantidad;
            this.id_registroProducto = id_registroProducto;
        }
        public Inventario(int cantidad, RegistroProducto id_registroProducto)
        {            
            this.cantidad = cantidad;
            this.id_registroProducto = id_registroProducto;
        }
    }
}
