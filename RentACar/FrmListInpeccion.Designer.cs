namespace RentACar
{
    partial class FrmListInpeccion
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
            this.gridInspeccion = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MARCA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.TxCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboVehiculo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridInspeccion)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(12, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Cerrar";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // gridInspeccion
            // 
            this.gridInspeccion.AllowUserToAddRows = false;
            this.gridInspeccion.AllowUserToDeleteRows = false;
            this.gridInspeccion.AllowUserToOrderColumns = true;
            this.gridInspeccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridInspeccion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.MARCA,
            this.Modelo,
            this.CODIGO});
            this.gridInspeccion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridInspeccion.Location = new System.Drawing.Point(0, 237);
            this.gridInspeccion.Name = "gridInspeccion";
            this.gridInspeccion.ReadOnly = true;
            this.gridInspeccion.Size = new System.Drawing.Size(652, 246);
            this.gridInspeccion.TabIndex = 19;
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
            // Modelo
            // 
            this.Modelo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Modelo.DataPropertyName = "MODELO";
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.Name = "Modelo";
            this.Modelo.ReadOnly = true;
            // 
            // CODIGO
            // 
            this.CODIGO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CODIGO.DataPropertyName = "CODIGO";
            this.CODIGO.HeaderText = "Codigo";
            this.CODIGO.Name = "CODIGO";
            this.CODIGO.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Codigo";
            // 
            // TxCodigo
            // 
            this.TxCodigo.Location = new System.Drawing.Point(70, 61);
            this.TxCodigo.Name = "TxCodigo";
            this.TxCodigo.ReadOnly = true;
            this.TxCodigo.Size = new System.Drawing.Size(158, 20);
            this.TxCodigo.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Vehiculo";
            // 
            // comboVehiculo
            // 
            this.comboVehiculo.FormattingEnabled = true;
            this.comboVehiculo.Location = new System.Drawing.Point(70, 87);
            this.comboVehiculo.Name = "comboVehiculo";
            this.comboVehiculo.Size = new System.Drawing.Size(158, 21);
            this.comboVehiculo.TabIndex = 23;
            // 
            // FrmListInpeccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 483);
            this.Controls.Add(this.comboVehiculo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxCodigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridInspeccion);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmListInpeccion";
            this.Text = "FrmListInpeccion";
            this.Load += new System.EventHandler(this.FrmListInpeccion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridInspeccion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView gridInspeccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MARCA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboVehiculo;
    }
}