using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    class Validar
    {

        public static void ValidarLetra(KeyPressEventArgs v)
        {

            if (Char.IsLetter(v.KeyChar))
            {
                v.Handled = false;
            }else if (Char.IsSeparator(v.KeyChar))
            {
                v.Handled = false;
            }else if (char.IsControl(v.KeyChar))
            {
                v.Handled = false;
            }
            else
            {
                v.Handled = true;
            }

        }

        public static void ValidarNumero(KeyPressEventArgs v)
        {
            if (Char.IsDigit(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (Char.IsSeparator(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (char.IsControl(v.KeyChar))
            {
                v.Handled = false;
            }
            else
            {
                v.Handled = true;
            }
        }
    }
}
