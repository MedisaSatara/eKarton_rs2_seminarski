using eKarton.Model.Request;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace eKarton.WinFr.Doktor
{
    public partial class frmDodajUrediOdjel : Form
    {
        ApiService _odjelService = new ApiService("Odjel");
        private Model.Models.Odjel _odjel;
        private Model.Models.Doktor doktor;

        public frmDodajUrediOdjel(Model.Models.Odjel _odjel = null)
        {
            InitializeComponent();
            this._odjel = _odjel;
        }

        public frmDodajUrediOdjel(Model.Models.Doktor doktor)
        {
            this.doktor = doktor;
        }

        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (_odjel == null)
            {
                OdjelInsertRequest request = new OdjelInsertRequest()
                {
                    Naziv = txtNazvOdjela.Text,
                    Telefon = txtTelefon.Text
                };

                var odjel = await _odjelService.Insert<Model.Models.Odjel>(request);
                MessageBox.Show("Uspjesno ste dodali novi odjel !");
                Close();
            }
            else
            {
                OdjelUpdateRequest request = new OdjelUpdateRequest()
                {
                    Naziv = txtNazvOdjela.Text,
                    Telefon = txtTelefon.Text
                };
                var odjel = await _odjelService.Update<Model.Models.Odjel>(_odjel.OdjelId, request);
                MessageBox.Show("Uspjesno ste editovali postojeci odjel");
                Close();
            }
        }

        private void frmDodajUrediOdjel_Load(object sender, EventArgs e)
        {
            if (_odjel != null)
            {
                txtNazvOdjela.Text = _odjel.Naziv;
                txtTelefon.Text = _odjel.Telefon;
            }
        }
    }
}
