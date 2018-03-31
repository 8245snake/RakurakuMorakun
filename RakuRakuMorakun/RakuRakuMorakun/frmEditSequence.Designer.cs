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
            this.combName = new System.Windows.Forms.ComboBox();
            this.combItem = new System.Windows.Forms.ComboBox();
            this.cmdSearch = new System.Windows.Forms.Button();
            this.lblEqual = new System.Windows.Forms.Label();
            this.cmdSet = new System.Windows.Forms.Button();
            this.cmdReverse = new System.Windows.Forms.Button();
            this.cmdReset = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.grdSeqItems)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdSeqItems
            // 
            this.grdSeqItems.AllowUserToAddRows = false;
            this.grdSeqItems.AllowUserToDeleteRows = false;
            this.grdSeqItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSeqItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SeqVAlue});
            this.grdSeqItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdSeqItems.Location = new System.Drawing.Point(3, 45);
            this.grdSeqItems.Name = "grdSeqItems";
            this.grdSeqItems.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.grdSeqItems.RowTemplate.Height = 21;
            this.grdSeqItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.grdSeqItems.Size = new System.Drawing.Size(526, 356);
            this.grdSeqItems.TabIndex = 0;
            this.grdSeqItems.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdSeqItems_KeyDown);
            // 
            // SeqVAlue
            // 
            this.SeqVAlue.HeaderText = "値";
            this.SeqVAlue.Name = "SeqVAlue";
            this.SeqVAlue.Width = 300;
            // 
            // combName
            // 
            this.combName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.combName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combName.FormattingEnabled = true;
            this.combName.Location = new System.Drawing.Point(3, 7);
            this.combName.Name = "combName";
            this.combName.Size = new System.Drawing.Size(82, 20);
            this.combName.TabIndex = 3;
            this.combName.TextChanged += new System.EventHandler(this.combName_TextChanged);
            // 
            // combItem
            // 
            this.combItem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.combItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combItem.FormattingEnabled = true;
            this.combItem.Location = new System.Drawing.Point(114, 7);
            this.combItem.Name = "combItem";
            this.combItem.Size = new System.Drawing.Size(145, 20);
            this.combItem.TabIndex = 4;
            // 
            // cmdSearch
            // 
            this.cmdSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdSearch.Location = new System.Drawing.Point(265, 3);
            this.cmdSearch.Name = "cmdSearch";
            this.cmdSearch.Size = new System.Drawing.Size(68, 28);
            this.cmdSearch.TabIndex = 5;
            this.cmdSearch.Text = "絞り込み";
            this.cmdSearch.UseVisualStyleBackColor = true;
            this.cmdSearch.Click += new System.EventHandler(this.cmdSearch_Click);
            // 
            // lblEqual
            // 
            this.lblEqual.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEqual.AutoSize = true;
            this.lblEqual.Location = new System.Drawing.Point(91, 11);
            this.lblEqual.Name = "lblEqual";
            this.lblEqual.Size = new System.Drawing.Size(17, 12);
            this.lblEqual.TabIndex = 6;
            this.lblEqual.Text = "＝";
            // 
            // cmdSet
            // 
            this.cmdSet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdSet.Location = new System.Drawing.Point(454, 422);
            this.cmdSet.Name = "cmdSet";
            this.cmdSet.Size = new System.Drawing.Size(90, 28);
            this.cmdSet.TabIndex = 1;
            this.cmdSet.Text = "設定";
            this.cmdSet.UseVisualStyleBackColor = true;
            this.cmdSet.Click += new System.EventHandler(this.cmdSet_Click);
            // 
            // cmdReverse
            // 
            this.cmdReverse.Location = new System.Drawing.Point(435, 3);
            this.cmdReverse.Name = "cmdReverse";
            this.cmdReverse.Size = new System.Drawing.Size(79, 28);
            this.cmdReverse.TabIndex = 8;
            this.cmdReverse.Text = "表示を反転";
            this.cmdReverse.UseVisualStyleBackColor = true;
            this.cmdReverse.Click += new System.EventHandler(this.cmdReverse_Click);
            // 
            // cmdReset
            // 
            this.cmdReset.Location = new System.Drawing.Point(339, 3);
            this.cmdReset.Name = "cmdReset";
            this.cmdReset.Size = new System.Drawing.Size(90, 28);
            this.cmdReset.TabIndex = 7;
            this.cmdReset.Text = "全て表示";
            this.cmdReset.UseVisualStyleBackColor = true;
            this.cmdReset.Click += new System.EventHandler(this.cmdReset_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCancel.Location = new System.Drawing.Point(360, 422);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(88, 28);
            this.cmdCancel.TabIndex = 2;
            this.cmdCancel.Text = "キャンセル";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.grdSeqItems, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(532, 404);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.combName);
            this.flowLayoutPanel1.Controls.Add(this.lblEqual);
            this.flowLayoutPanel1.Controls.Add(this.combItem);
            this.flowLayoutPanel1.Controls.Add(this.cmdSearch);
            this.flowLayoutPanel1.Controls.Add(this.cmdReset);
            this.flowLayoutPanel1.Controls.Add(this.cmdReverse);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(522, 36);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // frmEditSequence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 460);
            this.Controls.Add(this.cmdSet);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmEditSequence";
            this.Text = "シーケンス設定";
            this.Load += new System.EventHandler(this.frmEditSequence_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdSeqItems)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdSeqItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn SeqVAlue;
        private System.Windows.Forms.ComboBox combName;
        private System.Windows.Forms.ComboBox combItem;
        private System.Windows.Forms.Button cmdSearch;
        private System.Windows.Forms.Label lblEqual;
        private System.Windows.Forms.Button cmdSet;
        private System.Windows.Forms.Button cmdReverse;
        private System.Windows.Forms.Button cmdReset;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}