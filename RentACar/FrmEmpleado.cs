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
                var items = db.EMPLEADO.Select(
                    x => new
                    {
                        x.ID,
                        x.NOMBRES,
                        x.APELLIDOS,
                        TIPO_EMPLEADO = x.TIPO_EMPLEADO.DESCRIPCION,
                        ESTADO = x.ESTADO == true ? "Activo" : "Inactivo"
                    }).ToList();
                gridEmpleado.DataSource = items;
            }
        }

        private void PopulateCombos()
        {
            using (DBEntities db = new DBEntities())
            {
                //Fill tandas
                comboTanda.DataSource = db.TANDA.Where(x => x.ESTADO == true).ToList();
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

        private bool ValidateData()
        {
            if (String.IsNullOrWhiteSpace(TxNombre.Text))
            {
                MessageBox.Show("Debe ingresar el nombre del empleado.");
                TxNombre.Focus();
                return false;
            }

            if (String.IsNullOrWhiteSpace(TxApellido.Text))
            {
                MessageBox.Show("Debe ingresar el apellido del empleado.");
                TxApellido.Focus();
                return false;
            }

            if (String.IsNullOrWhiteSpace(TxClave.Text))
            {
                MessageBox.Show("Debe ingresar la clave del empleado.");
                TxClave.Focus();
                return false;
            }

            if (comboTanda.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar la tanda del empleado.");
                comboTanda.Focus();
                return false;
            }

            if (String.IsNullOrWhiteSpace(TxPorcientoComision.Text))
            {
                MessageBox.Show("Debe ingresar el porciento de comision del empleado.");
                TxPorcientoComision.Focus();
                return false;
            }

            if (String.IsNullOrWhiteSpace(DPFechaIngreso.Text))
            {
                MessageBox.Show("Debe ingresar la fecha de ingreso del empleado.");
                DPFechaIngreso.Focus();
                return false;
            }

            if (comboTipoEmpleado.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar el tipo de empleado.");
                comboTipoEmpleado.Focus();
                return false;
            }

            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateData())
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
                PopulateCombos();
                string result = (model.ESTADO == true) ? "Empleado activado existosamente" : "Empleado desactivado existosamente";
                MessageBox.Show(result);
            }
        }
    }
}
