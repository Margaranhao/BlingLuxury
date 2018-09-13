using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlingLuxury.Clases
{
  public class TipoEnvio
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public DateTime fecha { get; set; }
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
