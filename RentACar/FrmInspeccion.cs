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
        public FrmInspeccion()
        {
            InitializeComponent();
        }

        private void PopulateCombos()
        {
            using (DBEntities db = new DBEntities())
            {
                //Combustible
                var items = db.COMBUSTIBLE_VEHICULO
                    .Select(
                    x => new
                    {
                        x.ID,
                        x.NOMBRE
                    })
                    .ToList();
                comboCantidadCombustible.DataSource = items;
                comboCantidadCombustible.DisplayMember = "NOMBRE";
                comboCantidadCombustible.ValueMember = "ID";
            }
        }

        private void FrmInspeccion_Load(object sender, EventArgs e)
        {
            PopulateCombos();
        }
    }
}
