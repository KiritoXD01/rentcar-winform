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
        }

        private void PopulateDataGridView()
        {
            gridCliente.AutoGenerateColumns = false;
            using (DBEntities db = new DBEntities())
            {
                gridCliente.DataSource = db.CLIENTEs.ToList<CLIENTE>();
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
            model.CEDULA = Convert.ToInt32(TxCedula.Value);
            model.EMAIL = TxEmail.Text.Trim();
            model.TELEFONO = TxEmail.Text.Trim();
            model.TARJETA_CREDITO = Convert.ToInt32(TxTarjetaCredito.Value);
            model.ESTADO = checkEstado.Checked;
            model.FECHA_CREACION = DateTime.Now;
        }
    }
}
