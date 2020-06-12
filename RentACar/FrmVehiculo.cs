using System;
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

        private void ClearForm()
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

        private void PopulateDataGridView()
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
                        ESTADO = x.ESTADO == true ? "Activo" : "Inactivo"
                    }).ToList();
                gridVehiculo.DataSource = items;
            }
        }

        private void PopulateCombos()
        {
            using (DBEntities db = new DBEntities())
            {
                //Fill comboModelo
                var models = db.MODELO_VEHICULO
                    .Where(x => x.ESTADO == true)
                    .Select(
                    x => new
                    {
                        x.ID,
                        NOMBRE = x.MARCA_VEHICULO.NOMBRE + " - " + x.NOMBRE
                    })
                    .ToList();
                comboModelo.DataSource = models;
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

        private bool ValidateData()
        {
            if (comboModelo.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar el modelo del vehiculo.");
                comboModelo.Focus();
                return false;
            }

            if (String.IsNullOrWhiteSpace(TxNumeroChasis.Text))
            {
                MessageBox.Show("Debe el numero del chasis del vehiculo.");
                TxNumeroChasis.Focus();
                return false;
            }

            if (String.IsNullOrWhiteSpace(TxNumeroMotor.Text))
            {
                MessageBox.Show("Debe el numero del motor del vehiculo.");
                TxNumeroMotor.Focus();
                return false;
            }

            if (String.IsNullOrWhiteSpace(TxNumeroPlaca.Text))
            {
                MessageBox.Show("Debe el numero de placa del vehiculo.");
                TxNumeroPlaca.Focus();
                return false;
            }

            if (comboTipoVehiculo.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar el tipo de vehiculo.");
                comboTipoVehiculo.Focus();
                return false;
            }

            if (comboTipoCombustible.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar el tipo de combustible del vehiculo.");
                comboTipoCombustible.Focus();
                return false;
            }

            if (String.IsNullOrWhiteSpace(TxDescripcion.Text))
            {
                MessageBox.Show("Debe ingresar una descripcion del vehiculo.");
                TxDescripcion.Focus();
                return false;
            }

            return true;
        }

        private bool ValidateUniqueFieldsOnCreate()
        {
            using (DBEntities db = new DBEntities())
            {
                if (db.VEHICULO.Where(x => x.NUMERO_CHASIS == model.NUMERO_CHASIS).Count() > 0)
                {
                    MessageBox.Show("El numero de chasis ya existe, por favor verifique los datos.");
                    return false;
                }

                if (db.VEHICULO.Where(x => x.NUMERO_MOTOR == model.NUMERO_MOTOR).Count() > 0)
                {
                    MessageBox.Show("El numero de motor ya existe, por favor verifique los datos.");
                    return false;
                }

                if (db.VEHICULO.Where(x => x.NUMERO_PLACA == model.NUMERO_PLACA).Count() > 0)
                {
                    MessageBox.Show("El numero de placa ya existe, por favor verifique los datos.");
                    return false;
                }
            }

            return true;
        }

        private bool ValidateUniqueFieldsOnUpdate()
        {
            using (DBEntities db = new DBEntities())
            {
                if (db.VEHICULO.Where(x => x.NUMERO_CHASIS == model.NUMERO_CHASIS && x.ID != model.ID).Count() > 0)
                {
                    MessageBox.Show("El numero de chasis ya existe, por favor verifique los datos.");
                    return false;
                }

                if (db.VEHICULO.Where(x => x.NUMERO_MOTOR == model.NUMERO_MOTOR && x.ID != model.ID).Count() > 0)
                {
                    MessageBox.Show("El numero de motor ya existe, por favor verifique los datos.");
                    return false;
                }

                if (db.VEHICULO.Where(x => x.NUMERO_PLACA == model.NUMERO_PLACA && x.ID != model.ID).Count() > 0)
                {
                    MessageBox.Show("El numero de placa ya existe, por favor verifique los datos.");
                    return false;
                }
            }

            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                model.ID_MODELO_VEHICULO = Convert.ToInt32(comboModelo.SelectedValue);
                model.NUMERO_CHASIS = TxNumeroChasis.Text.Trim();
                model.NUMERO_MOTOR = TxNumeroMotor.Text.Trim();
                model.NUMERO_PLACA = TxNumeroPlaca.Text.Trim();
                model.ID_TIPO_VEHICULO = Convert.ToInt32(comboTipoVehiculo.SelectedValue);
                model.ID_TIPO_COMBUSTIBLE = Convert.ToInt32(comboTipoCombustible.SelectedValue);
                model.DESCRIPCION = TxDescripcion.Text.Trim();
                model.FECHA_CREACION = DateTime.Now;
                model.ESTADO = Convert.ToBoolean(checkEstado.Checked);

                using (DBEntities db = new DBEntities())
                {
                    if (model.ID == 0)
                    {
                        if (ValidateUniqueFieldsOnCreate())
                        {
                            db.VEHICULO.Add(model);
                            db.SaveChanges();
                            ClearForm();
                            PopulateDataGridView();
                            PopulateCombos();
                            MessageBox.Show("Vehiculo creado existosamente");
                        }                        
                    }
                    else
                    {
                        if (ValidateUniqueFieldsOnUpdate())
                        {
                            db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                            db.SaveChanges();
                            ClearForm();
                            PopulateDataGridView();
                            PopulateCombos();
                            MessageBox.Show("Vehiculo actualizado existosamente");
                        }                        
                    }                    
                }                
            }
        }

        private void gridVehiculo_DoubleClick(object sender, EventArgs e)
        {
            if (gridVehiculo.CurrentRow.Index != -1)
            {
                model.ID = Convert.ToInt32(gridVehiculo.CurrentRow.Cells["ID"].Value);

                using (DBEntities db = new DBEntities())
                {
                    model = db.VEHICULO.Where(x => x.ID == model.ID).FirstOrDefault();
                    comboModelo.SelectedValue = Convert.ToInt32(model.ID_MODELO_VEHICULO);
                    TxNumeroChasis.Text = model.NUMERO_CHASIS;
                    TxNumeroMotor.Text = model.NUMERO_MOTOR;
                    TxNumeroPlaca.Text = model.NUMERO_PLACA;
                    comboTipoVehiculo.SelectedValue = Convert.ToInt32(model.ID_TIPO_VEHICULO);
                    comboTipoCombustible.SelectedValue = Convert.ToInt32(model.ID_TIPO_COMBUSTIBLE);
                    TxDescripcion.Text = model.DESCRIPCION;
                    TxFechaCreacion.Visible = true;
                    labelFechaCreacion.Visible = true;
                    TxFechaCreacion.Text = model.FECHA_CREACION.ToString();
                    checkEstado.Checked = Convert.ToBoolean(model.ESTADO);
                    btnDelete.Text = model.ESTADO == true ? "Deshabilitar" : "Habilitar";
                    btnSave.Text = "Actualizar";
                    btnDelete.Enabled = true;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string question = (model.ESTADO == true) ? "Desea desactivar este elemento?" : "Desea activar este elemento";

            if (MessageBox.Show(question, "Cambiar Estado", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                model.ESTADO = !model.ESTADO;

                using (DBEntities db = new DBEntities())
                {
                    db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
                ClearForm();
                PopulateDataGridView();
                PopulateCombos();
                string result = (model.ESTADO == true) ? "Vehiculo activado existosamente" : "Vehiculo desactivado existosamente";
                MessageBox.Show(result);
            }
        }

        private void TxFiltrar_TextChanged(object sender, EventArgs e)
        {
            if (TxFiltrar.Text.Length > 0)
            {
                using (DBEntities db = new DBEntities())
                {
                    var items = db.VEHICULO
                        .Where(x =>
                            x.MODELO_VEHICULO.MARCA_VEHICULO.NOMBRE.Contains(TxFiltrar.Text.Trim().ToUpper()) ||
                            x.MODELO_VEHICULO.NOMBRE.Contains(TxFiltrar.Text.Trim().ToUpper()) || 
                            x.NUMERO_CHASIS.Contains(TxFiltrar.Text.Trim()) ||
                            x.NUMERO_MOTOR.Contains(TxFiltrar.Text.Trim()) ||
                            x.NUMERO_PLACA.Contains(TxFiltrar.Text.Trim()) ||
                            x.TIPO_VEHICULO.NOMBRE.Contains(TxFiltrar.Text.Trim().ToUpper()) ||
                            x.COMBUSTIBLE_VEHICULO.NOMBRE.Contains(TxFiltrar.Text.Trim().ToUpper())
                        )
                        .Select(
                        x => new
                        {
                            x.ID,
                            MARCA = x.MODELO_VEHICULO.MARCA_VEHICULO.NOMBRE,
                            MODELO = x.MODELO_VEHICULO.NOMBRE,
                            ESTADO = x.ESTADO == true ? "Activo" : "Inactivo"
                        })
                        .ToList();
                    gridVehiculo.DataSource = items;
                }
            }
            else
            {
                PopulateDataGridView();
            }
        }
    }
}
