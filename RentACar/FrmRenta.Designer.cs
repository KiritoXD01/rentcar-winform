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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRenta));
            this.btnClose = new System.Windows.Forms.Button();
            this.BtnNew = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxCodigo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.checkEstado = new System.Windows.Forms.CheckBox();
            this.TxDescripcion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxTotalAPagar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxMontoDia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxCantidadDias = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DPFechaDevolucion = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.DPFechaRenta = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.comboVehiculo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboCliente = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gridRenta = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VEHICULO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboCantidadCombustible = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.checkTieneRoturaCristal = new System.Windows.Forms.CheckBox();
            this.checkTieneGato = new System.Windows.Forms.CheckBox();
            this.checkTieneRayadura = new System.Windows.Forms.CheckBox();
            this.checkGomaRepuesto = new System.Windows.Forms.CheckBox();
            this.checkGomaDelanteraIzquierda = new System.Windows.Forms.CheckBox();
            this.checkGomaTraseraIzquierda = new System.Windows.Forms.CheckBox();
            this.checkGomaTraseraDerecha = new System.Windows.Forms.CheckBox();
            this.checkGomaDelanteraDerecha = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TxFiltrar = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridRenta)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(12, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Cerrar";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // BtnNew
            // 
            this.BtnNew.Location = new System.Drawing.Point(93, 12);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(75, 23);
            this.BtnNew.TabIndex = 1;
            this.BtnNew.Text = "Nuevo";
            this.BtnNew.UseVisualStyleBackColor = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.TxCodigo);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.checkEstado);
            this.groupBox1.Controls.Add(this.TxDescripcion);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.TxTotalAPagar);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.TxMontoDia);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.TxCantidadDias);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.DPFechaDevolucion);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.DPFechaRenta);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboVehiculo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboCliente);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(668, 164);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion de Renta";
            // 
            // TxCodigo
            // 
            this.TxCodigo.Enabled = false;
            this.TxCodigo.Location = new System.Drawing.Point(435, 125);
            this.TxCodigo.MaxLength = 6;
            this.TxCodigo.Name = "TxCodigo";
            this.TxCodigo.Size = new System.Drawing.Size(113, 20);
            this.TxCodigo.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(432, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Codigo";
            // 
            // checkEstado
            // 
            this.checkEstado.AutoSize = true;
            this.checkEstado.Location = new System.Drawing.Point(554, 125);
            this.checkEstado.Name = "checkEstado";
            this.checkEstado.Size = new System.Drawing.Size(81, 17);
            this.checkEstado.TabIndex = 17;
            this.checkEstado.Text = "Entregado?";
            this.checkEstado.UseVisualStyleBackColor = true;
            // 
            // TxDescripcion
            // 
            this.TxDescripcion.Location = new System.Drawing.Point(223, 125);
            this.TxDescripcion.Name = "TxDescripcion";
            this.TxDescripcion.Size = new System.Drawing.Size(200, 20);
            this.TxDescripcion.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(220, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Detalles";
            // 
            // TxTotalAPagar
            // 
            this.TxTotalAPagar.Enabled = false;
            this.TxTotalAPagar.Location = new System.Drawing.Point(10, 125);
            this.TxTotalAPagar.Name = "TxTotalAPagar";
            this.TxTotalAPagar.Size = new System.Drawing.Size(200, 20);
            this.TxTotalAPagar.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Total a Pagar";
            // 
            // TxMontoDia
            // 
            this.TxMontoDia.Enabled = false;
            this.TxMontoDia.Location = new System.Drawing.Point(435, 81);
            this.TxMontoDia.Name = "TxMontoDia";
            this.TxMontoDia.Size = new System.Drawing.Size(200, 20);
            this.TxMontoDia.TabIndex = 11;
            this.TxMontoDia.TextChanged += new System.EventHandler(this.TxMontoDia_TextChanged);
            this.TxMontoDia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxMontoDia_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(432, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Monto Por Dia";
            // 
            // TxCantidadDias
            // 
            this.TxCantidadDias.Enabled = false;
            this.TxCantidadDias.Location = new System.Drawing.Point(435, 36);
            this.TxCantidadDias.Name = "TxCantidadDias";
            this.TxCantidadDias.Size = new System.Drawing.Size(200, 20);
            this.TxCantidadDias.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(432, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Cantidad Dias";
            // 
            // DPFechaDevolucion
            // 
            this.DPFechaDevolucion.Location = new System.Drawing.Point(223, 81);
            this.DPFechaDevolucion.Name = "DPFechaDevolucion";
            this.DPFechaDevolucion.Size = new System.Drawing.Size(200, 20);
            this.DPFechaDevolucion.TabIndex = 7;
            this.DPFechaDevolucion.ValueChanged += new System.EventHandler(this.DPFechaDevolucion_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(220, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fecha Devolucion";
            // 
            // DPFechaRenta
            // 
            this.DPFechaRenta.Location = new System.Drawing.Point(223, 37);
            this.DPFechaRenta.Name = "DPFechaRenta";
            this.DPFechaRenta.Size = new System.Drawing.Size(200, 20);
            this.DPFechaRenta.TabIndex = 5;
            this.DPFechaRenta.ValueChanged += new System.EventHandler(this.DPFechaRenta_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(220, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha Renta";
            // 
            // comboVehiculo
            // 
            this.comboVehiculo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboVehiculo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboVehiculo.FormattingEnabled = true;
            this.comboVehiculo.Location = new System.Drawing.Point(10, 80);
            this.comboVehiculo.Name = "comboVehiculo";
            this.comboVehiculo.Size = new System.Drawing.Size(200, 21);
            this.comboVehiculo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vehiculo";
            // 
            // comboCliente
            // 
            this.comboCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboCliente.FormattingEnabled = true;
            this.comboCliente.Location = new System.Drawing.Point(10, 36);
            this.comboCliente.Name = "comboCliente";
            this.comboCliente.Size = new System.Drawing.Size(200, 21);
            this.comboCliente.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente";
            // 
            // gridRenta
            // 
            this.gridRenta.AllowUserToAddRows = false;
            this.gridRenta.AllowUserToDeleteRows = false;
            this.gridRenta.AllowUserToOrderColumns = true;
            this.gridRenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridRenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.VEHICULO,
            this.CLIENTE,
            this.CODIGO,
            this.ESTADO});
            this.gridRenta.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridRenta.Location = new System.Drawing.Point(0, 473);
            this.gridRenta.Name = "gridRenta";
            this.gridRenta.ReadOnly = true;
            this.gridRenta.Size = new System.Drawing.Size(668, 269);
            this.gridRenta.TabIndex = 3;
            this.gridRenta.DoubleClick += new System.EventHandler(this.gridRenta_DoubleClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // VEHICULO
            // 
            this.VEHICULO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.VEHICULO.DataPropertyName = "VEHICULO";
            this.VEHICULO.HeaderText = "Vehiculo";
            this.VEHICULO.Name = "VEHICULO";
            this.VEHICULO.ReadOnly = true;
            // 
            // CLIENTE
            // 
            this.CLIENTE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CLIENTE.DataPropertyName = "CLIENTE";
            this.CLIENTE.HeaderText = "Cliente";
            this.CLIENTE.Name = "CLIENTE";
            this.CLIENTE.ReadOnly = true;
            // 
            // CODIGO
            // 
            this.CODIGO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CODIGO.DataPropertyName = "CODIGO";
            this.CODIGO.HeaderText = "Codigo";
            this.CODIGO.Name = "CODIGO";
            this.CODIGO.ReadOnly = true;
            // 
            // ESTADO
            // 
            this.ESTADO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ESTADO.DataPropertyName = "ESTADO";
            this.ESTADO.HeaderText = "Estado";
            this.ESTADO.Name = "ESTADO";
            this.ESTADO.ReadOnly = true;
            // 
            // BtnSave
            // 
            this.BtnSave.Enabled = false;
            this.BtnSave.Location = new System.Drawing.Point(174, 12);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 4;
            this.BtnSave.Text = "Guardar";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Enabled = false;
            this.BtnCancel.Location = new System.Drawing.Point(255, 12);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 5;
            this.BtnCancel.Text = "Cancelar";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.TxFiltrar);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.comboCantidadCombustible);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.checkTieneRoturaCristal);
            this.groupBox2.Controls.Add(this.checkTieneGato);
            this.groupBox2.Controls.Add(this.checkTieneRayadura);
            this.groupBox2.Controls.Add(this.checkGomaRepuesto);
            this.groupBox2.Controls.Add(this.checkGomaDelanteraIzquierda);
            this.groupBox2.Controls.Add(this.checkGomaTraseraIzquierda);
            this.groupBox2.Controls.Add(this.checkGomaTraseraDerecha);
            this.groupBox2.Controls.Add(this.checkGomaDelanteraDerecha);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 218);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(668, 255);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Inspeccion de Vehiculo";
            // 
            // comboCantidadCombustible
            // 
            this.comboCantidadCombustible.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboCantidadCombustible.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboCantidadCombustible.FormattingEnabled = true;
            this.comboCantidadCombustible.Location = new System.Drawing.Point(167, 102);
            this.comboCantidadCombustible.Name = "comboCantidadCombustible";
            this.comboCantidadCombustible.Size = new System.Drawing.Size(181, 21);
            this.comboCantidadCombustible.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(164, 85);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Cantidad Combustible";
            // 
            // checkTieneRoturaCristal
            // 
            this.checkTieneRoturaCristal.AutoSize = true;
            this.checkTieneRoturaCristal.Location = new System.Drawing.Point(167, 65);
            this.checkTieneRoturaCristal.Name = "checkTieneRoturaCristal";
            this.checkTieneRoturaCristal.Size = new System.Drawing.Size(139, 17);
            this.checkTieneRoturaCristal.TabIndex = 8;
            this.checkTieneRoturaCristal.Text = "Tiene algun cristal roto?";
            this.checkTieneRoturaCristal.UseVisualStyleBackColor = true;
            // 
            // checkTieneGato
            // 
            this.checkTieneGato.AutoSize = true;
            this.checkTieneGato.Location = new System.Drawing.Point(167, 42);
            this.checkTieneGato.Name = "checkTieneGato";
            this.checkTieneGato.Size = new System.Drawing.Size(85, 17);
            this.checkTieneGato.TabIndex = 7;
            this.checkTieneGato.Text = "Tiene Gato?";
            this.checkTieneGato.UseVisualStyleBackColor = true;
            // 
            // checkTieneRayadura
            // 
            this.checkTieneRayadura.AutoSize = true;
            this.checkTieneRayadura.Location = new System.Drawing.Point(167, 19);
            this.checkTieneRayadura.Name = "checkTieneRayadura";
            this.checkTieneRayadura.Size = new System.Drawing.Size(113, 17);
            this.checkTieneRayadura.TabIndex = 6;
            this.checkTieneRayadura.Text = "Tiene Rayaduras?";
            this.checkTieneRayadura.UseVisualStyleBackColor = true;
            // 
            // checkGomaRepuesto
            // 
            this.checkGomaRepuesto.AutoSize = true;
            this.checkGomaRepuesto.Location = new System.Drawing.Point(77, 205);
            this.checkGomaRepuesto.Name = "checkGomaRepuesto";
            this.checkGomaRepuesto.Size = new System.Drawing.Size(15, 14);
            this.checkGomaRepuesto.TabIndex = 5;
            this.checkGomaRepuesto.UseVisualStyleBackColor = true;
            // 
            // checkGomaDelanteraIzquierda
            // 
            this.checkGomaDelanteraIzquierda.AutoSize = true;
            this.checkGomaDelanteraIzquierda.Location = new System.Drawing.Point(32, 60);
            this.checkGomaDelanteraIzquierda.Name = "checkGomaDelanteraIzquierda";
            this.checkGomaDelanteraIzquierda.Size = new System.Drawing.Size(15, 14);
            this.checkGomaDelanteraIzquierda.TabIndex = 4;
            this.checkGomaDelanteraIzquierda.UseVisualStyleBackColor = true;
            // 
            // checkGomaTraseraIzquierda
            // 
            this.checkGomaTraseraIzquierda.AutoSize = true;
            this.checkGomaTraseraIzquierda.Location = new System.Drawing.Point(32, 162);
            this.checkGomaTraseraIzquierda.Name = "checkGomaTraseraIzquierda";
            this.checkGomaTraseraIzquierda.Size = new System.Drawing.Size(15, 14);
            this.checkGomaTraseraIzquierda.TabIndex = 3;
            this.checkGomaTraseraIzquierda.UseVisualStyleBackColor = true;
            // 
            // checkGomaTraseraDerecha
            // 
            this.checkGomaTraseraDerecha.AutoSize = true;
            this.checkGomaTraseraDerecha.Location = new System.Drawing.Point(121, 162);
            this.checkGomaTraseraDerecha.Name = "checkGomaTraseraDerecha";
            this.checkGomaTraseraDerecha.Size = new System.Drawing.Size(15, 14);
            this.checkGomaTraseraDerecha.TabIndex = 2;
            this.checkGomaTraseraDerecha.UseVisualStyleBackColor = true;
            // 
            // checkGomaDelanteraDerecha
            // 
            this.checkGomaDelanteraDerecha.AutoSize = true;
            this.checkGomaDelanteraDerecha.Location = new System.Drawing.Point(121, 60);
            this.checkGomaDelanteraDerecha.Name = "checkGomaDelanteraDerecha";
            this.checkGomaDelanteraDerecha.Size = new System.Drawing.Size(15, 14);
            this.checkGomaDelanteraDerecha.TabIndex = 1;
            this.checkGomaDelanteraDerecha.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 194);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // TxFiltrar
            // 
            this.TxFiltrar.Location = new System.Drawing.Point(463, 216);
            this.TxFiltrar.Name = "TxFiltrar";
            this.TxFiltrar.Size = new System.Drawing.Size(200, 20);
            this.TxFiltrar.TabIndex = 17;
            this.TxFiltrar.TextChanged += new System.EventHandler(this.TxFiltrar_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(460, 200);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Detalles";
            // 
            // FrmRenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(668, 742);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.gridRenta);
            this.Controls.Add(this.BtnNew);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRenta";
            this.Text = "FrmRenta";
            this.Load += new System.EventHandler(this.FrmRenta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridRenta)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button BtnNew;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboVehiculo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DPFechaDevolucion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DPFechaRenta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxCantidadDias;
        private System.Windows.Forms.ComboBox comboCliente;
        private System.Windows.Forms.TextBox TxMontoDia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxTotalAPagar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkEstado;
        private System.Windows.Forms.TextBox TxDescripcion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView gridRenta;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkGomaDelanteraDerecha;
        private System.Windows.Forms.CheckBox checkGomaDelanteraIzquierda;
        private System.Windows.Forms.CheckBox checkGomaTraseraIzquierda;
        private System.Windows.Forms.CheckBox checkGomaTraseraDerecha;
        private System.Windows.Forms.CheckBox checkGomaRepuesto;
        private System.Windows.Forms.TextBox TxCodigo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkTieneRoturaCristal;
        private System.Windows.Forms.CheckBox checkTieneGato;
        private System.Windows.Forms.CheckBox checkTieneRayadura;
        private System.Windows.Forms.ComboBox comboCantidadCombustible;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn VEHICULO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTADO;
        private System.Windows.Forms.TextBox TxFiltrar;
        private System.Windows.Forms.Label label11;
    }
}