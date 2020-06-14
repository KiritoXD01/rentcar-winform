﻿using System;
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
        private EMPLEADO empleado = null;
        private RENTA renta = new RENTA();
        private INSPECCION inspeccion = new INSPECCION();
        private INSPECCION_GOMAS inspeccion_gomas = new INSPECCION_GOMAS();

        public FrmRenta(EMPLEADO Empleado = null)
        {
            InitializeComponent();
            empleado = Empleado;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PopulateCombos()
        {
            using (DBEntities db = new DBEntities())
            {
                //Clientes
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

                //vehiculos
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

                //Cantidad Combustible
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

                //Estado Inspeccion
                var estados = db.ESTADO_INSPECCION
                    .Select(
                    x => new
                    {
                        x.ID,
                        x.DESCRIPCION
                    })
                    .ToList();
                comboEstadoInspeccion.DataSource = estados;
                comboEstadoInspeccion.DisplayMember = "DESCRIPCION";
                comboEstadoInspeccion.ValueMember = "ID";
            }
        }

        private void ClearForm()
        {
            comboVehiculo.Enabled = true;
            comboCliente.Enabled = true;
            DPFechaRenta.Value = DateTime.Now;
            DPFechaRenta.Enabled = true;
            DPFechaDevolucion.Value = DateTime.Now;
            DPFechaDevolucion.Enabled = true;
            TxCantidadDias.Text = "0";
            TxCantidadDias.Enabled = true;
            TxMontoxDia.Text = "0";
            TxMontoxDia.Enabled = true;
            TxTotalPago.Text = "0";
            TxTotalPago.Enabled = true;
            TxDescripcionRenta.Text = "";
            TxDescripcionRenta.Enabled = true;
            renta.ID = 0;

            checkTieneRayaduras.Checked = false;
            comboCantidadCombustible.Enabled = true;
            checkTieneRayaduras.Enabled = true;
            checkTieneGoma.Checked = false;
            checkTieneGoma.Enabled = true;
            checkTieneGato.Checked = false;
            checkTieneGato.Enabled = true;
            checkTieneRoturaCristal.Checked = false;
            checkTieneRoturaCristal.Enabled = true;
            comboEstadoInspeccion.Enabled = true;
            inspeccion.ID = 0;

            checkGomaDerechaTrasera.Checked = false;
            checkGomaDerechaTrasera.Enabled = true;
            checkGomaTraseraIzquierda.Checked = false;
            checkGomaTraseraIzquierda.Enabled = true;
            checkGomaDelanteraDerecha.Checked = false;
            checkGomaDelanteraDerecha.Enabled = true;
            checkGomaDelanteraIzquierda.Checked = false;
            checkGomaDelanteraIzquierda.Enabled = true;
            TxDescripcionInspeccion.Text = "";
            TxDescripcionInspeccion.Enabled = true;
            inspeccion_gomas.ID = 0;

            btnSave.Enabled = true;
        }

        private void PopulateDataGridView()
        {
            gridRentas.AutoGenerateColumns = false;
            using (DBEntities db = new DBEntities())
            {
                var items = db.RENTA.Select(
                    x => new
                    {
                        x.ID,
                        Cliente = x.CLIENTE.NOMBRES + " " + x.CLIENTE.APELLIDOS,
                        Vehiculo = x.VEHICULO.MODELO_VEHICULO.MARCA_VEHICULO.NOMBRE + " " + x.VEHICULO.MODELO_VEHICULO.NOMBRE,
                        Fecha_Renta = x.FECHA_RENTA,
                        Fecha_Devolucion = x.FECHA_DEVOLUCION
                    })
                    .ToList();
                gridRentas.DataSource = items;
            }
        }

        private void FrmRenta_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            PopulateCombos();
            ClearForm();
            PopulateDataGridView();
        }

        private void DPFechaRenta_ValueChanged(object sender, EventArgs e)
        {
            DPFechaDevolucion.MinDate = DPFechaRenta.Value;
            SetCantidadDias();
            SetTotalAPagar();
        }

        private void SetCantidadDias()
        {
            DateTime StartDate = DPFechaRenta.Value;
            DateTime EndDate = DPFechaDevolucion.Value;

            TxCantidadDias.Text = Math.Round((EndDate - StartDate).TotalDays).ToString();            
        }

        private void DPFechaDevolucion_ValueChanged(object sender, EventArgs e)
        {
            SetCantidadDias();
            SetTotalAPagar();
        }

        private void SetTotalAPagar()
        {
            if (TxMontoxDia.Text.Length > 0)
            {
                int dias = Convert.ToInt32(TxCantidadDias.Text);
                decimal monto = Convert.ToDecimal(TxMontoxDia.Text);
                decimal total = monto * dias;
                TxTotalPago.Text = total.ToString();
            }
            else
            {
                TxTotalPago.Text = "0";
            }
        }

        private void TxMontoxDia_TextChanged(object sender, EventArgs e)
        {
            SetTotalAPagar();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
        
        private bool ValidateData()
        {
            if (comboVehiculo.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un vehiculo");
                comboVehiculo.Focus();
                return false;
            }

            if (comboCliente.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un cliente");
                comboCliente.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(TxMontoxDia.Text.Trim()))
            {
                MessageBox.Show("Debe colocar el monto de la renta");
                TxMontoxDia.Focus();
                return false;
            }

            if (comboCantidadCombustible.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar la cantidad de combustible");
                comboCantidadCombustible.Focus();
                return false;
            }

            if (comboEstadoInspeccion.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar la cantidad de combustible");
                comboCantidadCombustible.Focus();
                return false;
            }

            return true;
        }

        private string GenerateCode(int length = 6)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            Random random = new Random();
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                using (DBEntities db = new DBEntities())
                {
                    inspeccion.CODIGO = GenerateCode();
                    inspeccion.ID_VEHICULO = Convert.ToInt32(comboVehiculo.SelectedValue);
                    inspeccion.TIENE_RAYADURAS = checkTieneRayaduras.Checked;
                    inspeccion.ID_CANTIDAD_COMBUSTIBLE = Convert.ToInt32(comboCantidadCombustible.SelectedValue);
                    inspeccion.TIENE_GOMA = checkTieneGoma.Checked;
                    inspeccion.TIENE_GATO = checkTieneGato.Checked;
                    inspeccion.TIENE_ROTURA_CRISTAL = checkTieneRoturaCristal.Checked;
                    inspeccion.FECHA_CREACION = DateTime.Now;
                    inspeccion.ID_ESTADO_INSPECCION = Convert.ToInt32(comboEstadoInspeccion.SelectedValue);

                    db.INSPECCION.Add(inspeccion);

                    int ID_INSPECCION = inspeccion.ID;

                    inspeccion_gomas.ID_INSPECCION = ID_INSPECCION;
                    inspeccion_gomas.GOMA_TRASERA_DERECHA = checkGomaDerechaTrasera.Checked;
                    inspeccion_gomas.GOMA_TRASERA_IZQUIERDA = checkGomaTraseraIzquierda.Checked;
                    inspeccion_gomas.GOMA_DELANTERA_DERECHA = checkGomaDelanteraDerecha.Checked;
                    inspeccion_gomas.GOME_DELANTERA_IZQUIERDA = checkGomaDelanteraIzquierda.Checked;
                    inspeccion_gomas.DESCRIPCION = TxDescripcionInspeccion.Text.Trim();

                    db.INSPECCION_GOMAS.Add(inspeccion_gomas);

                    renta.ID_INSPECCION = ID_INSPECCION;
                    renta.ID_EMPLEADO = empleado.ID;
                    renta.ID_VEHICULO = Convert.ToInt32(comboVehiculo.SelectedValue);
                    renta.ID_CLIENTE = Convert.ToInt32(comboCliente.SelectedValue);
                    renta.FECHA_CREACION = DateTime.Now;
                    renta.FECHA_RENTA = DPFechaRenta.Value;
                    renta.FECHA_DEVOLUCION = DPFechaDevolucion.Value;
                    renta.CANTIDAD_DIAS = Convert.ToInt32(TxCantidadDias.Text.Trim());
                    renta.MONTO_DIA = Convert.ToDecimal(TxMontoxDia.Text.Trim());
                    renta.DESCRIPCION = TxDescripcionRenta.Text.Trim();

                    db.RENTA.Add(renta);
                    db.SaveChanges();
                    ClearForm();
                    PopulateDataGridView();

                    MessageBox.Show("Renta creada existosamente");
                }
            }
        }

        private void gridRentas_DoubleClick(object sender, EventArgs e)
        {
            if (gridRentas.CurrentRow.Index != -1)
            {
                renta.ID = Convert.ToInt32(gridRentas.CurrentRow.Cells["ID"].Value);

                using (DBEntities db = new DBEntities())
                {
                    renta = db.RENTA.Where(x => x.ID == renta.ID).FirstOrDefault();
                    inspeccion = db.INSPECCION.Where(x => x.ID == renta.ID_INSPECCION).FirstOrDefault();
                    inspeccion_gomas = db.INSPECCION_GOMAS.Where(x => x.ID_INSPECCION == renta.ID_INSPECCION).FirstOrDefault();

                    //renta
                    comboVehiculo.SelectedValue = Convert.ToInt32(renta.ID_VEHICULO);
                    comboVehiculo.Enabled = false;
                    comboCliente.SelectedValue = Convert.ToInt32(renta.ID_CLIENTE);
                    comboCliente.Enabled = false;
                    DPFechaRenta.Value = Convert.ToDateTime(renta.FECHA_RENTA);
                    DPFechaRenta.Enabled = false;
                    DPFechaDevolucion.Value = Convert.ToDateTime(renta.FECHA_DEVOLUCION);
                    DPFechaDevolucion.Enabled = false;
                    TxCantidadDias.Text = renta.CANTIDAD_DIAS.ToString();
                    TxCantidadDias.Enabled = false;
                    TxMontoxDia.Text = renta.MONTO_DIA.ToString();
                    TxMontoxDia.Enabled = false;
                    TxTotalPago.Enabled = false;
                    TxDescripcionRenta.Text = renta.DESCRIPCION;
                    TxDescripcionRenta.Enabled = false;

                    //inspeccion
                    checkTieneRayaduras.Checked = Convert.ToBoolean(inspeccion.TIENE_RAYADURAS);
                    checkTieneRayaduras.Enabled = false;
                    comboCantidadCombustible.SelectedValue = Convert.ToInt32(inspeccion.ID_CANTIDAD_COMBUSTIBLE);
                    comboCantidadCombustible.Enabled = false;
                    checkTieneGoma.Checked = Convert.ToBoolean(inspeccion.TIENE_GOMA);
                    checkTieneGoma.Enabled = false;
                    checkTieneGato.Checked = Convert.ToBoolean(inspeccion.TIENE_GATO);
                    checkTieneGato.Enabled = false;
                    checkTieneRoturaCristal.Checked = Convert.ToBoolean(inspeccion.TIENE_ROTURA_CRISTAL);
                    checkTieneRoturaCristal.Enabled = false;
                    comboEstadoInspeccion.SelectedValue = Convert.ToInt32(inspeccion.ID_ESTADO_INSPECCION);
                    comboEstadoInspeccion.Enabled = false;

                    //inspeccion Gomas
                    checkGomaDerechaTrasera.Checked = Convert.ToBoolean(inspeccion_gomas.GOMA_TRASERA_DERECHA);
                    checkGomaDerechaTrasera.Enabled = false;
                    checkGomaTraseraIzquierda.Checked = Convert.ToBoolean(inspeccion_gomas.GOMA_TRASERA_IZQUIERDA);
                    checkGomaTraseraIzquierda.Enabled = false;
                    checkGomaDelanteraDerecha.Checked = Convert.ToBoolean(inspeccion_gomas.GOMA_DELANTERA_DERECHA);
                    checkGomaDelanteraDerecha.Enabled = false;
                    checkGomaDelanteraIzquierda.Checked = Convert.ToBoolean(inspeccion_gomas.GOME_DELANTERA_IZQUIERDA);
                    checkGomaDelanteraIzquierda.Enabled = false;
                    TxDescripcionInspeccion.Text = inspeccion_gomas.DESCRIPCION;
                    TxDescripcionInspeccion.Enabled = false;

                    btnSave.Enabled = false;
                }
            }
        }
    }
}