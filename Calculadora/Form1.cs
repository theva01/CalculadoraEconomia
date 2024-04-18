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
