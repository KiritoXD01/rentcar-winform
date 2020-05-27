namespace RentACar
{
    partial class FrmEmpleado
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
            this.gridEmpleado = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.TxNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxApellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxClave = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboTanda = new System.Windows.Forms.ComboBox();
            this.checkEstado = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxPorcientoComision = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DPFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.labelFechaCreacion = new System.Windows.Forms.Label();
            this.TxFechaCreacion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboTipoEmpleado = new System.Windows.Forms.ComboBox();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPO_EMPLEADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmpleado)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(12, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "Cerrar";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(597, 70);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 25;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(597, 41);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 24;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(597, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gridEmpleado
            // 
            this.gridEmpleado.AllowUserToDeleteRows = false;
            this.gridEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEmpleado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NOMBRES,
            this.Apellido,
            this.TIPO_EMPLEADO,
            this.ESTADO});
            this.gridEmpleado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridEmpleado.Location = new System.Drawing.Point(0, 266);
            this.gridEmpleado.Name = "gridEmpleado";
            this.gridEmpleado.ReadOnly = true;
            this.gridEmpleado.Size = new System.Drawing.Size(684, 295);
            this.gridEmpleado.TabIndex = 26;
            this.gridEmpleado.DoubleClick += new System.EventHandler(this.gridEmpleado_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Nombre(s)";
            // 
            // TxNombre
            // 
            this.TxNombre.Location = new System.Drawing.Point(73, 67);
            this.TxNombre.MaxLength = 25;
            this.TxNombre.Name = "TxNombre";
            this.TxNombre.Size = new System.Drawing.Size(177, 20);
            this.TxNombre.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Apellido(s)";
            // 
            // TxApellido
            // 
            this.TxApellido.Location = new System.Drawing.Point(73, 96);
            this.TxApellido.MaxLength = 25;
            this.TxApellido.Name = "TxApellido";
            this.TxApellido.Size = new System.Drawing.Size(177, 20);
            this.TxApellido.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Clave";
            // 
            // TxClave
            // 
            this.TxClave.Location = new System.Drawing.Point(73, 125);
            this.TxClave.MaxLength = 10;
            this.TxClave.Name = "TxClave";
            this.TxClave.Size = new System.Drawing.Size(177, 20);
            this.TxClave.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Tanda";
            // 
            // comboTanda
            // 
            this.comboTanda.FormattingEnabled = true;
            this.comboTanda.Location = new System.Drawing.Point(73, 151);
            this.comboTanda.Name = "comboTanda";
            this.comboTanda.Size = new System.Drawing.Size(177, 21);
            this.comboTanda.TabIndex = 34;
            // 
            // checkEstado
            // 
            this.checkEstado.AutoSize = true;
            this.checkEstado.Location = new System.Drawing.Point(73, 178);
            this.checkEstado.Name = "checkEstado";
            this.checkEstado.Size = new System.Drawing.Size(15, 14);
            this.checkEstado.TabIndex = 35;
            this.checkEstado.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Estado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(268, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Porciento Comision";
            // 
            // TxPorcientoComision
            // 
            this.TxPorcientoComision.Location = new System.Drawing.Point(371, 66);
            this.TxPorcientoComision.Name = "TxPorcientoComision";
            this.TxPorcientoComision.Size = new System.Drawing.Size(157, 20);
            this.TxPorcientoComision.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(268, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "Fecha de Ingreso";
            // 
            // DPFechaIngreso
            // 
            this.DPFechaIngreso.Location = new System.Drawing.Point(371, 96);
            this.DPFechaIngreso.Name = "DPFechaIngreso";
            this.DPFechaIngreso.Size = new System.Drawing.Size(157, 20);
            this.DPFechaIngreso.TabIndex = 40;
            // 
            // labelFechaCreacion
            // 
            this.labelFechaCreacion.AutoSize = true;
            this.labelFechaCreacion.Location = new System.Drawing.Point(268, 154);
            this.labelFechaCreacion.Name = "labelFechaCreacion";
            this.labelFechaCreacion.Size = new System.Drawing.Size(97, 13);
            this.labelFechaCreacion.TabIndex = 41;
            this.labelFechaCreacion.Text = "Fecha de Creacion";
            // 
            // TxFechaCreacion
            // 
            this.TxFechaCreacion.Location = new System.Drawing.Point(371, 151);
            this.TxFechaCreacion.Name = "TxFechaCreacion";
            this.TxFechaCreacion.ReadOnly = true;
            this.TxFechaCreacion.Size = new System.Drawing.Size(157, 20);
            this.TxFechaCreacion.TabIndex = 42;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(268, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 43;
            this.label8.Text = "Tipo Empleado";
            // 
            // comboTipoEmpleado
            // 
            this.comboTipoEmpleado.FormattingEnabled = true;
            this.comboTipoEmpleado.Location = new System.Drawing.Point(371, 122);
            this.comboTipoEmpleado.Name = "comboTipoEmpleado";
            this.comboTipoEmpleado.Size = new System.Drawing.Size(157, 21);
            this.comboTipoEmpleado.TabIndex = 44;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // NOMBRES
            // 
            this.NOMBRES.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NOMBRES.DataPropertyName = "NOMBRES";
            this.NOMBRES.HeaderText = "Nombres";
            this.NOMBRES.Name = "NOMBRES";
            this.NOMBRES.ReadOnly = true;
            // 
            // Apellido
            // 
            this.Apellido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Apellido.DataPropertyName = "APELLIDOS";
            this.Apellido.HeaderText = "Apellidos";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            // 
            // TIPO_EMPLEADO
            // 
            this.TIPO_EMPLEADO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TIPO_EMPLEADO.DataPropertyName = "TIPO_EMPLEADO";
            this.TIPO_EMPLEADO.HeaderText = "Tipo";
            this.TIPO_EMPLEADO.Name = "TIPO_EMPLEADO";
            this.TIPO_EMPLEADO.ReadOnly = true;
            // 
            // ESTADO
            // 
            this.ESTADO.DataPropertyName = "ESTADO";
            this.ESTADO.HeaderText = "Estado";
            this.ESTADO.Name = "ESTADO";
            this.ESTADO.ReadOnly = true;
            // 
            // FrmEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.comboTipoEmpleado);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxFechaCreacion);
            this.Controls.Add(this.labelFechaCreacion);
            this.Controls.Add(this.DPFechaIngreso);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxPorcientoComision);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkEstado);
            this.Controls.Add(this.comboTanda);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxClave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxApellido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridEmpleado);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEmpleado";
            this.Text = "FrmEmpleado";
            this.Load += new System.EventHandler(this.FrmEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridEmpleado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView gridEmpleado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxApellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxClave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboTanda;
        private System.Windows.Forms.CheckBox checkEstado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxPorcientoComision;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker DPFechaIngreso;
        private System.Windows.Forms.Label labelFechaCreacion;
        private System.Windows.Forms.TextBox TxFechaCreacion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboTipoEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRES;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPO_EMPLEADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTADO;
    }
}