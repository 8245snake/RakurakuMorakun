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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grdMain = new System.Windows.Forms.DataGridView();
            this.cmdAllGrayOut = new System.Windows.Forms.Button();
            this.cmdInvalid = new System.Windows.Forms.Button();
            this.cmdValid = new System.Windows.Forms.Button();
            this.cmdAddColumn = new System.Windows.Forms.Button();
            this.cmdDeleteColumn = new System.Windows.Forms.Button();
            this.txtTemplate = new System.Windows.Forms.TextBox();
            this.grdCondition = new System.Windows.Forms.DataGridView();
            this.ConditionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Condition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrueText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FalseText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdStart = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.cmdAddCondition = new System.Windows.Forms.Button();
            this.cmdDeleteCondition = new System.Windows.Forms.Button();
            this.chkPreview = new System.Windows.Forms.CheckBox();
            this.txtCellText = new System.Windows.Forms.TextBox();
            this.cmdMoveLeft = new System.Windows.Forms.Button();
            this.cmdMoveRight = new System.Windows.Forms.Button();
            this.grdSequence = new System.Windows.Forms.DataGridView();
            this.SeqName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SeqValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ファイルToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.開くToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdDeleteSequence = new System.Windows.Forms.Button();
            this.cmdAddSequence = new System.Windows.Forms.Button();
            this.編集ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.入力支援ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.grdMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCondition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSequence)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdMain
            // 
            this.grdMain.AllowUserToDeleteRows = false;
            this.grdMain.AllowUserToResizeColumns = false;
            this.grdMain.AllowUserToResizeRows = false;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdMain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.grdMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMain.Location = new System.Drawing.Point(12, 99);
            this.grdMain.Name = "grdMain";
            this.grdMain.RowHeadersVisible = false;
            this.grdMain.RowTemplate.Height = 21;
            this.grdMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.grdMain.Size = new System.Drawing.Size(473, 269);
            this.grdMain.TabIndex = 0;
            this.grdMain.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.grdMain_CellBeginEdit);
            this.grdMain.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdMain_CellClick);
            this.grdMain.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdMain_CellEndEdit);
            this.grdMain.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdMain_CellEnter);
            this.grdMain.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.grdMain_EditingControlShowing);
            this.grdMain.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.grdMain_RowsAdded);
            this.grdMain.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdMain_KeyDown);
            // 
            // cmdAllGrayOut
            // 
            this.cmdAllGrayOut.Location = new System.Drawing.Point(128, 39);
            this.cmdAllGrayOut.Name = "cmdAllGrayOut";
            this.cmdAllGrayOut.Size = new System.Drawing.Size(118, 28);
            this.cmdAllGrayOut.TabIndex = 1;
            this.cmdAllGrayOut.Text = "空白セル無効化";
            this.cmdAllGrayOut.UseVisualStyleBackColor = true;
            this.cmdAllGrayOut.Click += new System.EventHandler(this.cmdAllGrayOut_Click);
            // 
            // cmdInvalid
            // 
            this.cmdInvalid.Location = new System.Drawing.Point(70, 40);
            this.cmdInvalid.Name = "cmdInvalid";
            this.cmdInvalid.Size = new System.Drawing.Size(52, 28);
            this.cmdInvalid.TabIndex = 2;
            this.cmdInvalid.Text = "無効";
            this.cmdInvalid.UseVisualStyleBackColor = true;
            this.cmdInvalid.Click += new System.EventHandler(this.cmdInvalid_Click);
            // 
            // cmdValid
            // 
            this.cmdValid.Location = new System.Drawing.Point(12, 40);
            this.cmdValid.Name = "cmdValid";
            this.cmdValid.Size = new System.Drawing.Size(52, 27);
            this.cmdValid.TabIndex = 3;
            this.cmdValid.Text = "有効";
            this.cmdValid.UseVisualStyleBackColor = true;
            this.cmdValid.Click += new System.EventHandler(this.cmdValid_Click);
            // 
            // cmdAddColumn
            // 
            this.cmdAddColumn.Location = new System.Drawing.Point(346, 40);
            this.cmdAddColumn.Name = "cmdAddColumn";
            this.cmdAddColumn.Size = new System.Drawing.Size(69, 27);
            this.cmdAddColumn.TabIndex = 4;
            this.cmdAddColumn.Text = "列追加";
            this.cmdAddColumn.UseVisualStyleBackColor = true;
            this.cmdAddColumn.Click += new System.EventHandler(this.cmdAddColumn_Click);
            // 
            // cmdDeleteColumn
            // 
            this.cmdDeleteColumn.Location = new System.Drawing.Point(421, 39);
            this.cmdDeleteColumn.Name = "cmdDeleteColumn";
            this.cmdDeleteColumn.Size = new System.Drawing.Size(64, 28);
            this.cmdDeleteColumn.TabIndex = 5;
            this.cmdDeleteColumn.Text = "列削除";
            this.cmdDeleteColumn.UseVisualStyleBackColor = true;
            this.cmdDeleteColumn.Click += new System.EventHandler(this.cmdDeleteColumn_Click);
            // 
            // txtTemplate
            // 
            this.txtTemplate.AcceptsReturn = true;
            this.txtTemplate.AcceptsTab = true;
            this.txtTemplate.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtTemplate.Location = new System.Drawing.Point(12, 401);
            this.txtTemplate.Multiline = true;
            this.txtTemplate.Name = "txtTemplate";
            this.txtTemplate.Size = new System.Drawing.Size(974, 232);
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
            this.ConditionName,
            this.Condition,
            this.TrueText,
            this.FalseText});
            this.grdCondition.Location = new System.Drawing.Point(507, 250);
            this.grdCondition.MultiSelect = false;
            this.grdCondition.Name = "grdCondition";
            this.grdCondition.ReadOnly = true;
            this.grdCondition.RowHeadersVisible = false;
            this.grdCondition.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.grdCondition.RowTemplate.Height = 21;
            this.grdCondition.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdCondition.Size = new System.Drawing.Size(492, 145);
            this.grdCondition.TabIndex = 8;
            this.grdCondition.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCondition_CellDoubleClick);
            // 
            // ConditionName
            // 
            this.ConditionName.HeaderText = "名前";
            this.ConditionName.Name = "ConditionName";
            this.ConditionName.ReadOnly = true;
            this.ConditionName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ConditionName.Width = 70;
            // 
            // Condition
            // 
            this.Condition.HeaderText = "条件";
            this.Condition.Name = "Condition";
            this.Condition.ReadOnly = true;
            this.Condition.Width = 200;
            // 
            // TrueText
            // 
            this.TrueText.HeaderText = "Trueのとき";
            this.TrueText.Name = "TrueText";
            this.TrueText.ReadOnly = true;
            // 
            // FalseText
            // 
            this.FalseText.HeaderText = "Falseのとき";
            this.FalseText.Name = "FalseText";
            this.FalseText.ReadOnly = true;
            // 
            // cmdStart
            // 
            this.cmdStart.Location = new System.Drawing.Point(822, 648);
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
            this.lblCount.Location = new System.Drawing.Point(12, 371);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(130, 24);
            this.lblCount.TabIndex = 10;
            this.lblCount.Text = "網羅回数0000回";
            // 
            // cmdAddCondition
            // 
            this.cmdAddCondition.Location = new System.Drawing.Point(507, 216);
            this.cmdAddCondition.Name = "cmdAddCondition";
            this.cmdAddCondition.Size = new System.Drawing.Size(103, 28);
            this.cmdAddCondition.TabIndex = 11;
            this.cmdAddCondition.Text = "追加";
            this.cmdAddCondition.UseVisualStyleBackColor = true;
            this.cmdAddCondition.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // cmdDeleteCondition
            // 
            this.cmdDeleteCondition.Location = new System.Drawing.Point(616, 216);
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
            this.chkPreview.Location = new System.Drawing.Point(528, 654);
            this.chkPreview.Name = "chkPreview";
            this.chkPreview.Size = new System.Drawing.Size(92, 16);
            this.chkPreview.TabIndex = 13;
            this.chkPreview.Text = "プレビュー表示";
            this.chkPreview.UseVisualStyleBackColor = true;
            this.chkPreview.CheckedChanged += new System.EventHandler(this.chkPreview_CheckedChanged);
            // 
            // txtCellText
            // 
            this.txtCellText.Location = new System.Drawing.Point(12, 74);
            this.txtCellText.Name = "txtCellText";
            this.txtCellText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCellText.Size = new System.Drawing.Size(473, 19);
            this.txtCellText.TabIndex = 15;
            this.txtCellText.TextChanged += new System.EventHandler(this.txtCellText_TextChanged);
            // 
            // cmdMoveLeft
            // 
            this.cmdMoveLeft.Location = new System.Drawing.Point(253, 40);
            this.cmdMoveLeft.Name = "cmdMoveLeft";
            this.cmdMoveLeft.Size = new System.Drawing.Size(40, 27);
            this.cmdMoveLeft.TabIndex = 16;
            this.cmdMoveLeft.Text = "←";
            this.cmdMoveLeft.UseVisualStyleBackColor = true;
            this.cmdMoveLeft.Click += new System.EventHandler(this.cmdMoveLeft_Click);
            // 
            // cmdMoveRight
            // 
            this.cmdMoveRight.Location = new System.Drawing.Point(300, 40);
            this.cmdMoveRight.Name = "cmdMoveRight";
            this.cmdMoveRight.Size = new System.Drawing.Size(40, 27);
            this.cmdMoveRight.TabIndex = 17;
            this.cmdMoveRight.Text = "→";
            this.cmdMoveRight.UseVisualStyleBackColor = true;
            this.cmdMoveRight.Click += new System.EventHandler(this.cmdMoveRight_Click);
            // 
            // grdSequence
            // 
            this.grdSequence.AllowUserToAddRows = false;
            this.grdSequence.AllowUserToDeleteRows = false;
            this.grdSequence.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSequence.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SeqName,
            this.SeqValue});
            this.grdSequence.Location = new System.Drawing.Point(504, 74);
            this.grdSequence.MultiSelect = false;
            this.grdSequence.Name = "grdSequence";
            this.grdSequence.RowHeadersVisible = false;
            this.grdSequence.RowTemplate.Height = 21;
            this.grdSequence.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdSequence.Size = new System.Drawing.Size(495, 115);
            this.grdSequence.TabIndex = 18;
            this.grdSequence.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdSequence_CellDoubleClick);
            // 
            // SeqName
            // 
            this.SeqName.HeaderText = "名前";
            this.SeqName.Name = "SeqName";
            this.SeqName.ReadOnly = true;
            this.SeqName.Width = 70;
            // 
            // SeqValue
            // 
            this.SeqValue.HeaderText = "値";
            this.SeqValue.Name = "SeqValue";
            this.SeqValue.ReadOnly = true;
            this.SeqValue.Width = 300;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルToolStripMenuItem,
            this.編集ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1011, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ファイルToolStripMenuItem
            // 
            this.ファイルToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.保存ToolStripMenuItem,
            this.開くToolStripMenuItem});
            this.ファイルToolStripMenuItem.Name = "ファイルToolStripMenuItem";
            this.ファイルToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ファイルToolStripMenuItem.Text = "ファイル";
            // 
            // 保存ToolStripMenuItem
            // 
            this.保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            this.保存ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.保存ToolStripMenuItem.Text = "保存";
            // 
            // 開くToolStripMenuItem
            // 
            this.開くToolStripMenuItem.Name = "開くToolStripMenuItem";
            this.開くToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.開くToolStripMenuItem.Text = "開く";
            // 
            // cmdDeleteSequence
            // 
            this.cmdDeleteSequence.Location = new System.Drawing.Point(613, 42);
            this.cmdDeleteSequence.Name = "cmdDeleteSequence";
            this.cmdDeleteSequence.Size = new System.Drawing.Size(103, 28);
            this.cmdDeleteSequence.TabIndex = 22;
            this.cmdDeleteSequence.Text = "削除";
            this.cmdDeleteSequence.UseVisualStyleBackColor = true;
            this.cmdDeleteSequence.Click += new System.EventHandler(this.cmdDeleteSequence_Click);
            // 
            // cmdAddSequence
            // 
            this.cmdAddSequence.Location = new System.Drawing.Point(504, 42);
            this.cmdAddSequence.Name = "cmdAddSequence";
            this.cmdAddSequence.Size = new System.Drawing.Size(103, 28);
            this.cmdAddSequence.TabIndex = 21;
            this.cmdAddSequence.Text = "追加";
            this.cmdAddSequence.UseVisualStyleBackColor = true;
            this.cmdAddSequence.Click += new System.EventHandler(this.cmdAddSequence_Click);
            // 
            // 編集ToolStripMenuItem
            // 
            this.編集ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.入力支援ToolStripMenuItem});
            this.編集ToolStripMenuItem.Name = "編集ToolStripMenuItem";
            this.編集ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.編集ToolStripMenuItem.Text = "編集";
            // 
            // 入力支援ToolStripMenuItem
            // 
            this.入力支援ToolStripMenuItem.Name = "入力支援ToolStripMenuItem";
            this.入力支援ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.入力支援ToolStripMenuItem.Text = "入力支援";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 682);
            this.Controls.Add(this.cmdDeleteSequence);
            this.Controls.Add(this.cmdAddSequence);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.grdSequence);
            this.Controls.Add(this.cmdMoveRight);
            this.Controls.Add(this.cmdMoveLeft);
            this.Controls.Add(this.txtCellText);
            this.Controls.Add(this.chkPreview);
            this.Controls.Add(this.cmdDeleteCondition);
            this.Controls.Add(this.cmdAddCondition);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.cmdStart);
            this.Controls.Add(this.grdCondition);
            this.Controls.Add(this.txtTemplate);
            this.Controls.Add(this.cmdDeleteColumn);
            this.Controls.Add(this.cmdAddColumn);
            this.Controls.Add(this.cmdValid);
            this.Controls.Add(this.cmdInvalid);
            this.Controls.Add(this.cmdAllGrayOut);
            this.Controls.Add(this.grdMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "らくらく網羅くんV2";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCondition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSequence)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.TextBox txtTemplate;
        private System.Windows.Forms.DataGridView grdCondition;
        private System.Windows.Forms.Button cmdStart;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Button cmdAddCondition;
        private System.Windows.Forms.Button cmdDeleteCondition;
        private System.Windows.Forms.CheckBox chkPreview;
        private System.Windows.Forms.TextBox txtCellText;
        private System.Windows.Forms.Button cmdMoveLeft;
        private System.Windows.Forms.Button cmdMoveRight;
        private System.Windows.Forms.DataGridView grdSequence;
        private System.Windows.Forms.DataGridViewTextBoxColumn SeqName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SeqValue;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ファイルToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 開くToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConditionName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Condition;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrueText;
        private System.Windows.Forms.DataGridViewTextBoxColumn FalseText;
        private System.Windows.Forms.Button cmdDeleteSequence;
        private System.Windows.Forms.Button cmdAddSequence;
        private System.Windows.Forms.ToolStripMenuItem 編集ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 入力支援ToolStripMenuItem;
    }
}