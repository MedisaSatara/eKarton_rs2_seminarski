
namespace eKarton.WinFr.Pacijent
{
    partial class frmPreventivneMjere
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
            this.dgvMjere = new System.Windows.Forms.DataGridView();
            this.btnPretraga = new System.Windows.Forms.Button();
            this.txtPacijent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PreventivneMjereId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stanje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMjere)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMjere
            // 
            this.dgvMjere.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMjere.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PreventivneMjereId,
            this.Stanje});
            this.dgvMjere.Location = new System.Drawing.Point(105, 116);
            this.dgvMjere.Name = "dgvMjere";
            this.dgvMjere.RowTemplate.Height = 25;
            this.dgvMjere.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMjere.Size = new System.Drawing.Size(240, 150);
            this.dgvMjere.TabIndex = 0;
            // 
            // btnPretraga
            // 
            this.btnPretraga.Location = new System.Drawing.Point(270, 86);
            this.btnPretraga.Name = "btnPretraga";
            this.btnPretraga.Size = new System.Drawing.Size(75, 23);
            this.btnPretraga.TabIndex = 1;
            this.btnPretraga.Text = "Pretrazi";
            this.btnPretraga.UseVisualStyleBackColor = true;
            this.btnPretraga.Click += new System.EventHandler(this.btnPretraga_Click);
            // 
            // txtPacijent
            // 
            this.txtPacijent.Location = new System.Drawing.Point(105, 87);
            this.txtPacijent.Name = "txtPacijent";
            this.txtPacijent.Size = new System.Drawing.Size(159, 23);
            this.txtPacijent.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ime pacijenta :";
            // 
            // PreventivneMjereId
            // 
            this.PreventivneMjereId.DataPropertyName = "PreventivneMjereId";
            this.PreventivneMjereId.HeaderText = "PreventivneMjereId";
            this.PreventivneMjereId.Name = "PreventivneMjereId";
            this.PreventivneMjereId.Visible = false;
            // 
            // Stanje
            // 
            this.Stanje.DataPropertyName = "Stanje";
            this.Stanje.HeaderText = "Stanje";
            this.Stanje.Name = "Stanje";
            this.Stanje.Width = 200;
            // 
            // frmPreventivneMjere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 321);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPacijent);
            this.Controls.Add(this.btnPretraga);
            this.Controls.Add(this.dgvMjere);
            this.Name = "frmPreventivneMjere";
            this.Text = "frmPreventivneMjere";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMjere)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMjere;
        private System.Windows.Forms.Button btnPretraga;
        private System.Windows.Forms.TextBox txtPacijent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PreventivneMjereId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stanje;
    }
}