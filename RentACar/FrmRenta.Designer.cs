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
            this.label5 = new System.Windows.Forms.Label();
            this.TxCantidadDias = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxMontoxDia = new System.Windows.Forms.TextBox();
            this.TxDescripcionRenta = new System.Windows.Forms.TextBox();
            this.TxTotalPago = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxDescripcionInspeccion = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.checkGomaDelanteraIzquierda = new System.Windows.Forms.CheckBox();
            this.label17 = new System.Windows.Forms.Label();
            this.checkGomaDelanteraDerecha = new System.Windows.Forms.CheckBox();
            this.label18 = new System.Windows.Forms.Label();
            this.checkGomaTraseraIzquierda = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.checkGomaDerechaTrasera = new System.Windows.Forms.CheckBox();
            this.label15 = new System.Windows.Forms.Label();
            this.comboEstadoInspeccion = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.checkTieneRoturaCristal = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.checkTieneGato = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.checkTieneGoma = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comboCantidadCombustible = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.checkTieneRayaduras = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.gridRentas = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Renta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Devolucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DPFechaRenta = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.DPFechaDevolucion = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridRentas)).BeginInit();
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
            this.TxMontoxDia.TextChanged += new System.EventHandler(this.TxMontoxDia_TextChanged);
            // 
            // TxDescripcionRenta
            // 
            this.TxDescripcionRenta.Location = new System.Drawing.Point(381, 143);
            this.TxDescripcionRenta.MaxLength = 255;
            this.TxDescripcionRenta.Name = "TxDescripcionRenta";
            this.TxDescripcionRenta.Size = new System.Drawing.Size(183, 20);
            this.TxDescripcionRenta.TabIndex = 15;
            // 
            // TxTotalPago
            // 
            this.TxTotalPago.Location = new System.Drawing.Point(381, 116);
            this.TxTotalPago.Name = "TxTotalPago";
            this.TxTotalPago.ReadOnly = true;
            this.TxTotalPago.Size = new System.Drawing.Size(183, 20);
            this.TxTotalPago.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.TxDescripcionInspeccion);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.checkGomaDelanteraIzquierda);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.checkGomaDelanteraDerecha);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.checkGomaTraseraIzquierda);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.checkGomaDerechaTrasera);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.comboEstadoInspeccion);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.checkTieneRoturaCristal);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.checkTieneGato);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.checkTieneGoma);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.comboCantidadCombustible);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.checkTieneRayaduras);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(12, 183);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(644, 155);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inspeccion";
            // 
            // TxDescripcionInspeccion
            // 
            this.TxDescripcionInspeccion.Location = new System.Drawing.Point(373, 98);
            this.TxDescripcionInspeccion.Multiline = true;
            this.TxDescripcionInspeccion.Name = "TxDescripcionInspeccion";
            this.TxDescripcionInspeccion.Size = new System.Drawing.Size(215, 40);
            this.TxDescripcionInspeccion.TabIndex = 21;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(322, 102);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(45, 13);
            this.label19.TabIndex = 20;
            this.label19.Text = "Detalles";
            // 
            // checkGomaDelanteraIzquierda
            // 
            this.checkGomaDelanteraIzquierda.AutoSize = true;
            this.checkGomaDelanteraIzquierda.Location = new System.Drawing.Point(298, 124);
            this.checkGomaDelanteraIzquierda.Name = "checkGomaDelanteraIzquierda";
            this.checkGomaDelanteraIzquierda.Size = new System.Drawing.Size(15, 14);
            this.checkGomaDelanteraIzquierda.TabIndex = 19;
            this.checkGomaDelanteraIzquierda.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(164, 125);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(130, 13);
            this.label17.TabIndex = 18;
            this.label17.Text = "Goma Delantera Izquierda";
            // 
            // checkGomaDelanteraDerecha
            // 
            this.checkGomaDelanteraDerecha.AutoSize = true;
            this.checkGomaDelanteraDerecha.Location = new System.Drawing.Point(298, 100);
            this.checkGomaDelanteraDerecha.Name = "checkGomaDelanteraDerecha";
            this.checkGomaDelanteraDerecha.Size = new System.Drawing.Size(15, 14);
            this.checkGomaDelanteraDerecha.TabIndex = 17;
            this.checkGomaDelanteraDerecha.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(164, 101);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(128, 13);
            this.label18.TabIndex = 16;
            this.label18.Text = "Goma Delantera Derecha";
            // 
            // checkGomaTraseraIzquierda
            // 
            this.checkGomaTraseraIzquierda.AutoSize = true;
            this.checkGomaTraseraIzquierda.Location = new System.Drawing.Point(132, 125);
            this.checkGomaTraseraIzquierda.Name = "checkGomaTraseraIzquierda";
            this.checkGomaTraseraIzquierda.Size = new System.Drawing.Size(15, 14);
            this.checkGomaTraseraIzquierda.TabIndex = 15;
            this.checkGomaTraseraIzquierda.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(8, 125);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(120, 13);
            this.label16.TabIndex = 14;
            this.label16.Text = "Goma Trasera Izquierda";
            // 
            // checkGomaDerechaTrasera
            // 
            this.checkGomaDerechaTrasera.AutoSize = true;
            this.checkGomaDerechaTrasera.Location = new System.Drawing.Point(132, 101);
            this.checkGomaDerechaTrasera.Name = "checkGomaDerechaTrasera";
            this.checkGomaDerechaTrasera.Size = new System.Drawing.Size(15, 14);
            this.checkGomaDerechaTrasera.TabIndex = 13;
            this.checkGomaDerechaTrasera.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(8, 101);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(118, 13);
            this.label15.TabIndex = 12;
            this.label15.Text = "Goma Trasera Derecha";
            // 
            // comboEstadoInspeccion
            // 
            this.comboEstadoInspeccion.FormattingEnabled = true;
            this.comboEstadoInspeccion.Location = new System.Drawing.Point(405, 61);
            this.comboEstadoInspeccion.Name = "comboEstadoInspeccion";
            this.comboEstadoInspeccion.Size = new System.Drawing.Size(183, 21);
            this.comboEstadoInspeccion.TabIndex = 11;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(290, 65);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(95, 13);
            this.label14.TabIndex = 10;
            this.label14.Text = "Estado Inspeccion";
            // 
            // checkTieneRoturaCristal
            // 
            this.checkTieneRoturaCristal.AutoSize = true;
            this.checkTieneRoturaCristal.Location = new System.Drawing.Point(405, 41);
            this.checkTieneRoturaCristal.Name = "checkTieneRoturaCristal";
            this.checkTieneRoturaCristal.Size = new System.Drawing.Size(15, 14);
            this.checkTieneRoturaCristal.TabIndex = 9;
            this.checkTieneRoturaCristal.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(290, 41);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(109, 13);
            this.label13.TabIndex = 8;
            this.label13.Text = "Tiene rotura en cristal";
            // 
            // checkTieneGato
            // 
            this.checkTieneGato.AutoSize = true;
            this.checkTieneGato.Location = new System.Drawing.Point(405, 15);
            this.checkTieneGato.Name = "checkTieneGato";
            this.checkTieneGato.Size = new System.Drawing.Size(15, 14);
            this.checkTieneGato.TabIndex = 7;
            this.checkTieneGato.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(290, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Tiene Gato";
            // 
            // checkTieneGoma
            // 
            this.checkTieneGoma.AutoSize = true;
            this.checkTieneGoma.Location = new System.Drawing.Point(101, 71);
            this.checkTieneGoma.Name = "checkTieneGoma";
            this.checkTieneGoma.Size = new System.Drawing.Size(15, 14);
            this.checkTieneGoma.TabIndex = 5;
            this.checkTieneGoma.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Tiene Gomas";
            // 
            // comboCantidadCombustible
            // 
            this.comboCantidadCombustible.FormattingEnabled = true;
            this.comboCantidadCombustible.Location = new System.Drawing.Point(101, 41);
            this.comboCantidadCombustible.Name = "comboCantidadCombustible";
            this.comboCantidadCombustible.Size = new System.Drawing.Size(183, 21);
            this.comboCantidadCombustible.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Combustible";
            // 
            // checkTieneRayaduras
            // 
            this.checkTieneRayaduras.AutoSize = true;
            this.checkTieneRayaduras.Location = new System.Drawing.Point(101, 20);
            this.checkTieneRayaduras.Name = "checkTieneRayaduras";
            this.checkTieneRayaduras.Size = new System.Drawing.Size(15, 14);
            this.checkTieneRayaduras.TabIndex = 1;
            this.checkTieneRayaduras.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Tiene Rayaduras";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(581, 41);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(581, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gridRentas
            // 
            this.gridRentas.AllowUserToAddRows = false;
            this.gridRentas.AllowUserToDeleteRows = false;
            this.gridRentas.AllowUserToOrderColumns = true;
            this.gridRentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridRentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Cliente,
            this.Vehiculo,
            this.Fecha_Renta,
            this.Fecha_Devolucion});
            this.gridRentas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridRentas.Location = new System.Drawing.Point(0, 344);
            this.gridRentas.Name = "gridRentas";
            this.gridRentas.ReadOnly = true;
            this.gridRentas.Size = new System.Drawing.Size(668, 178);
            this.gridRentas.TabIndex = 22;
            this.gridRentas.DoubleClick += new System.EventHandler(this.gridRentas_DoubleClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // Cliente
            // 
            this.Cliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cliente.DataPropertyName = "CLIENTE";
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            // 
            // Vehiculo
            // 
            this.Vehiculo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Vehiculo.DataPropertyName = "VEHICULO";
            this.Vehiculo.HeaderText = "Vehiculo";
            this.Vehiculo.Name = "Vehiculo";
            this.Vehiculo.ReadOnly = true;
            // 
            // Fecha_Renta
            // 
            this.Fecha_Renta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Fecha_Renta.DataPropertyName = "FECHA_RENTA";
            this.Fecha_Renta.HeaderText = "Fecha Renta";
            this.Fecha_Renta.Name = "Fecha_Renta";
            this.Fecha_Renta.ReadOnly = true;
            // 
            // Fecha_Devolucion
            // 
            this.Fecha_Devolucion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Fecha_Devolucion.DataPropertyName = "FECHA_DEVOLUCION";
            this.Fecha_Devolucion.HeaderText = "Fecha Devolucion";
            this.Fecha_Devolucion.Name = "Fecha_Devolucion";
            this.Fecha_Devolucion.ReadOnly = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(302, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Detalles";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(302, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Total a Pagar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 125);
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
            this.DPFechaDevolucion.ValueChanged += new System.EventHandler(this.DPFechaDevolucion_ValueChanged);
            // 
            // FrmRenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 522);
            this.Controls.Add(this.gridRentas);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TxTotalPago);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxDescripcionRenta);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridRentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboVehiculo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxCantidadDias;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxMontoxDia;
        private System.Windows.Forms.TextBox TxDescripcionRenta;
        private System.Windows.Forms.TextBox TxTotalPago;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkTieneRayaduras;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkTieneRoturaCristal;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox checkTieneGato;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox checkTieneGoma;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboCantidadCombustible;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboEstadoInspeccion;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox checkGomaTraseraIzquierda;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.CheckBox checkGomaDerechaTrasera;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox checkGomaDelanteraIzquierda;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.CheckBox checkGomaDelanteraDerecha;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox TxDescripcionInspeccion;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DataGridView gridRentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vehiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Renta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Devolucion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DPFechaRenta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DPFechaDevolucion;
    }
}