using eKarton.Model.Request;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace eKarton.WinFr.Pacijent
{
    public partial class frmUputnica : Form
    {
        ApiService _uputnicaService = new ApiService("Uputnica");
        public frmUputnica()
        {
            InitializeComponent();
            dgvUputnica.AutoGenerateColumns = false;
        }

        private void frmUputnica_Load(object sender, EventArgs e)
        {

        }

        private async void btnPretraga_Click(object sender, EventArgs e)
        {
            PacijentSearchRequest request = new PacijentSearchRequest()
            {
                Ime = txtPacijent.Text
            };
            dgvUputnica.DataSource = await _uputnicaService.Get<List<Model.Models.Uputnica>>(request);
            //dgvUputnica.DataSource = await _uputnicaService.Get<List<Model.Models.Uputnica>>(null);
        }
    }
}
