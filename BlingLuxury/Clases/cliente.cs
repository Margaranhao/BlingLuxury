using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlingLuxury.Clases
{
   public class Cliente
    {
        //variables
        public int id { set; get; }
        public string telefono { set; get; }
        public string calle { set; get; }
        public string colonia { set; get; }
        public Rango id_rango { get; set; } //para saber nivel del cliente 
        public Municipio id_municipio { set; get; }
        public Usuario id_usuario { set; get; }

        //constructor vacio
        public Cliente()
        {

        }
        //constructor con todos los parametros util para listar
        public Cliente(int id, string telefono, string calle, string colonia, 
            Rango id_rango, Municipio id_municipio, Usuario id_usuario)
        {
            this.id = id;
            this.telefono = telefono;
            this.calle = calle;
            this.colonia = colonia;
            this.id_rango = id_rango;
            this.id_municipio = id_municipio;
            this.id_usuario = id_usuario;
        }

        //Constructor sin id es muy util cuando no se necesita el id como en los insert
        public Cliente(string telefono, string calle, string colonia, Rango rango, 
            Municipio municipio, Usuario usuario )
        {
            this.telefono = telefono;
            this.calle = calle;
            this.colonia = colonia;
            this.id_rango = id_rango;
            this.id_municipio = id_municipio;
            this.id_usuario = id_usuario;
        }
    }
}
