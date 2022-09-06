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
    public partial class frmPreventivneMjere : Form
    {
        private Model.Models.Pacijent pacijent;
        ApiService _mjereService = new ApiService("PreventivneMjere");
        private Model.Models.PreventivneMjere _mjere;
        public frmPreventivneMjere()
        {
            InitializeComponent();
            dgvMjere.AutoGenerateColumns = false;
        }

        private async void btnPretraga_Click(object sender, EventArgs e)
        {
            MjereSearchRequest request = new MjereSearchRequest()
            {
                ImePacijenta = txtPacijent.Text
            };
            var result = await _mjereService.Get<List<Model.Models.PreventivneMjere>>(request);
            dgvMjere.DataSource = result;
        }

    }
}
