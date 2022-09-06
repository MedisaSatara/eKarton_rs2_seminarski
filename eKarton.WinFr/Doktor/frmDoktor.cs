using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace eKarton.WinFr.Doktor
{
    public partial class frmDoktor : Form
    {
        ApiService _doktorService = new ApiService("Doktor");
        public frmDoktor()
        {
            InitializeComponent();
            dgvDoktor.AutoGenerateColumns = false;
        }

        private async void frmDoktor_Load(object sender, EventArgs e)
        {
            dgvDoktor.DataSource = await _doktorService.Get<List<Model.Models.Doktor>>();

        }

        private void btnPretraga_Click(object sender, EventArgs e)
        {
            frmPretragaDoktora frm = new frmPretragaDoktora();
            frm.ShowDialog();
        }



        private void dgvDoktor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var item = dgvDoktor.SelectedRows[0].DataBoundItem;
            frmDodajUrediOdjel frm = new frmDodajUrediOdjel(item as Model.Models.Doktor);
            frm.ShowDialog();
        }

        private void btnOdjel_Click(object sender, EventArgs e)
        {
            frmOdjel frm = new frmOdjel();
            frm.ShowDialog();
        }
    }
}
