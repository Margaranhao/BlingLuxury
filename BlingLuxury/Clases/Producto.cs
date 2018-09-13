using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlingLuxury.Clases
{
    public class Producto
    {
        public int id { get; set; }
        public int codigoDeBarras { get; set; }
        public double peso { get; set; }
        public Modelo id_modelo { get; set; }
        public PrecioAdquisicion id_precio_adquisicion { get; set; }
        public Color id_color { get; set; }
        public Categoria id_categoria { get; set; }

        public Producto()
        {

        }
        public Producto(int id, int codigoDeBarras, double peso, 
            Modelo id_modelo, PrecioAdquisicion id_precio_adquisicion, Color id_color, 
            Categoria id_categoria)
        {
            this.id = id;
            this.codigoDeBarras = codigoDeBarras;
            this.peso = peso;
            this.id_modelo = id_modelo;
            this.id_precio_adquisicion = id_precio_adquisicion;
            this.id_color = id_color;
            this.id_categoria = id_categoria;
        }
        public Producto(int codigoDeBarras, double peso, Modelo id_modelo,
            PrecioAdquisicion id_precio_aduisicion, Color id_color, Categoria id_categoria)
        {
            this.codigoDeBarras = codigoDeBarras;
            this.peso = peso;
            this.id_modelo = id_modelo;
            this.id_precio_adquisicion = id_precio_adquisicion;
            this.id_color = id_color;
            this.id_categoria = id_categoria;
        }
    }
}
