using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class BonosDeInteres
    {
        public BonosDeInteres() 
        {
            valorPresente = 0;
            valorCupon = 0;
            interesRequerido = 0;
            numeroPeriodo = 0;
            resultado = 0;
            monto = 0;

        }
        public double valorPresente { get; set; }
        public double valorCupon { get; set; }
        public double interesRequerido { get; set; }
        public double numeroPeriodo { get; set; }
        public double resultado { get; set; }
        public double monto {  get; set; }

        private double EcuacionValorPresente()
        {
            double interes = interesRequerido / 100;
            double parte1 = valorCupon / interes;
            double parte2 = (1 - (1 / Math.Pow((1 + interes), numeroPeriodo)));
            double parte3 = (monto / Math.Pow(1 + interes, numeroPeriodo));
            resultado = (parte1 * parte2) + parte3;
            return resultado;
        }

        private double EcuacionValorFuturo()
        {
            double interes = interesRequerido / 100;
            resultado = (Math.Pow((1 + interes), numeroPeriodo) * valorPresente);
            return resultado;
        }

        public string BonosResultados()
        {
            if (valorPresente == 0 && valorCupon != 0 && numeroPeriodo != 0 && interesRequerido != 0)
            {
                return EcuacionValorPresente().ToString();
                //return "ecuacion 1"+ interesRequerido;
            }
            else
            {
                if (valorPresente != 0 && numeroPeriodo != 0 && interesRequerido != 0)
                {
                    return EcuacionValorFuturo().ToString();
                }
                else
                {
                    return "Ecuacion No Enconrada";
                }
            }
            
        }


    }
}
