
namespace eKarton.WinFr.Pacijent
{
    partial class frmUputnica
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
            this.dgvUputnica = new System.Windows.Forms.DataGridView();
            this.UputnicaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Razlog = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPacijent = new System.Windows.Forms.TextBox();
            this.btnPretraga = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUputnica)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUputnica
            // 
            this.dgvUputnica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUputnica.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UputnicaId,
            this.Datum,
            this.Razlog});
            this.dgvUputnica.Location = new System.Drawing.Point(84, 121);
            this.dgvUputnica.Name = "dgvUputnica";
            this.dgvUputnica.RowTemplate.Height = 25;
            this.dgvUputnica.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUputnica.Size = new System.Drawing.Size(245, 150);
            this.dgvUputnica.TabIndex = 0;
            // 
            // UputnicaId
            // 
            this.UputnicaId.DataPropertyName = "UputnicaId";
            this.UputnicaId.HeaderText = "UputnicaId";
            this.UputnicaId.Name = "UputnicaId";
            this.UputnicaId.Visible = false;
            // 
            // Datum
            // 
            this.Datum.DataPropertyName = "Datum";
            this.Datum.HeaderText = "Datum";
            this.Datum.Name = "Datum";
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
            this.label1.Location = new System.Drawing.Point(84, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Unesi ime pacijenta :";
            // 
            // txtPacijent
            // 
            this.txtPacijent.Location = new System.Drawing.Point(84, 92);
            this.txtPacijent.Name = "txtPacijent";
            this.txtPacijent.Size = new System.Drawing.Size(164, 23);
            this.txtPacijent.TabIndex = 2;
            // 
            // btnPretraga
            // 
            this.btnPretraga.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnPretraga.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPretraga.Location = new System.Drawing.Point(254, 91);
            this.btnPretraga.Name = "btnPretraga";
            this.btnPretraga.Size = new System.Drawing.Size(75, 23);
            this.btnPretraga.TabIndex = 3;
            this.btnPretraga.Text = "Pretrazi";
            this.btnPretraga.UseVisualStyleBackColor = false;
            this.btnPretraga.Click += new System.EventHandler(this.btnPretraga_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Uputnica";
            // 
            // frmUputnica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(417, 337);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPretraga);
            this.Controls.Add(this.txtPacijent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvUputnica);
            this.Name = "frmUputnica";
            this.Text = "frmUputnica";
            this.Load += new System.EventHandler(this.frmUputnica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUputnica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUputnica;
        private System.Windows.Forms.DataGridViewTextBoxColumn UputnicaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Razlog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPacijent;
        private System.Windows.Forms.Button btnPretraga;
        private System.Windows.Forms.Label label2;
    }
}