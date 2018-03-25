namespace RakuRakuMorakun
{
    partial class dialogDatarRcieved
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
            this.lblMessage = new System.Windows.Forms.Label();
            this.cmdTemplate = new System.Windows.Forms.Button();
            this.cmdIterator = new System.Windows.Forms.Button();
            this.txtData = new System.Windows.Forms.TextBox();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblMessage.Location = new System.Drawing.Point(12, 9);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(535, 46);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Text = "外部アプリ連携データを受信しました。データの反映先を選択してください。\r\n（反映すると入力中のデータは破棄されます）";
            // 
            // cmdTemplate
            // 
            this.cmdTemplate.Location = new System.Drawing.Point(208, 168);
            this.cmdTemplate.Name = "cmdTemplate";
            this.cmdTemplate.Size = new System.Drawing.Size(116, 27);
            this.cmdTemplate.TabIndex = 1;
            this.cmdTemplate.Text = "テンプレート";
            this.cmdTemplate.UseVisualStyleBackColor = true;
            this.cmdTemplate.Click += new System.EventHandler(this.cmdTemplate_Click);
            // 
            // cmdIterator
            // 
            this.cmdIterator.Location = new System.Drawing.Point(330, 168);
            this.cmdIterator.Name = "cmdIterator";
            this.cmdIterator.Size = new System.Drawing.Size(116, 27);
            this.cmdIterator.TabIndex = 2;
            this.cmdIterator.Text = "反復子";
            this.cmdIterator.UseVisualStyleBackColor = true;
            this.cmdIterator.Click += new System.EventHandler(this.cmdIterator_Click);
            // 
            // txtData
            // 
            this.txtData.Enabled = false;
            this.txtData.Location = new System.Drawing.Point(16, 58);
            this.txtData.Multiline = true;
            this.txtData.Name = "txtData";
            this.txtData.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtData.Size = new System.Drawing.Size(550, 101);
            this.txtData.TabIndex = 3;
            // 
            // cmdCancel
            // 
            this.cmdCancel.Location = new System.Drawing.Point(452, 168);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(116, 27);
            this.cmdCancel.TabIndex = 4;
            this.cmdCancel.Text = "キャンセル";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // dialogDatarRcieved
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 206);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.cmdIterator);
            this.Controls.Add(this.cmdTemplate);
            this.Controls.Add(this.lblMessage);
            this.Name = "dialogDatarRcieved";
            this.Text = "データ反映先設定";
            this.Load += new System.EventHandler(this.dialogDatarRcieved_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button cmdTemplate;
        private System.Windows.Forms.Button cmdIterator;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Button cmdCancel;
    }
}