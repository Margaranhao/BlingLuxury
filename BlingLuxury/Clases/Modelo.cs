using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlingLuxury.Clases
{
    public class Modelo
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public Marca id_marca { get; set; }
        public Modelo()
        {

        }
        public Modelo(int id, string nombre, Marca id_marca)
        {
            this.id = id;
            this.nombre = nombre;
            this.id_marca = id_marca;
        }
        public Modelo(string nombre, Marca id_marca)
        {
            this.nombre = nombre;
            this.id_marca = id_marca;
        }
    }
}
