using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlingLuxury.Validaciones
{
    public static class Seguridad
    {        
            /// Encripta una cadena
            public static string Encriptar(this string Encpassword)
            {
                string resultado = string.Empty;
                byte[] encriptar = System.Text.Encoding.Unicode.GetBytes(Encpassword);
                resultado = Convert.ToBase64String(encriptar);
                return resultado;
            }
            /// Esta función desencripta la cadena que le envíamos en el parámentro de entrada.
            public static string DesEncriptar(this string Despassword)
            {
                string resultado = string.Empty;
                byte[] desencriptar = Convert.FromBase64String(Despassword);
                //result = System.Text.Encoding.Unicode.GetString(decryted, 0, decryted.ToArray().Length);
                resultado = System.Text.Encoding.Unicode.GetString(desencriptar);
                return resultado;
            }
    }
}
