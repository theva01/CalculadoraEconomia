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
    public partial class FormPrimary : Form
    {
        public FormPrimary()
        {
            InitializeComponent();
            abrirFormatoHija(new contenedorPrincipal());
        }

        private void abrirFormatoHija(object FormatoHija)
        {
         
            if (panelContainer.Controls.Count > 0)
                panelContainer.Controls.RemoveAt(0);

            Form formatohija = FormatoHija as Form;
            formatohija.TopLevel = false;
            formatohija.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(formatohija);
            panelContainer.Tag = formatohija;
            formatohija.Show();
            
        }

        private void buttonSimple_Click(object sender, EventArgs e)
        {
            abrirFormatoHija(new FormSimple());
        }

        private void panelPrimary_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonCompuesto_Click(object sender, EventArgs e)
        {
            abrirFormatoHija(new FormCompuesto());
        }

        private void buttonSimple_MouseMove(object sender, MouseEventArgs e)
        {
        }

        private void buttonSimple_MouseLeave(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            abrirFormatoHija(new FormTir());
        }

        private void buttonBonosInteres_Click(object sender, EventArgs e)
        {
            abrirFormatoHija(new FormBonosInteres());
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            abrirFormatoHija(  new contenedorPrincipal());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonAnulidad_Click(object sender, EventArgs e)
        {
            abrirFormatoHija(new Form1());
        }
    }
}
