
namespace eKarton.WinFr.HomePageKorisnik
{
    partial class frmPocetna
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.korisnikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledKorisnikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doktoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaRaspolozivihDoktoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaDoktoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odjeliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaOdjelaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pacijentiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaPacijentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preventivneMjereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledPreventivnihMjeraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preglediToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaPregledaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.terminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaZauzetihTerminaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajTerminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vakcinacijaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaVakcinisanihPacijenataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnOdjaviSe = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.korisnikToolStripMenuItem,
            this.doktoriToolStripMenuItem,
            this.pacijentiToolStripMenuItem,
            this.preglediToolStripMenuItem,
            this.terminToolStripMenuItem,
            this.vakcinacijaToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(737, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // korisnikToolStripMenuItem
            // 
            this.korisnikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledKorisnikaToolStripMenuItem});
            this.korisnikToolStripMenuItem.Name = "korisnikToolStripMenuItem";
            this.korisnikToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.korisnikToolStripMenuItem.Text = "Korisnik";
            // 
            // pregledKorisnikaToolStripMenuItem
            // 
            this.pregledKorisnikaToolStripMenuItem.Name = "pregledKorisnikaToolStripMenuItem";
            this.pregledKorisnikaToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.pregledKorisnikaToolStripMenuItem.Text = "Pregled korisnika";
            this.pregledKorisnikaToolStripMenuItem.Click += new System.EventHandler(this.pregledKorisnikaToolStripMenuItem_Click);
            // 
            // doktoriToolStripMenuItem
            // 
            this.doktoriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaRaspolozivihDoktoraToolStripMenuItem,
            this.pretragaDoktoraToolStripMenuItem,
            this.odjeliToolStripMenuItem});
            this.doktoriToolStripMenuItem.Name = "doktoriToolStripMenuItem";
            this.doktoriToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.doktoriToolStripMenuItem.Text = "Doktori";
            // 
            // listaRaspolozivihDoktoraToolStripMenuItem
            // 
            this.listaRaspolozivihDoktoraToolStripMenuItem.Name = "listaRaspolozivihDoktoraToolStripMenuItem";
            this.listaRaspolozivihDoktoraToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.listaRaspolozivihDoktoraToolStripMenuItem.Text = "Lista raspolozivih doktora";
            this.listaRaspolozivihDoktoraToolStripMenuItem.Click += new System.EventHandler(this.listaRaspolozivihDoktoraToolStripMenuItem_Click);
            // 
            // pretragaDoktoraToolStripMenuItem
            // 
            this.pretragaDoktoraToolStripMenuItem.Name = "pretragaDoktoraToolStripMenuItem";
            this.pretragaDoktoraToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.pretragaDoktoraToolStripMenuItem.Text = "Pretraga doktora";
            this.pretragaDoktoraToolStripMenuItem.Click += new System.EventHandler(this.pretragaDoktoraToolStripMenuItem_Click);
            // 
            // odjeliToolStripMenuItem
            // 
            this.odjeliToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaOdjelaToolStripMenuItem});
            this.odjeliToolStripMenuItem.Name = "odjeliToolStripMenuItem";
            this.odjeliToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.odjeliToolStripMenuItem.Text = "Odjeli";
            this.odjeliToolStripMenuItem.Click += new System.EventHandler(this.odjeliToolStripMenuItem_Click);
            // 
            // listaOdjelaToolStripMenuItem
            // 
            this.listaOdjelaToolStripMenuItem.Name = "listaOdjelaToolStripMenuItem";
            this.listaOdjelaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listaOdjelaToolStripMenuItem.Text = "Lista odjela";
            this.listaOdjelaToolStripMenuItem.Click += new System.EventHandler(this.listaOdjelaToolStripMenuItem_Click);
            // 
            // pacijentiToolStripMenuItem
            // 
            this.pacijentiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pretragaPacijentaToolStripMenuItem,
            this.preventivneMjereToolStripMenuItem});
            this.pacijentiToolStripMenuItem.Name = "pacijentiToolStripMenuItem";
            this.pacijentiToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.pacijentiToolStripMenuItem.Text = "Pacijenti";
            // 
            // pretragaPacijentaToolStripMenuItem
            // 
            this.pretragaPacijentaToolStripMenuItem.Name = "pretragaPacijentaToolStripMenuItem";
            this.pretragaPacijentaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pretragaPacijentaToolStripMenuItem.Text = "Pretraga pacijenta";
            this.pretragaPacijentaToolStripMenuItem.Click += new System.EventHandler(this.pretragaPacijentaToolStripMenuItem_Click);
            // 
            // preventivneMjereToolStripMenuItem
            // 
            this.preventivneMjereToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledPreventivnihMjeraToolStripMenuItem});
            this.preventivneMjereToolStripMenuItem.Name = "preventivneMjereToolStripMenuItem";
            this.preventivneMjereToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.preventivneMjereToolStripMenuItem.Text = "Preventivne mjere";
            this.preventivneMjereToolStripMenuItem.Click += new System.EventHandler(this.preventivneMjereToolStripMenuItem_Click);
            // 
            // pregledPreventivnihMjeraToolStripMenuItem
            // 
            this.pregledPreventivnihMjeraToolStripMenuItem.Name = "pregledPreventivnihMjeraToolStripMenuItem";
            this.pregledPreventivnihMjeraToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.pregledPreventivnihMjeraToolStripMenuItem.Text = "Pregled preventivnih mjera";
            this.pregledPreventivnihMjeraToolStripMenuItem.Click += new System.EventHandler(this.pregledPreventivnihMjeraToolStripMenuItem_Click);
            // 
            // preglediToolStripMenuItem
            // 
            this.preglediToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pretragaPregledaToolStripMenuItem});
            this.preglediToolStripMenuItem.Name = "preglediToolStripMenuItem";
            this.preglediToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.preglediToolStripMenuItem.Text = "Pregledi";
            // 
            // pretragaPregledaToolStripMenuItem
            // 
            this.pretragaPregledaToolStripMenuItem.Name = "pretragaPregledaToolStripMenuItem";
            this.pretragaPregledaToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.pretragaPregledaToolStripMenuItem.Text = "Pretraga pregleda";
            this.pretragaPregledaToolStripMenuItem.Click += new System.EventHandler(this.pretragaPregledaToolStripMenuItem_Click);
            // 
            // terminToolStripMenuItem
            // 
            this.terminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaZauzetihTerminaToolStripMenuItem,
            this.dodajTerminToolStripMenuItem});
            this.terminToolStripMenuItem.Name = "terminToolStripMenuItem";
            this.terminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.terminToolStripMenuItem.Text = "Termin";
            // 
            // listaZauzetihTerminaToolStripMenuItem
            // 
            this.listaZauzetihTerminaToolStripMenuItem.Name = "listaZauzetihTerminaToolStripMenuItem";
            this.listaZauzetihTerminaToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.listaZauzetihTerminaToolStripMenuItem.Text = "Lista zauzetih termina";
            this.listaZauzetihTerminaToolStripMenuItem.Click += new System.EventHandler(this.listaZauzetihTerminaToolStripMenuItem_Click);
            // 
            // dodajTerminToolStripMenuItem
            // 
            this.dodajTerminToolStripMenuItem.Name = "dodajTerminToolStripMenuItem";
            this.dodajTerminToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.dodajTerminToolStripMenuItem.Text = "Dodaj termin";
            // 
            // vakcinacijaToolStripMenuItem
            // 
            this.vakcinacijaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaVakcinisanihPacijenataToolStripMenuItem});
            this.vakcinacijaToolStripMenuItem.Name = "vakcinacijaToolStripMenuItem";
            this.vakcinacijaToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.vakcinacijaToolStripMenuItem.Text = "Vakcinacija";
            // 
            // listaVakcinisanihPacijenataToolStripMenuItem
            // 
            this.listaVakcinisanihPacijenataToolStripMenuItem.Name = "listaVakcinisanihPacijenataToolStripMenuItem";
            this.listaVakcinisanihPacijenataToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.listaVakcinisanihPacijenataToolStripMenuItem.Text = "Lista vakcinisanih pacijenata";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::eKarton.WinFr.Properties.Resources.d336e801_resize_820x0x100;
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(737, 477);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnOdjaviSe
            // 
            this.btnOdjaviSe.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOdjaviSe.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnOdjaviSe.FlatAppearance.BorderSize = 0;
            this.btnOdjaviSe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnOdjaviSe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOdjaviSe.Location = new System.Drawing.Point(631, 0);
            this.btnOdjaviSe.Name = "btnOdjaviSe";
            this.btnOdjaviSe.Size = new System.Drawing.Size(106, 24);
            this.btnOdjaviSe.TabIndex = 5;
            this.btnOdjaviSe.Text = "Odjavi se";
            this.btnOdjaviSe.UseVisualStyleBackColor = false;
            this.btnOdjaviSe.Click += new System.EventHandler(this.btnOdjaviSe_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Location = new System.Drawing.Point(0, 501);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip.Size = new System.Drawing.Size(737, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(602, 501);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 22);
            this.button1.TabIndex = 6;
            this.button1.Text = "Tehnicka podrska";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // frmPocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(737, 523);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnOdjaviSe);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmPocetna";
            this.Text = "frmPocetna";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem korisnikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledKorisnikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doktoriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaRaspolozivihDoktoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretragaDoktoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odjeliToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pacijentiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretragaPacijentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preventivneMjereToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledPreventivnihMjeraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preglediToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretragaPregledaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem terminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaZauzetihTerminaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajTerminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vakcinacijaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaVakcinisanihPacijenataToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnOdjaviSe;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem listaOdjelaToolStripMenuItem;
    }
}



