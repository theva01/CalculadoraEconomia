using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Intereses
    {
        public Intereses() 
        {
            TasaDeInteres = 0;
            CapitalInicial = 0;
            Interes = 0;
            dias = 0;
            meses = 0;
            años = 0;
            Trimestral = 0;
            Semestral = 0;
            Cuatrimestral = 0;
        }
        public float TasaDeInteres { get; set; }
        public float CapitalInicial { get; set; }
        public float Interes { get; set; }
        public float dias { get; set; }
        public float meses { get; set; }
        public float años { get; set; }
        public float Trimestral { get; set; }
        public float Cuatrimestral { get; set; }
        public float Semestral { get; set; }

    }
}
