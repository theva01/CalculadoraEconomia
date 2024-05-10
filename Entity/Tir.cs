using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Tir
    {
        public double inicial { get; set; }
        public double periodo1 { get; set; }
        public double periodo2 { get; set; }
        public double tasa { get; set; }
        public int exponente { get; set; }
        private double EcuacionSegundoGrado()
        {
            double a = -System.Math.Abs(inicial);
            double b = periodo1;
            double c = periodo2;
            // Calcular el discriminante
            double discriminante = b * b - 4 * (a) * c;

            if (discriminante > 0)
            {
                // Dos soluciones reales diferentes
                double x2 = (-b - Math.Sqrt(discriminante)) / (2 * a);
                Console.WriteLine("Dos soluciones reales diferentes:");
                Console.WriteLine("x2 = " + x2);
                return (x2 - 1);
            }
            return 0;
        }


        public double calcularVan()
        {
            double van = (inicial - periodo1 / (Math.Pow(1 + EcuacionSegundoGrado(), 1))) + (periodo2 / (Math.Pow(1 + EcuacionSegundoGrado(), 2)));
            return van;
        }
        public string calcularValorFuturo()
        {
            tasa = (tasa / 100);
            double futuro = (Math.Round((periodo1 / Math.Pow((1 + tasa), 1))) + Math.Round(periodo2 / Math.Pow((1 + tasa), 2)) - inicial);
            return futuro.ToString();
        }

        public string calacularTir()
        {
            double tir = EcuacionSegundoGrado();
            return tir.ToString() + "    (Tir - 1)";
        }
        public string vanPorcentaje()
        {
            return Math.Round((EcuacionSegundoGrado() * 100), 2).ToString() + " %";
        }

        public string calcularVanInicial()
        {
            string aux = "0";
            if (periodo1 == 0)
            {
                aux = "  Año 1 : " + Math.Round((inicial / Math.Pow((1 + tasa), 1)), 1).ToString();
            }
            if (periodo2 == 0)
            {
                aux = "  Año 2 : " + Math.Round((inicial / Math.Pow((1 + tasa), 2)), 1).ToString();
            }
            if (periodo1 == 0 && periodo2 == 0)
            {
                aux = "  Año 1 : " + Math.Round((inicial / Math.Pow((1 + tasa), 1)), 1).ToString() + "   Año 2 : " + Math.Round((inicial / Math.Pow((1 + tasa), 1)), 2).ToString();
            }
            
            return aux;
        }
    }
}
