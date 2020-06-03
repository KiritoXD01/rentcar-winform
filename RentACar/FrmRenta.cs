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
            model.ID = 0;
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
                        VEHICULO = x.VEHICULO.MODELO_VEHICULO.MARCA_VEHICULO.NOMBRE,
                        CLIENTE = x.CLIENTE.NOMBRES,
                        EMPLEADO = x.EMPLEADO.NOMBRES
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
            //Verifica que la tecla presionada esa solo numerica
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnInspeccion_Click(object sender, EventArgs e)
        {
            FrmInspeccion form = new FrmInspeccion();
            form.ShowDialog();
        }
    }
}
