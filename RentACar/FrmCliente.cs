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
                var items = db.CLIENTE.Select(
                    x => new
                    {
                        x.ID,
                        x.NOMBRES,
                        x.APELLIDOS,
                        x.EMAIL,
                        ESTADO = x.ESTADO == true ? "Activo" : "Inactivo"
                    }).ToList();

                gridCliente.DataSource = items;
            }
        }

        private void PopulateCombos()
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

        private bool ValidateData()
        {
            if (String.IsNullOrWhiteSpace(TxNombres.Text))
            {
                MessageBox.Show("Debe ingresar el nombre del cliente.");
                TxNombres.Focus();
                return false;
            }

            if (String.IsNullOrWhiteSpace(TxApellidos.Text))
            {
                MessageBox.Show("Debe ingresar el apellidos del cliente.");
                TxApellidos.Focus();
                return false;
            }

            if (String.IsNullOrWhiteSpace(TxCedula.Text))
            {
                MessageBox.Show("Debe ingresar la cedula del cliente.");
                TxCedula.Focus();
                return false;
            }

            if (String.IsNullOrWhiteSpace(TxEmail.Text))
            {
                MessageBox.Show("Debe ingresar la correo del cliente.");
                TxEmail.Focus();
                return false;
            }

            if (String.IsNullOrWhiteSpace(TxTarjetaCredito.Text))
            {
                MessageBox.Show("Debe ingresar la tarjeta de credito del cliente.");
                TxTarjetaCredito.Focus();
                return false;
            }

            if (String.IsNullOrWhiteSpace(TxLimiteCredito.Text))
            {
                MessageBox.Show("Debe ingresar el limite de credito del cliente.");
                TxLimiteCredito.Focus();
                return false;
            }

            if (comboTipoPersona.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar el tipo de cliente.");
                comboTipoPersona.Focus();
                return false;
            }

            return true;
        }

        private bool ValidateUniqueFieldsOnCreate()
        {
            using (DBEntities db = new DBEntities())
            {
                if (db.CLIENTE.Where(x => x.CEDULA == model.CEDULA).Count() > 0)
                {
                    MessageBox.Show("La cedula ya existe, por favor verifique los datos.");
                    return false;
                }

                if (db.CLIENTE.Where(x => x.EMAIL == model.EMAIL).Count() > 0)
                {
                    MessageBox.Show("El email ya existe, por favor verifique los datos.");
                    return false;
                }
            }

            return true;
        }

        private bool ValidateUniqueFieldsOnUpdate()
        {
            using (DBEntities db = new DBEntities())
            {
                if (db.CLIENTE.Where(x => x.CEDULA == model.CEDULA && x.ID != model.ID).Count() > 0)
                {
                    MessageBox.Show("La cedula ya existe, por favor verifique los datos.");
                    return false;
                }

                if (db.CLIENTE.Where(x => x.EMAIL == model.EMAIL && x.ID != model.ID).Count() > 0)
                {
                    MessageBox.Show("El email ya existe, por favor verifique los datos.");
                    return false;
                }
            }

            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                model.NOMBRES = TxNombres.Text.Trim();
                model.APELLIDOS = TxApellidos.Text.Trim();
                model.CEDULA = TxCedula.Text.Trim();
                model.EMAIL = TxEmail.Text.Trim().ToLower();
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
                        if (ValidateUniqueFieldsOnCreate())
                        {
                            db.CLIENTE.Add(model);
                            db.SaveChanges();
                            ClearForm();
                            PopulateDataGridView();
                            PopulateCombos();
                            MessageBox.Show("Cliente creado existosamente");
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
                            MessageBox.Show("Cliente actualizado existosamente");
                        }
                    }
                }                
            }            
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
                string result = (model.ESTADO == true) ? "Cliente activado existosamente" : "Cliente desactivado existosamente";
                MessageBox.Show(result);
            }
        }

        private void TxFiltrar_TextChanged(object sender, EventArgs e)
        {
            if (TxFiltrar.Text.Length > 0)
            {
                using (DBEntities db = new DBEntities())
                {
                    var items = db.CLIENTE
                        .Where(x =>
                            x.NOMBRES.Contains(TxFiltrar.Text.Trim()) ||
                            x.APELLIDOS.Contains(TxFiltrar.Text.Trim()) ||
                            x.CEDULA.Contains(TxFiltrar.Text.Trim()) ||
                            x.EMAIL.Contains(TxFiltrar.Text.Trim().ToLower()) ||
                            x.TELEFONO.Contains(TxFiltrar.Text.Trim()) ||
                            x.TIPO_CLIENTE.DESCRIPCION.Contains(TxFiltrar.Text.Trim().ToUpper())
                        )
                        .Select(
                        x => new
                        {
                            x.ID,
                            x.NOMBRES,
                            x.APELLIDOS,
                            x.EMAIL,
                            ESTADO = x.ESTADO == true ? "Activo" : "Inactivo"
                        })
                        .ToList();
                    gridCliente.DataSource = items;
                }
            }
            else
            {
                PopulateDataGridView();
            }
        }

        private void TxCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Verifica que la tecla presionada es solo numerica
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void TxTarjetaCredito_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Verifica que la tecla presionada es solo numerica
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void TxLimiteCredito_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Verifica que la tecla presionada es solo numerica
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
