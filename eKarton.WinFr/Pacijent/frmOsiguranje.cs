using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eKarton.WinFr.Pacijent
{
    public partial class frmOsiguranje : UserControl
    {
        private Model.Models.Pacijent pacijent;
        ApiService _serviceOsiguranje = new ApiService("Osiguranje");
        private Model.Models.Osiguranje osiguranje;
        private int pacijentId;
        public frmOsiguranje()
        {
            InitializeComponent();
            dgvOsiguranje.AutoGenerateColumns = false;
        }

        private void btnOsiguranje_Click(object sender, EventArgs e)
        {
            frmDodajOsiguranje frm = new frmDodajOsiguranje();
            frm.ShowDialog();
        }
        private async Task LoadOsiguranje()
        {
            var listaOsiguranja = await _serviceOsiguranje.Get<List<Model.Models.Osiguranje>>();
            dgvOsiguranje.DataSource = listaOsiguranja;
        }

        private async void frmOsiguranje_Load(object sender, EventArgs e)
        {
            await LoadOsiguranje();

        }
    }
}
