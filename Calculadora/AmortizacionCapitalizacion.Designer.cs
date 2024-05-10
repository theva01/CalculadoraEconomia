namespace Calculadora
{
    partial class AmortizacionCapitalizacion
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
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblFactorInteresAcumulado = new System.Windows.Forms.Label();
            this.labelValorFinal = new System.Windows.Forms.Label();
            this.txtPeriodos = new System.Windows.Forms.TextBox();
            this.labelValorIncial = new System.Windows.Forms.Label();
            this.txtTasaInteres = new System.Windows.Forms.TextBox();
            this.montolb = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.tipoALB = new System.Windows.Forms.Label();
            this.cmbTipoAmortizacion = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbFrecuenciaPago = new System.Windows.Forms.ComboBox();
            this.lblImporteUltimaImposicion = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtrazonCreciente = new System.Windows.Forms.TextBox();
            this.richTxtInteresSimple = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnCalcular.Location = new System.Drawing.Point(492, 575);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(153, 71);
            this.btnCalcular.TabIndex = 36;
            this.btnCalcular.Text = "calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblFactorInteresAcumulado
            // 
            this.lblFactorInteresAcumulado.AutoSize = true;
            this.lblFactorInteresAcumulado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblFactorInteresAcumulado.Location = new System.Drawing.Point(13, 433);
            this.lblFactorInteresAcumulado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFactorInteresAcumulado.Name = "lblFactorInteresAcumulado";
            this.lblFactorInteresAcumulado.Size = new System.Drawing.Size(108, 25);
            this.lblFactorInteresAcumulado.TabIndex = 44;
            this.lblFactorInteresAcumulado.Text = "Resultado";
            // 
            // labelValorFinal
            // 
            this.labelValorFinal.AutoSize = true;
            this.labelValorFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelValorFinal.Location = new System.Drawing.Point(421, 68);
            this.labelValorFinal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelValorFinal.Name = "labelValorFinal";
            this.labelValorFinal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelValorFinal.Size = new System.Drawing.Size(103, 25);
            this.labelValorFinal.TabIndex = 43;
            this.labelValorFinal.Text = "Periodos ";
            // 
            // txtPeriodos
            // 
            this.txtPeriodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeriodos.Location = new System.Drawing.Point(415, 100);
            this.txtPeriodos.Margin = new System.Windows.Forms.Padding(4);
            this.txtPeriodos.Name = "txtPeriodos";
            this.txtPeriodos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPeriodos.Size = new System.Drawing.Size(164, 30);
            this.txtPeriodos.TabIndex = 42;
            // 
            // labelValorIncial
            // 
            this.labelValorIncial.AutoSize = true;
            this.labelValorIncial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelValorIncial.Location = new System.Drawing.Point(220, 68);
            this.labelValorIncial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelValorIncial.Name = "labelValorIncial";
            this.labelValorIncial.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelValorIncial.Size = new System.Drawing.Size(163, 25);
            this.labelValorIncial.TabIndex = 41;
            this.labelValorIncial.Text = "Tasa de Interes";
            // 
            // txtTasaInteres
            // 
            this.txtTasaInteres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTasaInteres.Location = new System.Drawing.Point(216, 100);
            this.txtTasaInteres.Margin = new System.Windows.Forms.Padding(4);
            this.txtTasaInteres.Name = "txtTasaInteres";
            this.txtTasaInteres.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTasaInteres.Size = new System.Drawing.Size(164, 30);
            this.txtTasaInteres.TabIndex = 40;
            // 
            // montolb
            // 
            this.montolb.AutoSize = true;
            this.montolb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.montolb.Location = new System.Drawing.Point(29, 68);
            this.montolb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.montolb.Name = "montolb";
            this.montolb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.montolb.Size = new System.Drawing.Size(72, 25);
            this.montolb.TabIndex = 39;
            this.montolb.Text = "Monto";
            // 
            // txtMonto
            // 
            this.txtMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonto.Location = new System.Drawing.Point(20, 100);
            this.txtMonto.Margin = new System.Windows.Forms.Padding(4);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMonto.Size = new System.Drawing.Size(164, 30);
            this.txtMonto.TabIndex = 38;
            // 
            // tipoALB
            // 
            this.tipoALB.AutoSize = true;
            this.tipoALB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.tipoALB.Location = new System.Drawing.Point(816, 70);
            this.tipoALB.Name = "tipoALB";
            this.tipoALB.Size = new System.Drawing.Size(137, 25);
            this.tipoALB.TabIndex = 46;
            this.tipoALB.Text = "Amortizacion";
            // 
            // cmbTipoAmortizacion
            // 
            this.cmbTipoAmortizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoAmortizacion.FormattingEnabled = true;
            this.cmbTipoAmortizacion.Items.AddRange(new object[] {
            ""});
            this.cmbTipoAmortizacion.Location = new System.Drawing.Point(821, 105);
            this.cmbTipoAmortizacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbTipoAmortizacion.Name = "cmbTipoAmortizacion";
            this.cmbTipoAmortizacion.Size = new System.Drawing.Size(137, 26);
            this.cmbTipoAmortizacion.TabIndex = 45;
            this.cmbTipoAmortizacion.Text = "Seleccione";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(975, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 25);
            this.label1.TabIndex = 48;
            this.label1.Text = "Frecuencia de pago";
            // 
            // cmbFrecuenciaPago
            // 
            this.cmbFrecuenciaPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFrecuenciaPago.FormattingEnabled = true;
            this.cmbFrecuenciaPago.Items.AddRange(new object[] {
            ""});
            this.cmbFrecuenciaPago.Location = new System.Drawing.Point(980, 105);
            this.cmbFrecuenciaPago.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbFrecuenciaPago.Name = "cmbFrecuenciaPago";
            this.cmbFrecuenciaPago.Size = new System.Drawing.Size(137, 26);
            this.cmbFrecuenciaPago.TabIndex = 47;
            this.cmbFrecuenciaPago.Text = "Seleccione";
            // 
            // lblImporteUltimaImposicion
            // 
            this.lblImporteUltimaImposicion.AutoSize = true;
            this.lblImporteUltimaImposicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblImporteUltimaImposicion.Location = new System.Drawing.Point(13, 491);
            this.lblImporteUltimaImposicion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblImporteUltimaImposicion.Name = "lblImporteUltimaImposicion";
            this.lblImporteUltimaImposicion.Size = new System.Drawing.Size(108, 25);
            this.lblImporteUltimaImposicion.TabIndex = 49;
            this.lblImporteUltimaImposicion.Text = "Resultado";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(132, 383);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(881, 185);
            this.dataGridView1.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.Location = new System.Drawing.Point(629, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(167, 25);
            this.label2.TabIndex = 52;
            this.label2.Text = "Razon creciente";
            // 
            // TxtrazonCreciente
            // 
            this.TxtrazonCreciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtrazonCreciente.Location = new System.Drawing.Point(620, 100);
            this.TxtrazonCreciente.Margin = new System.Windows.Forms.Padding(4);
            this.TxtrazonCreciente.Name = "TxtrazonCreciente";
            this.TxtrazonCreciente.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtrazonCreciente.Size = new System.Drawing.Size(164, 30);
            this.TxtrazonCreciente.TabIndex = 51;
            // 
            // richTxtInteresSimple
            // 
            this.richTxtInteresSimple.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.richTxtInteresSimple.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(156)))), ((int)(((byte)(140)))));
            this.richTxtInteresSimple.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTxtInteresSimple.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTxtInteresSimple.Location = new System.Drawing.Point(336, 148);
            this.richTxtInteresSimple.Name = "richTxtInteresSimple";
            this.richTxtInteresSimple.Size = new System.Drawing.Size(741, 217);
            this.richTxtInteresSimple.TabIndex = 53;
            this.richTxtInteresSimple.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::Calculadora.Properties.Resources.Amortizacion;
            this.pictureBox1.Location = new System.Drawing.Point(41, 153);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(289, 212);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            // 
            // AmortizacionCapitalizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(156)))), ((int)(((byte)(140)))));
            this.ClientSize = new System.Drawing.Size(1189, 554);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.richTxtInteresSimple);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtrazonCreciente);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblImporteUltimaImposicion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbFrecuenciaPago);
            this.Controls.Add(this.tipoALB);
            this.Controls.Add(this.cmbTipoAmortizacion);
            this.Controls.Add(this.lblFactorInteresAcumulado);
            this.Controls.Add(this.labelValorFinal);
            this.Controls.Add(this.txtPeriodos);
            this.Controls.Add(this.labelValorIncial);
            this.Controls.Add(this.txtTasaInteres);
            this.Controls.Add(this.montolb);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.btnCalcular);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AmortizacionCapitalizacion";
            this.Text = "AmortizacionCapitalizacion";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblFactorInteresAcumulado;
        private System.Windows.Forms.Label labelValorFinal;
        private System.Windows.Forms.TextBox txtPeriodos;
        private System.Windows.Forms.Label labelValorIncial;
        private System.Windows.Forms.TextBox txtTasaInteres;
        private System.Windows.Forms.Label montolb;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label tipoALB;
        private System.Windows.Forms.ComboBox cmbTipoAmortizacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbFrecuenciaPago;
        private System.Windows.Forms.Label lblImporteUltimaImposicion;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtrazonCreciente;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox richTxtInteresSimple;
    }
}