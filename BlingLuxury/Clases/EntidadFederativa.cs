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
        

        //constructor por default
        public EntidadFederativa()
        {

        }

        //constructor con todos los parametros, muy util para listar
        public EntidadFederativa(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
            
        }
        //constructor sin id, muy util para inserts
        public EntidadFederativa(string nombre)
        {
            this.nombre = nombre;
        }
        public EntidadFederativa(int id)
        {
            this.id = id;
        }
    }
}
