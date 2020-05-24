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
    public partial class FrmEmpleado : Form
    {
        EMPLEADO model = new EMPLEADO();

        public FrmEmpleado()
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
            TxApellido.Text = "";
            TxClave.Text = "";
            checkEstado.Checked = true;
            TxPorcientoComision.Text = "";
            DPFechaIngreso.Value = DateTime.Today;
            labelFechaCreacion.Visible = false;
            TxFechaCreacion.Visible = false;
            model.ID = 0;
            btnSave.Text = "Guardar";
            btnDelete.Enabled = false;
        }

        private void PopulateDataGridView()
        {
            gridEmpleado.AutoGenerateColumns = false;
            using (DBEntities db = new DBEntities())
            {
                gridEmpleado.DataSource = db.EMPLEADO.ToList<EMPLEADO>();
            }
        }

        private void PopulateCombos()
        {
            using (DBEntities db = new DBEntities())
            {
                //Fill tandas
                comboTanda.DataSource = db.TANDA.ToList<TANDA>();
                comboTanda.DisplayMember = "DESCRIPCION";
                comboTanda.ValueMember = "ID";

                //Fill Tipo de Empleado
                comboTipoEmpleado.DataSource = db.TIPO_EMPLEADO.ToList<TIPO_EMPLEADO>();
                comboTipoEmpleado.DisplayMember = "DESCRIPCION";
                comboTipoEmpleado.ValueMember = "ID";
            }
        }

        private void FrmEmpleado_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            ClearForm();
            PopulateDataGridView();
            PopulateCombos();            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            model.NOMBRES = TxNombre.Text.Trim();
            model.APELLIDOS = TxApellido.Text.Trim();
            model.CLAVE = TxClave.Text.Trim();
            model.ID_TANDA = Convert.ToInt32(comboTanda.SelectedValue);
            model.ESTADO = checkEstado.Checked;
            model.PORCIENTO_COMISION = Convert.ToDecimal(TxPorcientoComision.Text.Trim());
            model.FECHA_INGRESO = Convert.ToDateTime(DPFechaIngreso.Value);
            model.ID_TIPO_EMPLEADO = Convert.ToInt32(comboTipoEmpleado.SelectedValue);
            model.FECHA_CREACION = DateTime.Now;

            using (DBEntities db = new DBEntities())
            {
                if (model.ID == 0)
                {
                    db.EMPLEADO.Add(model);
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
            MessageBox.Show("Empleado actualizado existosamente");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void gridEmpleado_DoubleClick(object sender, EventArgs e)
        {
            if (gridEmpleado.CurrentRow.Index != -1)
            {
                model.ID = Convert.ToInt32(gridEmpleado.CurrentRow.Cells["ID"].Value);

                using (DBEntities db = new DBEntities())
                {
                    model = db.EMPLEADO.Where(x => x.ID == model.ID).FirstOrDefault();
                    TxNombre.Text = model.NOMBRES;
                    TxApellido.Text = model.APELLIDOS;
                    TxClave.Text = model.CLAVE;
                    comboTanda.SelectedValue = Convert.ToInt32(model.ID_TANDA);
                    checkEstado.Checked = Convert.ToBoolean(model.ESTADO);
                    TxPorcientoComision.Text = model.PORCIENTO_COMISION.ToString();
                    DPFechaIngreso.Value = Convert.ToDateTime(model.FECHA_INGRESO);
                    comboTipoEmpleado.SelectedValue = Convert.ToInt32(model.ID_TIPO_EMPLEADO);
                    TxFechaCreacion.Text = model.FECHA_CREACION.ToString();
                    labelFechaCreacion.Visible = true;
                    TxFechaCreacion.Visible = true;
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
                        db.EMPLEADO.Attach(model);
                    }
                    db.EMPLEADO.Remove(model);
                    db.SaveChanges();
                    ClearForm();
                    PopulateDataGridView();
                    PopulateCombos();
                    MessageBox.Show("Empleado eliminado existosamente");
                }
            }
        }
    }
}
