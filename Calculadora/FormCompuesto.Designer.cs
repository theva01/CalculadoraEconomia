namespace Calculadora
{
    partial class FormCompuesto
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
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.comboBoxSelector = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAños = new System.Windows.Forms.TextBox();
            this.textBoxMeses = new System.Windows.Forms.TextBox();
            this.textBoxDias = new System.Windows.Forms.TextBox();
            this.labelValor = new System.Windows.Forms.Label();
            this.labelAños = new System.Windows.Forms.Label();
            this.labelMeses = new System.Windows.Forms.Label();
            this.labelDias = new System.Windows.Forms.Label();
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.labelValorFinal = new System.Windows.Forms.Label();
            this.textBoxValorFinal = new System.Windows.Forms.TextBox();
            this.labelValorIncial = new System.Windows.Forms.Label();
            this.textBoxValorIncial = new System.Windows.Forms.TextBox();
            this.labelTasaInteres = new System.Windows.Forms.Label();
            this.textBoxTasaInteres = new System.Windows.Forms.TextBox();
            this.labelTiempo = new System.Windows.Forms.Label();
            this.panelPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(156)))), ((int)(((byte)(140)))));
            this.panelPrincipal.Controls.Add(this.comboBoxSelector);
            this.panelPrincipal.Controls.Add(this.label1);
            this.panelPrincipal.Controls.Add(this.textBoxAños);
            this.panelPrincipal.Controls.Add(this.textBoxMeses);
            this.panelPrincipal.Controls.Add(this.textBoxDias);
            this.panelPrincipal.Controls.Add(this.labelValor);
            this.panelPrincipal.Controls.Add(this.labelAños);
            this.panelPrincipal.Controls.Add(this.labelMeses);
            this.panelPrincipal.Controls.Add(this.labelDias);
            this.panelPrincipal.Controls.Add(this.buttonCalcular);
            this.panelPrincipal.Controls.Add(this.labelValorFinal);
            this.panelPrincipal.Controls.Add(this.textBoxValorFinal);
            this.panelPrincipal.Controls.Add(this.labelValorIncial);
            this.panelPrincipal.Controls.Add(this.textBoxValorIncial);
            this.panelPrincipal.Controls.Add(this.labelTasaInteres);
            this.panelPrincipal.Controls.Add(this.textBoxTasaInteres);
            this.panelPrincipal.Controls.Add(this.labelTiempo);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.panelPrincipal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(1303, 709);
            this.panelPrincipal.TabIndex = 0;
            // 
            // comboBoxSelector
            // 
            this.comboBoxSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSelector.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSelector.FormattingEnabled = true;
            this.comboBoxSelector.Items.AddRange(new object[] {
            "Diario",
            "Mensual",
            "Anual",
            "Diario-Mensual-Anual",
            "Trimestral",
            "Cuatrimestral",
            "Semestral"});
            this.comboBoxSelector.Location = new System.Drawing.Point(101, 144);
            this.comboBoxSelector.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxSelector.Name = "comboBoxSelector";
            this.comboBoxSelector.Size = new System.Drawing.Size(267, 30);
            this.comboBoxSelector.TabIndex = 41;
            this.comboBoxSelector.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelector_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(415, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 50);
            this.label1.TabIndex = 38;
            this.label1.Text = "Interes Compuesto";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxAños
            // 
            this.textBoxAños.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAños.Location = new System.Drawing.Point(193, 303);
            this.textBoxAños.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxAños.Name = "textBoxAños";
            this.textBoxAños.Size = new System.Drawing.Size(112, 29);
            this.textBoxAños.TabIndex = 37;
            this.textBoxAños.Visible = false;
            this.textBoxAños.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAños_KeyPress);
            // 
            // textBoxMeses
            // 
            this.textBoxMeses.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMeses.Location = new System.Drawing.Point(193, 250);
            this.textBoxMeses.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxMeses.Name = "textBoxMeses";
            this.textBoxMeses.Size = new System.Drawing.Size(112, 29);
            this.textBoxMeses.TabIndex = 36;
            this.textBoxMeses.Visible = false;
            this.textBoxMeses.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMeses_KeyPress);
            // 
            // textBoxDias
            // 
            this.textBoxDias.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDias.Location = new System.Drawing.Point(193, 197);
            this.textBoxDias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxDias.Name = "textBoxDias";
            this.textBoxDias.Size = new System.Drawing.Size(112, 29);
            this.textBoxDias.TabIndex = 35;
            this.textBoxDias.Visible = false;
            this.textBoxDias.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDias_KeyPress);
            // 
            // labelValor
            // 
            this.labelValor.AutoSize = true;
            this.labelValor.Font = new System.Drawing.Font("Rockwell", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelValor.Location = new System.Drawing.Point(189, 415);
            this.labelValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelValor.Name = "labelValor";
            this.labelValor.Size = new System.Drawing.Size(62, 25);
            this.labelValor.TabIndex = 34;
            this.labelValor.Text = "Valor";
            this.labelValor.Visible = false;
            this.labelValor.Click += new System.EventHandler(this.labelValor_Click);
            // 
            // labelAños
            // 
            this.labelAños.AutoSize = true;
            this.labelAños.Font = new System.Drawing.Font("Rockwell", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelAños.Location = new System.Drawing.Point(97, 308);
            this.labelAños.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAños.Name = "labelAños";
            this.labelAños.Size = new System.Drawing.Size(58, 25);
            this.labelAños.TabIndex = 32;
            this.labelAños.Text = "Años";
            this.labelAños.Visible = false;
            // 
            // labelMeses
            // 
            this.labelMeses.AutoSize = true;
            this.labelMeses.Font = new System.Drawing.Font("Rockwell", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelMeses.Location = new System.Drawing.Point(97, 251);
            this.labelMeses.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMeses.Name = "labelMeses";
            this.labelMeses.Size = new System.Drawing.Size(74, 25);
            this.labelMeses.TabIndex = 31;
            this.labelMeses.Text = "Meses";
            this.labelMeses.Visible = false;
            // 
            // labelDias
            // 
            this.labelDias.AutoSize = true;
            this.labelDias.Font = new System.Drawing.Font("Rockwell", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelDias.Location = new System.Drawing.Point(97, 201);
            this.labelDias.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDias.Name = "labelDias";
            this.labelDias.Size = new System.Drawing.Size(55, 25);
            this.labelDias.TabIndex = 30;
            this.labelDias.Text = "Dias";
            this.labelDias.Visible = false;
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.FlatAppearance.BorderSize = 0;
            this.buttonCalcular.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(167)))), ((int)(((byte)(255)))));
            this.buttonCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCalcular.Font = new System.Drawing.Font("Rockwell", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.buttonCalcular.Location = new System.Drawing.Point(777, 450);
            this.buttonCalcular.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(187, 57);
            this.buttonCalcular.TabIndex = 29;
            this.buttonCalcular.Text = "Calcular";
            this.buttonCalcular.UseVisualStyleBackColor = true;
            this.buttonCalcular.Click += new System.EventHandler(this.buttonCalcular_Click);
            // 
            // labelValorFinal
            // 
            this.labelValorFinal.AutoSize = true;
            this.labelValorFinal.Font = new System.Drawing.Font("Rockwell", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelValorFinal.Location = new System.Drawing.Point(756, 113);
            this.labelValorFinal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelValorFinal.Name = "labelValorFinal";
            this.labelValorFinal.Size = new System.Drawing.Size(186, 25);
            this.labelValorFinal.TabIndex = 28;
            this.labelValorFinal.Text = "Monto Compuesto";
            // 
            // textBoxValorFinal
            // 
            this.textBoxValorFinal.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxValorFinal.Location = new System.Drawing.Point(799, 145);
            this.textBoxValorFinal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxValorFinal.Name = "textBoxValorFinal";
            this.textBoxValorFinal.Size = new System.Drawing.Size(164, 29);
            this.textBoxValorFinal.TabIndex = 27;
            this.textBoxValorFinal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxValorFinal_KeyPress);
            // 
            // labelValorIncial
            // 
            this.labelValorIncial.AutoSize = true;
            this.labelValorIncial.Font = new System.Drawing.Font("Rockwell", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelValorIncial.Location = new System.Drawing.Point(596, 113);
            this.labelValorIncial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelValorIncial.Name = "labelValorIncial";
            this.labelValorIncial.Size = new System.Drawing.Size(150, 25);
            this.labelValorIncial.TabIndex = 26;
            this.labelValorIncial.Text = "Capital Inicial";
            // 
            // textBoxValorIncial
            // 
            this.textBoxValorIncial.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxValorIncial.Location = new System.Drawing.Point(600, 145);
            this.textBoxValorIncial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxValorIncial.Name = "textBoxValorIncial";
            this.textBoxValorIncial.Size = new System.Drawing.Size(164, 29);
            this.textBoxValorIncial.TabIndex = 25;
            this.textBoxValorIncial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxValorIncial_KeyPress);
            // 
            // labelTasaInteres
            // 
            this.labelTasaInteres.AutoSize = true;
            this.labelTasaInteres.Font = new System.Drawing.Font("Rockwell", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelTasaInteres.Location = new System.Drawing.Point(400, 113);
            this.labelTasaInteres.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTasaInteres.Name = "labelTasaInteres";
            this.labelTasaInteres.Size = new System.Drawing.Size(158, 25);
            this.labelTasaInteres.TabIndex = 24;
            this.labelTasaInteres.Text = "Tasa de Interes";
            this.labelTasaInteres.Click += new System.EventHandler(this.labelTasaInteres_Click);
            // 
            // textBoxTasaInteres
            // 
            this.textBoxTasaInteres.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTasaInteres.Location = new System.Drawing.Point(404, 145);
            this.textBoxTasaInteres.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxTasaInteres.Name = "textBoxTasaInteres";
            this.textBoxTasaInteres.Size = new System.Drawing.Size(164, 29);
            this.textBoxTasaInteres.TabIndex = 23;
            this.textBoxTasaInteres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTasaInteres_KeyPress);
            // 
            // labelTiempo
            // 
            this.labelTiempo.AutoSize = true;
            this.labelTiempo.Font = new System.Drawing.Font("Rockwell", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelTiempo.Location = new System.Drawing.Point(189, 113);
            this.labelTiempo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTiempo.Name = "labelTiempo";
            this.labelTiempo.Size = new System.Drawing.Size(86, 25);
            this.labelTiempo.TabIndex = 22;
            this.labelTiempo.Text = "Tiempo";
            // 
            // FormCompuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1303, 709);
            this.Controls.Add(this.panelPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormCompuesto";
            this.Text = "FormCompuesto";
            this.panelPrincipal.ResumeLayout(false);
            this.panelPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.TextBox textBoxAños;
        private System.Windows.Forms.TextBox textBoxMeses;
        private System.Windows.Forms.TextBox textBoxDias;
        private System.Windows.Forms.Label labelValor;
        private System.Windows.Forms.Label labelAños;
        private System.Windows.Forms.Label labelMeses;
        private System.Windows.Forms.Label labelDias;
        private System.Windows.Forms.Button buttonCalcular;
        private System.Windows.Forms.Label labelValorFinal;
        private System.Windows.Forms.TextBox textBoxValorFinal;
        private System.Windows.Forms.Label labelValorIncial;
        private System.Windows.Forms.TextBox textBoxValorIncial;
        private System.Windows.Forms.Label labelTasaInteres;
        private System.Windows.Forms.TextBox textBoxTasaInteres;
        private System.Windows.Forms.Label labelTiempo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxSelector;
    }
}