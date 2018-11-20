using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlingLuxury.mx.atc;

namespace BlingLuxury.DAO
{
    public class SeguridadDAO
    {
        private static SeguridadDAO seguridad;

        public SeguridadDAO()
        {

        }
        public static SeguridadDAO getInstance()
        {
            if (seguridad == null)
            {
                seguridad = new SeguridadDAO();
            }
            return seguridad;
        }
        public string Encriptar(string password)
        {
            try
            {
                criptografiaService criptografia = new criptografiaService();
                return criptografia.encriptar(password);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public string Desencriptar(string password)
        {
            try
            {
                criptografiaService criptografia = new criptografiaService();
                return criptografia.desencriptar(password);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }

}
