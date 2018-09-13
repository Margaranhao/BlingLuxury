using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlingLuxury.Clases
{
    public class EntidadFederativa
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public Municipio id_municipio { get; set; }
        public EntidadFederativa()
        {

        }
        public EntidadFederativa(int id, string nombre, Municipio id_municipio)
        {
            this.id = id;
            this.nombre = nombre;
            this.id_municipio = id_municipio;
        }
        public EntidadFederativa(string nombre, Municipio id_municipio)
        {
            this.nombre = nombre;
            this.id_municipio = id_municipio;
        }
    }
}
