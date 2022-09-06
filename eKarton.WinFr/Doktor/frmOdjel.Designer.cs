
namespace eKarton.WinFr.Doktor
{
    partial class frmOdjel
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
            this.dgvOdjel = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDodajOdjel = new System.Windows.Forms.Button();
            this.OdjelId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdjel)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOdjel
            // 
            this.dgvOdjel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOdjel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OdjelId,
            this.Naziv,
            this.Telefon});
            this.dgvOdjel.Location = new System.Drawing.Point(85, 70);
            this.dgvOdjel.Name = "dgvOdjel";
            this.dgvOdjel.RowTemplate.Height = 25;
            this.dgvOdjel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOdjel.Size = new System.Drawing.Size(245, 135);
            this.dgvOdjel.TabIndex = 0;
            this.dgvOdjel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOdjel_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(157, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Podaci o odjelu !";
            // 
            // btnDodajOdjel
            // 
            this.btnDodajOdjel.BackColor = System.Drawing.Color.Snow;
            this.btnDodajOdjel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDodajOdjel.Location = new System.Drawing.Point(85, 212);
            this.btnDodajOdjel.Name = "btnDodajOdjel";
            this.btnDodajOdjel.Size = new System.Drawing.Size(245, 30);
            this.btnDodajOdjel.TabIndex = 2;
            this.btnDodajOdjel.Text = "Dodaj odjel";
            this.btnDodajOdjel.UseVisualStyleBackColor = false;
            this.btnDodajOdjel.Click += new System.EventHandler(this.btnDodajOdjel_Click);
            // 
            // OdjelId
            // 
            this.OdjelId.DataPropertyName = "OdjelId";
            this.OdjelId.HeaderText = "OdjelId";
            this.OdjelId.Name = "OdjelId";
            this.OdjelId.Visible = false;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv odjela";
            this.Naziv.Name = "Naziv";
            // 
            // Telefon
            // 
            this.Telefon.DataPropertyName = "Telefon";
            this.Telefon.HeaderText = "Telefon";
            this.Telefon.Name = "Telefon";
            // 
            // frmOdjel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(411, 353);
            this.Controls.Add(this.btnDodajOdjel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvOdjel);
            this.Name = "frmOdjel";
            this.Text = "frmOdjel";
            this.Load += new System.EventHandler(this.frmOdjel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdjel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOdjel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDodajOdjel;
        private System.Windows.Forms.DataGridViewTextBoxColumn OdjelId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefon;
    }
}