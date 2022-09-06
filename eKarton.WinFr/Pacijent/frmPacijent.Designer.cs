
namespace eKarton.WinFr.Pacijent
{
    partial class frmPacijent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPacijent));
            this.dgvPacijenti = new System.Windows.Forms.DataGridView();
            this.PacijentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Spol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumRodjenja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prebivaliste = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPacijent = new System.Windows.Forms.TextBox();
            this.btnPretraga = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.frmNalazi1 = new eKarton.WinFr.Pacijent.frmNalazi();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOsiguranje = new System.Windows.Forms.Button();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.btnPreventivneMjere = new System.Windows.Forms.Button();
            this.btnNalaz = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.frmOsiguranje1 = new eKarton.WinFr.Pacijent.frmOsiguranje();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacijenti)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPacijenti
            // 
            this.dgvPacijenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPacijenti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PacijentId,
            this.Ime,
            this.Prezime,
            this.Spol,
            this.DatumRodjenja,
            this.Prebivaliste});
            this.dgvPacijenti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPacijenti.Location = new System.Drawing.Point(3, 19);
            this.dgvPacijenti.Name = "dgvPacijenti";
            this.dgvPacijenti.RowTemplate.Height = 25;
            this.dgvPacijenti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPacijenti.Size = new System.Drawing.Size(630, 149);
            this.dgvPacijenti.TabIndex = 0;
            this.dgvPacijenti.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPacijenti_CellDoubleClick);
            // 
            // PacijentId
            // 
            this.PacijentId.DataPropertyName = "PacijentId";
            this.PacijentId.HeaderText = "PacijentId";
            this.PacijentId.Name = "PacijentId";
            // 
            // Ime
            // 
            this.Ime.DataPropertyName = "Ime";
            this.Ime.HeaderText = "Ime";
            this.Ime.Name = "Ime";
            // 
            // Prezime
            // 
            this.Prezime.DataPropertyName = "Prezime";
            this.Prezime.HeaderText = "Prezime";
            this.Prezime.Name = "Prezime";
            // 
            // Spol
            // 
            this.Spol.DataPropertyName = "Spol";
            this.Spol.HeaderText = "Spol";
            this.Spol.Name = "Spol";
            // 
            // DatumRodjenja
            // 
            this.DatumRodjenja.DataPropertyName = "DatumRodjenja";
            this.DatumRodjenja.HeaderText = "Datum rodjenja";
            this.DatumRodjenja.Name = "DatumRodjenja";
            // 
            // Prebivaliste
            // 
            this.Prebivaliste.DataPropertyName = "Prebivaliste";
            this.Prebivaliste.HeaderText = "Prebivaliste";
            this.Prebivaliste.Name = "Prebivaliste";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Unesite ime pacijenta :";
            // 
            // txtPacijent
            // 
            this.txtPacijent.Location = new System.Drawing.Point(328, 118);
            this.txtPacijent.Name = "txtPacijent";
            this.txtPacijent.Size = new System.Drawing.Size(403, 23);
            this.txtPacijent.TabIndex = 2;
            // 
            // btnPretraga
            // 
            this.btnPretraga.Location = new System.Drawing.Point(737, 118);
            this.btnPretraga.Name = "btnPretraga";
            this.btnPretraga.Size = new System.Drawing.Size(75, 23);
            this.btnPretraga.TabIndex = 3;
            this.btnPretraga.Text = "Pretrazi";
            this.btnPretraga.UseVisualStyleBackColor = true;
            this.btnPretraga.Click += new System.EventHandler(this.btnPretraga_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(328, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pronadjite informacije o sebi kao pacijentu !";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvPacijenti);
            this.groupBox1.Location = new System.Drawing.Point(179, 147);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(636, 171);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pacijenti";
            // 
            // frmNalazi1
            // 
            this.frmNalazi1.BackColor = System.Drawing.Color.White;
            this.frmNalazi1.Location = new System.Drawing.Point(159, 61);
            this.frmNalazi1.Name = "frmNalazi1";
            this.frmNalazi1.Size = new System.Drawing.Size(694, 390);
            this.frmNalazi1.TabIndex = 8;
            this.frmNalazi1.Visible = false;
            this.frmNalazi1.Load += new System.EventHandler(this.frmNalazi1_Load);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnOsiguranje);
            this.panel1.Controls.Add(this.btnPretrazi);
            this.panel1.Controls.Add(this.btnPreventivneMjere);
            this.panel1.Controls.Add(this.btnNalaz);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(162, 451);
            this.panel1.TabIndex = 6;
            // 
            // btnOsiguranje
            // 
            this.btnOsiguranje.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnOsiguranje.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnOsiguranje.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnOsiguranje.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOsiguranje.Location = new System.Drawing.Point(0, 253);
            this.btnOsiguranje.Name = "btnOsiguranje";
            this.btnOsiguranje.Size = new System.Drawing.Size(162, 51);
            this.btnOsiguranje.TabIndex = 4;
            this.btnOsiguranje.Text = "Osiguranje";
            this.btnOsiguranje.UseVisualStyleBackColor = false;
            this.btnOsiguranje.Click += new System.EventHandler(this.btnOsiguranje_Click);
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnPretrazi.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPretrazi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnPretrazi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPretrazi.Location = new System.Drawing.Point(0, 61);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(162, 51);
            this.btnPretrazi.TabIndex = 3;
            this.btnPretrazi.Text = "Pretraga";
            this.btnPretrazi.UseVisualStyleBackColor = false;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // btnPreventivneMjere
            // 
            this.btnPreventivneMjere.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnPreventivneMjere.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPreventivneMjere.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnPreventivneMjere.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPreventivneMjere.Location = new System.Drawing.Point(0, 126);
            this.btnPreventivneMjere.Name = "btnPreventivneMjere";
            this.btnPreventivneMjere.Size = new System.Drawing.Size(162, 45);
            this.btnPreventivneMjere.TabIndex = 1;
            this.btnPreventivneMjere.Text = "Preventivne mjere";
            this.btnPreventivneMjere.UseVisualStyleBackColor = false;
            this.btnPreventivneMjere.Click += new System.EventHandler(this.btnPreventivneMjere_Click);
            // 
            // btnNalaz
            // 
            this.btnNalaz.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnNalaz.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNalaz.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnNalaz.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNalaz.Location = new System.Drawing.Point(0, 187);
            this.btnNalaz.Name = "btnNalaz";
            this.btnNalaz.Size = new System.Drawing.Size(162, 51);
            this.btnNalaz.TabIndex = 0;
            this.btnNalaz.Text = "Nalazi";
            this.btnNalaz.UseVisualStyleBackColor = false;
            this.btnNalaz.Click += new System.EventHandler(this.btnNalaz_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Linen;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(853, 64);
            this.panel2.TabIndex = 7;
            // 
            // frmOsiguranje1
            // 
            this.frmOsiguranje1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("frmOsiguranje1.BackgroundImage")));
            this.frmOsiguranje1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.frmOsiguranje1.Location = new System.Drawing.Point(165, 61);
            this.frmOsiguranje1.Name = "frmOsiguranje1";
            this.frmOsiguranje1.Size = new System.Drawing.Size(688, 390);
            this.frmOsiguranje1.TabIndex = 9;
            this.frmOsiguranje1.Visible = false;
            // 
            // frmPacijent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::eKarton.WinFr.Properties.Resources.DR;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(853, 450);
            this.Controls.Add(this.frmOsiguranje1);
            this.Controls.Add(this.frmNalazi1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPretraga);
            this.Controls.Add(this.txtPacijent);
            this.Controls.Add(this.label1);
            this.Name = "frmPacijent";
            this.Text = "frmPacijent";
            this.Load += new System.EventHandler(this.frmPacijent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacijenti)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPacijenti;
        private System.Windows.Forms.DataGridViewTextBoxColumn PacijentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Spol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumRodjenja;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prebivaliste;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPacijent;
        private System.Windows.Forms.Button btnPretraga;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPreventivneMjere;
        private System.Windows.Forms.Button btnNalaz;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnPretrazi;
        private frmNalazi frmNalazi1;
        private System.Windows.Forms.Button btnOsiguranje;
        private frmOsiguranje frmOsiguranje1;
    }
}