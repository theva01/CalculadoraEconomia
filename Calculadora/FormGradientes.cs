using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class FormGradientes : Form
    {
        public FormGradientes()
        {
            InitializeComponent();
        }
        
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Obtener los valores ingresados en los TextBox
            double primerPago = double.Parse(txtPrimerPago.Text);
            double disminucion = double.Parse(txtDisminucion.Text);

            // Calcular el último pago
            string ultimoPagoString = Convert.ToString(primerPago - (11 * disminucion));
            double ultimoPago = Convert.ToDouble(ultimoPagoString.Contains("-") ? ultimoPagoString.Replace("-", "") : ultimoPagoString);

            // Calcular el valor final
            double i = 0.36 / 12; // Tasa de interés mensual
            double n = 12; // Número de periodos
            double g = -disminucion; // Gradiente (negativo porque disminuye)
            double A = primerPago; // Primer pago

            double P = (A / i) * (1 - Math.Pow(1 + i, -n)) + (g / i) * ((1 - Math.Pow(1 + i, -n)) / i - n * Math.Pow(1 + i, -n));
            double S = P * Math.Pow(1 + i, n);

            // Mostrar los resultados en los Labels
            lblUltimoPago.Text = ultimoPago.ToString("0.00");
            lblValorFinal.Text = S.ToString("0.00");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblUltimoPago_Click(object sender, EventArgs e)
        {

        }

        private void MenuAritmetico_Click(object sender, EventArgs e)
        {
            
            GradienteAritmetico art = new GradienteAritmetico();
            art.Show();
            
        }
    }
}
