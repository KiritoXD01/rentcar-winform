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
    public partial class FrmInspeccion : Form
    {
        INSPECCION inspeccion = new INSPECCION();
        INSPECCION_GOMAS inspeccion_gomas = new INSPECCION_GOMAS();

        public FrmInspeccion()
        {
            InitializeComponent();
        }

        private void ClearForm()
        {
            checkTieneRayaduras.Checked = false;
            checkTieneGomas.Checked = false;
            checkTieneGato.Checked = false;
            checkTieneCristalesRotos.Checked = false;
            checkLlantaTraseraDerecha.Checked = false;
            checkLlantaTraseraIzquierda.Checked = false;
            checkLlantaDelanteraIzquierda.Checked = false;
            checkLlantaDelanteraDerecha.Checked = false;
            TxDescripcion.Text = "";
            inspeccion.ID = 0;
            inspeccion_gomas.ID = 0;
        }

        private void PopulateCombos()
        {
            using (DBEntities db = new DBEntities())
            {
                //Combustible
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

                //Estado inspeccion
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

                //vehiculo
                var vehiculo = db.VEHICULO
                    .Where(x => x.ID == FrmRenta.VEHICULO)
                    .FirstOrDefault();
                TxVehiculo.Text = vehiculo.MODELO_VEHICULO.MARCA_VEHICULO.NOMBRE + " " + vehiculo.MODELO_VEHICULO.NOMBRE;

                //Cliente
                var cliente = db.CLIENTE
                    .Where(x => x.ID == FrmRenta.CLIENTE)
                    .FirstOrDefault();
                TxCliente.Text = cliente.NOMBRES + " " + cliente.APELLIDOS;

                //Empleado
                var empleado = db.EMPLEADO
                    .Where(x => x.ID == FrmRenta.EMPLEADO)
                    .FirstOrDefault();
                TxEmpleado.Text = empleado.NOMBRES + " " + empleado.APELLIDOS;
            }
        }

        private bool ValidateData()
        {
            if (comboCantidadCombustible.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar la cantidad de combustible");
                comboCantidadCombustible.Focus();
                return false;
            }

            if (comboEstadoInspeccion.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar la cantidad de combustible");
                comboEstadoInspeccion.Focus();
                return false;
            }

            return true;
        }

        private void FrmInspeccion_Load(object sender, EventArgs e)
        {
            PopulateCombos();
            ClearForm();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string GenerateCode(int length = 20)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            Random random = new Random();
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                inspeccion.CODIGO = GenerateCode(6);
                inspeccion.ID_VEHICULO = FrmRenta.VEHICULO;
                inspeccion.ID_CLIENTE = FrmRenta.CLIENTE;
                inspeccion.ID_EMPLEADO = FrmRenta.EMPLEADO;
                inspeccion.TIENE_RAYADURAS = checkTieneRayaduras.Checked;
                inspeccion.ID_CANTIDAD_COMBUSTIBLE = Convert.ToInt32(comboCantidadCombustible.SelectedValue);
                inspeccion.TIENE_GOMA = checkTieneGomas.Checked;
                inspeccion.TIENE_GATO = checkTieneGato.Checked;
                inspeccion.TIENE_ROTURA_CRISTAL = checkTieneCristalesRotos.Checked;
                inspeccion.FECHA_CREACION = DateTime.Now;
                inspeccion.ID_ESTADO_INSPECCION = Convert.ToInt32(comboEstadoInspeccion.SelectedValue);
                
                using (DBEntities db = new DBEntities())
                {
                    db.INSPECCION.Add(inspeccion);
                    db.SaveChanges();

                    int ID_INSPECCION = inspeccion.ID;

                    inspeccion_gomas.ID_INSPECCION = ID_INSPECCION;
                    inspeccion_gomas.GOMA_TRASERA_DERECHA = checkLlantaTraseraDerecha.Checked;
                    inspeccion_gomas.GOMA_TRASERA_IZQUIERDA = checkLlantaTraseraIzquierda.Checked;
                    inspeccion_gomas.GOMA_DELANTERA_DERECHA = checkLlantaDelanteraDerecha.Checked;
                    inspeccion_gomas.GOME_DELANTERA_IZQUIERDA = checkLlantaDelanteraIzquierda.Checked;
                    inspeccion_gomas.DESCRIPCION = TxDescripcion.Text.Trim();

                    db.INSPECCION_GOMAS.Add(inspeccion_gomas);
                    db.SaveChanges();

                    
                }
            }
        }
    }
}
