using eKarton.Model.Models;
using eKarton.Model.Request;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eKarton.WinFr.Korisnik
{
    public partial class frmUrediKorisnika : Form
    {
        ApiService _korisnikService = new ApiService("Korisnik");
        ApiService _ulogaService = new ApiService("Uloga");
        ApiService _korisnikUlogeService = new ApiService("KorisnikUloge");

        private Model.Models.Korisnik selectedKorisnik;
        private Model.Models.Korisnik _korisnik;

        public frmUrediKorisnika(Model.Models.Korisnik korisnik)
        {
            InitializeComponent();
            _korisnik = korisnik;
        }

        public bool IsValidEmailAddress(string email)
        {
            try
            {
                MailAddress ma = new MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }
        private bool ValidateContact(string broj)
        {
            return (System.Text.RegularExpressions.Regex.IsMatch("[^0-12]", broj));
        }
        private async Task LoadUloge()
        {
            var result = await _ulogaService.Get<List<Model.Models.Uloga>>();
            result.Insert(0, new Uloga());
            cmbUloga.DisplayMember = "Naziv";
            cmbUloga.ValueMember = "UlogaId";
            cmbUloga.DataSource = result;
        }
        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if(_korisnik==null)
            {
                var newList = new List<int>();
                newList.Add(cmbUloga.SelectedIndex);
                KorisnikInsertRequest request = new KorisnikInsertRequest()
                {
                    Ime = txtIme.Text,
                    Prezime = txtPrezime.Text,
                    KorisnickoIme = txtKorisnickoIme.Text,
                    Password = txtLozinka.Text,
                    PasswordPotvrda = txtPotvrdaLozinke.Text
                };
                bool postojiUsername = false;
                var listakorsnika = await _korisnikService.Get<List<Model.Models.Korisnik>>(null);
                foreach (var item in listakorsnika)
                {
                    if (item.KorisnickoIme.ToLower() == request.KorisnickoIme)
                        postojiUsername = true;
                }

                if (txtPrezime.Text == ""|| txtIme.Text == "" ||
                    txtPotvrdaLozinke.Text == "" || txtLozinka.Text == "" || txtPrezime.Text.Length < 2 || txtIme.Text.Length < 2 || cmbUloga.SelectedIndex == 0)
                {
                    MessageBox.Show("Niste unijeli sva polja ispravno. Pokusajte ponovo. (Polje prazno/ne sadrzi dovoljan broj karaktera)");
                }
                
                else if (txtLozinka.Text != txtPotvrdaLozinke.Text || txtLozinka.Text.Length < 4)
                {
                    errorProvider1.SetError(txtLozinka, "Passwordi se ne slazu ili moraju sadrzavati minimalno 4 karaktera.");
                }
                else if (postojiUsername)

                {
                    errorProvider1.SetError(txtKorisnickoIme, "Korisnik sa tim korisnickim imenom vec postoji.");
                }
                else
                {
                    var korisnik = await _korisnikService.Insert<Model.Models.Korisnik>(request);
                    MessageBox.Show("Uspjesno ste dodali novog korisnika.");
                    Close();
                }
            }
            else
            {
                KorisnikUpdateRequest request = new KorisnikUpdateRequest()
                {
                    Ime = txtIme.Text,
                    Prezime = txtPrezime.Text,
                    KorisnickoIme = txtKorisnickoIme.Text,
                    Password = txtLozinka.Text,
                    PasswordPotvrda = txtPotvrdaLozinke.Text

                };
                bool postojiUsername = false;
                var listakorsnika = await _korisnikService.Get<List<Model.Models.Korisnik>>(null);
                foreach (var item in listakorsnika)
                {
                    if (item.KorisnickoIme.ToLower() == request.KorisnickoIme && _korisnik.KorisnikId != item.KorisnikId)
                        postojiUsername = true;
                }
                if (txtPrezime.Text == "" ||  txtIme.Text == "" ||
                    txtPotvrdaLozinke.Text == "" || txtLozinka.Text == "" || txtPrezime.Text.Length < 2 || txtIme.Text.Length < 2 || cmbUloga.SelectedIndex == 0)
                {
                    MessageBox.Show("Niste unijeli sva polja ispravno. Pokusajte ponovo. (Polje prazno/ne sadrzi dovoljan broj karaktera)");
                }
                
                else if (txtLozinka.Text != txtPotvrdaLozinke.Text || txtLozinka.Text.Length < 4)
                {
                    errorProvider1.SetError(txtLozinka, "Passwordi se ne slazu ili moraju sadrzavati minimalno 4 karaktera.");
                }
                else if (postojiUsername)
                {
                    errorProvider1.SetError(txtKorisnickoIme, "Korisnik sa tim korisnickim imenom vec postoji.");
                }
                else
                {
                    var korisnik = await _korisnikService.Update<Model.Models.Korisnik>(_korisnik.KorisnikId, request);
                    MessageBox.Show("Uspjesno ste editovali postojeceg korisnika.");
                    Close();
                }
            }
        }

        private async void frmUrediKorisnika_Load(object sender, EventArgs e)
        {
            await LoadUloge();
            if (_korisnik != null)
            {
                MessageBox.Show($"Korisnik: {_korisnik.Ime}");
                txtIme.Text = _korisnik.Ime;
                txtPrezime.Text = _korisnik.Prezime;
                txtKorisnickoIme.Text = _korisnik.KorisnickoIme;

                var lista = await _korisnikUlogeService.Get<List<Model.Models.KorisnikUloga>>();
                foreach (var item in lista)
                {
                    if (_korisnik.KorisnikId == item.KorisnikId)
                        cmbUloga.SelectedIndex = item.UlogaId;
                }
            }

        }
    }
}
