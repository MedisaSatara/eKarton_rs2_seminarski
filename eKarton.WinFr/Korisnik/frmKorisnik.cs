using eKarton.Model.Request;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eKarton.WinFr.Korisnik
{
    public partial class frmKorisnik : Form
    {
        ApiService _serviceKorisnik = new ApiService("Korisnik");
        ApiService _servicePacijent = new ApiService("Pacijent");
        public Model.Models.Pacijent pacijent;
        public frmKorisnik()
        {
            InitializeComponent();
            dgvKorisnik.AutoGenerateColumns = false;
        }
        public frmKorisnik(Model.Models.Pacijent pacijent)
        {
            this.pacijent = pacijent;
        }

        private async Task LoadKorisnik()
        {
            var listaKorisnik = await _serviceKorisnik.Get<List<Model.Models.Korisnik>>();
            dgvKorisnik.DataSource = listaKorisnik;
        }
        private async void btnPretrazi_Click(object sender, EventArgs e)
        {
            KorisnikSearchRequest searchRequest = new KorisnikSearchRequest()
            {
                Ime = txtKorisnik.Text
            };
            /*var list = await _serviceKorisnik.Get<List<KorisnikSearchRequest>>(searchRequest);
            var prvi = list[0];
            dgvKorisnik.DataSource = list;*/
            var lista = await _serviceKorisnik.Get<List<Model.Models.Korisnik>>(searchRequest);
            dgvKorisnik.DataSource = lista;
        }
        private void label2_Click(object sender, EventArgs e)
        {        }
        private async void frmKorisnik_Load(object sender, EventArgs e)
        {
            await LoadKorisnik();
        }
        private async void dgvKorisnik_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var item = dgvKorisnik.SelectedRows[0].DataBoundItem;
            frmUrediKorisnika frm = new frmUrediKorisnika(item as Model.Models.Korisnik);
            frm.ShowDialog();
            await LoadKorisnik();
        }
    }
}
