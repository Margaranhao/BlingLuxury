using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlingLuxury.Clases
{
    public class Categoria
    {
        public int id { get; set; }
        public string nombre { get; set; } //****Nombre de la categoria****

        //constructor default
        public Categoria()
        {

        }
        //constructor con todos los parametros
        public Categoria(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }
        //constructor sin id muy util para los insert
        public Categoria(string nombre)
        {
            this.nombre = nombre;
        }
    }
}
