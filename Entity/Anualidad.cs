using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Anualidad
    {
        //formula 1.
        public double CalcularAnualidadMonto(double renta, double tasaInteres, int periodos)
        {
            
            double valorFuturo = renta * ((Math.Pow(1 + tasaInteres, periodos) - 1) / (tasaInteres));
            return valorFuturo;
        }
        
        //formula 2.
        public double CalcularAnualidadRenta(double monto, double tasaInteres, int periodos)
        {
           
            double renta = monto / ((Math.Pow(1 + tasaInteres, periodos) - 1) / (tasaInteres));
            return renta;
        }


        // forula 3. 
        public double CalcularAnualidadCapital(double renta, double tasaInteres, int periodos)
        {
            if (tasaInteres >= 1)
            {
                tasaInteres = tasaInteres / 10;
            }
            double capital = renta * (1 - Math.Pow(1 + tasaInteres, -periodos)) / tasaInteres;
            return capital;
        }

       


    }
}
