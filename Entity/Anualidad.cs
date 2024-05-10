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
            
            double valorFuturo = renta * ((Math.Pow(1 + (tasaInteres / 100), periodos) - 1) / (tasaInteres/100));
            return valorFuturo;
        }
        
        //formula 2.
        public double CalcularAnualidadRenta(double monto, double tasaInteres, int periodos)
        {
            
            double renta = monto / ((Math.Pow(1 + (tasaInteres/100), periodos) - 1) / ((tasaInteres / 100)));
            return renta;
        }


        // forula 3. 
        public double CalcularAnualidadCapital(double renta, double tasaInteres, int periodos)
        {
            
            if (tasaInteres >= 1)
            { 
                tasaInteres = tasaInteres / 100;
            }
            double capital = renta * (1 - Math.Pow(1 + tasaInteres, -periodos)) / tasaInteres;
            return capital;
        }

        //public double CalcularAnualidadCapitalEnganche( double renta, double tasaInteres, int periodos,int enganche)
        //{
        //    // capitalEnganche = renta*(1-(Math.Pow(1+ tasaInteres / periodos,periodos))/ tasaInteres / periodos);

        //     double capitalEnganche = renta * (1 - Math.Pow(1 + tasaInteres, -periodos)) / tasaInteres + capitalEnganche * Math.Pow(1 + tasaInteres, -periodos);

        //    //// Se asume que la tasa de interés está en porcentaje y se convierte a su equivalente decimal
        //    //double tasaInteres = (renta / monto) * (Math.Pow(monto / renta, 1.0 / periodos) - 1);
        //    //return capitalEnganche * 100; // La tasa de interés se multiplica por 100 para convertirla en porcentaje
        //}



    }
}
