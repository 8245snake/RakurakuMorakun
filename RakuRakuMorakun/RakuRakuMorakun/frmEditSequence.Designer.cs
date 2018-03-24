namespace RakuRakuMorakun
{
    partial class frmEditSequence
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
            this.grdSeqItems = new System.Windows.Forms.DataGridView();
            this.cmdSet = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.SeqVAlue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdSeqItems)).BeginInit();
            this.SuspendLayout();
            // 
            // grdSeqItems
            // 
            this.grdSeqItems.AllowUserToAddRows = false;
            this.grdSeqItems.AllowUserToDeleteRows = false;
            this.grdSeqItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSeqItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SeqVAlue});
            this.grdSeqItems.Location = new System.Drawing.Point(12, 12);
            this.grdSeqItems.Name = "grdSeqItems";
            this.grdSeqItems.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.grdSeqItems.RowTemplate.Height = 21;
            this.grdSeqItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.grdSeqItems.Size = new System.Drawing.Size(363, 390);
            this.grdSeqItems.TabIndex = 0;
            this.grdSeqItems.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdSeqItems_KeyDown);
            // 
            // cmdSet
            // 
            this.cmdSet.Location = new System.Drawing.Point(289, 408);
            this.cmdSet.Name = "cmdSet";
            this.cmdSet.Size = new System.Drawing.Size(88, 28);
            this.cmdSet.TabIndex = 1;
            this.cmdSet.Text = "設定";
            this.cmdSet.UseVisualStyleBackColor = true;
            this.cmdSet.Click += new System.EventHandler(this.cmdSet_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.Location = new System.Drawing.Point(195, 408);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(88, 28);
            this.cmdCancel.TabIndex = 2;
            this.cmdCancel.Text = "キャンセル";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // SeqVAlue
            // 
            this.SeqVAlue.HeaderText = "値";
            this.SeqVAlue.Name = "SeqVAlue";
            this.SeqVAlue.Width = 300;
            // 
            // frmEditSequence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 450);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdSet);
            this.Controls.Add(this.grdSeqItems);
            this.Name = "frmEditSequence";
            this.Text = "シーケンス設定";
            this.Load += new System.EventHandler(this.frmEditSequence_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdSeqItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdSeqItems;
        private System.Windows.Forms.Button cmdSet;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn SeqVAlue;
    }
}