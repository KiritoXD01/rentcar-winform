﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACar
{
    public partial class FrmVehiculo : Form
    {
        VEHICULO model = new VEHICULO();

        public FrmVehiculo()
        {
            InitializeComponent();
        }

        public void ClearForm()
        {
            TxNumeroChasis.Text = "";
            TxNumeroMotor.Text = "";
            TxNumeroPlaca.Text = "";
            TxDescripcion.Text = "";
            TxFechaCreacion.Visible = false;
            labelFechaCreacion.Visible = false;
            checkEstado.Checked = true;
            btnSave.Text = "Guardar";
            btnDelete.Enabled = false;
            model.ID = 0;
        }

        public void PopulateDataGridView()
        {
            gridVehiculo.AutoGenerateColumns = false;
            using (DBEntities db = new DBEntities())
            {
                var items = db.VEHICULO.Select(
                    x => new
                    {
                        x.ID,
                        MARCA = x.MODELO_VEHICULO.MARCA_VEHICULO.NOMBRE,
                        MODELO = x.MODELO_VEHICULO.NOMBRE,
                        x.FECHA_CREACION,
                        ESTADO = x.ESTADO == true ? "Activo" : "Inactivo"
                    }).ToList();
                gridVehiculo.DataSource = items;
            }
        }

        public void PopulateCombos()
        {
            using (DBEntities db = new DBEntities())
            {
                //Fill comboModelo
                comboModelo.DataSource = db.MODELO_VEHICULO.Where(x => x.ESTADO == true).ToList();
                comboModelo.DisplayMember = "NOMBRE";
                comboModelo.ValueMember = "ID";

                //Fill comboTipoVehiculo
                comboTipoVehiculo.DataSource = db.TIPO_VEHICULO.Where(x => x.ESTADO == true).ToList();
                comboTipoVehiculo.DisplayMember = "NOMBRE";
                comboTipoVehiculo.ValueMember = "ID";

                //Fill comboTipoCombustible
                comboTipoCombustible.DataSource = db.COMBUSTIBLE_VEHICULO.Where(x => x.ESTADO == true).ToList();
                comboTipoCombustible.DisplayMember = "NOMBRE";
                comboTipoCombustible.ValueMember = "ID";
            }
        }

        private void FrmVehiculo_Load(object sender, EventArgs e)
        {
            ClearForm();
            PopulateDataGridView();
            PopulateCombos();
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            model.ID_MODELO_VEHICULO = Convert.ToInt32(comboModelo.SelectedValue);
            model.NUMERO_CHASIS = TxNumeroChasis.Text.Trim();
            model.NUMERO_MOTOR = TxNumeroMotor.Text.Trim();
            model.NUMERO_PLACA = TxNumeroPlaca.Text.Trim();
            model.ID_TIPO_VEHICULO = Convert.ToInt32(comboTipoVehiculo.SelectedValue);
            model.ID_TIPO_COMBUSTIBLE = Convert.ToInt32(comboTipoCombustible.SelectedValue);
            model.DESCRIPCION = TxDescripcion.Text.Trim();
            model.FECHA_CREACION = DateTime.Now;

            using (DBEntities db = new DBEntities())
            {
                if (model.ID == 0)
                {
                    db.VEHICULO.Add(model);
                }
                else
                {
                    db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                }
                db.SaveChanges();
            }
            ClearForm();
            PopulateDataGridView();
            PopulateCombos();
            MessageBox.Show("Vehiculo actualizado existosamente");
        }

        private void gridVehiculo_DoubleClick(object sender, EventArgs e)
        {
            if (gridVehiculo.CurrentRow.Index != -1)
            {
                model.ID = Convert.ToInt32(gridVehiculo.CurrentRow.Cells["ID"].Value);

                using (DBEntities db = new DBEntities())
                {
                    model = db.VEHICULO.Where(x => x.ID == model.ID).FirstOrDefault();
                    comboModelo.SelectedValue = Convert.ToInt32(model.MODELO_VEHICULO);
                    TxNumeroChasis.Text = model.NUMERO_CHASIS;
                    TxNumeroMotor.Text = model.NUMERO_MOTOR;
                    TxNumeroPlaca.Text = model.NUMERO_PLACA;
                    comboTipoVehiculo.SelectedValue = Convert.ToInt32(model.TIPO_VEHICULO);
                    comboTipoCombustible.SelectedValue = Convert.ToInt32(model.ID_TIPO_COMBUSTIBLE);
                    TxDescripcion.Text = model.DESCRIPCION;
                    TxFechaCreacion.Visible = true;
                    labelFechaCreacion.Visible = true;
                    TxFechaCreacion.Text = model.FECHA_CREACION.ToString();
                }
                btnSave.Text = "Actualizar";
                btnDelete.Enabled = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea borrar este elemento?", "Eliminar Elemento", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (DBEntities db = new DBEntities())
                {
                    var entry = db.Entry(model);
                    if(entry.State == System.Data.Entity.EntityState.Detached)
                    {
                        db.VEHICULO.Attach(model);
                    }
                    db.VEHICULO.Remove(model);
                    db.SaveChanges();

                    PopulateDataGridView();
                    PopulateCombos();
                    ClearForm();
                }
            }
        }
    }
}
