using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace RentACar
{
    public partial class FrmRenta : Form
    {
        private EMPLEADO empleado = null;
        private RENTA renta = new RENTA();
        private INSPECCION inspeccion = new INSPECCION();

        public FrmRenta(EMPLEADO Empleado = null)
        {
            InitializeComponent();
            empleado = Empleado;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearForm()
        {
            #region Renta
            comboCliente.Enabled = false;
            comboVehiculo.Enabled = false;
            TxTotalAPagar.Text = "0";
            DPFechaRenta.Enabled = false;
            DPFechaRenta.MinDate = DateTime.Now;
            DPFechaDevolucion.Enabled = false;
            DPFechaDevolucion.MinDate = DateTime.Now;
            TxDescripcion.Text = "";
            TxDescripcion.Enabled = false;
            TxCantidadDias.Text = "";
            TxCantidadDias.Enabled = false;
            checkEstado.Enabled = false;
            BtnSave.Enabled = false;
            BtnCancel.Enabled = false;
            BtnNew.Enabled = true;
            renta.ID = 0;
            #endregion

            #region Inspeccion
            checkGomaDelanteraDerecha.Enabled = false;
            checkGomaDelanteraIzquierda.Enabled = false;
            checkGomaTraseraDerecha.Enabled = false;
            checkGomaTraseraIzquierda.Enabled = false;
            checkGomaRepuesto.Enabled = false;
            checkTieneRayadura.Enabled = false;
            checkTieneGato.Enabled = false;
            checkTieneRoturaCristal.Enabled = false;
            comboCantidadCombustible.Enabled = false;
            #endregion
        }

        private void PopulateCombos()
        {
            using (DBEntities db = new DBEntities())
            {
                #region Clientes
                var clientes = db.CLIENTE
                    .Where(x => x.ESTADO == true)
                    .Select(
                    x => new
                    {
                        x.ID,
                        NOMBRE = x.NOMBRES + " " + x.APELLIDOS
                    })
                    .ToList();
                comboCliente.DataSource = clientes;
                comboCliente.DisplayMember = "NOMBRE";
                comboCliente.ValueMember = "ID";
                #endregion

                #region Vehiculos
                var vehiculos = db.VEHICULO
                    .Where(x => x.ESTADO == true)
                    .Select(
                    x => new
                    {
                        x.ID,
                        NOMBRE = x.MODELO_VEHICULO.MARCA_VEHICULO.NOMBRE + " " + x.MODELO_VEHICULO.NOMBRE
                    })
                    .ToList();
                comboVehiculo.DataSource = vehiculos;
                comboVehiculo.DisplayMember = "NOMBRE";
                comboVehiculo.ValueMember = "ID";
                #endregion

                #region Cantidad Combustible
                var combustibles = db.CANTIDAD_COMBUSTIBLE
                    .Select(
                    x => new
                    {
                        x.ID,
                        x.DESCRIPCION
                    })
                    .ToList();
                comboVehiculo.DataSource = vehiculos;
                comboVehiculo.DisplayMember = "DESCRIPCION";
                comboVehiculo.ValueMember = "ID";
                #endregion
            }
        }

        private void TxMontoDia_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Verifica que la tecla presionada es solo numerica
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void FrmRenta_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            ClearForm();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            PopulateCombos();

            #region Renta
            comboCliente.Enabled = true;
            comboVehiculo.Enabled = true;
            TxTotalAPagar.Enabled = false;
            TxTotalAPagar.Text = "0";
            DPFechaRenta.Enabled = true;
            DPFechaDevolucion.Enabled = true;
            TxDescripcion.Text = "";
            TxDescripcion.Enabled = true;
            TxCantidadDias.Text = "";
            TxMontoDia.Text = "";
            TxMontoDia.Enabled = true;
            checkEstado.Checked = false;
            checkEstado.Enabled = true;
            BtnSave.Enabled = true;
            BtnCancel.Enabled = true;
            BtnNew.Enabled = false;
            renta.ID = 0;
            #endregion

            #region Inspeccion
            checkGomaDelanteraDerecha.Checked = false;
            checkGomaDelanteraDerecha.Enabled = true;
            checkGomaDelanteraIzquierda.Checked = false;
            checkGomaDelanteraIzquierda.Enabled = true;

            #endregion
        }

        private void DPFechaRenta_ValueChanged(object sender, EventArgs e)
        {
            DPFechaDevolucion.MinDate = DPFechaRenta.Value;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
    }
}