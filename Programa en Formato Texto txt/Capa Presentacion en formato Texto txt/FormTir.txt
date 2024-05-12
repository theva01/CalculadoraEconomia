using Entity;
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
    public partial class FormTir : Form
    {
        public readonly Tir tir;
        public ValidacionCampos validacionCampos;
        public FormTir()
        {
            InitializeComponent();
            ValorInicial();
            validacionCampos = new ValidacionCampos();
            tir = new Tir();
            CargaRichTxt();
        }

        private void CargaRichTxt()
        {
            richTxtInteresSimple.Text = "La tasa interna de retorno (TIR) ​​es una tasa utilizada en la valoración de inversiones. Su valor representa una rentabilidad cero, un equilibrio entre pérdidas y ganancias. En ingles se le conoce como Tasa interna de retorno (TIR)." +
                ""+
                "Cómo calcular la TIR" +
                "La TIR se calcula para un VAN de cero, donde el análisis de la inversión en base a valores presentes no muestra ni ganancia ni pérdida." +
                "El cálculo se realiza sumando cada elemento del flujo de caja menos la inversión inicial, lo que iguala la fórmula a cero.La TIR se representa como una incógnita en la fórmula:" +
                "FCi = flujo de efectivo del período" +
                "i = período de cada inversión" +
                "N = período de inversión final";
        }
        private void ValorInicial()
        {
            textBoxCapitalInicial.Text = 0.ToString();
            textBoxFnc1.Text = 0.ToString();
            textBoxFnc2.Text = 0.ToString();
            textBoxTasa.Text = 0.ToString();
        }
        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                tir.inicial = double.Parse(textBoxCapitalInicial.Text);
                tir.periodo1 = double.Parse(textBoxFnc1.Text);
                tir.periodo2 = double.Parse(textBoxFnc2.Text);
                tir.tasa = double.Parse(textBoxTasa.Text);
                labelResultado.Text = tir.vanPorcentaje();
                labelResultadoPresente.Text = tir.calcularValorFuturo();
                labelResultadoTir.Text = tir.calacularTir();
                labelVanInteresCompuesto.Text = tir.calcularVanInicial();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error {ex}");
            }
            
        }

        private void textBoxCapitalInicial_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacionCampos.validacion(e, 2);
        }

        private void textBoxFnc1_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacionCampos.validacion(e, 2);
        }

        private void textBoxFnc2_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacionCampos.validacion(e, 2);
        }

        private void textBoxTasa_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacionCampos.validacion(e, 2);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
