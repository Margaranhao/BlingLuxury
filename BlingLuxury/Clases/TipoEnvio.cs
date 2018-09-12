using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlingLuxury.Clases
{
    class TipoEnvio
    {
        private int id { get; set; }
        private string nombre { get; set; }
        private DateTime fecha { get; set; }
        public TipoEnvio()
        {

        }
        public TipoEnvio(int id, string nombre, DateTime fecha)
        {
            this.id = id;
            this.nombre = nombre;
            this.fecha = fecha;
        }
        public TipoEnvio(string nombre, DateTime fecha)
        {
            this.nombre = nombre;
            this.fecha = fecha;
        }
    }
}
