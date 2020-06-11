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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            SetPanel();
        }

        private void SetPanel()
        {
            panelLogin.Location = new Point(
                this.ClientSize.Width / 2 - panelLogin.Size.Width / 2,
                this.ClientSize.Height /2 - panelLogin.Size.Height / 2
                );
            panelLogin.Anchor = AnchorStyles.None;
        }

        private bool ValidateData()
        {
            if (string.IsNullOrWhiteSpace(TxEmail.Text))
            {
                MessageBox.Show("Debe ingresar el email");
                TxEmail.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(TxClave.Text))
            {
                MessageBox.Show("Debe ingresar la clave");
                TxClave.Focus();
                return false;
            }

            return true;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                BtnLogin.Enabled = false;
                BtnLogin.Text = "Por favor, espere";
                using (DBEntities db = new DBEntities())
                {
                    var empleado = db.EMPLEADO.FirstOrDefault(x => x.EMAIL.Equals(TxEmail.Text.Trim().ToLower()));

                    if (empleado != null)
                    {
                        if (empleado.CLAVE.Equals(TxClave.Text.Trim()))
                        {
                            FrmHome frm = new FrmHome();
                            frm.ID_EMPLEADO = empleado.ID;
                            this.Hide();
                            frm.Show();
                        }
                        else
                        {
                            MessageBox.Show("La clave no es correcta");
                            BtnLogin.Text = "Login";
                            BtnLogin.Enabled = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usuario no encontrado");
                        BtnLogin.Text = "Login";
                        BtnLogin.Enabled = true;
                    }
                }
            }
        }
    }
}
