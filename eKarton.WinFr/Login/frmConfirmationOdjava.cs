using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace eKarton.WinFr.Login
{
    public partial class frmConfirmationOdjava : Form
    {
        public frmConfirmationOdjava()
        {
            InitializeComponent();
        }

        private void btnDa_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Pozdrav!");
            DialogResult = DialogResult.Yes;
        }

        private void frmConfirmationOdjava_Load(object sender, EventArgs e)
        {

        }

        private void btnNe_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
