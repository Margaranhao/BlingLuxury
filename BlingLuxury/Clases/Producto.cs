using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlingLuxury.Clases
{
    class Producto
    {
        private int id { get; set; }
        private int codigoDeBarras { get; set; }
        private double peso { get; set; }
        private int id_modelo { get; set; }
        private int id_precio_adquisicion { get; set; }
        private int id_color { get; set; }
        private int id_categoria { get; set; }

        public Producto()
        {

        }
        public Producto(int id, int codigoDeBarras, double peso, 
            int id_modelo, int id_precio_adquisicion, int id_color, 
            int id_categoria)
        {
            this.id = id;
            this.codigoDeBarras = codigoDeBarras;
            this.peso = peso;
            this.id_modelo = id_modelo;
            this.id_precio_adquisicion = id_precio_adquisicion;
            this.id_color = id_color;
            this.id_categoria = id_categoria;
        }
        public Producto(int codigoDeBarras, double peso, int id_modelo,
            int id_precio_aduisicion, int id_color, int id_categoria)
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
