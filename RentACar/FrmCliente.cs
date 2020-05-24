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
    public partial class FrmCliente : Form
    {
        CLIENTE model = new CLIENTE();

        public FrmCliente()
        {
            InitializeComponent();
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            ClearForm();
            PopulateCombos();
            PopulateDataGridView();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearForm()
        {
            TxNombres.Text = "";
            TxApellidos.Text = "";
            TxCedula.Text = "";
            TxEmail.Text = "";
            TxTelefono.Text = "";
            checkEstado.Checked = true;
            TxTarjetaCredito.Text = "";
            TxLimiteCredito.Text = "";
            labelFechaCreacion.Visible = false;
            TxFechaCreacion.Visible = false;
            model.ID = 0;
            btnSave.Text = "Guardar";
            btnDelete.Enabled = false;
        }

        private void PopulateDataGridView()
        {
            gridCliente.AutoGenerateColumns = false;
            using (DBEntities db = new DBEntities())
            {
                gridCliente.DataSource = db.CLIENTE.ToList<CLIENTE>();
            }
        }

        public void PopulateCombos()
        {
            using (DBEntities db = new DBEntities())
            {
                comboTipoPersona.DataSource = db.TIPO_CLIENTE.ToList<TIPO_CLIENTE>();
                comboTipoPersona.DisplayMember = "DESCRIPCION";
                comboTipoPersona.ValueMember = "ID";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            model.NOMBRES = TxNombres.Text.Trim();
            model.APELLIDOS = TxApellidos.Text.Trim();
            model.CEDULA = TxCedula.Text.Trim();
            model.EMAIL = TxEmail.Text.Trim();
            model.TELEFONO = TxTelefono.Text.Trim();
            model.TARJETA_CREDITO = TxTarjetaCredito.Text.Trim();
            model.LIMITE_CREDITO = Convert.ToDecimal(TxLimiteCredito.Text.Trim());
            model.ESTADO = checkEstado.Checked;
            model.ID_TIPO_CLIENTE = Convert.ToInt32(comboTipoPersona.SelectedValue);
            model.FECHA_CREACION = DateTime.Now;

            using (DBEntities db = new DBEntities())
            {
                if (model.ID == 0)
                {
                    db.CLIENTE.Add(model);
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
            MessageBox.Show("Cliente actualizado existosamente");
        }

        private void gridCliente_DoubleClick(object sender, EventArgs e)
        {
            if (gridCliente.CurrentRow.Index != -1)
            {
                model.ID = Convert.ToInt32(gridCliente.CurrentRow.Cells["ID"].Value);

                using (DBEntities db = new DBEntities())
                {
                    model = db.CLIENTE.Where(x => x.ID == model.ID).FirstOrDefault();
                    TxNombres.Text = model.NOMBRES;
                    TxApellidos.Text = model.APELLIDOS;
                    TxCedula.Text = model.CEDULA;
                    TxEmail.Text = model.EMAIL;
                    TxTelefono.Text = model.TELEFONO;
                    TxTarjetaCredito.Text = model.TARJETA_CREDITO;
                    TxLimiteCredito.Text = model.LIMITE_CREDITO.ToString();
                    checkEstado.Checked = Convert.ToBoolean(model.ESTADO);
                    comboTipoPersona.SelectedValue = Convert.ToInt32(model.ID_TIPO_CLIENTE);
                    TxFechaCreacion.Visible = true;
                    labelFechaCreacion.Visible = true;
                    TxFechaCreacion.Text = model.FECHA_CREACION.ToString();
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
                        db.CLIENTE.Attach(model);
                    }
                    db.CLIENTE.Remove(model);
                    db.SaveChanges();

                    PopulateDataGridView();
                    PopulateCombos();
                    ClearForm();
                    MessageBox.Show("Cliente eliminado existosamente");
                }
            }
        }
    }
}
