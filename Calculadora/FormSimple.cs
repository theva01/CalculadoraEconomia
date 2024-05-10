using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;

namespace Calculadora
{
    public partial class FormSimple : Form
    {
        public ValidacionCampos validacionCampos;
        public InteresSimple calcular;
        public FormSimple()
        {
            InitializeComponent();
            validacionCampos = new ValidacionCampos();
            calcular = new InteresSimple();
            CamposInicio();
            CargaRichTxt();
        }

        private void CargaRichTxt()
        {
            richTxtInteresSimple.Text = "Defunción: El interés simple es la tasa aplicada sobre un capital origen que permanece constante en el tiempo y no se añade a periodos sucesivos." +
                "En otras palabras, el interés simple se calcula para pagos o cobros sobre el capital dispuesto inicialmente en todos los periodos considerados, mientras que el interés compuesto va sumando los intereses al capital para producir nuevos intereses." +
                "El interés puede ser pagado o cobrado, sobre un préstamo que paguemos o sobre un depósito que cobremos.La condición que diferencia al interés compuesto del interés simple, es que mientras en una situación de interés compuesto los intereses devengados se van sumando y produciendo nueva rentabilidad junto al capital inicial, en un modelo de interés simple solo se calculan los intereses sobre el capital inicial prestado o depositado." +
                "Así pues, puesto que los intereses no se van incorporando al capital, estos quedan devengados y se reciben al final del periodo. Recordemos que la fórmula del interés simple es la siguiente y que a partir de ella vamos a poder realizar todos los ejercicios.";
        }
        
        private void CamposInicio()
        {
            textBoxTasaInteres.Text = "0";
            textBoxValorFinal.Text = "0";
            textBoxValorIncial.Text = "0";
            textBoxDias.Text = "0";
            textBoxAños.Text = "0";
            textBoxMeses.Text = "0";
        }
        private void labelValorIncial_Click(object sender, EventArgs e)
        {

        }

        private void textBoxTasaInteres_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacionCampos.validacion(e,2);
        }

