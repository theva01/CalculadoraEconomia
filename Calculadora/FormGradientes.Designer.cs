namespace Calculadora
{
    partial class FormGradientes
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
            this.txtPrimerPago = new System.Windows.Forms.TextBox();
            this.txtDisminucion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblUltimoPago = new System.Windows.Forms.Label();
            this.lblValorFinal = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuAritmetico = new System.Windows.Forms.ToolStripMenuItem();
            this.richTxtInteresSimple = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPrimerPago
            // 
            this.txtPrimerPago.Location = new System.Drawing.Point(276, 117);
            this.txtPrimerPago.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrimerPago.Name = "txtPrimerPago";
            this.txtPrimerPago.Size = new System.Drawing.Size(149, 22);
            this.txtPrimerPago.TabIndex = 0;
            this.txtPrimerPago.TextChanged += new System.EventHandler(this.txtPrimerPago_TextChanged);
            // 
            // txtDisminucion
            // 
            this.txtDisminucion.Location = new System.Drawing.Point(633, 117);
            this.txtDisminucion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDisminucion.Name = "txtDisminucion";
            this.txtDisminucion.Size = new System.Drawing.Size(132, 22);
            this.txtDisminucion.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.Location = new System.Drawing.Point(271, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 25);
            this.label2.TabIndex = 22;
            this.label2.Text = "Pago Inicial";
            this.label2.UseWaitCursor = true;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(628, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 25);
            this.label1.TabIndex = 23;
            this.label1.Text = "Disminucion";
            this.label1.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.Location = new System.Drawing.Point(249, 534);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 25);
            this.label3.TabIndex = 24;
            this.label3.Text = "Ultimo Pago: ";
            this.label3.UseWaitCursor = true;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label4.Location = new System.Drawing.Point(563, 534);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 25);
            this.label4.TabIndex = 25;
            this.label4.Text = "Valor Final: ";
            this.label4.UseWaitCursor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label5.Location = new System.Drawing.Point(490, 489);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 25);
            this.label5.TabIndex = 26;
            this.label5.Text = "Resultado";
            this.label5.UseWaitCursor = true;
            // 
            // lblUltimoPago
            // 
            this.lblUltimoPago.AutoSize = true;
            this.lblUltimoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblUltimoPago.Location = new System.Drawing.Point(411, 534);
            this.lblUltimoPago.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUltimoPago.Name = "lblUltimoPago";
            this.lblUltimoPago.Size = new System.Drawing.Size(0, 25);
            this.lblUltimoPago.TabIndex = 27;
            this.lblUltimoPago.UseWaitCursor = true;
            this.lblUltimoPago.Click += new System.EventHandler(this.lblUltimoPago_Click);
            // 
            // lblValorFinal
            // 
            this.lblValorFinal.AutoSize = true;
            this.lblValorFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblValorFinal.Location = new System.Drawing.Point(707, 349);
            this.lblValorFinal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValorFinal.Name = "lblValorFinal";
            this.lblValorFinal.Size = new System.Drawing.Size(0, 25);
            this.lblValorFinal.TabIndex = 28;
            this.lblValorFinal.UseWaitCursor = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.FlatAppearance.BorderSize = 0;
            this.btnCalcular.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(167)))), ((int)(((byte)(255)))));
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnCalcular.Location = new System.Drawing.Point(442, 629);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(187, 49);
            this.btnCalcular.TabIndex = 29;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuAritmetico});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1281, 30);
            this.menuStrip1.TabIndex = 30;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuAritmetico
            // 
            this.MenuAritmetico.Name = "MenuAritmetico";
            this.MenuAritmetico.Size = new System.Drawing.Size(93, 26);
            this.MenuAritmetico.Text = "Aritmetico";
            this.MenuAritmetico.Click += new System.EventHandler(this.MenuAritmetico_Click);
            // 
            // richTxtInteresSimple
            // 
            this.richTxtInteresSimple.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.richTxtInteresSimple.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(156)))), ((int)(((byte)(140)))));
            this.richTxtInteresSimple.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTxtInteresSimple.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTxtInteresSimple.Location = new System.Drawing.Point(248, 150);
            this.richTxtInteresSimple.Name = "richTxtInteresSimple";
            this.richTxtInteresSimple.Size = new System.Drawing.Size(741, 217);
            this.richTxtInteresSimple.TabIndex = 46;
            this.richTxtInteresSimple.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::Calculadora.Properties.Resources.Captura_de_pantalla_2024_05_09_002456;
            this.pictureBox1.Location = new System.Drawing.Point(302, 370);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(439, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // FormGradientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(156)))), ((int)(((byte)(140)))));
            this.ClientSize = new System.Drawing.Size(1281, 661);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.richTxtInteresSimple);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblValorFinal);
            this.Controls.Add(this.lblUltimoPago);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDisminucion);
            this.Controls.Add(this.txtPrimerPago);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormGradientes";
            this.Text = "FormGradientes";
            this.Load += new System.EventHandler(this.FormGradientes_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPrimerPago;
        private System.Windows.Forms.TextBox txtDisminucion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblUltimoPago;
        private System.Windows.Forms.Label lblValorFinal;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuAritmetico;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox richTxtInteresSimple;
    }
}