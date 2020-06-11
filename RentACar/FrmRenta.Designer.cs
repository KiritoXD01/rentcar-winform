namespace RentACar
{
    partial class FrmRenta
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
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboVehiculo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboCliente = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DPFechaRenta = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.DPFechaDevolucion = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.TxCantidadDias = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxMontoxDia = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxDescripcion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(12, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Cerrar";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Vehiculo";
            // 
            // comboVehiculo
            // 
            this.comboVehiculo.FormattingEnabled = true;
            this.comboVehiculo.Location = new System.Drawing.Point(113, 64);
            this.comboVehiculo.Name = "comboVehiculo";
            this.comboVehiculo.Size = new System.Drawing.Size(183, 21);
            this.comboVehiculo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cliente";
            // 
            // comboCliente
            // 
            this.comboCliente.FormattingEnabled = true;
            this.comboCliente.Location = new System.Drawing.Point(113, 91);
            this.comboCliente.Name = "comboCliente";
            this.comboCliente.Size = new System.Drawing.Size(183, 21);
            this.comboCliente.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fecha Renta";
            // 
            // DPFechaRenta
            // 
            this.DPFechaRenta.Location = new System.Drawing.Point(113, 118);
            this.DPFechaRenta.Name = "DPFechaRenta";
            this.DPFechaRenta.Size = new System.Drawing.Size(183, 20);
            this.DPFechaRenta.TabIndex = 7;
            this.DPFechaRenta.ValueChanged += new System.EventHandler(this.DPFechaRenta_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Fecha Devolucion";
            // 
            // DPFechaDevolucion
            // 
            this.DPFechaDevolucion.Location = new System.Drawing.Point(113, 144);
            this.DPFechaDevolucion.Name = "DPFechaDevolucion";
            this.DPFechaDevolucion.Size = new System.Drawing.Size(183, 20);
            this.DPFechaDevolucion.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(302, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Cantidad Dias";
            // 
            // TxCantidadDias
            // 
            this.TxCantidadDias.Location = new System.Drawing.Point(381, 64);
            this.TxCantidadDias.Name = "TxCantidadDias";
            this.TxCantidadDias.ReadOnly = true;
            this.TxCantidadDias.Size = new System.Drawing.Size(183, 20);
            this.TxCantidadDias.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(302, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Monto X Dia";
            // 
            // TxMontoxDia
            // 
            this.TxMontoxDia.Location = new System.Drawing.Point(381, 90);
            this.TxMontoxDia.Name = "TxMontoxDia";
            this.TxMontoxDia.Size = new System.Drawing.Size(183, 20);
            this.TxMontoxDia.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(302, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Detalles";
            // 
            // TxDescripcion
            // 
            this.TxDescripcion.Location = new System.Drawing.Point(381, 116);
            this.TxDescripcion.Multiline = true;
            this.TxDescripcion.Name = "TxDescripcion";
            this.TxDescripcion.Size = new System.Drawing.Size(183, 47);
            this.TxDescripcion.TabIndex = 15;
            // 
            // FrmRenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 522);
            this.Controls.Add(this.TxDescripcion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxMontoxDia);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxCantidadDias);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DPFechaDevolucion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DPFechaRenta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboVehiculo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRenta";
            this.Text = "FrmRenta";
            this.Load += new System.EventHandler(this.FrmRenta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboVehiculo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DPFechaRenta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DPFechaDevolucion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxCantidadDias;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxMontoxDia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxDescripcion;
    }
}