namespace RakuRakuMorakun
{
    partial class frmMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grdMain = new System.Windows.Forms.DataGridView();
            this.cmdAllGrayOut = new System.Windows.Forms.Button();
            this.cmdInvalid = new System.Windows.Forms.Button();
            this.cmdValid = new System.Windows.Forms.Button();
            this.cmdAddColumn = new System.Windows.Forms.Button();
            this.cmdDeleteColumn = new System.Windows.Forms.Button();
            this.cmdAllEnabled = new System.Windows.Forms.Button();
            this.txtTemplate = new System.Windows.Forms.TextBox();
            this.grdCondition = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Condition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.True = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.False = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdStart = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.cmdAddCondition = new System.Windows.Forms.Button();
            this.cmdDeleteCondition = new System.Windows.Forms.Button();
            this.chkPreview = new System.Windows.Forms.CheckBox();
            this.cmdValidAll = new System.Windows.Forms.Button();
            this.txtCellText = new System.Windows.Forms.TextBox();
            this.cmdMoveLeft = new System.Windows.Forms.Button();
            this.cmdMoveRight = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCondition)).BeginInit();
            this.SuspendLayout();
            // 
            // grdMain
            // 
            this.grdMain.AllowUserToDeleteRows = false;
            this.grdMain.AllowUserToResizeColumns = false;
            this.grdMain.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdMain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMain.Location = new System.Drawing.Point(12, 112);
            this.grdMain.Name = "grdMain";
            this.grdMain.RowHeadersVisible = false;
            this.grdMain.RowTemplate.Height = 21;
            this.grdMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.grdMain.Size = new System.Drawing.Size(404, 302);
            this.grdMain.TabIndex = 0;
            this.grdMain.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.grdMain_CellBeginEdit);
            this.grdMain.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdMain_CellClick);
            this.grdMain.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdMain_CellEndEdit);
            this.grdMain.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdMain_CellEnter);
            this.grdMain.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.grdMain_EditingControlShowing);
            this.grdMain.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdMain_KeyDown);
            // 
            // cmdAllGrayOut
            // 
            this.cmdAllGrayOut.Location = new System.Drawing.Point(105, 51);
            this.cmdAllGrayOut.Name = "cmdAllGrayOut";
            this.cmdAllGrayOut.Size = new System.Drawing.Size(172, 28);
            this.cmdAllGrayOut.TabIndex = 1;
            this.cmdAllGrayOut.Text = "全ての空白セルを無効化する";
            this.cmdAllGrayOut.UseVisualStyleBackColor = true;
            this.cmdAllGrayOut.Click += new System.EventHandler(this.cmdAllGrayOut_Click);
            // 
            // cmdInvalid
            // 
            this.cmdInvalid.Location = new System.Drawing.Point(12, 51);
            this.cmdInvalid.Name = "cmdInvalid";
            this.cmdInvalid.Size = new System.Drawing.Size(84, 28);
            this.cmdInvalid.TabIndex = 2;
            this.cmdInvalid.Text = "無効化";
            this.cmdInvalid.UseVisualStyleBackColor = true;
            this.cmdInvalid.Click += new System.EventHandler(this.cmdInvalid_Click);
            // 
            // cmdValid
            // 
            this.cmdValid.Location = new System.Drawing.Point(12, 18);
            this.cmdValid.Name = "cmdValid";
            this.cmdValid.Size = new System.Drawing.Size(84, 27);
            this.cmdValid.TabIndex = 3;
            this.cmdValid.Text = "有効化";
            this.cmdValid.UseVisualStyleBackColor = true;
            this.cmdValid.Click += new System.EventHandler(this.cmdValid_Click);
            // 
            // cmdAddColumn
            // 
            this.cmdAddColumn.Location = new System.Drawing.Point(283, 18);
            this.cmdAddColumn.Name = "cmdAddColumn";
            this.cmdAddColumn.Size = new System.Drawing.Size(89, 29);
            this.cmdAddColumn.TabIndex = 4;
            this.cmdAddColumn.Text = "列追加";
            this.cmdAddColumn.UseVisualStyleBackColor = true;
            this.cmdAddColumn.Click += new System.EventHandler(this.cmdAddColumn_Click);
            // 
            // cmdDeleteColumn
            // 
            this.cmdDeleteColumn.Location = new System.Drawing.Point(283, 51);
            this.cmdDeleteColumn.Name = "cmdDeleteColumn";
            this.cmdDeleteColumn.Size = new System.Drawing.Size(89, 28);
            this.cmdDeleteColumn.TabIndex = 5;
            this.cmdDeleteColumn.Text = "列削除";
            this.cmdDeleteColumn.UseVisualStyleBackColor = true;
            this.cmdDeleteColumn.Click += new System.EventHandler(this.cmdDeleteColumn_Click);
            // 
            // cmdAllEnabled
            // 
            this.cmdAllEnabled.Location = new System.Drawing.Point(105, 18);
            this.cmdAllEnabled.Name = "cmdAllEnabled";
            this.cmdAllEnabled.Size = new System.Drawing.Size(172, 26);
            this.cmdAllEnabled.TabIndex = 6;
            this.cmdAllEnabled.Text = "空白セル以外を有効化";
            this.cmdAllEnabled.UseVisualStyleBackColor = true;
            this.cmdAllEnabled.Click += new System.EventHandler(this.cmdAllEnabled_Click);
            // 
            // txtTemplate
            // 
            this.txtTemplate.AcceptsReturn = true;
            this.txtTemplate.AcceptsTab = true;
            this.txtTemplate.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtTemplate.Location = new System.Drawing.Point(439, 236);
            this.txtTemplate.Multiline = true;
            this.txtTemplate.Name = "txtTemplate";
            this.txtTemplate.Size = new System.Drawing.Size(624, 178);
            this.txtTemplate.TabIndex = 7;
            this.txtTemplate.TextChanged += new System.EventHandler(this.txtTemplate_TextChanged);
            // 
            // grdCondition
            // 
            this.grdCondition.AllowUserToAddRows = false;
            this.grdCondition.AllowUserToDeleteRows = false;
            this.grdCondition.AllowUserToResizeColumns = false;
            this.grdCondition.AllowUserToResizeRows = false;
            this.grdCondition.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCondition.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.Condition,
            this.True,
            this.False});
            this.grdCondition.Location = new System.Drawing.Point(439, 85);
            this.grdCondition.MultiSelect = false;
            this.grdCondition.Name = "grdCondition";
            this.grdCondition.ReadOnly = true;
            this.grdCondition.RowHeadersVisible = false;
            this.grdCondition.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.grdCondition.RowTemplate.Height = 21;
            this.grdCondition.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdCondition.Size = new System.Drawing.Size(624, 145);
            this.grdCondition.TabIndex = 8;
            this.grdCondition.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCondition_CellDoubleClick);
            // 
            // Name
            // 
            this.Name.HeaderText = "名前";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            // 
            // Condition
            // 
            this.Condition.HeaderText = "条件";
            this.Condition.Name = "Condition";
            this.Condition.ReadOnly = true;
            this.Condition.Width = 300;
            // 
            // True
            // 
            this.True.HeaderText = "Trueのとき";
            this.True.Name = "True";
            this.True.ReadOnly = true;
            // 
            // False
            // 
            this.False.HeaderText = "Falseのとき";
            this.False.Name = "False";
            this.False.ReadOnly = true;
            // 
            // cmdStart
            // 
            this.cmdStart.Location = new System.Drawing.Point(899, 434);
            this.cmdStart.Name = "cmdStart";
            this.cmdStart.Size = new System.Drawing.Size(164, 27);
            this.cmdStart.TabIndex = 9;
            this.cmdStart.Text = "開始";
            this.cmdStart.UseVisualStyleBackColor = true;
            this.cmdStart.Click += new System.EventHandler(this.cmdStart_Click);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblCount.Location = new System.Drawing.Point(296, 426);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(120, 24);
            this.lblCount.TabIndex = 10;
            this.lblCount.Text = "網羅回数000回";
            // 
            // cmdAddCondition
            // 
            this.cmdAddCondition.Location = new System.Drawing.Point(439, 51);
            this.cmdAddCondition.Name = "cmdAddCondition";
            this.cmdAddCondition.Size = new System.Drawing.Size(103, 28);
            this.cmdAddCondition.TabIndex = 11;
            this.cmdAddCondition.Text = "追加";
            this.cmdAddCondition.UseVisualStyleBackColor = true;
            this.cmdAddCondition.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // cmdDeleteCondition
            // 
            this.cmdDeleteCondition.Location = new System.Drawing.Point(548, 51);
            this.cmdDeleteCondition.Name = "cmdDeleteCondition";
            this.cmdDeleteCondition.Size = new System.Drawing.Size(103, 28);
            this.cmdDeleteCondition.TabIndex = 12;
            this.cmdDeleteCondition.Text = "削除";
            this.cmdDeleteCondition.UseVisualStyleBackColor = true;
            this.cmdDeleteCondition.Click += new System.EventHandler(this.cmdDeleteCondition_Click);
            // 
            // chkPreview
            // 
            this.chkPreview.AutoSize = true;
            this.chkPreview.Location = new System.Drawing.Point(439, 434);
            this.chkPreview.Name = "chkPreview";
            this.chkPreview.Size = new System.Drawing.Size(92, 16);
            this.chkPreview.TabIndex = 13;
            this.chkPreview.Text = "プレビュー表示";
            this.chkPreview.UseVisualStyleBackColor = true;
            this.chkPreview.CheckedChanged += new System.EventHandler(this.chkPreview_CheckedChanged);
            // 
            // cmdValidAll
            // 
            this.cmdValidAll.Location = new System.Drawing.Point(392, 16);
            this.cmdValidAll.Name = "cmdValidAll";
            this.cmdValidAll.Size = new System.Drawing.Size(95, 27);
            this.cmdValidAll.TabIndex = 14;
            this.cmdValidAll.Text = "全て有効化";
            this.cmdValidAll.UseVisualStyleBackColor = true;
            this.cmdValidAll.Click += new System.EventHandler(this.cmdValidAll_Click);
            // 
            // txtCellText
            // 
            this.txtCellText.Location = new System.Drawing.Point(12, 87);
            this.txtCellText.Name = "txtCellText";
            this.txtCellText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCellText.Size = new System.Drawing.Size(404, 19);
            this.txtCellText.TabIndex = 15;
            this.txtCellText.TextChanged += new System.EventHandler(this.txtCellText_TextChanged);
            // 
            // cmdMoveLeft
            // 
            this.cmdMoveLeft.Location = new System.Drawing.Point(493, 16);
            this.cmdMoveLeft.Name = "cmdMoveLeft";
            this.cmdMoveLeft.Size = new System.Drawing.Size(57, 27);
            this.cmdMoveLeft.TabIndex = 16;
            this.cmdMoveLeft.Text = "←";
            this.cmdMoveLeft.UseVisualStyleBackColor = true;
            this.cmdMoveLeft.Click += new System.EventHandler(this.cmdMoveLeft_Click);
            // 
            // cmdMoveRight
            // 
            this.cmdMoveRight.Location = new System.Drawing.Point(556, 17);
            this.cmdMoveRight.Name = "cmdMoveRight";
            this.cmdMoveRight.Size = new System.Drawing.Size(63, 27);
            this.cmdMoveRight.TabIndex = 17;
            this.cmdMoveRight.Text = "→";
            this.cmdMoveRight.UseVisualStyleBackColor = true;
            this.cmdMoveRight.Click += new System.EventHandler(this.cmdMoveRight_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 482);
            this.Controls.Add(this.cmdMoveRight);
            this.Controls.Add(this.cmdMoveLeft);
            this.Controls.Add(this.txtCellText);
            this.Controls.Add(this.cmdValidAll);
            this.Controls.Add(this.chkPreview);
            this.Controls.Add(this.cmdDeleteCondition);
            this.Controls.Add(this.cmdAddCondition);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.cmdStart);
            this.Controls.Add(this.grdCondition);
            this.Controls.Add(this.txtTemplate);
            this.Controls.Add(this.cmdAllEnabled);
            this.Controls.Add(this.cmdDeleteColumn);
            this.Controls.Add(this.cmdAddColumn);
            this.Controls.Add(this.cmdValid);
            this.Controls.Add(this.cmdInvalid);
            this.Controls.Add(this.cmdAllGrayOut);
            this.Controls.Add(this.grdMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Text = "らくらく網羅くんV2";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCondition)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdMain;
        private System.Windows.Forms.Button cmdAllGrayOut;
        private System.Windows.Forms.Button cmdInvalid;
        private System.Windows.Forms.Button cmdValid;
        private System.Windows.Forms.Button cmdAddColumn;
        private System.Windows.Forms.Button cmdDeleteColumn;
        private System.Windows.Forms.Button cmdAllEnabled;
        private System.Windows.Forms.TextBox txtTemplate;
        private System.Windows.Forms.DataGridView grdCondition;
        private System.Windows.Forms.Button cmdStart;
        private System.Windows.Forms.Label lblCount;
        private new System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Condition;
        private System.Windows.Forms.DataGridViewTextBoxColumn True;
        private System.Windows.Forms.DataGridViewTextBoxColumn False;
        private System.Windows.Forms.Button cmdAddCondition;
        private System.Windows.Forms.Button cmdDeleteCondition;
        private System.Windows.Forms.CheckBox chkPreview;
        private System.Windows.Forms.Button cmdValidAll;
        private System.Windows.Forms.TextBox txtCellText;
        private System.Windows.Forms.Button cmdMoveLeft;
        private System.Windows.Forms.Button cmdMoveRight;
    }
}