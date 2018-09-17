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
        public string nombre { get; set; } //nombre del Estado/Entidad Federativa
        public Municipio id_municipio { get; set; }

        //constructor por default
        public EntidadFederativa()
        {

        }

        //constructor con todos los parametros, muy util para listar
        public EntidadFederativa(int id, string nombre, Municipio id_municipio)
        {
            this.id = id;
            this.nombre = nombre;
            this.id_municipio = id_municipio;
        }
        //constructor sin id, muy util para inserts
        public EntidadFederativa(string nombre, Municipio id_municipio)
        {
            this.nombre = nombre;
            this.id_municipio = id_municipio;
        }
    }
}
