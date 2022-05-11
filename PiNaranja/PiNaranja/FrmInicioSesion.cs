using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PiNaranja
{
    public partial class FrmInicioSesion : Form
    {
        public FrmInicioSesion()
        {
            InitializeComponent();
        }

        private void btnInicioSesion_Click(object sender, EventArgs e)
        {
            FrmPanelControl frm = new FrmPanelControl();
            frm.Show();
        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            FrmCreaCuenta frm = new FrmCreaCuenta();
            frm.Show();
        }
    }
}
