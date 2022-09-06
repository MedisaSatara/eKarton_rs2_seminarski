using eKarton.WinFr.HomePageKorisnik;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace eKarton.WinFr.Login
{
    public partial class frmLogin : Form
    {
        private readonly ApiService _api = new ApiService( resource:"Korisnik");
        public frmLogin()
        {
            InitializeComponent();
        }

        private async void btnPrijaviSe_Click(object sender, EventArgs e)
        {
            ApiService.Username = txtKorisnickoIme.Text;
            ApiService.Password = txtLozinka.Text;

            try
            {
                var result = await _api.Get<List<Model.Models.Korisnik>>();

                frmPocetna frm = new frmPocetna();
                frm.Show();
            }
            catch
            {
                MessageBox.Show("Pogrešan username ili password");
            }
        }
    }
}
