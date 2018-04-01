namespace RakuRakuMorakun
{
    partial class frmSetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSetting));
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cmdConditionDelete = new System.Windows.Forms.Button();
            this.cmdConditionAdd = new System.Windows.Forms.Button();
            this.grdCondition = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtConditionItem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtConditionName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cmdDelegateDelete = new System.Windows.Forms.Button();
            this.combDelegate = new System.Windows.Forms.ComboBox();
            this.cmdDelegateAdd = new System.Windows.Forms.Button();
            this.cmdDelegateDown = new System.Windows.Forms.Button();
            this.cmdDeledateUp = new System.Windows.Forms.Button();
            this.grdDelegate = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.cmdSet = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCondition)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDelegate)).BeginInit();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabPage1);
            this.tabMain.Controls.Add(this.tabPage2);
            this.tabMain.Location = new System.Drawing.Point(2, 4);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(866, 408);
            this.tabMain.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cmdConditionDelete);
            this.tabPage1.Controls.Add(this.cmdConditionAdd);
            this.tabPage1.Controls.Add(this.grdCondition);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtConditionItem);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtConditionName);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(858, 382);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "条件付き文字列";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cmdConditionDelete
            // 
            this.cmdConditionDelete.Location = new System.Drawing.Point(353, 183);
            this.cmdConditionDelete.Name = "cmdConditionDelete";
            this.cmdConditionDelete.Size = new System.Drawing.Size(71, 34);
            this.cmdConditionDelete.TabIndex = 7;
            this.cmdConditionDelete.Text = "＜＜削除";
            this.cmdConditionDelete.UseVisualStyleBackColor = true;
            // 
            // cmdConditionAdd
            // 
            this.cmdConditionAdd.Location = new System.Drawing.Point(353, 132);
            this.cmdConditionAdd.Name = "cmdConditionAdd";
            this.cmdConditionAdd.Size = new System.Drawing.Size(71, 34);
            this.cmdConditionAdd.TabIndex = 6;
            this.cmdConditionAdd.Text = "追加＞＞";
            this.cmdConditionAdd.UseVisualStyleBackColor = true;
            // 
            // grdCondition
            // 
            this.grdCondition.AllowUserToAddRows = false;
            this.grdCondition.AllowUserToDeleteRows = false;
            this.grdCondition.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCondition.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3});
            this.grdCondition.Location = new System.Drawing.Point(453, 65);
            this.grdCondition.Name = "grdCondition";
            this.grdCondition.ReadOnly = true;
            this.grdCondition.RowHeadersVisible = false;
            this.grdCondition.RowTemplate.Height = 21;
            this.grdCondition.Size = new System.Drawing.Size(382, 203);
            this.grdCondition.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(17, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "内容";
            // 
            // txtConditionItem
            // 
            this.txtConditionItem.Location = new System.Drawing.Point(21, 163);
            this.txtConditionItem.Multiline = true;
            this.txtConditionItem.Name = "txtConditionItem";
            this.txtConditionItem.Size = new System.Drawing.Size(320, 105);
            this.txtConditionItem.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(17, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "名前";
            // 
            // txtConditionName
            // 
            this.txtConditionName.Location = new System.Drawing.Point(21, 96);
            this.txtConditionName.Name = "txtConditionName";
            this.txtConditionName.Size = new System.Drawing.Size(320, 19);
            this.txtConditionName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(17, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(780, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "よく使う文章を条件付き文字列として設定しておくことで起動時に自動で読み込まれます。";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cmdDelegateDelete);
            this.tabPage2.Controls.Add(this.combDelegate);
            this.tabPage2.Controls.Add(this.cmdDelegateAdd);
            this.tabPage2.Controls.Add(this.cmdDelegateDown);
            this.tabPage2.Controls.Add(this.cmdDeledateUp);
            this.tabPage2.Controls.Add(this.grdDelegate);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(858, 382);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "文字列処理";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cmdDelegateDelete
            // 
            this.cmdDelegateDelete.Location = new System.Drawing.Point(605, 53);
            this.cmdDelegateDelete.Name = "cmdDelegateDelete";
            this.cmdDelegateDelete.Size = new System.Drawing.Size(94, 32);
            this.cmdDelegateDelete.TabIndex = 7;
            this.cmdDelegateDelete.Text = "削除";
            this.cmdDelegateDelete.UseVisualStyleBackColor = true;
            this.cmdDelegateDelete.Click += new System.EventHandler(this.cmdDelegateDelete_Click);
            // 
            // combDelegate
            // 
            this.combDelegate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combDelegate.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combDelegate.FormattingEnabled = true;
            this.combDelegate.Location = new System.Drawing.Point(103, 53);
            this.combDelegate.Name = "combDelegate";
            this.combDelegate.Size = new System.Drawing.Size(349, 31);
            this.combDelegate.TabIndex = 6;
            // 
            // cmdDelegateAdd
            // 
            this.cmdDelegateAdd.Location = new System.Drawing.Point(458, 53);
            this.cmdDelegateAdd.Name = "cmdDelegateAdd";
            this.cmdDelegateAdd.Size = new System.Drawing.Size(94, 32);
            this.cmdDelegateAdd.TabIndex = 5;
            this.cmdDelegateAdd.Text = "追加";
            this.cmdDelegateAdd.UseVisualStyleBackColor = true;
            this.cmdDelegateAdd.Click += new System.EventHandler(this.cmdDelegateAdd_Click);
            // 
            // cmdDelegateDown
            // 
            this.cmdDelegateDown.Location = new System.Drawing.Point(712, 193);
            this.cmdDelegateDown.Name = "cmdDelegateDown";
            this.cmdDelegateDown.Size = new System.Drawing.Size(50, 34);
            this.cmdDelegateDown.TabIndex = 4;
            this.cmdDelegateDown.Text = "▼";
            this.cmdDelegateDown.UseVisualStyleBackColor = true;
            this.cmdDelegateDown.Click += new System.EventHandler(this.cmdDelegateDown_Click);
            // 
            // cmdDeledateUp
            // 
            this.cmdDeledateUp.Location = new System.Drawing.Point(712, 153);
            this.cmdDeledateUp.Name = "cmdDeledateUp";
            this.cmdDeledateUp.Size = new System.Drawing.Size(50, 34);
            this.cmdDeledateUp.TabIndex = 3;
            this.cmdDeledateUp.Text = "▲";
            this.cmdDeledateUp.UseVisualStyleBackColor = true;
            this.cmdDeledateUp.Click += new System.EventHandler(this.cmdDeledateUp_Click);
            // 
            // grdDelegate
            // 
            this.grdDelegate.AllowUserToAddRows = false;
            this.grdDelegate.AllowUserToDeleteRows = false;
            this.grdDelegate.AllowUserToResizeColumns = false;
            this.grdDelegate.AllowUserToResizeRows = false;
            this.grdDelegate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDelegate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.grdDelegate.Location = new System.Drawing.Point(103, 91);
            this.grdDelegate.Name = "grdDelegate";
            this.grdDelegate.ReadOnly = true;
            this.grdDelegate.RowHeadersWidth = 60;
            this.grdDelegate.RowTemplate.Height = 21;
            this.grdDelegate.Size = new System.Drawing.Size(596, 207);
            this.grdDelegate.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "処理の内容";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 550;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(23, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(676, 26);
            this.label4.TabIndex = 1;
            this.label4.Text = "文字列処理の順番を設定できます。";
            // 
            // cmdSet
            // 
            this.cmdSet.Location = new System.Drawing.Point(760, 418);
            this.cmdSet.Name = "cmdSet";
            this.cmdSet.Size = new System.Drawing.Size(94, 32);
            this.cmdSet.TabIndex = 6;
            this.cmdSet.Text = "設定";
            this.cmdSet.UseVisualStyleBackColor = true;
            this.cmdSet.Click += new System.EventHandler(this.cmdSet_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.Location = new System.Drawing.Point(660, 418);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(94, 32);
            this.cmdCancel.TabIndex = 7;
            this.cmdCancel.Text = "キャンセル";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // Column2
            // 
            this.Column2.Frozen = true;
            this.Column2.HeaderText = "名前";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.Frozen = true;
            this.Column3.HeaderText = "内容";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 300;
            // 
            // frmSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 458);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdSet);
            this.Controls.Add(this.tabMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSetting";
            this.Text = "設定";
            this.Load += new System.EventHandler(this.frmSetting_Load);
            this.tabMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCondition)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDelegate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button cmdConditionDelete;
        private System.Windows.Forms.Button cmdConditionAdd;
        private System.Windows.Forms.DataGridView grdCondition;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtConditionItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtConditionName;
        private System.Windows.Forms.Button cmdDelegateDelete;
        private System.Windows.Forms.ComboBox combDelegate;
        private System.Windows.Forms.Button cmdDelegateAdd;
        private System.Windows.Forms.Button cmdDelegateDown;
        private System.Windows.Forms.Button cmdDeledateUp;
        private System.Windows.Forms.DataGridView grdDelegate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cmdSet;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}