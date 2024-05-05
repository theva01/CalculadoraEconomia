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
            double monto = double.Parse(txtMonto.Text);
            double tasaInteres = double.Parse(txtTasaInteres.Text);
            int periodos = int.Parse(txtPeriodos.Text);
            string frecuenciaPago = cmbFrecuenciaPago.SelectedItem.ToString();

            // Calcular la amortización y llenar la tabla en el DataGridView
            CalcularAmortizacion(monto, tasaInteres, periodos, frecuenciaPago);
        }

        private void CalcularAmortizacion(double monto, double tasaInteres, int periodos, string frecuenciaPago)
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


        private double CalcularAnualidadVencida(double monto, double tasaInteres, int periodos)
        {
            double interesPorPeriodo = tasaInteres / 100;
            double factor = Math.Pow(1 + interesPorPeriodo, periodos);
            return monto * interesPorPeriodo * factor / (factor - 1);
        }

    }
}
