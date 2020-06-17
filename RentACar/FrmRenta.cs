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
            DPFechaDevolucion.Enabled = false;
            TxDescripcion.Text = "";
            TxDescripcion.Enabled = false;
            TxCantidadDias.Text = "";
            TxCantidadDias.Enabled = false;
            TxMontoDia.Text = "";
            TxMontoDia.Enabled = false;
            checkEstado.Enabled = false;
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

            BtnSave.Enabled = false;
            BtnCancel.Enabled = false;
            BtnNew.Enabled = true;
            renta.ID = 0;
            inspeccion.ID = 0;
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
                comboCantidadCombustible.DataSource = combustibles;
                comboCantidadCombustible.DisplayMember = "DESCRIPCION";
                comboCantidadCombustible.ValueMember = "ID";
                #endregion
            }
        }

        private void PopulateDataGridView()
        {
            using (DBEntities db = new DBEntities())
            {
                gridRenta.AutoGenerateColumns = false;
                var items = db.RENTA.Select(
                    x => new
                    {
                        x.ID,
                        VEHICULO = x.VEHICULO.MODELO_VEHICULO.MARCA_VEHICULO.NOMBRE + " " + x.VEHICULO.MODELO_VEHICULO.NOMBRE,
                        CLIENTE = x.CLIENTE.NOMBRES + " " + x.CLIENTE.APELLIDOS,
                        x.CODIGO,
                        ESTADO = x.ESTADO == true ? "Entregado" : "Sin Entregar"
                    })
                    .ToList();
                gridRenta.DataSource = items;
            }
        }

        private void TxMontoDia_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Verifica que la tecla presionada es solo numerica
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void FrmRenta_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            ClearForm();
            PopulateDataGridView();
            PopulateCombos();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            #region Renta
            comboCliente.Enabled = true;
            comboVehiculo.Enabled = true;
            TxTotalAPagar.Enabled = false;
            TxTotalAPagar.Text = "0";
            DPFechaRenta.MinDate = DateTime.Now;
            DPFechaRenta.Value = DateTime.Now;
            DPFechaRenta.Enabled = true;
            DPFechaDevolucion.Value = DateTime.Now;
            DPFechaDevolucion.Enabled = true;
            TxDescripcion.Text = "";
            TxDescripcion.Enabled = true;
            TxCantidadDias.Text = "";
            TxMontoDia.Text = "";
            TxMontoDia.Enabled = true;
            checkEstado.Checked = false;
            checkEstado.Enabled = false;
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
            checkGomaTraseraDerecha.Checked = false;
            checkGomaTraseraDerecha.Enabled = true;
            checkGomaTraseraIzquierda.Checked = false;
            checkGomaTraseraIzquierda.Enabled = true;
            checkGomaRepuesto.Checked = false;
            checkGomaRepuesto.Enabled = true;
            checkTieneRayadura.Checked = false;
            checkTieneRayadura.Enabled = true;
            checkTieneGato.Checked = false;
            checkTieneGato.Enabled = true;
            checkTieneRoturaCristal.Checked = false;
            checkTieneRoturaCristal.Enabled = true;
            comboCantidadCombustible.Enabled = true;
            #endregion
        }

        private void DPFechaRenta_ValueChanged(object sender, EventArgs e)
        {
            DPFechaDevolucion.MinDate = DPFechaRenta.Value;
            SetCantidadDias();
            SetTotalAPagar();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private bool ValidateData()
        {
            if (comboCliente.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un cliente.");
                comboCliente.Focus();
                return false;
            }

            if (comboVehiculo.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un vehiculo.");
                comboVehiculo.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(TxMontoDia.Text))
            {
                MessageBox.Show("Debe ingresar el monto or dia de la renta.");
                TxMontoDia.Focus();
                return false;
            }

            if (comboCantidadCombustible.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar la cantidad de combustible disponible.");
                comboCantidadCombustible.Focus();
                return false;
            }

            if (renta.ID == 0)
            {
                using (DBEntities db = new DBEntities())
                {
                    int ID_VEHICULO = Convert.ToInt32(comboVehiculo.SelectedValue);
                    DateTime StartDate = DPFechaRenta.Value;
                    DateTime EndDate = DPFechaDevolucion.Value;

                    int VehicleIsRented = db.RENTA
                        .Where(x =>
                            x.ID_VEHICULO == ID_VEHICULO &&
                            (
                                (StartDate >= x.FECHA_RENTA && StartDate <= x.FECHA_DEVOLUCION)
                                ||
                                (EndDate >= x.FECHA_RENTA && EndDate <= x.FECHA_DEVOLUCION)
                            )
                        )
                        .Count();

                    if (VehicleIsRented > 0)
                    {
                        MessageBox.Show("El vehiculo seleccionado ya esta reservado para el rango de fecha ingresado.");
                        DPFechaRenta.Focus();
                        return false;
                    }
                }
            }

            return true;
        }

        private void SetCantidadDias()
        {
            DateTime StartDate = DPFechaRenta.Value;
            DateTime EndDate = DPFechaDevolucion.Value;

            int dias = (EndDate - StartDate).Days + 1;
            TxCantidadDias.Text = dias.ToString();
        }

        private void SetTotalAPagar()
        {
            decimal total = 0;

            if (TxMontoDia.Text.Length > 0)
            {
                int CantidadDias = Convert.ToInt32(TxCantidadDias.Text);
                decimal MontoXDia = Convert.ToInt32(TxMontoDia.Text);

                total = CantidadDias * MontoXDia;
            }

            TxTotalAPagar.Text = total.ToString();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                using (DBEntities db = new DBEntities())
                {
                    if (renta.ID > 0)
                    {
                        renta.ID_CLIENTE = Convert.ToInt32(comboCliente.SelectedValue);
                        renta.ID_VEHICULO = Convert.ToInt32(comboVehiculo.SelectedValue);
                        renta.FECHA_RENTA = DPFechaRenta.Value;
                        renta.FECHA_DEVOLUCION = DPFechaDevolucion.Value;
                        renta.CANTIDAD_DIAS = Convert.ToInt32(TxCantidadDias.Text);
                        renta.MONTO_DIA = Convert.ToDecimal(TxMontoDia.Text.Trim());
                        renta.DESCRIPCION = TxDescripcion.Text.Trim();
                        renta.ESTADO = checkEstado.Checked;

                        db.Entry(renta).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                        MessageBox.Show("Renta Actualizada Existosamente");
                        ClearForm();
                        PopulateDataGridView();
                    }
                    else
                    {
                        #region Inspeccion
                        inspeccion.ID_VEHICULO = Convert.ToInt32(comboVehiculo.SelectedValue);
                        inspeccion.CODIGO = GenerateCode();
                        inspeccion.TIENE_RAYADURAS = checkTieneRayadura.Checked;
                        inspeccion.ID_CANTIDAD_COMBUSTIBLE = Convert.ToInt32(comboCantidadCombustible.SelectedValue);
                        inspeccion.TIENE_GATO = checkTieneGato.Checked;
                        inspeccion.TIENE_ROTURA_CRISTAL = checkTieneRoturaCristal.Checked;
                        inspeccion.FECHA_CREACION = DateTime.Now;
                        inspeccion.GOMA_DELANTERA_DERECHA = checkGomaDelanteraDerecha.Checked;
                        inspeccion.GOMA_DELANTERA_IZQUIERDA = checkGomaDelanteraIzquierda.Checked;
                        inspeccion.GOMA_TRASERA_DERECHA = checkGomaTraseraDerecha.Checked;
                        inspeccion.GOMA_TRASERA_IZQUIERDA = checkGomaTraseraIzquierda.Checked;
                        inspeccion.GOMA_REPUESTO = checkGomaRepuesto.Checked;

                        db.INSPECCION.Add(inspeccion);
                        #endregion

                        #region Renta
                        renta.ID_INSPECCION = inspeccion.ID;
                        renta.ID_EMPLEADO = empleado.ID;
                        renta.ID_CLIENTE = Convert.ToInt32(comboCliente.SelectedValue);
                        renta.ID_VEHICULO = Convert.ToInt32(comboVehiculo.SelectedValue);
                        renta.FECHA_RENTA = DPFechaRenta.Value;
                        renta.FECHA_DEVOLUCION = DPFechaDevolucion.Value;
                        renta.FECHA_CREACION = DateTime.Now;
                        renta.CANTIDAD_DIAS = Convert.ToInt32(TxCantidadDias.Text);
                        renta.MONTO_DIA = Convert.ToDecimal(TxMontoDia.Text.Trim());
                        renta.DESCRIPCION = TxDescripcion.Text.Trim();
                        renta.CODIGO = GenerateCode();
                        renta.ESTADO = false;
                        db.RENTA.Add(renta);
                        #endregion

                        db.SaveChanges();
                        MessageBox.Show("Renta Creada Existosamente");
                        ClearForm();
                        PopulateDataGridView();
                    }
                }
            }
        }

        private void DPFechaDevolucion_ValueChanged(object sender, EventArgs e)
        {
            SetCantidadDias();
            SetTotalAPagar();
        }

        private void TxMontoDia_TextChanged(object sender, EventArgs e)
        {
            SetTotalAPagar();
        }

        private string GenerateCode(int length = 6)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            Random random = new Random();
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void gridRenta_DoubleClick(object sender, EventArgs e)
        {
            if (gridRenta.CurrentRow.Index != -1)
            {
                renta.ID = Convert.ToInt32(gridRenta.CurrentRow.Cells["ID"].Value);
                using (DBEntities db = new DBEntities())
                {
                    #region Renta
                    renta = db.RENTA.Where(x => x.ID == renta.ID).FirstOrDefault();
                    comboCliente.Enabled = true;
                    comboCliente.SelectedValue = Convert.ToInt32(renta.ID_CLIENTE);
                    comboVehiculo.Enabled = true;
                    comboVehiculo.SelectedValue = Convert.ToInt32(renta.ID_VEHICULO);
                    DPFechaRenta.Enabled = true;
                    DPFechaRenta.Value = Convert.ToDateTime(renta.FECHA_RENTA);
                    DPFechaDevolucion.Enabled = true;
                    DPFechaDevolucion.Value = Convert.ToDateTime(renta.FECHA_DEVOLUCION);
                    TxDescripcion.Enabled = true;
                    TxDescripcion.Text = renta.DESCRIPCION;
                    TxCantidadDias.Text = renta.CANTIDAD_DIAS.ToString();
                    TxMontoDia.Enabled = true;
                    TxMontoDia.Text = renta.MONTO_DIA.ToString();
                    TxCodigo.Text = renta.CODIGO;
                    checkEstado.Enabled = true;
                    checkEstado.Checked = Convert.ToBoolean(renta.ESTADO);
                    #endregion

                    #region Inspeccion
                    inspeccion = db.INSPECCION.Where(x => x.ID == renta.ID_INSPECCION).FirstOrDefault();
                    checkGomaDelanteraDerecha.Checked = Convert.ToBoolean(inspeccion.GOMA_DELANTERA_DERECHA);
                    checkGomaDelanteraIzquierda.Checked = Convert.ToBoolean(inspeccion.GOMA_DELANTERA_IZQUIERDA);
                    checkGomaTraseraDerecha.Checked = Convert.ToBoolean(inspeccion.GOMA_TRASERA_DERECHA);
                    checkGomaTraseraIzquierda.Checked = Convert.ToBoolean(inspeccion.GOMA_TRASERA_IZQUIERDA);
                    checkGomaRepuesto.Checked = Convert.ToBoolean(inspeccion.GOMA_REPUESTO);
                    checkTieneRayadura.Checked = Convert.ToBoolean(inspeccion.TIENE_RAYADURAS);
                    checkTieneGato.Checked = Convert.ToBoolean(inspeccion.TIENE_GATO);
                    checkTieneRoturaCristal.Checked = Convert.ToBoolean(inspeccion.TIENE_ROTURA_CRISTAL);
                    comboCantidadCombustible.SelectedValue = Convert.ToInt32(inspeccion.ID_CANTIDAD_COMBUSTIBLE);
                    #endregion

                    BtnNew.Enabled = false;
                    BtnCancel.Enabled = true;
                    BtnSave.Enabled = true;
                }
            }
        }

        private void TxFiltrar_TextChanged(object sender, EventArgs e)
        {
            if (TxFiltrar.Text.Length > 0)
            {
                using (DBEntities db = new DBEntities())
                {
                    var items = db.RENTA
                        .Where(x => 
                            x.CLIENTE.NOMBRES.Contains(TxFiltrar.Text.Trim())
                        )
                        .Select(
                        x => new
                        {
                            x.ID,
                            VEHICULO = x.VEHICULO.MODELO_VEHICULO.MARCA_VEHICULO.NOMBRE + " " + x.VEHICULO.MODELO_VEHICULO.NOMBRE,
                            CLIENTE = x.CLIENTE.NOMBRES + " " + x.CLIENTE.APELLIDOS,
                            x.CODIGO,
                            ESTADO = x.ESTADO == true ? "Entregado" : "Sin Entregar"
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