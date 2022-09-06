using eKarton.Model.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace eKarton.WinFr.Pacijent
{
    public partial class frmNalazi : UserControl
    {
        ApiService _nalazService = new ApiService("Nalaz");
        public frmNalazi()
        {
            InitializeComponent();
            dgvNalaz.AutoGenerateColumns = false;
        }

        private async void btnPretraga_Click(object sender, EventArgs e)
        {
            NalazSearchRequest request = new NalazSearchRequest()
            {
                ImePrezimePacijenta = txtPacijent.Text
            };
            dgvNalaz.DataSource = await _nalazService.Get<List<Model.Models.Nalaz>>(request);
        }
    }
}
