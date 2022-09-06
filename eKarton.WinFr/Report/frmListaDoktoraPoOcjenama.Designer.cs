
namespace eKarton.WinFr.Report
{
    partial class frmListaDoktoraPoOcjenama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaDoktoraPoOcjenama));
            this.dgvOcjene = new System.Windows.Forms.DataGridView();
            this.OcjenaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoktorId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ocjena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Anonimno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Razlog = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDoktor = new System.Windows.Forms.ComboBox();
            this.btnOdabri = new System.Windows.Forms.Button();
            this.btnPrintaj = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOcjene)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOcjene
            // 
            this.dgvOcjene.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOcjene.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OcjenaId,
            this.DoktorId,
            this.Ocjena,
            this.Anonimno,
            this.Razlog});
            this.dgvOcjene.Location = new System.Drawing.Point(80, 156);
            this.dgvOcjene.Name = "dgvOcjene";
            this.dgvOcjene.RowTemplate.Height = 25;
            this.dgvOcjene.Size = new System.Drawing.Size(578, 150);
            this.dgvOcjene.TabIndex = 0;
            this.dgvOcjene.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOcjene_CellContentClick);
            // 
            // OcjenaId
            // 
            this.OcjenaId.DataPropertyName = "OcjenaId";
            this.OcjenaId.HeaderText = "OcjenaId";
            this.OcjenaId.Name = "OcjenaId";
            // 
            // DoktorId
            // 
            this.DoktorId.DataPropertyName = "DoktorId";
            this.DoktorId.HeaderText = "DoktorId";
            this.DoktorId.Name = "DoktorId";
            // 
            // Ocjena
            // 
            this.Ocjena.DataPropertyName = "Ocjena";
            this.Ocjena.HeaderText = "Ocjena";
            this.Ocjena.Name = "Ocjena";
            // 
            // Anonimno
            // 
            this.Anonimno.DataPropertyName = "Anonimno";
            this.Anonimno.HeaderText = "Anonimno";
            this.Anonimno.Name = "Anonimno";
            // 
            // Razlog
            // 
            this.Razlog.DataPropertyName = "Razlog";
            this.Razlog.HeaderText = "Razlog";
            this.Razlog.Name = "Razlog";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // cmbDoktor
            // 
            this.cmbDoktor.FormattingEnabled = true;
            this.cmbDoktor.Location = new System.Drawing.Point(160, 116);
            this.cmbDoktor.Name = "cmbDoktor";
            this.cmbDoktor.Size = new System.Drawing.Size(121, 23);
            this.cmbDoktor.TabIndex = 2;
            this.cmbDoktor.SelectedIndexChanged += new System.EventHandler(this.cmbDoktor_SelectedIndexChanged);
            // 
            // btnOdabri
            // 
            this.btnOdabri.Location = new System.Drawing.Point(308, 115);
            this.btnOdabri.Name = "btnOdabri";
            this.btnOdabri.Size = new System.Drawing.Size(75, 23);
            this.btnOdabri.TabIndex = 3;
            this.btnOdabri.Text = "button1";
            this.btnOdabri.UseVisualStyleBackColor = true;
            this.btnOdabri.Click += new System.EventHandler(this.btnOdabri_Click);
            // 
            // btnPrintaj
            // 
            this.btnPrintaj.Location = new System.Drawing.Point(231, 323);
            this.btnPrintaj.Name = "btnPrintaj";
            this.btnPrintaj.Size = new System.Drawing.Size(75, 23);
            this.btnPrintaj.TabIndex = 4;
            this.btnPrintaj.Text = "Printaj";
            this.btnPrintaj.UseVisualStyleBackColor = true;
            this.btnPrintaj.Click += new System.EventHandler(this.btnPrintaj_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // frmListaDoktoraPoOcjenama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPrintaj);
            this.Controls.Add(this.btnOdabri);
            this.Controls.Add(this.cmbDoktor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvOcjene);
            this.Name = "frmListaDoktoraPoOcjenama";
            this.Text = "frmListaDoktoraPoOcjenama";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOcjene)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOcjene;
        private System.Windows.Forms.DataGridViewTextBoxColumn OcjenaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoktorId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ocjena;
        private System.Windows.Forms.DataGridViewTextBoxColumn Anonimno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Razlog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDoktor;
        private System.Windows.Forms.Button btnOdabri;
        private System.Windows.Forms.Button btnPrintaj;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}