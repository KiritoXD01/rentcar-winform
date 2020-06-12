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
            }
        }

        private void ClearForm()
        {
            DPFechaRenta.Value = DateTime.Now;
            DPFechaDevolucion.Value = DateTime.Now;
            TxCantidadDias.Text = "0";
            TxMontoxDia.Text = "0";
            TxTotalPago.Text = "0";
            TxDescripcion.Text = "";
            renta.ID = 0;

        }

        private void FrmRenta_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            PopulateCombos();
            DPFechaRenta.MinDate = DateTime.Now;
            DPFechaDevolucion.MinDate = DateTime.Now;
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
    }
}