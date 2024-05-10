
namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.labelValorFinal = new System.Windows.Forms.Label();
            this.textBoxPeriodos = new System.Windows.Forms.TextBox();
            this.labelValorIncial = new System.Windows.Forms.Label();
            this.textBoxTasaInteres = new System.Windows.Forms.TextBox();
            this.montolb = new System.Windows.Forms.Label();
            this.textBoxMonto = new System.Windows.Forms.TextBox();
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.labelResultado = new System.Windows.Forms.Label();
            this.resultadoLB = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.anualidadCB = new System.Windows.Forms.ComboBox();
            this.tipoALB = new System.Windows.Forms.Label();
            this.richTxtInteresSimple = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(169, 213);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 7;
            this.label1.UseWaitCursor = true;
            // 
            // labelValorFinal
            // 
            this.labelValorFinal.AutoSize = true;
            this.labelValorFinal.Font = new System.Drawing.Font("Rockwell", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelValorFinal.Location = new System.Drawing.Point(650, 177);
            this.labelValorFinal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelValorFinal.Name = "labelValorFinal";
            this.labelValorFinal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelValorFinal.Size = new System.Drawing.Size(100, 25);
            this.labelValorFinal.TabIndex = 34;
            this.labelValorFinal.Text = "Periodos ";
            // 
            // textBoxPeriodos
            // 
            this.textBoxPeriodos.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPeriodos.Location = new System.Drawing.Point(644, 209);
            this.textBoxPeriodos.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPeriodos.Name = "textBoxPeriodos";
            this.textBoxPeriodos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxPeriodos.Size = new System.Drawing.Size(164, 29);
            this.textBoxPeriodos.TabIndex = 33;
            // 
            // labelValorIncial
            // 
            this.labelValorIncial.AutoSize = true;
            this.labelValorIncial.Font = new System.Drawing.Font("Rockwell", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelValorIncial.Location = new System.Drawing.Point(449, 177);
            this.labelValorIncial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelValorIncial.Name = "labelValorIncial";
            this.labelValorIncial.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelValorIncial.Size = new System.Drawing.Size(158, 25);
            this.labelValorIncial.TabIndex = 32;
            this.labelValorIncial.Text = "Tasa de Interes";
            // 
            // textBoxTasaInteres
            // 
            this.textBoxTasaInteres.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTasaInteres.Location = new System.Drawing.Point(445, 209);
            this.textBoxTasaInteres.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTasaInteres.Name = "textBoxTasaInteres";
            this.textBoxTasaInteres.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxTasaInteres.Size = new System.Drawing.Size(164, 29);
            this.textBoxTasaInteres.TabIndex = 31;
            // 
            // montolb
            // 
            this.montolb.AutoSize = true;
            this.montolb.Font = new System.Drawing.Font("Rockwell", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.montolb.Location = new System.Drawing.Point(258, 177);
            this.montolb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.montolb.Name = "montolb";
            this.montolb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.montolb.Size = new System.Drawing.Size(73, 25);
            this.montolb.TabIndex = 30;
            this.montolb.Text = "Monto";
            // 
            // textBoxMonto
            // 
            this.textBoxMonto.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMonto.Location = new System.Drawing.Point(249, 209);
            this.textBoxMonto.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMonto.Name = "textBoxMonto";
            this.textBoxMonto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxMonto.Size = new System.Drawing.Size(164, 29);
            this.textBoxMonto.TabIndex = 29;
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCalcular.Font = new System.Drawing.Font("Rockwell", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.buttonCalcular.Location = new System.Drawing.Point(575, 514);
            this.buttonCalcular.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(100, 28);
            this.buttonCalcular.TabIndex = 35;
            this.buttonCalcular.Text = "calcular";
            this.buttonCalcular.UseVisualStyleBackColor = true;
            this.buttonCalcular.Click += new System.EventHandler(this.buttonCalcular_Click);
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Font = new System.Drawing.Font("Rockwell", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelResultado.Location = new System.Drawing.Point(354, 364);
            this.labelResultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(0, 25);
            this.labelResultado.TabIndex = 36;
            this.labelResultado.Click += new System.EventHandler(this.labelResultado_Click);
            // 
            // resultadoLB
            // 
            this.resultadoLB.AutoSize = true;
            this.resultadoLB.Font = new System.Drawing.Font("Rockwell", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.resultadoLB.Location = new System.Drawing.Point(304, 514);
            this.resultadoLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.resultadoLB.Name = "resultadoLB";
            this.resultadoLB.Size = new System.Drawing.Size(107, 25);
            this.resultadoLB.TabIndex = 37;
            this.resultadoLB.Text = "Resultado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(292, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(482, 50);
            this.label2.TabIndex = 38;
            this.label2.Text = "Calculo de Anualidades ";
            this.label2.UseWaitCursor = true;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // anualidadCB
            // 
            this.anualidadCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anualidadCB.FormattingEnabled = true;
            this.anualidadCB.Items.AddRange(new object[] {
            "Renta",
            "Monto",
            "Capital"});
            this.anualidadCB.Location = new System.Drawing.Point(851, 209);
            this.anualidadCB.Name = "anualidadCB";
            this.anualidadCB.Size = new System.Drawing.Size(138, 26);
            this.anualidadCB.TabIndex = 39;
            this.anualidadCB.Text = "Escoja...";
            this.anualidadCB.SelectedIndexChanged += new System.EventHandler(this.anualidadCB_SelectedIndexChanged);
            // 
            // tipoALB
            // 
            this.tipoALB.AutoSize = true;
            this.tipoALB.Font = new System.Drawing.Font("Rockwell", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.tipoALB.Location = new System.Drawing.Point(851, 177);
            this.tipoALB.Name = "tipoALB";
            this.tipoALB.Size = new System.Drawing.Size(158, 25);
            this.tipoALB.TabIndex = 40;
            this.tipoALB.Text = "Tipo Anualidad";
            // 
            // richTxtInteresSimple
            // 
            this.richTxtInteresSimple.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.richTxtInteresSimple.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(156)))), ((int)(((byte)(140)))));
            this.richTxtInteresSimple.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTxtInteresSimple.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTxtInteresSimple.Location = new System.Drawing.Point(296, 245);
            this.richTxtInteresSimple.Name = "richTxtInteresSimple";
            this.richTxtInteresSimple.Size = new System.Drawing.Size(741, 217);
            this.richTxtInteresSimple.TabIndex = 46;
            this.richTxtInteresSimple.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::Calculadora.Properties.Resources.Anualidades;
            this.pictureBox1.Location = new System.Drawing.Point(12, 250);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(277, 212);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(156)))), ((int)(((byte)(140)))));
            this.ClientSize = new System.Drawing.Size(1049, 507);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.richTxtInteresSimple);
            this.Controls.Add(this.tipoALB);
            this.Controls.Add(this.anualidadCB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.resultadoLB);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.buttonCalcular);
            this.Controls.Add(this.labelValorFinal);
            this.Controls.Add(this.textBoxPeriodos);
            this.Controls.Add(this.labelValorIncial);
            this.Controls.Add(this.textBoxTasaInteres);
            this.Controls.Add(this.montolb);
            this.Controls.Add(this.textBoxMonto);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "FormAnulidad";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelValorFinal;
        private System.Windows.Forms.TextBox textBoxPeriodos;
        private System.Windows.Forms.Label labelValorIncial;
        private System.Windows.Forms.TextBox textBoxTasaInteres;
        private System.Windows.Forms.Label montolb;
        private System.Windows.Forms.TextBox textBoxMonto;
        private System.Windows.Forms.Button buttonCalcular;
        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.Label resultadoLB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox anualidadCB;
        private System.Windows.Forms.Label tipoALB;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox richTxtInteresSimple;
    }
}