        private void textBoxValorIncial_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacionCampos.validacion(e, 2);
        }

        private void textBoxValorFinal_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacionCampos.validacion(e, 2);
        }

        private void VariablesEntradas()
        {
            if (comboBoxSelector.Text.Equals("Diario"))
            {
                calcular.dias = int.Parse(textBoxDias.Text);
                calcular.TasaDeInteres = float.Parse(textBoxTasaInteres.Text);
                calcular.CapitalInicial = float.Parse(textBoxValorIncial.Text);
                calcular.Interes = float.Parse(textBoxValorFinal.Text);
            }
            if (comboBoxSelector.Text.Equals("Mensual"))
            {
                calcular.meses = int.Parse(textBoxDias.Text);
                calcular.TasaDeInteres = float.Parse(textBoxTasaInteres.Text);
                calcular.CapitalInicial = float.Parse(textBoxValorIncial.Text);
                calcular.Interes = float.Parse(textBoxValorFinal.Text);
            }
            if (comboBoxSelector.Text.Equals("Anual"))
            {
                calcular.años = int.Parse(textBoxDias.Text);
                calcular.TasaDeInteres = float.Parse(textBoxTasaInteres.Text);
                calcular.CapitalInicial = float.Parse(textBoxValorIncial.Text);
                calcular.Interes = float.Parse(textBoxValorFinal.Text);
            }
            if (comboBoxSelector.Text.Equals("Diario-Mensual-Anual"))
            {
                calcular.dias = int.Parse(textBoxDias.Text);
                calcular.meses = int.Parse(textBoxMeses.Text);
                calcular.años = int.Parse(textBoxAños.Text);
                calcular.TasaDeInteres = float.Parse(textBoxTasaInteres.Text);
                calcular.CapitalInicial = float.Parse(textBoxValorIncial.Text);
                calcular.Interes = float.Parse(textBoxValorFinal.Text);
            }
            if (comboBoxSelector.Text.Equals("Trimestral"))
            {
                calcular.Trimestral = int.Parse(textBoxDias.Text);
                calcular.TasaDeInteres = float.Parse(textBoxTasaInteres.Text);
                calcular.CapitalInicial = float.Parse(textBoxValorIncial.Text);
                calcular.Interes = float.Parse(textBoxValorFinal.Text);
            }
            if (comboBoxSelector.Text.Equals("Cuatrimestral"))
            {
                calcular.Cuatrimestral = int.Parse(textBoxDias.Text);
                calcular.TasaDeInteres = float.Parse(textBoxTasaInteres.Text);
                calcular.CapitalInicial = float.Parse(textBoxValorIncial.Text);
                calcular.Interes = float.Parse(textBoxValorFinal.Text);
            }
            if (comboBoxSelector.Text.Equals("Semestral"))
            {
                calcular.Semestral = int.Parse(textBoxDias.Text);
                calcular.TasaDeInteres = float.Parse(textBoxTasaInteres.Text);
                calcular.CapitalInicial = float.Parse(textBoxValorIncial.Text);
                calcular.Interes = float.Parse(textBoxValorFinal.Text);
            }

        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            
            if (comboBoxSelector.Text != "" && textBoxValorIncial.Text != "" && textBoxValorFinal.Text != "" && textBoxTasaInteres.Text != "" && textBoxDias.Text != "" && textBoxMeses.Text != "" && textBoxAños.Text != "")
            {
                VariablesEntradas();
                labelValor.Visible = true;
                labelValor.Text = (calcular.CalcularInteresSimple());
            }
            else
            {
                CamposInicio();
                MessageBox.Show("Debe llenar al menos un campo", "Alerta", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            
        }

        private void textBoxDias_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacionCampos.validacion(e, 1);
        }

        private void textBoxMeses_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacionCampos.validacion(e, 1);
        }

        private void textBoxAños_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacionCampos.validacion(e, 1);
        }

        private void comboBoxSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSelector.Text.Equals("Diario"))
            {
                labelDias.Text = "Diario";
                textBoxDias.Visible = true;
                textBoxMeses.Visible = false;
                textBoxAños.Visible = false;
                labelDias.Visible = true;
                labelMeses.Visible = false;
                labelAños.Visible = false;
            }
            if (comboBoxSelector.Text.Equals("Mensual"))
            {
                labelDias.Text = "Mensual";
                textBoxDias.Visible = true;
                textBoxMeses.Visible = false;
                textBoxAños.Visible = false;
                labelDias.Visible = true;
                labelMeses.Visible = false;
                labelAños.Visible = false;
            }
            if (comboBoxSelector.Text.Equals("Anual"))
            {
                labelDias.Text = "Anual";
                textBoxDias.Visible = true;
                textBoxMeses.Visible = false;
                textBoxAños.Visible = false;
                labelDias.Visible = true;
                labelMeses.Visible = false;
                labelAños.Visible = false;
            }
            if (comboBoxSelector.Text.Equals("Diario-Mensual-Anual"))
            {
                labelDias.Text = "Diario";
                textBoxDias.Visible = true;
                textBoxMeses.Visible = true;
                textBoxAños.Visible = true;
                labelDias.Visible = true;
                labelMeses.Visible = true;
                labelAños.Visible = true;
            }
            if (comboBoxSelector.Text.Equals("Trimestral"))
            {
                labelDias.Text = "Trimestral";
                textBoxDias.Visible = true;
                textBoxMeses.Visible = false;
                textBoxAños.Visible = false;
                labelDias.Visible = true;
                labelMeses.Visible = false;
                labelAños.Visible = false;
            }
            if (comboBoxSelector.Text.Equals("Cuatrimestral"))
            {
                labelDias.Text = "Cuatrimestral";
                textBoxDias.Visible = true;
                textBoxMeses.Visible = false;
                textBoxAños.Visible = false;
                labelDias.Visible = true;
                labelMeses.Visible = false;
                labelAños.Visible = false;
            }
            if (comboBoxSelector.Text.Equals("Semestral"))
            {
                labelDias.Text = "Semestral";
                textBoxDias.Visible = true;
                textBoxMeses.Visible = false;
                textBoxAños.Visible = false;
                labelDias.Visible = true;
                labelMeses.Visible = false;
                labelAños.Visible = false;
            }
        }

        private void labelValor_Click(object sender, EventArgs e)
        {

        }

        private void labelTasaInteres_Click(object sender, EventArgs e)
        {

        }

        private void labelTiempo_Click(object sender, EventArgs e)
        {

        }

        private void panelPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}