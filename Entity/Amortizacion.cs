using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Amortizacion
    {
        public enum TipoAmortizacion
        {
            Frances,
            Creciente,
            Decreciente
        }

        public static (double factorInteresAcumulado, double importeUltimaImposicion) CalcularAmortizacion(double monto, double tasa, int periodos, TipoAmortizacion tipo, string frecuenciaPago)
        {
            switch (tipo)
            {
                case TipoAmortizacion.Frances:
                  //  return CalcularAmortizacionFrances(monto, tasa, periodos, frecuenciaPago);
                case TipoAmortizacion.Creciente:
                    return CalcularAmortizacionCreciente(monto, tasa, periodos, frecuenciaPago);
                case TipoAmortizacion.Decreciente:
                   // return CalcularAmortizacionDecreciente(monto, tasa, periodos, frecuenciaPago);
                default:
                    Console.WriteLine("Tipo de amortización no válido.");
                    return (0, 0); // Retorna valores por defecto en caso de tipo de amortización inválido
            }
        }

        private static void CalcularAmortizacionFrances(double monto, double tasa, int periodos, string frecuenciaPago)
        {
            // Implementación del cálculo para amortización francesa
        }

        private static (double factorInteresAcumulado, double importeUltimaImposicion) CalcularAmortizacionCreciente(double monto, double tasa, int periodos, string frecuenciaPago)
        {
            // Convertir la tasa de interés a tasa por período
            double tasaPeriodo = tasa / 100 / 2; // Suponiendo pagos semestrales

            // Calcular el factor de interés acumulado (Sn*i)
            double factorInteresAcumulado = (Math.Pow(1 + tasaPeriodo, periodos) - 1) / tasaPeriodo;

            // Calcular el importe de la última imposición (d)
            double importeUltimaImposicion = ((monto * ((Math.Pow(1 + tasaPeriodo, periodos) - 1))) / factorInteresAcumulado) - periodos;

            // Retornar los resultados como una tupla
            return (factorInteresAcumulado, importeUltimaImposicion);
        }

        private static void CalcularAmortizacionDecreciente(double monto, double tasa, int periodos, string frecuenciaPago)
        {
            // Implementación del cálculo para amortización decreciente
        }
    }
}
