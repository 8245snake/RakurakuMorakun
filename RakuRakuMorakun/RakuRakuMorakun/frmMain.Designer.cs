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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menueFile = new System.Windows.Forms.ToolStripMenuItem();
            this.Save = new System.Windows.Forms.ToolStripMenuItem();
            this.Open = new System.Windows.Forms.ToolStripMenuItem();
            this.Setting = new System.Windows.Forms.ToolStripMenuItem();
            this.menueEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.InputAssist = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdDeleteSequence = new System.Windows.Forms.Button();
            this.cmdAddSequence = new System.Windows.Forms.Button();
            this.groupSequence = new System.Windows.Forms.GroupBox();
            this.groupCondition = new System.Windows.Forms.GroupBox();
            this.cmdConditionsSummary = new System.Windows.Forms.Button();
            this.txtExternal = new System.Windows.Forms.TextBox();
            this.cmdExternal = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.grdMain = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.AddRows = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.grdCondition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSequence)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupSequence.SuspendLayout();
            this.groupCondition.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMain)).BeginInit();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdAllGrayOut
            // 
            this.cmdAllGrayOut.Location = new System.Drawing.Point(119, 3);
            this.cmdAllGrayOut.Name = "cmdAllGrayOut";
            this.cmdAllGrayOut.Size = new System.Drawing.Size(118, 28);
            this.cmdAllGrayOut.TabIndex = 1;
            this.cmdAllGrayOut.Text = "空白セル無効化";
            this.cmdAllGrayOut.UseVisualStyleBackColor = true;
            this.cmdAllGrayOut.Click += new System.EventHandler(this.cmdAllGrayOut_Click);
            // 
            // cmdInvalid
            // 
            this.cmdInvalid.Location = new System.Drawing.Point(61, 3);
            this.cmdInvalid.Name = "cmdInvalid";
            this.cmdInvalid.Size = new System.Drawing.Size(52, 28);
            this.cmdInvalid.TabIndex = 2;
            this.cmdInvalid.Text = "無効";
            this.cmdInvalid.UseVisualStyleBackColor = true;
            this.cmdInvalid.Click += new System.EventHandler(this.cmdInvalid_Click);
            // 
            // cmdValid
            // 
            this.cmdValid.Location = new System.Drawing.Point(3, 3);
            this.cmdValid.Name = "cmdValid";
            this.cmdValid.Size = new System.Drawing.Size(52, 27);
            this.cmdValid.TabIndex = 3;
            this.cmdValid.Text = "有効";
            this.cmdValid.UseVisualStyleBackColor = true;
            this.cmdValid.Click += new System.EventHandler(this.cmdValid_Click);
            // 
            // cmdAddColumn
            // 
            this.cmdAddColumn.Location = new System.Drawing.Point(335, 3);
            this.cmdAddColumn.Name = "cmdAddColumn";
            this.cmdAddColumn.Size = new System.Drawing.Size(69, 27);
            this.cmdAddColumn.TabIndex = 4;
            this.cmdAddColumn.Text = "列追加";
            this.cmdAddColumn.UseVisualStyleBackColor = true;
            this.cmdAddColumn.Click += new System.EventHandler(this.cmdAddColumn_Click);
            // 
            // cmdDeleteColumn
            // 
            this.cmdDeleteColumn.Location = new System.Drawing.Point(410, 3);
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
            this.txtTemplate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTemplate.BackColor = System.Drawing.SystemColors.Control;
            this.txtTemplate.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtTemplate.ForeColor = System.Drawing.Color.Black;
            this.txtTemplate.Location = new System.Drawing.Point(12, 410);
            this.txtTemplate.Multiline = true;
            this.txtTemplate.Name = "txtTemplate";
            this.txtTemplate.Size = new System.Drawing.Size(1045, 148);
            this.txtTemplate.TabIndex = 7;
            this.txtTemplate.TextChanged += new System.EventHandler(this.txtTemplate_TextChanged);
            this.txtTemplate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTemplate_KeyDown);
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
            this.grdCondition.Location = new System.Drawing.Point(9, 52);
            this.grdCondition.MultiSelect = false;
            this.grdCondition.Name = "grdCondition";
            this.grdCondition.ReadOnly = true;
            this.grdCondition.RowHeadersVisible = false;
            this.grdCondition.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.grdCondition.RowTemplate.Height = 21;
            this.grdCondition.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdCondition.Size = new System.Drawing.Size(498, 120);
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
            this.cmdStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdStart.Location = new System.Drawing.Point(893, 564);
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
            this.lblCount.Location = new System.Drawing.Point(3, 349);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(130, 24);
            this.lblCount.TabIndex = 10;
            this.lblCount.Text = "網羅回数0000回";
            // 
            // cmdAddCondition
            // 
            this.cmdAddCondition.Location = new System.Drawing.Point(9, 18);
            this.cmdAddCondition.Name = "cmdAddCondition";
            this.cmdAddCondition.Size = new System.Drawing.Size(103, 28);
            this.cmdAddCondition.TabIndex = 11;
            this.cmdAddCondition.Text = "追加";
            this.cmdAddCondition.UseVisualStyleBackColor = true;
            this.cmdAddCondition.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // cmdDeleteCondition
            // 
            this.cmdDeleteCondition.Location = new System.Drawing.Point(118, 18);
            this.cmdDeleteCondition.Name = "cmdDeleteCondition";
            this.cmdDeleteCondition.Size = new System.Drawing.Size(103, 28);
            this.cmdDeleteCondition.TabIndex = 12;
            this.cmdDeleteCondition.Text = "削除";
            this.cmdDeleteCondition.UseVisualStyleBackColor = true;
            this.cmdDeleteCondition.Click += new System.EventHandler(this.cmdDeleteCondition_Click);
            // 
            // chkPreview
            // 
            this.chkPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkPreview.AutoSize = true;
            this.chkPreview.Location = new System.Drawing.Point(762, 570);
            this.chkPreview.Name = "chkPreview";
            this.chkPreview.Size = new System.Drawing.Size(92, 16);
            this.chkPreview.TabIndex = 13;
            this.chkPreview.Text = "プレビュー表示";
            this.chkPreview.UseVisualStyleBackColor = true;
            this.chkPreview.CheckedChanged += new System.EventHandler(this.chkPreview_CheckedChanged);
            // 
            // txtCellText
            // 
            this.txtCellText.Location = new System.Drawing.Point(3, 46);
            this.txtCellText.Name = "txtCellText";
            this.txtCellText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCellText.Size = new System.Drawing.Size(490, 19);
            this.txtCellText.TabIndex = 15;
            this.txtCellText.TextChanged += new System.EventHandler(this.txtCellText_TextChanged);
            // 
            // cmdMoveLeft
            // 
            this.cmdMoveLeft.Location = new System.Drawing.Point(243, 3);
            this.cmdMoveLeft.Name = "cmdMoveLeft";
            this.cmdMoveLeft.Size = new System.Drawing.Size(40, 27);
            this.cmdMoveLeft.TabIndex = 16;
            this.cmdMoveLeft.Text = "←";
            this.cmdMoveLeft.UseVisualStyleBackColor = true;
            this.cmdMoveLeft.Click += new System.EventHandler(this.cmdMoveLeft_Click);
            // 
            // cmdMoveRight
            // 
            this.cmdMoveRight.Location = new System.Drawing.Point(289, 3);
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
            this.grdSequence.Location = new System.Drawing.Point(9, 52);
            this.grdSequence.MultiSelect = false;
            this.grdSequence.Name = "grdSequence";
            this.grdSequence.RowHeadersVisible = false;
            this.grdSequence.RowTemplate.Height = 21;
            this.grdSequence.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdSequence.Size = new System.Drawing.Size(498, 97);
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
            this.SeqValue.Width = 400;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menueFile,
            this.menueEdit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1068, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menueFile
            // 
            this.menueFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Save,
            this.Open,
            this.Setting});
            this.menueFile.Name = "menueFile";
            this.menueFile.Size = new System.Drawing.Size(53, 20);
            this.menueFile.Text = "ファイル";
            // 
            // Save
            // 
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(98, 22);
            this.Save.Text = "保存";
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Open
            // 
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(98, 22);
            this.Open.Text = "開く";
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // Setting
            // 
            this.Setting.Name = "Setting";
            this.Setting.Size = new System.Drawing.Size(98, 22);
            this.Setting.Text = "設定";
            this.Setting.Click += new System.EventHandler(this.Setting_Click);
            // 
            // menueEdit
            // 
            this.menueEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InputAssist,
            this.AddRows});
            this.menueEdit.Name = "menueEdit";
            this.menueEdit.Size = new System.Drawing.Size(43, 20);
            this.menueEdit.Text = "編集";
            // 
            // InputAssist
            // 
            this.InputAssist.Name = "InputAssist";
            this.InputAssist.Size = new System.Drawing.Size(180, 22);
            this.InputAssist.Text = "入力支援";
            this.InputAssist.Click += new System.EventHandler(this.InputAssist_Click);
            // 
            // cmdDeleteSequence
            // 
            this.cmdDeleteSequence.Location = new System.Drawing.Point(118, 18);
            this.cmdDeleteSequence.Name = "cmdDeleteSequence";
            this.cmdDeleteSequence.Size = new System.Drawing.Size(103, 28);
            this.cmdDeleteSequence.TabIndex = 22;
            this.cmdDeleteSequence.Text = "削除";
            this.cmdDeleteSequence.UseVisualStyleBackColor = true;
            this.cmdDeleteSequence.Click += new System.EventHandler(this.cmdDeleteSequence_Click);
            // 
            // cmdAddSequence
            // 
            this.cmdAddSequence.Location = new System.Drawing.Point(9, 18);
            this.cmdAddSequence.Name = "cmdAddSequence";
            this.cmdAddSequence.Size = new System.Drawing.Size(103, 28);
            this.cmdAddSequence.TabIndex = 21;
            this.cmdAddSequence.Text = "追加";
            this.cmdAddSequence.UseVisualStyleBackColor = true;
            this.cmdAddSequence.Click += new System.EventHandler(this.cmdAddSequence_Click);
            // 
            // groupSequence
            // 
            this.groupSequence.AutoSize = true;
            this.groupSequence.Controls.Add(this.cmdDeleteSequence);
            this.groupSequence.Controls.Add(this.cmdAddSequence);
            this.groupSequence.Controls.Add(this.grdSequence);
            this.groupSequence.Location = new System.Drawing.Point(3, 3);
            this.groupSequence.Name = "groupSequence";
            this.groupSequence.Size = new System.Drawing.Size(513, 167);
            this.groupSequence.TabIndex = 23;
            this.groupSequence.TabStop = false;
            this.groupSequence.Text = "シーケンス";
            // 
            // groupCondition
            // 
            this.groupCondition.AutoSize = true;
            this.groupCondition.Controls.Add(this.cmdConditionsSummary);
            this.groupCondition.Controls.Add(this.cmdDeleteCondition);
            this.groupCondition.Controls.Add(this.cmdAddCondition);
            this.groupCondition.Controls.Add(this.grdCondition);
            this.groupCondition.Location = new System.Drawing.Point(3, 176);
            this.groupCondition.Name = "groupCondition";
            this.groupCondition.Size = new System.Drawing.Size(513, 190);
            this.groupCondition.TabIndex = 24;
            this.groupCondition.TabStop = false;
            this.groupCondition.Text = "条件付き文字列";
            // 
            // cmdConditionsSummary
            // 
            this.cmdConditionsSummary.Location = new System.Drawing.Point(227, 18);
            this.cmdConditionsSummary.Name = "cmdConditionsSummary";
            this.cmdConditionsSummary.Size = new System.Drawing.Size(103, 28);
            this.cmdConditionsSummary.TabIndex = 13;
            this.cmdConditionsSummary.Text = "サマリー表示";
            this.cmdConditionsSummary.UseVisualStyleBackColor = true;
            this.cmdConditionsSummary.Click += new System.EventHandler(this.cmdConditionsSummary_Click);
            // 
            // txtExternal
            // 
            this.txtExternal.AcceptsReturn = true;
            this.txtExternal.AcceptsTab = true;
            this.txtExternal.Location = new System.Drawing.Point(-3000, -3000);
            this.txtExternal.Multiline = true;
            this.txtExternal.Name = "txtExternal";
            this.txtExternal.Size = new System.Drawing.Size(235, 36);
            this.txtExternal.TabIndex = 25;
            this.txtExternal.TextChanged += new System.EventHandler(this.txtExternal_TextChanged);
            // 
            // cmdExternal
            // 
            this.cmdExternal.Location = new System.Drawing.Point(-3000, -3000);
            this.cmdExternal.Name = "cmdExternal";
            this.cmdExternal.Size = new System.Drawing.Size(75, 23);
            this.cmdExternal.TabIndex = 26;
            this.cmdExternal.Text = "button1";
            this.cmdExternal.UseVisualStyleBackColor = true;
            this.cmdExternal.Click += new System.EventHandler(this.cmdExternal_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.cmdValid);
            this.flowLayoutPanel1.Controls.Add(this.cmdInvalid);
            this.flowLayoutPanel1.Controls.Add(this.cmdAllGrayOut);
            this.flowLayoutPanel1.Controls.Add(this.cmdMoveLeft);
            this.flowLayoutPanel1.Controls.Add(this.cmdMoveRight);
            this.flowLayoutPanel1.Controls.Add(this.cmdAddColumn);
            this.flowLayoutPanel1.Controls.Add(this.cmdDeleteColumn);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(483, 37);
            this.flowLayoutPanel1.TabIndex = 27;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel1);
            this.flowLayoutPanel2.Controls.Add(this.txtCellText);
            this.flowLayoutPanel2.Controls.Add(this.grdMain);
            this.flowLayoutPanel2.Controls.Add(this.lblCount);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(12, 27);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(505, 377);
            this.flowLayoutPanel2.TabIndex = 29;
            // 
            // grdMain
            // 
            this.grdMain.AllowUserToDeleteRows = false;
            this.grdMain.AllowUserToResizeColumns = false;
            this.grdMain.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdMain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.grdMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMain.Location = new System.Drawing.Point(3, 71);
            this.grdMain.Name = "grdMain";
            this.grdMain.RowHeadersWidth = 60;
            this.grdMain.RowTemplate.Height = 21;
            this.grdMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.grdMain.Size = new System.Drawing.Size(490, 275);
            this.grdMain.TabIndex = 28;
            this.grdMain.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.grdMain_RowsAdded);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.groupSequence);
            this.flowLayoutPanel3.Controls.Add(this.groupCondition);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(534, 27);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(523, 377);
            this.flowLayoutPanel3.TabIndex = 30;
            // 
            // AddRows
            // 
            this.AddRows.Name = "AddRows";
            this.AddRows.Size = new System.Drawing.Size(180, 22);
            this.AddRows.Text = "行を追加";
            this.AddRows.Click += new System.EventHandler(this.AddRows_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1068, 598);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.chkPreview);
            this.Controls.Add(this.cmdStart);
            this.Controls.Add(this.txtTemplate);
            this.Controls.Add(this.txtExternal);
            this.Controls.Add(this.cmdExternal);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "らくらく網羅くんV2";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdCondition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSequence)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupSequence.ResumeLayout(false);
            this.groupCondition.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMain)).EndInit();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menueFile;
        private System.Windows.Forms.ToolStripMenuItem Save;
        private System.Windows.Forms.ToolStripMenuItem Open;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConditionName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Condition;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrueText;
        private System.Windows.Forms.DataGridViewTextBoxColumn FalseText;
        private System.Windows.Forms.Button cmdDeleteSequence;
        private System.Windows.Forms.Button cmdAddSequence;
        private System.Windows.Forms.ToolStripMenuItem menueEdit;
        private System.Windows.Forms.ToolStripMenuItem InputAssist;
        private System.Windows.Forms.DataGridViewTextBoxColumn SeqName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SeqValue;
        private System.Windows.Forms.GroupBox groupSequence;
        private System.Windows.Forms.GroupBox groupCondition;
        private System.Windows.Forms.TextBox txtExternal;
        private System.Windows.Forms.Button cmdExternal;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.DataGridView grdMain;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.ToolStripMenuItem Setting;
        private System.Windows.Forms.Button cmdConditionsSummary;
        private System.Windows.Forms.ToolStripMenuItem AddRows;
    }
}