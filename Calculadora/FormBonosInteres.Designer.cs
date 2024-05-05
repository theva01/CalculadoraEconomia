namespace Calculadora
{
    partial class FormBonosInteres
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
            this.panelFondo = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxMonto = new System.Windows.Forms.TextBox();
            this.labelResultado = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxValorPresente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPeriodos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxInteresRequerido = new System.Windows.Forms.TextBox();
            this.labelCupo = new System.Windows.Forms.Label();
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.textBoxCupo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelFondo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFondo
            // 
            this.panelFondo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(156)))), ((int)(((byte)(140)))));
            this.panelFondo.Controls.Add(this.label6);
            this.panelFondo.Controls.Add(this.textBoxMonto);
            this.panelFondo.Controls.Add(this.labelResultado);
            this.panelFondo.Controls.Add(this.label5);
            this.panelFondo.Controls.Add(this.label4);
            this.panelFondo.Controls.Add(this.textBoxValorPresente);
            this.panelFondo.Controls.Add(this.label3);
            this.panelFondo.Controls.Add(this.textBoxPeriodos);
            this.panelFondo.Controls.Add(this.label2);
            this.panelFondo.Controls.Add(this.textBoxInteresRequerido);
            this.panelFondo.Controls.Add(this.labelCupo);
            this.panelFondo.Controls.Add(this.buttonCalcular);
            this.panelFondo.Controls.Add(this.textBoxCupo);
            this.panelFondo.Controls.Add(this.label1);
            this.panelFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFondo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.panelFondo.Location = new System.Drawing.Point(0, 0);
            this.panelFondo.Name = "panelFondo";
            this.panelFondo.Size = new System.Drawing.Size(800, 450);
            this.panelFondo.TabIndex = 0;
            this.panelFondo.UseWaitCursor = true;
            this.panelFondo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelFondo_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label6.Location = new System.Drawing.Point(352, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Monto";
            this.label6.UseWaitCursor = true;
            // 
            // textBoxMonto
            // 
            this.textBoxMonto.Location = new System.Drawing.Point(412, 120);
            this.textBoxMonto.Multiline = true;
            this.textBoxMonto.Name = "textBoxMonto";
            this.textBoxMonto.Size = new System.Drawing.Size(124, 25);
            this.textBoxMonto.TabIndex = 12;
            this.textBoxMonto.UseWaitCursor = true;
            this.textBoxMonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMonto_KeyPress);
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Location = new System.Drawing.Point(465, 167);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(19, 20);
            this.labelResultado.TabIndex = 11;
            this.labelResultado.Text = "0";
            this.labelResultado.UseWaitCursor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label5.Location = new System.Drawing.Point(381, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Resultado :";
            this.label5.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label4.Location = new System.Drawing.Point(66, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Valor Presente";
            this.label4.UseWaitCursor = true;
            // 
            // textBoxValorPresente
            // 
            this.textBoxValorPresente.Location = new System.Drawing.Point(195, 262);
            this.textBoxValorPresente.Multiline = true;
            this.textBoxValorPresente.Name = "textBoxValorPresente";
            this.textBoxValorPresente.Size = new System.Drawing.Size(124, 25);
            this.textBoxValorPresente.TabIndex = 8;
            this.textBoxValorPresente.UseWaitCursor = true;
            this.textBoxValorPresente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxValorPresente_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.Location = new System.Drawing.Point(50, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Numero Periodos";
            this.label3.UseWaitCursor = true;
            // 
            // textBoxPeriodos
            // 
            this.textBoxPeriodos.Location = new System.Drawing.Point(196, 218);
            this.textBoxPeriodos.Multiline = true;
            this.textBoxPeriodos.Name = "textBoxPeriodos";
            this.textBoxPeriodos.Size = new System.Drawing.Size(124, 25);
            this.textBoxPeriodos.TabIndex = 6;
            this.textBoxPeriodos.UseWaitCursor = true;
            this.textBoxPeriodos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPeriodos_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.Location = new System.Drawing.Point(50, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Interes Requerido";
            this.label2.UseWaitCursor = true;
            // 
            // textBoxInteresRequerido
            // 
            this.textBoxInteresRequerido.Location = new System.Drawing.Point(195, 167);
            this.textBoxInteresRequerido.Multiline = true;
            this.textBoxInteresRequerido.Name = "textBoxInteresRequerido";
            this.textBoxInteresRequerido.Size = new System.Drawing.Size(124, 25);
            this.textBoxInteresRequerido.TabIndex = 4;
            this.textBoxInteresRequerido.UseWaitCursor = true;
            this.textBoxInteresRequerido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxInteresRequerido_KeyPress);
            // 
            // labelCupo
            // 
            this.labelCupo.AutoSize = true;
            this.labelCupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelCupo.Location = new System.Drawing.Point(109, 123);
            this.labelCupo.Name = "labelCupo";
            this.labelCupo.Size = new System.Drawing.Size(51, 20);
            this.labelCupo.TabIndex = 3;
            this.labelCupo.Text = "Cupo";
            this.labelCupo.UseWaitCursor = true;
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.BackColor = System.Drawing.Color.PowderBlue;
            this.buttonCalcular.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.buttonCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.buttonCalcular.Location = new System.Drawing.Point(546, 345);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(123, 40);
            this.buttonCalcular.TabIndex = 2;
            this.buttonCalcular.Text = "Calcular";
            this.buttonCalcular.UseVisualStyleBackColor = false;
            this.buttonCalcular.UseWaitCursor = true;
            this.buttonCalcular.Click += new System.EventHandler(this.buttonCalcular_Click);
            // 
            // textBoxCupo
            // 
            this.textBoxCupo.Location = new System.Drawing.Point(196, 120);
            this.textBoxCupo.Multiline = true;
            this.textBoxCupo.Name = "textBoxCupo";
            this.textBoxCupo.Size = new System.Drawing.Size(124, 25);
            this.textBoxCupo.TabIndex = 1;
            this.textBoxCupo.UseWaitCursor = true;
            this.textBoxCupo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCupo_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(252, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bonos de Interes";
            this.label1.UseWaitCursor = true;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FormBonosInteres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelFondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBonosInteres";
            this.Text = "FormBonosInteres";
            this.UseWaitCursor = true;
            this.panelFondo.ResumeLayout(false);
            this.panelFondo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFondo;
        private System.Windows.Forms.Button buttonCalcular;
        private System.Windows.Forms.TextBox textBoxCupo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCupo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxValorPresente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPeriodos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxInteresRequerido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxMonto;
    }
}