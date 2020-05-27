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
    public partial class FrmModeloVehiculo : Form
    {
        MODELO_VEHICULO model = new MODELO_VEHICULO();

        public FrmModeloVehiculo()
        {
            InitializeComponent();
        }

        private void FrmModeloVehiculo_Load(object sender, EventArgs e)
        {
            ClearForm();
            PopulateDataGridView();
            PopulateComboMarca();
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnCloseTipoVehiculo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearForm()
        {
            TxNombre.Text = "";
            checkEstado.Checked = true;
            btnSave.Text = "Guardar";
            btnDelete.Enabled = false;
            model.ID = 0;
        }

        private void PopulateDataGridView()
        {
            gridModeloVehiculo.AutoGenerateColumns = false;
            using (DBEntities db = new DBEntities())
            {
                var items = db.MODELO_VEHICULO.Select(
                    x => new
                    {
                        x.ID,
                        x.NOMBRE,
                        MARCA = x.MARCA_VEHICULO.NOMBRE,
                        ESTADO = x.ESTADO == true ? "Activo" : "Inactivo"
                    }).ToList();
                gridModeloVehiculo.DataSource = items;
            }
        }

        private void PopulateComboMarca()
        {
            using (DBEntities db = new DBEntities())
            {
                var items = db.MARCA_VEHICULO.Where(x => x.ESTADO == true).ToList();
                comboMarca.DataSource = items;
                comboMarca.DisplayMember = "NOMBRE";
                comboMarca.ValueMember = "ID";
            }
        }

        private bool ValidateData()
        {
            if (String.IsNullOrWhiteSpace(TxNombre.Text))
            {
                MessageBox.Show("Debe ingresar el modelo del vehiculo.");
                TxNombre.Focus();
                return false;
            }

            if (comboMarca.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar la marca del vehiculo.");
                comboMarca.Focus();
                return false;
            }

            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                model.NOMBRE = TxNombre.Text.Trim();
                model.ID_MARCA_VEHICULO = Convert.ToInt32(comboMarca.SelectedValue);
                model.ESTADO = checkEstado.Checked;

                using (DBEntities db = new DBEntities())
                {
                    if (model.ID == 0)
                    {
                        db.MODELO_VEHICULO.Add(model);
                    }
                    else
                    {
                        db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                    }
                    db.SaveChanges();
                }
                ClearForm();
                PopulateDataGridView();
                PopulateComboMarca();
                MessageBox.Show("Modelo de vehiculo actualizado existosamente");
            }            
        }

        private void gridModeloVehiculo_DoubleClick(object sender, EventArgs e)
        {
            if (gridModeloVehiculo.CurrentRow.Index != -1)
            {
                model.ID = Convert.ToInt32(gridModeloVehiculo.CurrentRow.Cells["ID"].Value);

                using (DBEntities db = new DBEntities())
                {
                    model = db.MODELO_VEHICULO.Where(x => x.ID == model.ID).FirstOrDefault();
                    TxNombre.Text = model.NOMBRE;
                    checkEstado.Checked = Convert.ToBoolean(model.ESTADO);
                    comboMarca.SelectedValue = Convert.ToInt32(model.MARCA_VEHICULO);
                }
                btnSave.Text = "Actualizar";
                btnDelete.Enabled = true;
            }
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
                        db.MODELO_VEHICULO.Attach(model);
                    }
                    db.MODELO_VEHICULO.Remove(model);
                    db.SaveChanges();

                    PopulateDataGridView();
                    PopulateComboMarca();
                    ClearForm();
                    MessageBox.Show("Marca de vehiculo eliminado existosamente");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
    }
}