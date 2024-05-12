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
    public partial class FormCompuesto : Form
    {
        public InteresCompuesto calcular;
        public ValidacionCampos validacionCampos;
        public FormCompuesto()
        {
            InitializeComponent();
            validacionCampos = new ValidacionCampos();
            calcular = new InteresCompuesto();
            CamposInicio();
            CargaRichTxt();
        }
        private void CargaRichTxt()
        {
            richTxtInteresSimple.Text = "El interés compuesto es el valor que se genera sobre el monto de un capital variable y que se aplica sobre una inversión o un crédito. " +
                "Se denomina compuesto porque se calcula sobre el valor de un capital que aumenta constantemente, debido a que los intereses se van sumando en cada período.Este concepto es aplicable para calcular cuánto se gana en una inversión o en un ahorro, " +
                "así como también para calcular cuánto se paga en un préstamo o crédito." +
                "Su característica principal radica en que el interés calculado varía constantemente de manera exponencial y se suma al valor del capital de cada período(capitalización). Por lo anterior, los intereses siempre serán mayores en cada período de tiempo";
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
            calcular.TasaDeInteres = float.Parse(textBoxTasaInteres.Text);
            calcular.CapitalInicial = float.Parse(textBoxValorIncial.Text);
            calcular.Interes = float.Parse(textBoxValorFinal.Text);
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
        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            if (textBoxValorIncial.Text != "" && textBoxValorFinal.Text != "" && textBoxTasaInteres.Text != "" && textBoxDias.Text != "" && textBoxMeses.Text != "" && textBoxAños.Text != "")
            {
                VariablesEntradas();
                labelValor.Visible = true;
                labelValor.Text = calcular.interesCompuesto();
            }
            else
            {
                CamposInicio();
                MessageBox.Show("Debe llenar al menos un campo", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
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

        private void textBoxTasaInteres_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacionCampos.validacion(e, 2);
        }

        private void textBoxValorIncial_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacionCampos.validacion(e, 2);
        }

        private void textBoxValorFinal_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacionCampos.validacion(e, 2);
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
    }
}
