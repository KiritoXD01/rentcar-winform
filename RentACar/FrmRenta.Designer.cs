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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCloseTipoVehiculo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboVehiculo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboEmpleado = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboCliente = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnInspeccion = new System.Windows.Forms.Button();
            this.gridRenta = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.TxFechaRenta = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DPFechaDevolucion = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TxMontoDia = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxTotal = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TxDescripcion = new System.Windows.Forms.TextBox();
            this.TxCantidadDias = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_VEHICULO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_EMPLEADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INSPECCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridRenta)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(597, 41);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(597, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCloseTipoVehiculo
            // 
            this.btnCloseTipoVehiculo.Location = new System.Drawing.Point(12, 12);
            this.btnCloseTipoVehiculo.Name = "btnCloseTipoVehiculo";
            this.btnCloseTipoVehiculo.Size = new System.Drawing.Size(75, 23);
            this.btnCloseTipoVehiculo.TabIndex = 14;
            this.btnCloseTipoVehiculo.Text = "Cerrar";
            this.btnCloseTipoVehiculo.UseVisualStyleBackColor = true;
            this.btnCloseTipoVehiculo.Click += new System.EventHandler(this.btnCloseTipoVehiculo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Vehiculo";
            // 
            // comboVehiculo
            // 
            this.comboVehiculo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboVehiculo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboVehiculo.FormattingEnabled = true;
            this.comboVehiculo.Location = new System.Drawing.Point(83, 67);
            this.comboVehiculo.Name = "comboVehiculo";
            this.comboVehiculo.Size = new System.Drawing.Size(186, 21);
            this.comboVehiculo.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Empleado";
            // 
            // comboEmpleado
            // 
            this.comboEmpleado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboEmpleado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboEmpleado.FormattingEnabled = true;
            this.comboEmpleado.Location = new System.Drawing.Point(83, 94);
            this.comboEmpleado.Name = "comboEmpleado";
            this.comboEmpleado.Size = new System.Drawing.Size(186, 21);
            this.comboEmpleado.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Cliente";
            // 
            // comboCliente
            // 
            this.comboCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboCliente.FormattingEnabled = true;
            this.comboCliente.Location = new System.Drawing.Point(83, 121);
            this.comboCliente.Name = "comboCliente";
            this.comboCliente.Size = new System.Drawing.Size(186, 21);
            this.comboCliente.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Inspeccion";
            // 
            // btnInspeccion
            // 
            this.btnInspeccion.Location = new System.Drawing.Point(83, 148);
            this.btnInspeccion.Name = "btnInspeccion";
            this.btnInspeccion.Size = new System.Drawing.Size(186, 23);
            this.btnInspeccion.TabIndex = 23;
            this.btnInspeccion.Text = "Crear Inspeccion";
            this.btnInspeccion.UseVisualStyleBackColor = true;
            this.btnInspeccion.Click += new System.EventHandler(this.btnInspeccion_Click);
            // 
            // gridRenta
            // 
            this.gridRenta.AllowUserToAddRows = false;
            this.gridRenta.AllowUserToDeleteRows = false;
            this.gridRenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridRenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.ID_VEHICULO,
            this.ID_CLIENTE,
            this.ID_EMPLEADO,
            this.INSPECCION});
            this.gridRenta.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridRenta.Location = new System.Drawing.Point(0, 326);
            this.gridRenta.Name = "gridRenta";
            this.gridRenta.ReadOnly = true;
            this.gridRenta.Size = new System.Drawing.Size(684, 235);
            this.gridRenta.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Fecha Renta";
            // 
            // TxFechaRenta
            // 
            this.TxFechaRenta.Location = new System.Drawing.Point(83, 177);
            this.TxFechaRenta.Name = "TxFechaRenta";
            this.TxFechaRenta.ReadOnly = true;
            this.TxFechaRenta.Size = new System.Drawing.Size(186, 20);
            this.TxFechaRenta.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(275, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Fecha Devolucion";
            // 
            // DPFechaDevolucion
            // 
            this.DPFechaDevolucion.Location = new System.Drawing.Point(375, 67);
            this.DPFechaDevolucion.Name = "DPFechaDevolucion";
            this.DPFechaDevolucion.Size = new System.Drawing.Size(182, 20);
            this.DPFechaDevolucion.TabIndex = 27;
            this.DPFechaDevolucion.ValueChanged += new System.EventHandler(this.DPFechaDevolucion_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(275, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Cantidad Dias";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(275, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Monto x Dia";
            // 
            // TxMontoDia
            // 
            this.TxMontoDia.Location = new System.Drawing.Point(375, 119);
            this.TxMontoDia.Name = "TxMontoDia";
            this.TxMontoDia.Size = new System.Drawing.Size(182, 20);
            this.TxMontoDia.TabIndex = 31;
            this.TxMontoDia.TextChanged += new System.EventHandler(this.TxMontoDia_TextChanged);
            this.TxMontoDia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxMontoDia_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(275, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "Total a Pagar";
            // 
            // TxTotal
            // 
            this.TxTotal.Location = new System.Drawing.Point(375, 145);
            this.TxTotal.Name = "TxTotal";
            this.TxTotal.ReadOnly = true;
            this.TxTotal.Size = new System.Drawing.Size(182, 20);
            this.TxTotal.TabIndex = 33;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(276, 180);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "Descripcion";
            // 
            // TxDescripcion
            // 
            this.TxDescripcion.Location = new System.Drawing.Point(375, 176);
            this.TxDescripcion.Multiline = true;
            this.TxDescripcion.Name = "TxDescripcion";
            this.TxDescripcion.Size = new System.Drawing.Size(182, 20);
            this.TxDescripcion.TabIndex = 35;
            // 
            // TxCantidadDias
            // 
            this.TxCantidadDias.Location = new System.Drawing.Point(375, 93);
            this.TxCantidadDias.Name = "TxCantidadDias";
            this.TxCantidadDias.ReadOnly = true;
            this.TxCantidadDias.Size = new System.Drawing.Size(182, 20);
            this.TxCantidadDias.TabIndex = 36;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // ID_VEHICULO
            // 
            this.ID_VEHICULO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID_VEHICULO.DataPropertyName = "VEHICULO";
            this.ID_VEHICULO.HeaderText = "Vehiculo";
            this.ID_VEHICULO.Name = "ID_VEHICULO";
            this.ID_VEHICULO.ReadOnly = true;
            // 
            // ID_CLIENTE
            // 
            this.ID_CLIENTE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID_CLIENTE.DataPropertyName = "CLIENTE";
            this.ID_CLIENTE.HeaderText = "Cliente";
            this.ID_CLIENTE.Name = "ID_CLIENTE";
            this.ID_CLIENTE.ReadOnly = true;
            // 
            // ID_EMPLEADO
            // 
            this.ID_EMPLEADO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID_EMPLEADO.DataPropertyName = "EMPLEADO";
            this.ID_EMPLEADO.HeaderText = "Empleado";
            this.ID_EMPLEADO.Name = "ID_EMPLEADO";
            this.ID_EMPLEADO.ReadOnly = true;
            // 
            // INSPECCION
            // 
            this.INSPECCION.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.INSPECCION.DataPropertyName = "INSPECCION";
            this.INSPECCION.HeaderText = "Inspeccion";
            this.INSPECCION.Name = "INSPECCION";
            this.INSPECCION.ReadOnly = true;
            // 
            // FrmRenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.TxCantidadDias);
            this.Controls.Add(this.TxDescripcion);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TxTotal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TxMontoDia);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DPFechaDevolucion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxFechaRenta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnInspeccion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboEmpleado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboVehiculo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridRenta);
            this.Controls.Add(this.btnCloseTipoVehiculo);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRenta";
            this.Text = "FrmRenta";
            this.Load += new System.EventHandler(this.FrmRenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridRenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCloseTipoVehiculo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboVehiculo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboEmpleado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView gridRenta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxFechaRenta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker DPFechaDevolucion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxMontoDia;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxTotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxDescripcion;
        private System.Windows.Forms.TextBox TxCantidadDias;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.Button btnInspeccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_VEHICULO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_CLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_EMPLEADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn INSPECCION;
    }
}