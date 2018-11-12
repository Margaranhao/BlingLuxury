using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace BlingLuxury.Validaciones
{
    public class Validar
    {
        //metodo para validar si los valores son numericos
        public static void SoloNumeros(KeyPressEventArgs pE)
        {
            if (char.IsDigit(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else if (char.IsControl(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else
            {
                pE.Handled = true;
                MessageBox.Show("NO SE ADMITEN LETRAS, SOLO NÚMEROS", "¡¡¡ADVERTENCIA!!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }
        }
        //Metodo para validar que los valores sean caracteres
        public static void SoloLetras(KeyPressEventArgs pE)
        {
            if (Char.IsLetter(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else if (Char.IsControl(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else if (Char.IsSeparator(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else
            {
                pE.Handled = true;
                MessageBox.Show("NO SE ADMITEN NÚMEROS, SOLO LETRAS", "¡¡¡ADVERTENCIA!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        //Validar que no acepte espacios
        public static void SinEspacios(KeyPressEventArgs pE)
        {
            if (Char.IsSeparator(pE.KeyChar))
                pE.Handled = true;
        }
        //Para validar solo numereos decimales
        public static void SoloDecimales(KeyPressEventArgs pE)
        {
            if (Char.IsDigit(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else if (Char.IsSeparator(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else if (Char.IsControl(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else if (pE.KeyChar.ToString().Equals("."))
            {
                pE.Handled = false;
            }
            else
            {
                pE.Handled = true;
                MessageBox.Show("SOLO SE ADMITEN NÚMEROS DECIMALES", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
