using eKarton.Model.Request;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace eKarton.WinFr.Doktor
{
    public partial class frmPretragaDoktora : Form
    {
        ApiService _doktorService = new ApiService("Doktor");
        ApiService _odjelService = new ApiService("Odjel");

        public frmPretragaDoktora()
        {
            InitializeComponent();
            dgvDoktor.AutoGenerateColumns = false;
        }

        private async void btnDoktor_Click(object sender, EventArgs e)
        {
            DoktorSearchRequest request = new DoktorSearchRequest()
            {
                ImePrezime = txtDoktor.Text
            };
            var listaPregleda = _doktorService.Get<List<Model.Models.Doktor>>(request);
            dgvDoktor.DataSource = await listaPregleda;
        }

        private async void btnOdjel_Click(object sender, EventArgs e)
        {
            OdjelSearchRequest request = new OdjelSearchRequest()
            {
                Naziv = txtOdjel.Text
            };
            var listaPregleda = _doktorService.Get<List<Model.Models.Doktor>>(request);
            dgvDoktor.DataSource = await listaPregleda;
        }
    }
}
