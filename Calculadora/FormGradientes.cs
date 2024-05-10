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
            
            InitializeComponent(); CargaRichTxt();
        }
         private void CargaRichTxt()
        {
            richTxtInteresSimple.Text = "En matemáticas financieras gradientes son anualidades o serie de pagos periódicos, en los cuales cada pago es igual al anterior más una cantidad; esta cantidad puede ser constante o proporcional al pago inmediatamente anterior. El monto en que varía cada pago determina la clase de gradiente:" +
                "Si la cantidad es constante el gradiente es aritmético(por ejemplo, cada pago aumenta o disminuye en UM 250 mensuales sin importar su monto)." +
                "Si la cantidad en que varía el pago es proporcional al pago inmediatamente anterior el gradiente es geométrico(por ejemplo, cada pago aumenta o disminuye en 3.8 % mensual)" +
                "La aplicación de gradientes en los negocios supone el empleo de dos conceptos dependiendo del tipo de negocios:" +
                "Negocios con amortización(crédito), tipo en el que partimos de un valor actual, con cuotas crecientes pagaderas al vencimiento y con saldo cero al pago de la última cuota." +
                "Negocios de capitalización(ahorro), tipo en el que partimos de un valor actual cero con cuotas crecientes acumulables hasta alcanzar al final del plazo un valor futuro deseado." +
                "Gradientes diferidos. Son aquellos valorados con posterioridad a su origen. El tiempo que transcurre entre el origen del gradiente y el momento de valoración es el período de diferimiento o de gracia." +
                "Gradientes anticipados o prepagables. Aquellos valorados anticipadamente a su final. El tiempo que transcurre entre el final del gradiente y el momento de valoración es el período de anticipación.Pago o cobro por adelantado.Los valores actuales y futuros de los gradientes anticipados(adelantados) o prepagables son calculadas a partir de las vencidas o pos pagables multiplicado por(1 + i)";
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
            this.Enabled = false;
            GradienteAritmetico art = new GradienteAritmetico(this);
            art.Show();

            
        }

        private void FormGradientes_Load(object sender, EventArgs e)
        {
           
        }

        private void txtPrimerPago_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
