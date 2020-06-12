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
    public partial class FrmHome : Form
    {
        private Form activeForm = null;
        public EMPLEADO EMPLEADO = null;

        public FrmHome()
        {
            InitializeComponent();
            CustomizeDesign();
        }

        private void FrmHome_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void CustomizeDesign()
        {
            panelVehiculo.Visible = false;
            panelEmpleado.Visible = false;
            panelRenta.Visible = false;
        }

        private void HideSubMenu()
        {
            if (panelVehiculo.Visible == true)
            {
                panelVehiculo.Visible = false;
            }

            if(panelEmpleado.Visible == true)
            {
                panelEmpleado.Visible = false;
            }

            if (panelRenta.Visible == true)
            {
                panelRenta.Visible = false;
            }
        }

        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void btnVehiculoPanel_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelVehiculo);
        }

        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            panelContainer.Controls.Add(childForm);
            panelContainer.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmTipoVehiculo());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmMarcaVehiculo());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmModeloVehiculo());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmCombustibleVehiculo());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmVehiculo());
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmCliente());
        }

        private void btnVehiculo_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmEmpleado());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelEmpleado);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmTanda());
        }

        private void button9_Click(object sender, EventArgs e)
        {
        
        }

        private void button10_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmRenta(EMPLEADO));
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelRenta);
        }

        private void FrmHome_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (MessageBox.Show("Desea cerrar el programa?", "Cerrar Programa", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }            
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
