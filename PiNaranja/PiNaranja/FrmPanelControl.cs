using System;
using PInaranja.Clases;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading;
using PiNaranja.Recursos;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PiNaranja
{
    public partial class FrmPanelControl : Form
    {
        public FrmPanelControl()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblReloj.Text = DateTime.Now.ToString("T");
            lblFecha.Text = DateTime.Now.ToShortDateString();
            cmbIdioma.Text = "Castellano";
            AplicarIdioma();
        }
        
        private void btnAgregarHogar_Click(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblReloj.Text = DateTime.Now.ToString("T");
        }
        private void AplicarIdioma()
        {
            this.Text = Recursos.Idioma.FrmPanelControl;
            lblSelecHogar.Text = Recursos.Idioma.lblSelecHogar;
            grbAnyadirDispositivo.Text = Recursos.Idioma.grbAnyadirProducto;
            lblNombreDis.Text = Recursos.Idioma.lblNombreDis;
            lblSelecHogar.Text = Recursos.Idioma.lblSelecHogar;
            lblEstanciaDispo.Text = Recursos.Idioma.lblEstanciaDispo;
            lblConsumoBase.Text = Recursos.Idioma.lblConsumoBase;
            btnAgregarDispositivo.Text = Recursos.Idioma.btnAgregarDispositivo;
            btnEliminaDispositivo.Text = Recursos.Idioma.btnEliminaDispositivo;
            btnCalculo.Text = Recursos.Idioma.btnCalculo;
            btnLog.Text = Recursos.Idioma.btnLog;
            lblCalculo.Text = Recursos.Idioma.lblCalculo;
            lblEstanciasRegistradas.Text = Recursos.Idioma.lblEstanciasRegistradas;
            lblDispositivosRegistrados.Text = Recursos.Idioma.lblDispositivosRegistrados;
            lblClick.Text = Recursos.Idioma.lblClick;
            lblTotalConsumo.Text = Recursos.Idioma.lblTotalConsumo;
            lblIdioma.Text = Recursos.Idioma.lblIdioma;
        }

        private void cmbIdioma_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cultura = "";
            switch (cmbIdioma.Text)
            {
                case "Castellano":
                    {
                        cultura = "ES-ES";
                        break;
                    }
                case "English":
                    {
                        cultura = "EN-GB";
                        break;
                    }
            }
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(cultura);
            AplicarIdioma();
        }

        private void ptbSalida_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
