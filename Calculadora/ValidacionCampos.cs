using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public class ValidacionCampos
    {
        public void validacion(KeyPressEventArgs e,int tipo)
        {
            if (tipo == 1)
            {
                //solo permite numeros
                if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
                {
                    e.Handled = true;
                }
            }
            if (tipo == 2)
            {
                //decimales para tomar las comas 
                if ((e.KeyChar >= 32 && e.KeyChar <= 43) || (e.KeyChar >= 58 && e.KeyChar <= 255) || (e.KeyChar <= 47 && e.KeyChar >= 45))
                {
                    e.Handled = true;
                }
            }
        }
    }
}
