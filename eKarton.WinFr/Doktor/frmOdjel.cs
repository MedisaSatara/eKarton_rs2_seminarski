using eKarton.Model.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace eKarton.WinFr.Doktor
{
    public partial class frmOdjel : Form
    {
        ApiService _odjelService = new ApiService("Odjel");
        public frmOdjel()
        {
            InitializeComponent();
            dgvOdjel.AutoGenerateColumns = false;
        }

        private async void frmOdjel_Load(object sender, EventArgs e)
        {
            dgvOdjel.DataSource = await _odjelService.Get<List<Model.Models.Odjel>>(null);
        }

        private void btnDodajOdjel_Click(object sender, EventArgs e)
        {
            frmDodajUrediOdjel frm = new frmDodajUrediOdjel();
            frm.ShowDialog();
        }

        private void dgvOdjel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var item = dgvOdjel.SelectedRows[0].DataBoundItem;
            frmDodajUrediOdjel uredi = new frmDodajUrediOdjel(item as Odjel);
            uredi.ShowDialog();
        }
    }
}
