
namespace eKarton.WinFr.Pacijent
{
    partial class frmNalazi
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
            this.dgvNalaz = new System.Windows.Forms.DataGridView();
            this.NalazId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LicnaAnamneza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PorodicnaAnamneza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RadnaAnamneza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPretraga = new System.Windows.Forms.Button();
            this.txtPacijent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNalaz)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNalaz
            // 
            this.dgvNalaz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNalaz.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NalazId,
            this.LicnaAnamneza,
            this.PorodicnaAnamneza,
            this.RadnaAnamneza});
            this.dgvNalaz.Location = new System.Drawing.Point(103, 136);
            this.dgvNalaz.Name = "dgvNalaz";
            this.dgvNalaz.RowTemplate.Height = 25;
            this.dgvNalaz.Size = new System.Drawing.Size(344, 150);
            this.dgvNalaz.TabIndex = 9;
            // 
            // NalazId
            // 
            this.NalazId.HeaderText = "NalazId";
            this.NalazId.Name = "NalazId";
            this.NalazId.Visible = false;
            // 
            // LicnaAnamneza
            // 
            this.LicnaAnamneza.DataPropertyName = "LicnaAnamneza";
            this.LicnaAnamneza.HeaderText = "LicnaAnamneza";
            this.LicnaAnamneza.Name = "LicnaAnamneza";
            // 
            // PorodicnaAnamneza
            // 
            this.PorodicnaAnamneza.DataPropertyName = "PorodicnaAnamneza";
            this.PorodicnaAnamneza.HeaderText = "PorodicnaAnamneza";
            this.PorodicnaAnamneza.Name = "PorodicnaAnamneza";
            // 
            // RadnaAnamneza
            // 
            this.RadnaAnamneza.DataPropertyName = "RadnaAnamneza";
            this.RadnaAnamneza.HeaderText = "RadnaAnamneza";
            this.RadnaAnamneza.Name = "RadnaAnamneza";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Pronadjite svoje nalaze";
            // 
            // btnPretraga
            // 
            this.btnPretraga.Location = new System.Drawing.Point(371, 106);
            this.btnPretraga.Name = "btnPretraga";
            this.btnPretraga.Size = new System.Drawing.Size(76, 23);
            this.btnPretraga.TabIndex = 7;
            this.btnPretraga.Text = "Pretrazi";
            this.btnPretraga.UseVisualStyleBackColor = true;
            this.btnPretraga.Click += new System.EventHandler(this.btnPretraga_Click);
            // 
            // txtPacijent
            // 
            this.txtPacijent.Location = new System.Drawing.Point(187, 107);
            this.txtPacijent.Name = "txtPacijent";
            this.txtPacijent.Size = new System.Drawing.Size(179, 23);
            this.txtPacijent.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ime pacijenta";
            // 
            // frmNalazi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgvNalaz);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPretraga);
            this.Controls.Add(this.txtPacijent);
            this.Controls.Add(this.label1);
            this.Name = "frmNalazi";
            this.Size = new System.Drawing.Size(562, 365);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNalaz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNalaz;
        private System.Windows.Forms.DataGridViewTextBoxColumn NalazId;
        private System.Windows.Forms.DataGridViewTextBoxColumn LicnaAnamneza;
        private System.Windows.Forms.DataGridViewTextBoxColumn PorodicnaAnamneza;
        private System.Windows.Forms.DataGridViewTextBoxColumn RadnaAnamneza;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPretraga;
        private System.Windows.Forms.TextBox txtPacijent;
        private System.Windows.Forms.Label label1;
    }
}
