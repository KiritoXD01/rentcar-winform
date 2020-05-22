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
    public partial class FrmCombustibleVehiculo : Form
    {
        COMBUSTIBLE_VEHICULO model = new COMBUSTIBLE_VEHICULO();

        public FrmCombustibleVehiculo()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
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
            gridCombustibleVehiculo.AutoGenerateColumns = false;
            using (DBEntities db = new DBEntities())
            {
                gridCombustibleVehiculo.DataSource = db.COMBUSTIBLE_VEHICULO.ToList<COMBUSTIBLE_VEHICULO>();
            }
        }

        private void FormCombustibleVehiculo_Load(object sender, EventArgs e)
        {
            ClearForm();
            PopulateDataGridView();
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            model.NOMBRE = TxNombre.Text.Trim();
            model.ESTADO = checkEstado.Checked;

            using (DBEntities db = new DBEntities())
            {
                if (model.ID == 0)
                {
                    db.COMBUSTIBLE_VEHICULO.Add(model);
                }
                else
                {
                    db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                }
                db.SaveChanges();
            }
            ClearForm();
            PopulateDataGridView();
            MessageBox.Show("Combustible de vehiculo actualizado existosamente");
        }

        private void gridCombustibleVehiculo_DoubleClick(object sender, EventArgs e)
        {
            if (gridCombustibleVehiculo.CurrentRow.Index != -1)
            {
                model.ID = Convert.ToInt32(gridCombustibleVehiculo.CurrentRow.Cells["ID"].Value);
                using (DBEntities db = new DBEntities())
                {
                    model = db.COMBUSTIBLE_VEHICULO.Where(x => x.ID == model.ID).FirstOrDefault();
                    TxNombre.Text = model.NOMBRE;
                    checkEstado.Checked = Convert.ToBoolean(model.ESTADO);
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
                    if (entry.State == System.Data.Entity.EntityState.Detached)
                    {
                        db.COMBUSTIBLE_VEHICULO.Attach(model);
                    }
                    db.COMBUSTIBLE_VEHICULO.Remove(model);
                    db.SaveChanges();

                    PopulateDataGridView();
                    ClearForm();
                    MessageBox.Show("Combustible de vehiculo eliminado existosamente");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
    }
}
