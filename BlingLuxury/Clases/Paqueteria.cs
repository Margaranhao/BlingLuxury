using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlingLuxury.Clases
{
    class Paqueteria
    {
        private int id { get; set; }
        private string nombre { get; set; }
        private int id_envio { get; set; }
        public Paqueteria()
        {

        }
        public Paqueteria(int id, string nombre, int id_envio)
        {
            this.id = id;
            this.nombre = nombre;
            this.id_envio = id_envio;
        }
        public Paqueteria(string nombre, int id_envio)
        {
            this.nombre = nombre;
            this.id_envio = id_envio;
        }
    }
}
