namespace RakuRakuMorakun
{
    partial class frmEditCondition
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditCondition));
            this.cmdSet = new System.Windows.Forms.Button();
            this.combCondition = new System.Windows.Forms.ComboBox();
            this.lblGa = new System.Windows.Forms.Label();
            this.combItem = new System.Windows.Forms.ComboBox();
            this.combOperator = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.optIterator = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.optNumber = new System.Windows.Forms.RadioButton();
            this.lblTrue = new System.Windows.Forms.Label();
            this.lblFalse = new System.Windows.Forms.Label();
            this.txtTrue = new System.Windows.Forms.TextBox();
            this.txtFalse = new System.Windows.Forms.TextBox();
            this.combAndOr = new System.Windows.Forms.ComboBox();
            this.grdConditionElement = new System.Windows.Forms.DataGridView();
            this.ColConditionElement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdPush = new System.Windows.Forms.Button();
            this.cmdPull = new System.Windows.Forms.Button();
            this.vmdCancel = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdConditionElement)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdSet
            // 
            this.cmdSet.Location = new System.Drawing.Point(323, 425);
            this.cmdSet.Name = "cmdSet";
            this.cmdSet.Size = new System.Drawing.Size(109, 31);
            this.cmdSet.TabIndex = 0;
            this.cmdSet.Text = "設定";
            this.cmdSet.UseVisualStyleBackColor = true;
            this.cmdSet.Click += new System.EventHandler(this.cmdSet_Click);
            // 
            // combCondition
            // 
            this.combCondition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combCondition.FormattingEnabled = true;
            this.combCondition.Location = new System.Drawing.Point(18, 76);
            this.combCondition.Name = "combCondition";
            this.combCondition.Size = new System.Drawing.Size(96, 20);
            this.combCondition.TabIndex = 1;
            this.combCondition.TextChanged += new System.EventHandler(this.combCondition_TextChanged);
            // 
            // lblGa
            // 
            this.lblGa.AutoSize = true;
            this.lblGa.Location = new System.Drawing.Point(123, 82);
            this.lblGa.Name = "lblGa";
            this.lblGa.Size = new System.Drawing.Size(15, 12);
            this.lblGa.TabIndex = 2;
            this.lblGa.Text = "が";
            // 
            // combItem
            // 
            this.combItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combItem.FormattingEnabled = true;
            this.combItem.Location = new System.Drawing.Point(146, 76);
            this.combItem.Name = "combItem";
            this.combItem.Size = new System.Drawing.Size(154, 20);
            this.combItem.TabIndex = 3;
            // 
            // combOperator
            // 
            this.combOperator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combOperator.FormattingEnabled = true;
            this.combOperator.Location = new System.Drawing.Point(306, 76);
            this.combOperator.Name = "combOperator";
            this.combOperator.Size = new System.Drawing.Size(126, 20);
            this.combOperator.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(315, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 12);
            this.label2.TabIndex = 5;
            // 
            // optIterator
            // 
            this.optIterator.AutoSize = true;
            this.optIterator.Location = new System.Drawing.Point(6, 18);
            this.optIterator.Name = "optIterator";
            this.optIterator.Size = new System.Drawing.Size(59, 16);
            this.optIterator.TabIndex = 6;
            this.optIterator.TabStop = true;
            this.optIterator.Text = "反復子";
            this.optIterator.UseVisualStyleBackColor = true;
            this.optIterator.CheckedChanged += new System.EventHandler(this.optIterator_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.optNumber);
            this.groupBox1.Controls.Add(this.optIterator);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(165, 46);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "条件の対象";
            // 
            // optNumber
            // 
            this.optNumber.AutoSize = true;
            this.optNumber.Location = new System.Drawing.Point(82, 18);
            this.optNumber.Name = "optNumber";
            this.optNumber.Size = new System.Drawing.Size(47, 16);
            this.optNumber.TabIndex = 7;
            this.optNumber.TabStop = true;
            this.optNumber.Text = "番号";
            this.optNumber.UseVisualStyleBackColor = true;
            this.optNumber.CheckedChanged += new System.EventHandler(this.optSequence_CheckedChanged);
            // 
            // lblTrue
            // 
            this.lblTrue.AutoSize = true;
            this.lblTrue.Location = new System.Drawing.Point(16, 264);
            this.lblTrue.Name = "lblTrue";
            this.lblTrue.Size = new System.Drawing.Size(101, 12);
            this.lblTrue.TabIndex = 8;
            this.lblTrue.Text = "Trueのときの文字列";
            // 
            // lblFalse
            // 
            this.lblFalse.AutoSize = true;
            this.lblFalse.Location = new System.Drawing.Point(16, 340);
            this.lblFalse.Name = "lblFalse";
            this.lblFalse.Size = new System.Drawing.Size(106, 12);
            this.lblFalse.TabIndex = 9;
            this.lblFalse.Text = "Falseのときの文字列";
            // 
            // txtTrue
            // 
            this.txtTrue.Location = new System.Drawing.Point(18, 281);
            this.txtTrue.Multiline = true;
            this.txtTrue.Name = "txtTrue";
            this.txtTrue.Size = new System.Drawing.Size(414, 49);
            this.txtTrue.TabIndex = 11;
            this.txtTrue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTrue_KeyDown);
            // 
            // txtFalse
            // 
            this.txtFalse.Location = new System.Drawing.Point(18, 358);
            this.txtFalse.Multiline = true;
            this.txtFalse.Name = "txtFalse";
            this.txtFalse.Size = new System.Drawing.Size(414, 49);
            this.txtFalse.TabIndex = 12;
            this.txtFalse.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFalse_KeyDown);
            // 
            // combAndOr
            // 
            this.combAndOr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.combAndOr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combAndOr.FormattingEnabled = true;
            this.combAndOr.Location = new System.Drawing.Point(271, 16);
            this.combAndOr.Margin = new System.Windows.Forms.Padding(100, 3, 3, 3);
            this.combAndOr.Name = "combAndOr";
            this.combAndOr.Size = new System.Drawing.Size(137, 20);
            this.combAndOr.TabIndex = 13;
            this.combAndOr.TextChanged += new System.EventHandler(this.combAndOr_TextChanged);
            // 
            // grdConditionElement
            // 
            this.grdConditionElement.AllowUserToAddRows = false;
            this.grdConditionElement.AllowUserToDeleteRows = false;
            this.grdConditionElement.AllowUserToResizeColumns = false;
            this.grdConditionElement.AllowUserToResizeRows = false;
            this.grdConditionElement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdConditionElement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColConditionElement});
            this.grdConditionElement.Location = new System.Drawing.Point(18, 151);
            this.grdConditionElement.MultiSelect = false;
            this.grdConditionElement.Name = "grdConditionElement";
            this.grdConditionElement.ReadOnly = true;
            this.grdConditionElement.RowHeadersVisible = false;
            this.grdConditionElement.RowTemplate.Height = 21;
            this.grdConditionElement.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.grdConditionElement.Size = new System.Drawing.Size(414, 101);
            this.grdConditionElement.TabIndex = 14;
            // 
            // ColConditionElement
            // 
            this.ColConditionElement.HeaderText = "条件";
            this.ColConditionElement.Name = "ColConditionElement";
            this.ColConditionElement.ReadOnly = true;
            this.ColConditionElement.Width = 400;
            // 
            // cmdPush
            // 
            this.cmdPush.Location = new System.Drawing.Point(222, 116);
            this.cmdPush.Name = "cmdPush";
            this.cmdPush.Size = new System.Drawing.Size(72, 29);
            this.cmdPush.TabIndex = 15;
            this.cmdPush.Text = "↓";
            this.cmdPush.UseVisualStyleBackColor = true;
            this.cmdPush.Click += new System.EventHandler(this.cmdPush_Click);
            // 
            // cmdPull
            // 
            this.cmdPull.Location = new System.Drawing.Point(129, 116);
            this.cmdPull.Name = "cmdPull";
            this.cmdPull.Size = new System.Drawing.Size(72, 29);
            this.cmdPull.TabIndex = 16;
            this.cmdPull.Text = "↑";
            this.cmdPull.UseVisualStyleBackColor = true;
            this.cmdPull.Click += new System.EventHandler(this.cmdPull_Click);
            // 
            // vmdCancel
            // 
            this.vmdCancel.Location = new System.Drawing.Point(206, 425);
            this.vmdCancel.Name = "vmdCancel";
            this.vmdCancel.Size = new System.Drawing.Size(109, 31);
            this.vmdCancel.TabIndex = 17;
            this.vmdCancel.Text = "キャンセル";
            this.vmdCancel.UseVisualStyleBackColor = true;
            this.vmdCancel.Click += new System.EventHandler(this.vmdCancel_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.groupBox1);
            this.flowLayoutPanel1.Controls.Add(this.combAndOr);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(18, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(426, 56);
            this.flowLayoutPanel1.TabIndex = 18;
            // 
            // frmEditCondition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 475);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.vmdCancel);
            this.Controls.Add(this.cmdPull);
            this.Controls.Add(this.cmdPush);
            this.Controls.Add(this.grdConditionElement);
            this.Controls.Add(this.txtFalse);
            this.Controls.Add(this.txtTrue);
            this.Controls.Add(this.lblFalse);
            this.Controls.Add(this.lblTrue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.combOperator);
            this.Controls.Add(this.combItem);
            this.Controls.Add(this.lblGa);
            this.Controls.Add(this.combCondition);
            this.Controls.Add(this.cmdSet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEditCondition";
            this.Text = "条件付き文字列";
            this.Load += new System.EventHandler(this.frmEditCondition_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdConditionElement)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdSet;
        private System.Windows.Forms.ComboBox combCondition;
        private System.Windows.Forms.Label lblGa;
        private System.Windows.Forms.ComboBox combItem;
        private System.Windows.Forms.ComboBox combOperator;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton optIterator;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton optNumber;
        private System.Windows.Forms.Label lblTrue;
        private System.Windows.Forms.Label lblFalse;
        private System.Windows.Forms.TextBox txtTrue;
        private System.Windows.Forms.TextBox txtFalse;
        private System.Windows.Forms.ComboBox combAndOr;
        private System.Windows.Forms.DataGridView grdConditionElement;
        private System.Windows.Forms.Button cmdPush;
        private System.Windows.Forms.Button cmdPull;
        private System.Windows.Forms.Button vmdCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColConditionElement;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        //private System.Windows.Forms.DataGridViewTextBoxColumn Condition;
    }
}