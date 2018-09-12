using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlingLuxury.Clases
{
    class Modelo
    {
        private int id { get; set; }
        private string nombre { get; set; }
        private int id_marca { get; set; }
        public Modelo()
        {

        }
        public Modelo(int id, string nombre, int id_marca)
        {
            this.id = id;
            this.nombre = nombre;
            this.id_marca = id_marca;
        }
        public Modelo(string nombre, int id_marca)
        {
            this.nombre = nombre;
            this.id_marca = id_marca;
        }
    }
}
