namespace RentACar
{
    partial class FrmVehiculo
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.gridVehiculo = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MARCA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MODELO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA_CREACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.comboModelo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxNumeroChasis = new System.Windows.Forms.TextBox();
            this.TxNumeroMotor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxNumeroPlaca = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboTipoVehiculo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboTipoCombustible = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxDescripcion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.labelFechaCreacion = new System.Windows.Forms.Label();
            this.TxFechaCreacion = new System.Windows.Forms.TextBox();
            this.checkEstado = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridVehiculo)).BeginInit();
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
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCancel.Location = new System.Drawing.Point(581, 70);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnDelete.Location = new System.Drawing.Point(581, 41);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSave.Location = new System.Drawing.Point(581, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gridVehiculo
            // 
            this.gridVehiculo.AllowUserToDeleteRows = false;
            this.gridVehiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridVehiculo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.MARCA,
            this.MODELO,
            this.FECHA_CREACION,
            this.ESTADO});
            this.gridVehiculo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridVehiculo.Location = new System.Drawing.Point(0, 250);
            this.gridVehiculo.Name = "gridVehiculo";
            this.gridVehiculo.ReadOnly = true;
            this.gridVehiculo.Size = new System.Drawing.Size(668, 272);
            this.gridVehiculo.TabIndex = 18;
            this.gridVehiculo.DoubleClick += new System.EventHandler(this.gridVehiculo_DoubleClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // MARCA
            // 
            this.MARCA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MARCA.DataPropertyName = "MARCA";
            this.MARCA.HeaderText = "Marca";
            this.MARCA.Name = "MARCA";
            this.MARCA.ReadOnly = true;
            // 
            // MODELO
            // 
            this.MODELO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MODELO.DataPropertyName = "MODELO";
            this.MODELO.HeaderText = "Modelo";
            this.MODELO.Name = "MODELO";
            this.MODELO.ReadOnly = true;
            // 
            // FECHA_CREACION
            // 
            this.FECHA_CREACION.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FECHA_CREACION.DataPropertyName = "FECHA_CREACION";
            this.FECHA_CREACION.HeaderText = "Fecha Creacion";
            this.FECHA_CREACION.Name = "FECHA_CREACION";
            this.FECHA_CREACION.ReadOnly = true;
            // 
            // ESTADO
            // 
            this.ESTADO.DataPropertyName = "ESTADO";
            this.ESTADO.HeaderText = "Estado";
            this.ESTADO.Name = "ESTADO";
            this.ESTADO.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Modelo";
            // 
            // comboModelo
            // 
            this.comboModelo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboModelo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboModelo.FormattingEnabled = true;
            this.comboModelo.Location = new System.Drawing.Point(103, 60);
            this.comboModelo.Name = "comboModelo";
            this.comboModelo.Size = new System.Drawing.Size(172, 21);
            this.comboModelo.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Numero Chasis";
            // 
            // TxNumeroChasis
            // 
            this.TxNumeroChasis.Location = new System.Drawing.Point(103, 90);
            this.TxNumeroChasis.MaxLength = 10;
            this.TxNumeroChasis.Name = "TxNumeroChasis";
            this.TxNumeroChasis.Size = new System.Drawing.Size(172, 20);
            this.TxNumeroChasis.TabIndex = 22;
            // 
            // TxNumeroMotor
            // 
            this.TxNumeroMotor.Location = new System.Drawing.Point(103, 117);
            this.TxNumeroMotor.MaxLength = 10;
            this.TxNumeroMotor.Name = "TxNumeroMotor";
            this.TxNumeroMotor.Size = new System.Drawing.Size(172, 20);
            this.TxNumeroMotor.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Numero Motor";
            // 
            // TxNumeroPlaca
            // 
            this.TxNumeroPlaca.Location = new System.Drawing.Point(103, 143);
            this.TxNumeroPlaca.MaxLength = 10;
            this.TxNumeroPlaca.Name = "TxNumeroPlaca";
            this.TxNumeroPlaca.Size = new System.Drawing.Size(172, 20);
            this.TxNumeroPlaca.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Numero Placa";
            // 
            // comboTipoVehiculo
            // 
            this.comboTipoVehiculo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboTipoVehiculo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboTipoVehiculo.FormattingEnabled = true;
            this.comboTipoVehiculo.Location = new System.Drawing.Point(384, 60);
            this.comboTipoVehiculo.Name = "comboTipoVehiculo";
            this.comboTipoVehiculo.Size = new System.Drawing.Size(172, 21);
            this.comboTipoVehiculo.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(290, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Tipo Vehiculo";
            // 
            // comboTipoCombustible
            // 
            this.comboTipoCombustible.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboTipoCombustible.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboTipoCombustible.FormattingEnabled = true;
            this.comboTipoCombustible.Location = new System.Drawing.Point(384, 90);
            this.comboTipoCombustible.Name = "comboTipoCombustible";
            this.comboTipoCombustible.Size = new System.Drawing.Size(172, 21);
            this.comboTipoCombustible.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(290, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Combustible";
            // 
            // TxDescripcion
            // 
            this.TxDescripcion.Location = new System.Drawing.Point(384, 117);
            this.TxDescripcion.MaxLength = 255;
            this.TxDescripcion.Multiline = true;
            this.TxDescripcion.Name = "TxDescripcion";
            this.TxDescripcion.Size = new System.Drawing.Size(172, 20);
            this.TxDescripcion.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(290, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Descripcion";
            // 
            // labelFechaCreacion
            // 
            this.labelFechaCreacion.AutoSize = true;
            this.labelFechaCreacion.Location = new System.Drawing.Point(290, 146);
            this.labelFechaCreacion.Name = "labelFechaCreacion";
            this.labelFechaCreacion.Size = new System.Drawing.Size(82, 13);
            this.labelFechaCreacion.TabIndex = 33;
            this.labelFechaCreacion.Text = "Fecha Creacion";
            // 
            // TxFechaCreacion
            // 
            this.TxFechaCreacion.Location = new System.Drawing.Point(384, 143);
            this.TxFechaCreacion.Multiline = true;
            this.TxFechaCreacion.Name = "TxFechaCreacion";
            this.TxFechaCreacion.ReadOnly = true;
            this.TxFechaCreacion.Size = new System.Drawing.Size(172, 20);
            this.TxFechaCreacion.TabIndex = 35;
            // 
            // checkEstado
            // 
            this.checkEstado.AutoSize = true;
            this.checkEstado.Location = new System.Drawing.Point(103, 170);
            this.checkEstado.Name = "checkEstado";
            this.checkEstado.Size = new System.Drawing.Size(15, 14);
            this.checkEstado.TabIndex = 36;
            this.checkEstado.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "Estado";
            // 
            // FrmVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 522);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.checkEstado);
            this.Controls.Add(this.TxFechaCreacion);
            this.Controls.Add(this.labelFechaCreacion);
            this.Controls.Add(this.TxDescripcion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboTipoCombustible);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboTipoVehiculo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxNumeroPlaca);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxNumeroMotor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxNumeroChasis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboModelo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridVehiculo);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmVehiculo";
            this.Text = "FrmVehiculo";
            this.Load += new System.EventHandler(this.FrmVehiculo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridVehiculo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView gridVehiculo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboModelo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxNumeroChasis;
        private System.Windows.Forms.TextBox TxNumeroMotor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxNumeroPlaca;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboTipoVehiculo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboTipoCombustible;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxDescripcion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelFechaCreacion;
        private System.Windows.Forms.TextBox TxFechaCreacion;
        private System.Windows.Forms.CheckBox checkEstado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MARCA;
        private System.Windows.Forms.DataGridViewTextBoxColumn MODELO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_CREACION;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTADO;
    }
}