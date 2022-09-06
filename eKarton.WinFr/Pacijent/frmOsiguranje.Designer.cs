
namespace eKarton.WinFr.Pacijent
{
    partial class frmOsiguranje
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtPacijent = new System.Windows.Forms.TextBox();
            this.dgvOsiguranje = new System.Windows.Forms.DataGridView();
            this.OsiguranjeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Osiguranik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPretraga = new System.Windows.Forms.Button();
            this.btnOsiguranje = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOsiguranje)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime pacijenta :";
            // 
            // txtPacijent
            // 
            this.txtPacijent.Location = new System.Drawing.Point(18, 57);
            this.txtPacijent.Name = "txtPacijent";
            this.txtPacijent.Size = new System.Drawing.Size(100, 23);
            this.txtPacijent.TabIndex = 1;
            // 
            // dgvOsiguranje
            // 
            this.dgvOsiguranje.BackgroundColor = System.Drawing.Color.White;
            this.dgvOsiguranje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOsiguranje.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OsiguranjeId,
            this.Osiguranik});
            this.dgvOsiguranje.Location = new System.Drawing.Point(54, 115);
            this.dgvOsiguranje.Name = "dgvOsiguranje";
            this.dgvOsiguranje.RowTemplate.Height = 25;
            this.dgvOsiguranje.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOsiguranje.Size = new System.Drawing.Size(243, 131);
            this.dgvOsiguranje.TabIndex = 2;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(172, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Popis unesenih osiguranja !";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btnPretraga);
            this.groupBox1.Controls.Add(this.txtPacijent);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(303, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 104);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Provjera osiguranja";
            // 
            // btnPretraga
            // 
            this.btnPretraga.Location = new System.Drawing.Point(125, 56);
            this.btnPretraga.Name = "btnPretraga";
            this.btnPretraga.Size = new System.Drawing.Size(75, 23);
            this.btnPretraga.TabIndex = 2;
            this.btnPretraga.Text = "Pretrazi";
            this.btnPretraga.UseVisualStyleBackColor = true;
            // 
            // btnOsiguranje
            // 
            this.btnOsiguranje.BackColor = System.Drawing.Color.White;
            this.btnOsiguranje.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOsiguranje.Location = new System.Drawing.Point(54, 253);
            this.btnOsiguranje.Name = "btnOsiguranje";
            this.btnOsiguranje.Size = new System.Drawing.Size(243, 23);
            this.btnOsiguranje.TabIndex = 5;
            this.btnOsiguranje.Text = "Dodaj osiguranje ";
            this.btnOsiguranje.UseVisualStyleBackColor = false;
            this.btnOsiguranje.Click += new System.EventHandler(this.btnOsiguranje_Click);
            // 
            // frmOsiguranje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::eKarton.WinFr.Properties.Resources.Insurance_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.btnOsiguranje);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvOsiguranje);
            this.Name = "frmOsiguranje";
            this.Size = new System.Drawing.Size(582, 348);
            this.Load += new System.EventHandler(this.frmOsiguranje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOsiguranje)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPacijent;
        private System.Windows.Forms.DataGridView dgvOsiguranje;
        private System.Windows.Forms.DataGridViewTextBoxColumn OsiguranjeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Osiguranik;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPretraga;
        private System.Windows.Forms.Button btnOsiguranje;
    }
}
