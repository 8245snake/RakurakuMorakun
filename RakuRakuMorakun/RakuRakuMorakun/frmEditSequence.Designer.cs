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
            this.SeqVAlue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdSet = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.combName = new System.Windows.Forms.ComboBox();
            this.combItem = new System.Windows.Forms.ComboBox();
            this.cmdSearch = new System.Windows.Forms.Button();
            this.lblEqual = new System.Windows.Forms.Label();
            this.cmdReset = new System.Windows.Forms.Button();
            this.cmdReverse = new System.Windows.Forms.Button();
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
            this.grdSeqItems.Location = new System.Drawing.Point(12, 39);
            this.grdSeqItems.Name = "grdSeqItems";
            this.grdSeqItems.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.grdSeqItems.RowTemplate.Height = 21;
            this.grdSeqItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.grdSeqItems.Size = new System.Drawing.Size(510, 363);
            this.grdSeqItems.TabIndex = 0;
            this.grdSeqItems.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdSeqItems_KeyDown);
            // 
            // SeqVAlue
            // 
            this.SeqVAlue.HeaderText = "値";
            this.SeqVAlue.Name = "SeqVAlue";
            this.SeqVAlue.Width = 300;
            // 
            // cmdSet
            // 
            this.cmdSet.Location = new System.Drawing.Point(434, 410);
            this.cmdSet.Name = "cmdSet";
            this.cmdSet.Size = new System.Drawing.Size(88, 28);
            this.cmdSet.TabIndex = 1;
            this.cmdSet.Text = "設定";
            this.cmdSet.UseVisualStyleBackColor = true;
            this.cmdSet.Click += new System.EventHandler(this.cmdSet_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.Location = new System.Drawing.Point(340, 410);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(88, 28);
            this.cmdCancel.TabIndex = 2;
            this.cmdCancel.Text = "キャンセル";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // combName
            // 
            this.combName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combName.FormattingEnabled = true;
            this.combName.Location = new System.Drawing.Point(12, 12);
            this.combName.Name = "combName";
            this.combName.Size = new System.Drawing.Size(82, 20);
            this.combName.TabIndex = 3;
            // 
            // combItem
            // 
            this.combItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combItem.FormattingEnabled = true;
            this.combItem.Location = new System.Drawing.Point(132, 12);
            this.combItem.Name = "combItem";
            this.combItem.Size = new System.Drawing.Size(145, 20);
            this.combItem.TabIndex = 4;
            // 
            // cmdSearch
            // 
            this.cmdSearch.Location = new System.Drawing.Point(292, 7);
            this.cmdSearch.Name = "cmdSearch";
            this.cmdSearch.Size = new System.Drawing.Size(68, 28);
            this.cmdSearch.TabIndex = 5;
            this.cmdSearch.Text = "絞り込み";
            this.cmdSearch.UseVisualStyleBackColor = true;
            // 
            // lblEqual
            // 
            this.lblEqual.AutoSize = true;
            this.lblEqual.Location = new System.Drawing.Point(104, 18);
            this.lblEqual.Name = "lblEqual";
            this.lblEqual.Size = new System.Drawing.Size(17, 12);
            this.lblEqual.TabIndex = 6;
            this.lblEqual.Text = "＝";
            // 
            // cmdReset
            // 
            this.cmdReset.Location = new System.Drawing.Point(454, 7);
            this.cmdReset.Name = "cmdReset";
            this.cmdReset.Size = new System.Drawing.Size(68, 28);
            this.cmdReset.TabIndex = 7;
            this.cmdReset.Text = "全て表示";
            this.cmdReset.UseVisualStyleBackColor = true;
            // 
            // cmdReverse
            // 
            this.cmdReverse.Location = new System.Drawing.Point(366, 7);
            this.cmdReverse.Name = "cmdReverse";
            this.cmdReverse.Size = new System.Drawing.Size(82, 28);
            this.cmdReverse.TabIndex = 8;
            this.cmdReverse.Text = "表示を反転";
            this.cmdReverse.UseVisualStyleBackColor = true;
            // 
            // frmEditSequence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 450);
            this.Controls.Add(this.cmdReverse);
            this.Controls.Add(this.cmdReset);
            this.Controls.Add(this.lblEqual);
            this.Controls.Add(this.cmdSearch);
            this.Controls.Add(this.combItem);
            this.Controls.Add(this.combName);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdSet);
            this.Controls.Add(this.grdSeqItems);
            this.Name = "frmEditSequence";
            this.Text = "シーケンス設定";
            this.Load += new System.EventHandler(this.frmEditSequence_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdSeqItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdSeqItems;
        private System.Windows.Forms.Button cmdSet;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn SeqVAlue;
        private System.Windows.Forms.ComboBox combName;
        private System.Windows.Forms.ComboBox combItem;
        private System.Windows.Forms.Button cmdSearch;
        private System.Windows.Forms.Label lblEqual;
        private System.Windows.Forms.Button cmdReset;
        private System.Windows.Forms.Button cmdReverse;
    }
}