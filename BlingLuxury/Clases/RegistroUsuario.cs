using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlingLuxury.Clases
{
    public class RegistroUsuario
    {
        //usuario
        public int idUsuario { get; set; }
        public string nombreUsuario { get; set; }
        public string nickUsuario { get; set; }
        public string pass { get; set; }
        public Nivel usuarioIdNivel { get; set; }
        public Rango usuarioRango { get; set; }
        public int idCliente { get; set; }
        public string telefonoCliente { get; set; }
        public string calleCliente { get; set; }
        public Localidad idLocalidad { get; set; }
        public CodigoPostal idCp { get; set; }
        public Municipio idMunicipio { get; set; }
        public EntidadFederativa idEntidadFederativa { get; set; }
        //constructor vacio
        public RegistroUsuario()
        {

        }
        
        public RegistroUsuario(int idUsuario, string nombreUsuario, string nickUsuario, string pass,
       Nivel usuarioIdNivel, Rango usuarioRango, int idCliente, string telefonoCliente, string calleCliente, Localidad idLocalidad, 
       CodigoPostal idCp, Municipio idMunicipio, EntidadFederativa idEntidadFederativa)
       
        {
            this.idUsuario = idUsuario;
            this.nombreUsuario = nombreUsuario;
            this.nickUsuario = nickUsuario;
            this.pass = pass;
            this.usuarioIdNivel = usuarioIdNivel;
            this.usuarioRango = usuarioRango;
            this.idCliente = idCliente;
            this.telefonoCliente = telefonoCliente;
            this.calleCliente = calleCliente;
            this.idLocalidad = idLocalidad;
            this.idCp = idCp;
            this.idMunicipio = idMunicipio;
            this.idEntidadFederativa = idEntidadFederativa;
            
        }

    }
}
