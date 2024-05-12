using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class GradienteAritmetico : Form
    {
        Control padre = new Control();
        public GradienteAritmetico()
        {
            InitializeComponent();
        }

        public GradienteAritmetico(Object sender)
        {
            this.padre = (Control)sender;
            
            InitializeComponent();

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Obtener los valores ingresados por el usuario
            double depositoInicial = double.Parse(txtDepositoInicial.Text);
            double incrementoAnual = double.Parse(txtIncrementoAnual.Text);
            double tasaInteres = double.Parse(txtTasaInteres.Text) / 100; // Convertir la tasa de interés a decimal
            int periodos = int.Parse(txtPeriodos.Text);

            // Calcular el valor final usando la fórmula de la tasa de interés efectiva anual
            double valorFinal = CalcularValorFinal(depositoInicial, incrementoAnual, tasaInteres, periodos);

            // Mostrar el valor final en el lblValorFinal
            lblValorFinal.Text = valorFinal.ToString("0.00"); // Ajusta el formato según tus necesidades
        }

        private double CalcularValorFinal(double depositoInicial, double incrementoAnual, double tasaInteres, int periodos)
        {
            // Calcular la parte A de la fórmula
            double parteA = depositoInicial * (((Math.Pow(1 + tasaInteres, periodos)) - 1) / tasaInteres);

            // Calcular la parte G de la fórmula
            double parteG = incrementoAnual / tasaInteres * ((((Math.Pow(1 + tasaInteres, periodos)) - 1) / tasaInteres) - periodos);

            // Calcular el valor final
            double valorFinal = parteA + parteG;

            return valorFinal;
        }

        private void GradienteAritmetico_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.padre.Enabled = true;
            this.Dispose();
        }
    }
}
