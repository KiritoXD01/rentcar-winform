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
    public partial class FrmTipoVehiculo : Form
    {
        TIPO_VEHICULO model = new TIPO_VEHICULO();

        public FrmTipoVehiculo()
        {
            InitializeComponent();
        }

        private void btnCloseTipoVehiculo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmTipoVehiculo_Load(object sender, EventArgs e)
        {
            ClearForm();
            PopulateDataGridView();
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearForm();
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
            using (DBEntities db = new DBEntities())
            {
                var items = db.TIPO_VEHICULO.Select(
                    x => new
                    {
                        x.ID,
                        x.NOMBRE,
                        ESTADO = x.ESTADO == true ? "Activo" : "Inactivo"
                    }).ToList();
                gridTipoVehiculo.DataSource = items;
            }
        }

        private bool ValidateData()
        {
            if (String.IsNullOrWhiteSpace(TxNombre.Text))
            {
                MessageBox.Show("Debe ingresar el tipo de vehiculo.");
                TxNombre.Focus();
                return false;
            }
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                model.NOMBRE = TxNombre.Text.Trim().ToUpper();
                model.ESTADO = checkEstado.Checked;

                using (DBEntities db = new DBEntities())
                {
                    if (model.ID == 0)
                    {
                        if (db.TIPO_VEHICULO.Where(x => x.NOMBRE == model.NOMBRE).Count() > 0)
                        {
                            MessageBox.Show("El tipo de vehiculo ingresado ya existe, por favor intentelo nuevamente");
                        }
                        else
                        {
                            db.TIPO_VEHICULO.Add(model);
                            db.SaveChanges();
                            ClearForm();
                            PopulateDataGridView();
                            MessageBox.Show("Tipo de vehiculo creado existosamente");
                        }                        
                    }
                    else
                    {
                        if (db.TIPO_VEHICULO.Where(x => x.NOMBRE == model.NOMBRE && x.ID != model.ID).Count() > 0)
                        {
                            MessageBox.Show("El tipo de vehiculo ingresado ya existe, por favor intentelo nuevamente");
                        }
                        else
                        {
                            db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                            db.SaveChanges();
                            ClearForm();
                            PopulateDataGridView();
                            MessageBox.Show("Tipo de vehiculo actualizado existosamente");
                        }                        
                    }
                }
            }            
        }

        private void gridTipoVehiculo_DoubleClick(object sender, EventArgs e)
        {
            if (gridTipoVehiculo.CurrentRow.Index != -1)
            {
                model.ID = Convert.ToInt32(gridTipoVehiculo.CurrentRow.Cells["ID"].Value);
                using (DBEntities db = new DBEntities())
                {
                    model = db.TIPO_VEHICULO.Where(x => x.ID == model.ID).FirstOrDefault();
                    TxNombre.Text = model.NOMBRE;
                    checkEstado.Checked = Convert.ToBoolean(model.ESTADO);
                    btnDelete.Text = model.ESTADO == true ? "Deshabilitar" : "Habilitar";
                    btnSave.Text = "Actualizar";
                    btnDelete.Enabled = true;
                }
            }
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
                string result = (model.ESTADO == true) ? "Tipo de vehiculo activado existosamente" : "Tipo de vehiculo desactivado existosamente";
                MessageBox.Show(result);
            }
        }

        private void TxFiltrar_TextChanged(object sender, EventArgs e)
        {
            if (TxFiltrar.Text.Length > 0)
            {
                using (DBEntities db = new DBEntities())
                {
                    var query = from tipos in db.TIPO_VEHICULO
                                where tipos.NOMBRE.Contains(TxFiltrar.Text.Trim().ToUpper())
                                select tipos;

                    var items = query.Select(
                        x => new
                        {
                            x.ID,
                            x.NOMBRE,
                            ESTADO = x.ESTADO == true ? "Activo" : "Inactivo"
                        }).ToList();
                    gridTipoVehiculo.DataSource = items;
                }
            }
            else
            {
                PopulateDataGridView();
            }            
        }
    }
}
