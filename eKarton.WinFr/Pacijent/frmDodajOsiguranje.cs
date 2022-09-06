using eKarton.Model.Request;
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
    public partial class frmDodajOsiguranje : Form
    {
        ApiService _serviceOsiguranje = new ApiService("Osiguranje");
        private Model.Models.Osiguranje _osiguranje;
        OsiguranjeInsertRequest insert = new OsiguranjeInsertRequest();
        public frmDodajOsiguranje(Model.Models.Osiguranje osiguranje = null)
        {
            InitializeComponent();
            dgvOsiguranje.AutoGenerateColumns = false;
            //_osiguranje = osiguranje;
        }

        private async Task LoadOsiguranje()
        {
            var listaOsiguranje = await _serviceOsiguranje.Get<List<Model.Models.Osiguranje>>();
            dgvOsiguranje.DataSource = listaOsiguranje;
        }
        private async void btnDodaj_Click(object sender, EventArgs e)
        {
            if (txtOsiguranik != null || txtOsiguranik.Text != "")
            {
                bool postojiOsiguranje = false;
                var listaOsiguranja = await _serviceOsiguranje.Get<List<Model.Models.Osiguranje>>();
                foreach (var item in listaOsiguranja)
                {
                    if (item.Osiguranik == txtOsiguranik.Text)
                    {
                        postojiOsiguranje = true;
                        errorProvider1.SetError(txtOsiguranik, "Osiguranik vec postoji!");
                    }
                }
                if (!postojiOsiguranje)
                {
                    insert.Osiguranik = txtOsiguranik.Text;

                    await _serviceOsiguranje.Insert<Model.Models.Osiguranje>(insert);
                    MessageBox.Show("Uspjesno ste dodali osiguranje");
                    await LoadOsiguranje();

                }

            }
        }
    }
}
