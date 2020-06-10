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
    public partial class FrmRenta : Form
    {
        RENTA model = new RENTA();

        public static int VEHICULO = 0;
        public static int CLIENTE = 0;
        public static int EMPLEADO = 0;

        public FrmRenta()
        {
            InitializeComponent();
        }

        private void btnCloseTipoVehiculo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearForm()
        {
            btnInspeccion.Text = "Crear Inspeccion";
            TxFechaRenta.Text = "";
            TxFechaRenta.Text = DateTime.Now.ToString();
            DPFechaDevolucion.MinDate = DateTime.Now;
            TxCantidadDias.Text = "";
            TxMontoDia.Text = "";
            TxDescripcion.Text = "";
            btnSave.Text = "Guardar";
            btnSave.Enabled = false;
            btnInspeccion.Enabled = false;
            btnInspeccion.Text = "Crear Inspeccion";
            model.ID = 0;
            model.ID_INSPECCION = 0;
        }

        private void PopulateDataGridView()
        {
            gridRenta.AutoGenerateColumns = false;
            using (DBEntities db = new DBEntities())
            {
                var items = db.RENTA.Select(
                    x => new
                    {
                        x.ID,
                        VEHICULO = x.VEHICULO.MODELO_VEHICULO.MARCA_VEHICULO.NOMBRE + " " + x.VEHICULO.MODELO_VEHICULO.NOMBRE,
                        CLIENTE = x.CLIENTE.NOMBRES + " " + x.CLIENTE.APELLIDOS,
                        EMPLEADO = x.EMPLEADO.NOMBRES + " " + x.EMPLEADO.APELLIDOS,
                        INSPECCION = x.INSPECCION.CODIGO
                    }).ToList();
                gridRenta.DataSource = items;
            }
        }

        private void PopulateCombos()
        {
            using (DBEntities db = new DBEntities())
            {
                //vehiculos
                var vehiculos = db.VEHICULO
                    .Where(x => x.ESTADO == true)
                    .Select(
                    x => new
                    {
                        x.ID,
                        VEHICULO = x.MODELO_VEHICULO.MARCA_VEHICULO.NOMBRE + " " + x.MODELO_VEHICULO.NOMBRE
                    })
                    .ToList();
                comboVehiculo.DataSource = vehiculos;
                comboVehiculo.DisplayMember = "VEHICULO";
                comboVehiculo.ValueMember = "ID";

                //Empleados
                var empleados = db.EMPLEADO
                    .Where(x => x.ESTADO == true)
                    .Select(
                    x => new
                    {
                        x.ID,
                        EMPLEADO = x.NOMBRES+" "+x.APELLIDOS
                    })
                    .ToList();
                comboEmpleado.DataSource = empleados;
                comboEmpleado.DisplayMember = "EMPLEADO";
                comboEmpleado.ValueMember = "ID";

                //Clientes
                var clientes = db.CLIENTE
                    .Where(x => x.ESTADO == true)
                    .Select(
                    x => new
                    {
                        x.ID,
                        CLIENTE = x.NOMBRES+" "+x.APELLIDOS
                    })
                    .ToList();
                comboCliente.DataSource = clientes;
                comboCliente.DisplayMember = "CLIENTE";
                comboCliente.ValueMember = "ID";
            }
        }

        public void GetIdInspeccion(int ID_INSPECCION)
        {
            model.ID_INSPECCION = ID_INSPECCION;
        }

        private void FrmRenta_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            ClearForm();
            PopulateDataGridView();
            PopulateCombos();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void TxMontoDia_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Verifica que la tecla presionada es solo numerica
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                model.ID_VEHICULO = Convert.ToInt32(comboVehiculo.SelectedValue);
                model.ID_EMPLEADO = Convert.ToInt32(comboEmpleado.SelectedValue);
                model.ID_CLIENTE = Convert.ToInt32(comboCliente.SelectedValue);
                model.FECHA_RENTA = Convert.ToDateTime(TxFechaRenta.Text);
                model.FECHA_DEVOLUCION = Convert.ToDateTime(DPFechaDevolucion.Value);
                model.CANTIDAD_DIAS = Convert.ToInt32(TxCantidadDias.Text);
                model.MONTO_DIA = Convert.ToInt32(TxMontoDia.Text.Trim());
                model.DESCRIPCION = TxDescripcion.Text.Trim();

                using (DBEntities db = new DBEntities())
                {
                    db.RENTA.Add(model);
                    db.SaveChanges();
                    MessageBox.Show("Renta creada exitosamente");
                    ClearForm();
                    PopulateCombos();
                    PopulateDataGridView();
                }
            }
        }

        private void btnInspeccion_Click(object sender, EventArgs e)
        {
            if (comboVehiculo.SelectedIndex != -1 && comboCliente.SelectedIndex != -1 && comboEmpleado.SelectedIndex != -1)
            {
                VEHICULO = Convert.ToInt32(comboVehiculo.SelectedValue);
                CLIENTE = Convert.ToInt32(comboCliente.SelectedValue);
                EMPLEADO = Convert.ToInt32(comboEmpleado.SelectedValue);

                FrmInspeccion form = new FrmInspeccion(this);
                form.ShowDialog();
            }
        }

        private bool ValidateData()
        {
            if (comboVehiculo.SelectedIndex == -1)
            {
                comboVehiculo.Focus();
                MessageBox.Show("Debe seleccionar un vehiculo");
                return false;
            }

            if (comboEmpleado.SelectedIndex == -1)
            {
                comboEmpleado.Focus();
                MessageBox.Show("Debe seleccionar un empleado");
                return false;
            }

            if (comboCliente.SelectedIndex == -1)
            {
                comboCliente.Focus();
                MessageBox.Show("Debe seleccionar un cliente");
                return false;
            }

            if (model.ID_INSPECCION == 0)
            {
                MessageBox.Show("Debe crear una inspeccion");
                return false;
            }
            
            if (String.IsNullOrWhiteSpace(TxMontoDia.Text))
            {
                TxMontoDia.Focus();
                MessageBox.Show("Debe ingresar el monto de la renta por dia");
                return false;
            }

            return true;
        }

        private void DPFechaDevolucion_ValueChanged(object sender, EventArgs e)
        {
            DateTime StartDate = DateTime.Now;
            DateTime EndDate = DPFechaDevolucion.Value;

            TxCantidadDias.Text = Math.Round((EndDate - StartDate).TotalDays).ToString();

            SetTotalAPagar();
        }

        private void SetTotalAPagar()
        {
            if (TxCantidadDias.Text.Length > 0 && TxMontoDia.Text.Length > 0)
            {
                decimal total = Convert.ToInt32(TxCantidadDias.Text) * Convert.ToDecimal(TxMontoDia.Text);
                TxTotal.Text = total.ToString();
            }
            else
            {
                TxTotal.Text = "";
            }
        }

        private void TxMontoDia_TextChanged(object sender, EventArgs e)
        {
            SetTotalAPagar();
        }

        private void gridRenta_DoubleClick(object sender, EventArgs e)
        {
            if (gridRenta.CurrentRow.Index != -1)
            {
                model.ID = Convert.ToInt32(gridRenta.CurrentRow.Cells["ID"].Value);

                using (DBEntities db = new DBEntities())
                {
                    model = db.RENTA.Where(x => x.ID == model.ID).FirstOrDefault();

                    comboVehiculo.SelectedValue = Convert.ToInt32(model.ID_VEHICULO);
                    comboEmpleado.SelectedValue = Convert.ToInt32(model.ID_EMPLEADO);
                    comboCliente.SelectedValue = Convert.ToInt32(model.ID_CLIENTE);
                    btnInspeccion.Enabled = false;
                    btnInspeccion.Text = model.INSPECCION.CODIGO;
                    TxFechaRenta.Text = model.FECHA_RENTA.ToString();
                    DPFechaDevolucion.Value = Convert.ToDateTime(model.FECHA_DEVOLUCION);
                    DPFechaDevolucion.Enabled = false;
                    TxCantidadDias.Text = model.CANTIDAD_DIAS.ToString();
                    TxMontoDia.Text = model.MONTO_DIA.ToString();
                    TxMontoDia.Enabled = false;
                    decimal TotalAPagaar = Convert.ToInt32(model.CANTIDAD_DIAS) * Convert.ToDecimal(model.MONTO_DIA);
                    TxTotal.Text = TotalAPagaar.ToString();
                    TxTotal.Enabled = false;
                    TxDescripcion.Text = model.DESCRIPCION;
                    TxDescripcion.Enabled = false;
                    btnSave.Enabled = false;
                    comboCliente.Enabled = false;
                    comboEmpleado.Enabled = false;
                    comboVehiculo.Enabled = false;
                }
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            comboVehiculo.Enabled = true;
            comboCliente.Enabled = true;
            comboEmpleado.Enabled = true;
            btnInspeccion.Enabled = true;
            TxFechaRenta.Enabled = true;
            TxFechaRenta.ReadOnly = true;
            TxFechaRenta.Text = DateTime.Now.ToString();
            DPFechaDevolucion.Enabled = true;
            DPFechaDevolucion.MinDate = DateTime.Now;
            TxMontoDia.Enabled = true;
            TxMontoDia.ReadOnly = false;
            TxMontoDia.Text = "";
            TxDescripcion.Enabled = true;
            TxDescripcion.ReadOnly = false;
            TxDescripcion.Text = "";
            btnNew.Enabled = false;
            btnSave.Enabled = true;
            model.ID = 0;
        }

        private void TxFiltrar_TextChanged(object sender, EventArgs e)
        {
            if (TxFiltrar.Text.Length > 0)
            {
                using (DBEntities db = new DBEntities())
                {
                    var items = db.RENTA
                        .Where(x =>
                            x.VEHICULO.MODELO_VEHICULO.MARCA_VEHICULO.NOMBRE.Contains(TxFiltrar.Text.Trim().ToUpper()) ||
                            x.VEHICULO.MODELO_VEHICULO.NOMBRE.Contains(TxFiltrar.Text.Trim().ToUpper()) ||
                            x.CLIENTE.NOMBRES.Contains(TxFiltrar.Text.Trim()) ||
                            x.CLIENTE.APELLIDOS.Contains(TxFiltrar.Text.Trim()) ||
                            x.CLIENTE.CEDULA.Contains(TxFiltrar.Text.Trim()) ||
                            x.INSPECCION.CODIGO.Contains(TxFiltrar.Text.Trim().ToUpper())
                        )
                        .Select(
                        x => new
                        {
                            x.ID,
                            VEHICULO = x.VEHICULO.MODELO_VEHICULO.MARCA_VEHICULO.NOMBRE + " " + x.VEHICULO.MODELO_VEHICULO.NOMBRE,
                            CLIENTE = x.CLIENTE.NOMBRES + " " + x.CLIENTE.APELLIDOS,
                            EMPLEADO = x.EMPLEADO.NOMBRES + " " + x.EMPLEADO.APELLIDOS,
                            INSPECCION = x.INSPECCION.CODIGO
                        })
                        .ToList();
                    gridRenta.DataSource = items;
                }
            }
            else
            {
                PopulateDataGridView();
            }
        }
    }
}
