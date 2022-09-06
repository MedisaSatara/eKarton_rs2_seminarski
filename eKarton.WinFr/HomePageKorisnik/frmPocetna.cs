using eKarton.WinFr.Doktor;
using eKarton.WinFr.Korisnik;
using eKarton.WinFr.Login;
using eKarton.WinFr.Pacijent;
using eKarton.WinFr.Pregled;
using eKarton.WinFr.Termin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace eKarton.WinFr.HomePageKorisnik
{
    public partial class frmPocetna : Form
    {
        private int childFormNumber = 0;

        public frmPocetna()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void btnOdjaviSe_Click(object sender, EventArgs e)
        {
            frmConfirmationOdjava frm = new frmConfirmationOdjava();
            frm.Show();
        }

        private void pregledKorisnikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKorisnik frm = new frmKorisnik();
            frm.ShowDialog();
        }

        private void listaRaspolozivihDoktoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDoktor frm = new frmDoktor();
            frm.Show();
        }

        private void pretragaDoktoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPretragaDoktora frm = new frmPretragaDoktora();
            frm.Show();
        }

        private void odjeliToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void pretragaPacijentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPacijent frm = new frmPacijent();
            frm.Show();
        }

        private void preventivneMjereToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pregledPreventivnihMjeraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPreventivneMjere frm = new frmPreventivneMjere();
            frm.Show();

        }

        private void pretragaPregledaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPregled frm = new frmPregled();
            frm.Show();
        }

        private void listaZauzetihTerminaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTermin frm = new frmTermin();
            frm.Show();
        }

        private void listaOsiguranjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void listaOdjelaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOdjel frm = new frmOdjel();
            frm.Show();
        }
    }
}
