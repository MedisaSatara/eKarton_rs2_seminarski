
namespace eKarton.WinFr.Pacijent
{
    partial class frmDodajOsiguranje
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOsiguranik = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.dgvOsiguranje = new System.Windows.Forms.DataGridView();
            this.OsiguranjeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Osiguranik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOsiguranje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btnDodaj);
            this.groupBox1.Controls.Add(this.txtOsiguranik);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(100, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodaj osiguranje ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv osiguranja";
            // 
            // txtOsiguranik
            // 
            this.txtOsiguranik.Location = new System.Drawing.Point(21, 58);
            this.txtOsiguranik.Name = "txtOsiguranik";
            this.txtOsiguranik.Size = new System.Drawing.Size(120, 23);
            this.txtOsiguranik.TabIndex = 1;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(147, 58);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 2;
            this.btnDodaj.Text = "Sacuvaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // dgvOsiguranje
            // 
            this.dgvOsiguranje.BackgroundColor = System.Drawing.Color.White;
            this.dgvOsiguranje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOsiguranje.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OsiguranjeId,
            this.Osiguranik});
            this.dgvOsiguranje.Location = new System.Drawing.Point(100, 186);
            this.dgvOsiguranje.Name = "dgvOsiguranje";
            this.dgvOsiguranje.RowTemplate.Height = 25;
            this.dgvOsiguranje.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOsiguranje.Size = new System.Drawing.Size(243, 131);
            this.dgvOsiguranje.TabIndex = 3;
            // 
            // OsiguranjeId
            // 
            this.OsiguranjeId.DataPropertyName = "OsiguranjeId";
            this.OsiguranjeId.HeaderText = "OsiguranjeId";
            this.OsiguranjeId.Name = "OsiguranjeId";
            this.OsiguranjeId.Visible = false;
            // 
            // Osiguranik
            // 
            this.Osiguranik.DataPropertyName = "Osiguranik";
            this.Osiguranik.HeaderText = "Osiguranik";
            this.Osiguranik.Name = "Osiguranik";
            this.Osiguranik.Width = 200;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmDodajOsiguranje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(455, 360);
            this.Controls.Add(this.dgvOsiguranje);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmDodajOsiguranje";
            this.Text = "frmDodajOsiguranje";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOsiguranje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.TextBox txtOsiguranik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvOsiguranje;
        private System.Windows.Forms.DataGridViewTextBoxColumn OsiguranjeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Osiguranik;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}