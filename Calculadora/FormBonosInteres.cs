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
    public partial class FormBonosInteres : Form
    {
        private readonly BonosDeInteres bonos;
        public ValidacionCampos validacionCampos;
        public FormBonosInteres()
        {
            InitializeComponent();
            llenarCampos();
            validacionCampos = new ValidacionCampos();
            bonos = new BonosDeInteres();
        }

        private void SendVariables()
        {
            if (textBoxCupo.Text != "" || textBoxMonto.Text != "" || textBoxPeriodos.Text != "" || textBoxValorPresente.Text != "" || textBoxInteresRequerido.Text != "")
            {
                bonos.monto = double.Parse(textBoxMonto.Text);
                bonos.valorCupon = double.Parse(textBoxCupo.Text);
                bonos.valorPresente = double.Parse(textBoxValorPresente.Text);
                bonos.interesRequerido = double.Parse(textBoxInteresRequerido.Text);
                bonos.numeroPeriodo = double.Parse(textBoxPeriodos.Text);
                labelResultado.Text = bonos.BonosResultados();
            }
            else
            {
                llenarCampos();
            }
        }

        private void llenarCampos()
        {
            textBoxCupo.Text = "0";
            textBoxMonto.Text = "0";
            textBoxInteresRequerido.Text = "0";
            textBoxPeriodos.Text = "0";
            textBoxValorPresente.Text = "0";
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            SendVariables();
        }

        private void textBoxCupo_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacionCampos.validacion(e, 2);
        }

        private void textBoxInteresRequerido_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacionCampos.validacion(e, 2);
        }

        private void textBoxPeriodos_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacionCampos.validacion(e, 2);
        }

        private void textBoxValorPresente_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacionCampos.validacion(e, 2);
        }

        private void textBoxMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacionCampos.validacion(e, 2);
        }

        private void panelFondo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
