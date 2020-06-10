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
    public partial class FrmTanda : Form
    {
        TANDA model = new TANDA();

        public FrmTanda()
        {
            InitializeComponent();
        }

        private void FrmTanda_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            ClearForm();
            PopulateDataGridView();
        }

        private void ClearForm()
        {
            TxDescripcion.Text = "";
            checkEstado.Checked = true;
            btnSave.Text = "Guardar";
            btnDelete.Enabled = false;
            model.ID = 0;
        }

        private void PopulateDataGridView()
        {
            gridTanda.AutoGenerateColumns = false;
            using (DBEntities db = new DBEntities())
            {
                var items = db.TANDA.Select(
                    x => new
                    {
                        x.ID,
                        x.DESCRIPCION,
                        ESTADO = x.ESTADO == true ? "Activo" : "Inactivo"
                    }).ToList();
                gridTanda.DataSource = items;
            }
        }

        private void btnCloseTipoVehiculo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private bool ValidateData()
        {
            if(String.IsNullOrWhiteSpace(TxDescripcion.Text))
            {
                MessageBox.Show("Debe ingresar el tipo de tanda.");
                TxDescripcion.Focus();
                return false;
            }
            return true;
        }

        private bool ValidateUniqueFieldsOnCreate()
        {
            using (DBEntities db = new DBEntities())
            {
                if (db.TANDA.Where(x => x.DESCRIPCION == model.DESCRIPCION).Count() > 0)
                {
                    MessageBox.Show("Esta tanda ya existe, por favor verifique los datos.");
                    return false;
                }
            }

            return true;
        }

        private bool ValidateUniqueFieldsOnUpdate()
        {
            using (DBEntities db = new DBEntities())
            {
                if (db.TANDA.Where(x => x.DESCRIPCION == model.DESCRIPCION && x.ID != model.ID).Count() > 0)
                {
                    MessageBox.Show("Esta tanda ya existe, por favor verifique los datos.");
                    return false;
                }
            }


            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(ValidateData())
            {
                model.DESCRIPCION = TxDescripcion.Text.Trim().ToUpper();
                model.ESTADO = checkEstado.Checked;

                using (DBEntities db = new DBEntities())
                {
                    if(model.ID == 0)
                    {
                        if (ValidateUniqueFieldsOnCreate())
                        {
                            db.TANDA.Add(model);
                            db.SaveChanges();
                            ClearForm();
                            PopulateDataGridView();
                            MessageBox.Show("Tanda creada existosamente");
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
                            MessageBox.Show("Tanda actualizada existosamente");
                        }                        
                    }                    
                }                
            }
        }

        private void gridTanda_DoubleClick(object sender, EventArgs e)
        {
            if(gridTanda.CurrentRow.Index != -1)
            {
                model.ID = Convert.ToInt32(gridTanda.CurrentRow.Cells["ID"].Value);
                using (DBEntities db = new DBEntities())
                {
                    model = db.TANDA.Where(x => x.ID == model.ID).FirstOrDefault();
                    TxDescripcion.Text = model.DESCRIPCION;
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
                string result = (model.ESTADO == true) ? "Tanda activado existosamente" : "Tanda desactivado existosamente";
                MessageBox.Show(result);
            }
        }
    }
}
