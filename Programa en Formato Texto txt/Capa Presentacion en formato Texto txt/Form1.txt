using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            CargaRichTxt();
        }

        private void CargaRichTxt()
        {
            richTxtInteresSimple.Text = "Una anualidad es una serie de retiros, depósitos o pagos que se efectúan de forma regular, ya sea en periodos anuales, mensuales, trimestrales, semestrales o de otro tipo. En simple, una anualidad es un ingreso o desembolso de dinero que se concreta cada determinado intervalo de tiempo, que no siempre es un año. Con todo, lo importante es que el lapso tiempo que separa una renta de la otra es siempre el mismo. Por ejemplo, nos podemos referir a la anualidad que se paga por un crédito hipotecario. En este caso, puede tratarse de una cuota mensual constante (amortización contable lineal) que debe cancelarse por un periodo de endeudamiento de veinte años. Sin embargo, cabe aclarar que existe un tipo de anualidad denominada impropia o variable donde el monto de la renta no siempre es el mismo."+
                "Elementos de las anualidades" +
                "Los elementos de las anualidades son:" +
                "• Renta: Monto retirado, depositado o pagado periódicamente." +
                "• Periodo de pago de renta: Intervalo de tiempo que se ha establecido entre una renta y otra." +
                "• Plazo de la anualidad: Periodo que transcurre entre la primera y la última renta." +
                "• Tasa de la anualidad: Tipo de interés fijado para la operación, por ejemplo, como sucede en el caso de un préstamo, donde cada cuota incorporará normalmente el interés acumulado. ";
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            Anualidad anualidad = new Anualidad();
            Console.WriteLine(textBoxTasaInteres.Text);
            string resultado = "Resultado";
            if (anualidadCB.SelectedIndex==0)
            {
                resultado = anualidad.CalcularAnualidadRenta(Convert.ToDouble(textBoxMonto.Text), Convert.ToDouble(textBoxTasaInteres.Text), Convert.ToInt32(textBoxPeriodos.Text)).ToString();
            }

            if (anualidadCB.SelectedIndex == 1)
            {
                resultado = anualidad.CalcularAnualidadMonto(Convert.ToDouble(textBoxMonto.Text), Convert.ToDouble(textBoxTasaInteres.Text), Convert.ToInt32(textBoxPeriodos.Text)).ToString();
            }
            if (anualidadCB.SelectedIndex == 2)
            {
                resultado = anualidad.CalcularAnualidadCapital(Convert.ToDouble(textBoxMonto.Text), Convert.ToDouble(textBoxTasaInteres.Text), Convert.ToInt32(textBoxPeriodos.Text)).ToString();
            }

            resultadoLB.Text = resultado;

        }
        
        private void labelResultado_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void anualidadCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (anualidadCB.SelectedIndex > 0 )
            {
                montolb.Text = "Renta";
                

            }
            if (anualidadCB.SelectedIndex == 0)
            {
                montolb.Text = "Monto";
            }
        }
    }
}
