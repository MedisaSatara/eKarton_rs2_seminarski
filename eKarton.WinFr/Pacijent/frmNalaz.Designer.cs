
namespace eKarton.WinFr.Pacijent
{
    partial class frmNalaz
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtPacijent = new System.Windows.Forms.TextBox();
            this.btnPretraga = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NalazId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LicnaAnamneza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PorodicnaAnamneza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RadnaAnamneza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime pacijenta";
            // 
            // txtPacijent
            // 
            this.txtPacijent.Location = new System.Drawing.Point(154, 95);
            this.txtPacijent.Name = "txtPacijent";
            this.txtPacijent.Size = new System.Drawing.Size(178, 23);
            this.txtPacijent.TabIndex = 1;
            // 
            // btnPretraga
            // 
            this.btnPretraga.Location = new System.Drawing.Point(338, 94);
            this.btnPretraga.Name = "btnPretraga";
            this.btnPretraga.Size = new System.Drawing.Size(75, 23);
            this.btnPretraga.TabIndex = 2;
            this.btnPretraga.Text = "Pretrazi";
            this.btnPretraga.UseVisualStyleBackColor = true;
            this.btnPretraga.Click += new System.EventHandler(this.btnPretraga_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pronadjite svoje nalaze";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NalazId,
            this.LicnaAnamneza,
            this.PorodicnaAnamneza,
            this.RadnaAnamneza});
            this.dataGridView1.Location = new System.Drawing.Point(70, 124);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(454, 150);
            this.dataGridView1.TabIndex = 4;
            // 
            // NalazId
            // 
            this.NalazId.HeaderText = "NalazId";
            this.NalazId.MinimumWidth = 6;
            this.NalazId.Name = "NalazId";
            this.NalazId.Visible = false;
            // 
            // LicnaAnamneza
            // 
            this.LicnaAnamneza.DataPropertyName = "LicnaAnamneza";
            this.LicnaAnamneza.HeaderText = "Licna Anamneza";
            this.LicnaAnamneza.Name = "LicnaAnamneza";
            this.LicnaAnamneza.Width = 130;
            // 
            // PorodicnaAnamneza
            // 
            this.PorodicnaAnamneza.DataPropertyName = "PorodicnaAnamneza";
            this.PorodicnaAnamneza.HeaderText = "Porodicna Anamneza";
            this.PorodicnaAnamneza.Name = "PorodicnaAnamneza";
            this.PorodicnaAnamneza.Width = 150;
            // 
            // RadnaAnamneza
            // 
            this.RadnaAnamneza.DataPropertyName = "RadnaAnamneza";
            this.RadnaAnamneza.HeaderText = "Radna Anamneza";
            this.RadnaAnamneza.Name = "RadnaAnamneza";
            this.RadnaAnamneza.Width = 130;
            // 
            // frmNalaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 363);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPretraga);
            this.Controls.Add(this.txtPacijent);
            this.Controls.Add(this.label1);
            this.Name = "frmNalaz";
            this.Text = "frmNalaz";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPacijent;
        private System.Windows.Forms.Button btnPretraga;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NalazId;
        private System.Windows.Forms.DataGridViewTextBoxColumn LicnaAnamneza;
        private System.Windows.Forms.DataGridViewTextBoxColumn PorodicnaAnamneza;
        private System.Windows.Forms.DataGridViewTextBoxColumn RadnaAnamneza;
    }
}