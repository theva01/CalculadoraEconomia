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
using static Entity.Amortizacion;

namespace Calculadora
{
    public partial class AmortizacionCapitalizacion : Form
    {

        public AmortizacionCapitalizacion()
        {
            InitializeComponent();
            cargarCombo();
            cargaDtg();
            CargaRichTxt();
        }
        private void CargaRichTxt()
        {
            richTxtInteresSimple.Text = "Una forma de gestionar mejor tu economía personal es conociendo cuál es el valor real de tus bienes y deudas y cuánto tiempo los tendrás. Para ello, la amortización es un método que te puede ayudar a calcular dicha información en cualquier momento. Te contamos qué significa y cómo le puedes sacar provecho a este concepto." +
                "Amortización es una palabra que, seguramente, habrás escuchado con frecuencia en los entornos laborales o en tu propia economía familiar y cuyo significado puede generarte bastantes dudas, pues no siempre se emplea para decir lo mismo, por lo que habrás oído frases como “el uso de este coche ya está amortizado” o “el plazo de amortización del préstamo será de 5 años”. A simple vista las dos frases parecen indicar cosas diferentes." +
                "Lo primero que debes tener claro es que el concepto de amortización, en general, se refiere a la disminución de valor de una forma distribuida en el tiempo. Si se trata de un bien como un coche o un ordenador, es normal que con el paso de los años su valor económico y prestaciones se vayan mermando, mientras que si es una obligación financiera como un préstamo o una" +
                "hipoteca también ocurre que la cuantía adeudada irá disminuyendo con el pago de las cuotas. Por ello, la clave para que entiendas qué significa la amortización en cada caso es identificar si hablas de un activo o un pasivo.";
        }
        
        private void cargarCombo()
        {
            cmbTipoAmortizacion.Items.Add("Francesa");
            cmbTipoAmortizacion.Items.Add("Creciente");
            cmbTipoAmortizacion.Items.Add("Decreciente");

            cmbFrecuenciaPago.Items.Add("Mensual");
            cmbFrecuenciaPago.Items.Add("Trimestral");
            cmbFrecuenciaPago.Items.Add("Semestral");
            cmbFrecuenciaPago.Items.Add("Anual");
        }

        private void cargaDtg()
        {
            // Agregar las columnas al DataGridView
            //dataGridView1.Columns.Add("Semestres", "Semestres");
            //dataGridView1.Columns.Add("AnualidadVencida", "Anualidad Vencida");
            //dataGridView1.Columns.Add("Intereses", "Intereses");
            //dataGridView1.Columns.Add("ValorFinal", "Valor Final");

            // Asignar un origen de datos vacío para que se muestren las columnas sin datos
            //dataGridView1.DataSource = new List<object>();
        }
        
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double monto = double.Parse(txtMonto.Text);
                double tasaInteres = double.Parse(txtTasaInteres.Text);
                int periodos = int.Parse(txtPeriodos.Text);
                string frecuenciaPago = cmbFrecuenciaPago.SelectedItem.ToString();
                double razonCrecimiento = double.Parse(TxtrazonCreciente.Text);


                // Calcular la amortización y llenar la tabla en el DataGridView
                CalcularAmortizacion1(monto, tasaInteres, periodos, frecuenciaPago, razonCrecimiento);
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        private void CalcularAmortizacion(double monto, double tasaInteres, int periodos, string frecuenciaPago, double razonCrecimiento)
        {
            // Limpiar el DataGridView antes de llenarlo con nuevos datos
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            // Agregar las columnas necesarias al DataGridView
            dataGridView1.Columns.Add("Semestre", "Semestre");
            dataGridView1.Columns.Add("AnualidadVencida", "Anualidad Vencida");
            dataGridView1.Columns.Add("Intereses", "Intereses");
            dataGridView1.Columns.Add("ValorFinal", "Valor Final");

            // Ajustar la tasa de interés según la frecuencia de pago
            switch (frecuenciaPago)
            {
                case "Mensual":
                    tasaInteres /= 12; // Convertir la tasa de interés a una tasa mensual
                    break;
                case "Trimestral":
                    tasaInteres /= 4; // Convertir la tasa de interés a una tasa trimestral
                    break;
                case "Semestral":
                    tasaInteres /= 2; // Convertir la tasa de interés a una tasa semestral
                    break;
                case "Anual":
                    // La tasa de interés ya está en términos anuales
                    break;
                default:
                    MessageBox.Show("Frecuencia de pago no válida.");
                    return;
            }

            // Aquí puedes usar la variable razonCrecimiento para calcular los periodos correctamente
            // ...

            // Inicializar el valor final
            double valorFinal = monto;

            // Calcular y llenar cada fila de la tabla en el DataGridView
            for (int semestre = 0; semestre <= periodos; semestre++)
            {
                // Calcular los intereses (excepto en el primer período)
                double intereses = (semestre > 0) ? valorFinal * (tasaInteres / 100) : 0;

                // Calcular la anualidad vencida
                double anualidadVencida = CalcularAnualidadVencida(monto, tasaInteres, semestre);

                // Calcular el valor final
                valorFinal = valorFinal + anualidadVencida - intereses;

                // Agregar la fila al DataGridView
                dataGridView1.Rows.Add(semestre, anualidadVencida, intereses, valorFinal);
            }
        }

        private void CalcularAmortizacion1(double monto, double tasaInteres, int periodos, string frecuenciaPago, double razonCrecimiento)
        {
            // Limpiar el DataGridView antes de llenarlo con nuevos datos
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            // Agregar las columnas necesarias al DataGridView
            dataGridView1.Columns.Add("Semestre", "Semestre");
            dataGridView1.Columns.Add("AnualidadVencida", "Anualidad Vencida");
            dataGridView1.Columns.Add("Intereses", "Intereses");
            dataGridView1.Columns.Add("ValorFinal", "Valor Final");

            // Ajustar la tasa de interés según la frecuencia de pago
            switch (frecuenciaPago)
            {
                case "Mensual":
                    tasaInteres /= 12; // Convertir la tasa de interés a una tasa mensual
                    break;
                case "Trimestral":
                    tasaInteres /= 4; // Convertir la tasa de interés a una tasa trimestral
                    break;
                case "Semestral":
                    tasaInteres /= 2; // Convertir la tasa de interés a una tasa semestral
                    break;
                case "Anual":
                    // La tasa de interés ya está en términos anuales
                    break;
                default:
                    MessageBox.Show("Frecuencia de pago no válida.");
                    return;
            }
            // Inicializar el valor final y la suma de las imposiciones
            double valorFinal = 0;
            double sumaImposiciones = 0;

            // Calcular la tasa de interés por periodo
            double interesPorPeriodo = tasaInteres / 100;

            // Calcular y llenar cada fila de la tabla en el DataGridView
            for (int semestre = 1; semestre <= periodos; semestre++)
            {
                // Calcular la imposición creciente
                double imposicion = monto + (semestre - 1) * razonCrecimiento;

                // Sumar la imposición al total
                sumaImposiciones += imposicion;

                // Calcular los intereses
                double intereses = sumaImposiciones * interesPorPeriodo;

                // Calcular el valor final
                valorFinal += imposicion + intereses;

                // Agregar la fila al DataGridView
                dataGridView1.Rows.Add(semestre, imposicion, intereses, valorFinal);
            }
        }


        private double CalcularAnualidadVencida(double monto, double tasaInteres, int periodos)
        {
            double interesPorPeriodo = tasaInteres / 100;
            double factor = Math.Pow(1 + interesPorPeriodo, periodos);
            return monto * interesPorPeriodo * factor / (factor - 1);
        }


    }
}
