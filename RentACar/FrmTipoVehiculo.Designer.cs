namespace RentACar
{
    partial class FrmTipoVehiculo
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
            this.btnCloseTipoVehiculo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxNombre = new System.Windows.Forms.TextBox();
            this.checkEstado = new System.Windows.Forms.CheckBox();
            this.gridTipoVehiculo = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridTipoVehiculo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCloseTipoVehiculo
            // 
            this.btnCloseTipoVehiculo.Location = new System.Drawing.Point(13, 13);
            this.btnCloseTipoVehiculo.Name = "btnCloseTipoVehiculo";
            this.btnCloseTipoVehiculo.Size = new System.Drawing.Size(75, 23);
            this.btnCloseTipoVehiculo.TabIndex = 0;
            this.btnCloseTipoVehiculo.Text = "Cerrar";
            this.btnCloseTipoVehiculo.UseVisualStyleBackColor = true;
            this.btnCloseTipoVehiculo.Click += new System.EventHandler(this.btnCloseTipoVehiculo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // TxNombre
            // 
            this.TxNombre.Location = new System.Drawing.Point(62, 64);
            this.TxNombre.MaxLength = 25;
            this.TxNombre.Name = "TxNombre";
            this.TxNombre.Size = new System.Drawing.Size(196, 20);
            this.TxNombre.TabIndex = 2;
            // 
            // checkEstado
            // 
            this.checkEstado.AutoSize = true;
            this.checkEstado.Location = new System.Drawing.Point(62, 100);
            this.checkEstado.Name = "checkEstado";
            this.checkEstado.Size = new System.Drawing.Size(59, 17);
            this.checkEstado.TabIndex = 3;
            this.checkEstado.Text = "Estado";
            this.checkEstado.UseVisualStyleBackColor = true;
            // 
            // gridTipoVehiculo
            // 
            this.gridTipoVehiculo.AllowUserToDeleteRows = false;
            this.gridTipoVehiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTipoVehiculo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NOMBRE,
            this.ESTADO});
            this.gridTipoVehiculo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridTipoVehiculo.Location = new System.Drawing.Point(0, 157);
            this.gridTipoVehiculo.Name = "gridTipoVehiculo";
            this.gridTipoVehiculo.ReadOnly = true;
            this.gridTipoVehiculo.Size = new System.Drawing.Size(684, 404);
            this.gridTipoVehiculo.TabIndex = 4;
            this.gridTipoVehiculo.DoubleClick += new System.EventHandler(this.gridTipoVehiculo_DoubleClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // NOMBRE
            // 
            this.NOMBRE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NOMBRE.DataPropertyName = "NOMBRE";
            this.NOMBRE.HeaderText = "Nombre";
            this.NOMBRE.Name = "NOMBRE";
            this.NOMBRE.ReadOnly = true;
            // 
            // ESTADO
            // 
            this.ESTADO.DataPropertyName = "ESTADO";
            this.ESTADO.HeaderText = "Estado";
            this.ESTADO.Name = "ESTADO";
            this.ESTADO.ReadOnly = true;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSave.Location = new System.Drawing.Point(597, 38);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnDelete.Location = new System.Drawing.Point(597, 67);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCancel.Location = new System.Drawing.Point(597, 96);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmTipoVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gridTipoVehiculo);
            this.Controls.Add(this.checkEstado);
            this.Controls.Add(this.TxNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCloseTipoVehiculo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTipoVehiculo";
            this.Text = "TipoVehiculo";
            this.Load += new System.EventHandler(this.FrmTipoVehiculo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridTipoVehiculo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCloseTipoVehiculo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxNombre;
        private System.Windows.Forms.CheckBox checkEstado;
        private System.Windows.Forms.DataGridView gridTipoVehiculo;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTADO;
    }
}