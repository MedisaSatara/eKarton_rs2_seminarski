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
    public partial class frmPacijentDetalji : Form
    {
        private Model.Models.Pacijent _pacijent;
        ApiService _ulogaService = new ApiService("Uloga");
        
        ApiService _osiguranjePacijentService = new ApiService("OsiguranjePacijent");
        private OsiguranjeInsertRequest insert = new OsiguranjeInsertRequest();
        private OsiguranjeUpdateRequest update = new OsiguranjeUpdateRequest();
        public frmPacijentDetalji(Model.Models.Pacijent _pacijent)
        {
            InitializeComponent();
            this._pacijent = _pacijent;
        }
        

        private void frmPacijentDetalji_Load(object sender, EventArgs e)
        {
            
            if (_pacijent != null)
            {
                MessageBox.Show($"Pacijent : {_pacijent.Ime}");
                lblImePrezime.Text = _pacijent.Ime + " " + _pacijent.Prezime;
                txtSpol.Text = _pacijent.Spol;
                txtDatumRodjenja.Text = _pacijent.DatumRodjenja;
                txtMjestoRodjenja.Text = _pacijent.MjestoRodjenja;
                txtPrebivaliste.Text = _pacijent.Prebivaliste;
                txtTelefon.Text = _pacijent.Telefon;
                txtJMBG.Text = _pacijent.Jmbg.ToString();
                txtAlergican.Text = _pacijent.Alergican;
                txtHronicneBolesti.Text = _pacijent.HronicneBolesti;
                txtKoagulopatija.Text = _pacijent.Koagulopatije.ToString();
                txtRhfaktor.Text = _pacijent.RhFaktor;
                txtKrvnaGrupa.Text = _pacijent.KrvnaGrupa;
                txtKorisnickoIme.Text = _pacijent.KorisnickoIme;
                lblBrojKartona.Text = _pacijent.BrojKartona;

                /*var lista = await _osiguranjePacijentService.Get<List< Model.Models.PacijentOsiguranje >> ();
                foreach(var item in lista)
                {
                    if(_pacijent.PacijentId==item.PacijentId)
                    {
                        cmbOsiguranje.SelectedIndex = item.OsiguranjeId;
                    }
                }*/
            }
        }
    }
}
