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
    public partial class frmPacijent : Form
    {
        ApiService _pacijentService = new ApiService("Pacijent");

        public frmPacijent()
        {
            InitializeComponent();
            dgvPacijenti.AutoGenerateColumns = false;
        }

        private async void btnPretraga_Click(object sender, EventArgs e)
        {
            PacijentSearchRequest searchRequest = new PacijentSearchRequest()
            {
                Ime = txtPacijent.Text
            };
            dgvPacijenti.DataSource = await _pacijentService.Get<List<Model.Models.Pacijent>>(searchRequest);
        }

        private void btnNalaz_Click(object sender, EventArgs e)
        {
            //frmNalaz frm = new frmNalaz();
            //frm.ShowDialog();

            //frmNalazi frm = new frmNalazi();
            //frm.Visible = true;
            frmNalazi1.Visible = true;
            frmOsiguranje1.Visible = true;


        }

        private void btnPreventivneMjere_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmUputnica frm = new frmUputnica();
            frm.ShowDialog();
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            //frmPacijent frm = new frmPacijent();
            //frm.Visible = false;
            frmNalazi1.Visible = false;
            frmOsiguranje1.Visible = false;
            
        }

        private void frmPacijent_Load(object sender, EventArgs e)
        {

        }

        private void frmNalazi1_Load(object sender, EventArgs e)
        {

        }

        private void dgvPacijenti_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var item = dgvPacijenti.SelectedRows[0].DataBoundItem;
            frmPacijentDetalji frm = new frmPacijentDetalji(item as Model.Models.Pacijent);
            frm.ShowDialog();
        }

        private void btnOsiguranje_Click(object sender, EventArgs e)
        {
            frmOsiguranje1.Visible = true;
            frmNalazi1.Visible = false;
        }
    }
}
