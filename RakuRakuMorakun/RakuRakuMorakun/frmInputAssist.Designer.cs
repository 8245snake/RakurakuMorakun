namespace RakuRakuMorakun
{
    partial class frmInputAssist
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
            this.txtWork = new System.Windows.Forms.TextBox();
            this.cmdConvert = new System.Windows.Forms.Button();
            this.combConvertType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtWork
            // 
            this.txtWork.Location = new System.Drawing.Point(2, 36);
            this.txtWork.Multiline = true;
            this.txtWork.Name = "txtWork";
            this.txtWork.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtWork.Size = new System.Drawing.Size(423, 291);
            this.txtWork.TabIndex = 0;
            // 
            // cmdConvert
            // 
            this.cmdConvert.Location = new System.Drawing.Point(302, 2);
            this.cmdConvert.Name = "cmdConvert";
            this.cmdConvert.Size = new System.Drawing.Size(115, 28);
            this.cmdConvert.TabIndex = 1;
            this.cmdConvert.Text = "変換";
            this.cmdConvert.UseVisualStyleBackColor = true;
            this.cmdConvert.Click += new System.EventHandler(this.cmdConvert_Click);
            // 
            // combConvertType
            // 
            this.combConvertType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combConvertType.FormattingEnabled = true;
            this.combConvertType.Location = new System.Drawing.Point(8, 7);
            this.combConvertType.Name = "combConvertType";
            this.combConvertType.Size = new System.Drawing.Size(284, 20);
            this.combConvertType.TabIndex = 2;
            // 
            // frmInputAssist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 330);
            this.Controls.Add(this.combConvertType);
            this.Controls.Add(this.cmdConvert);
            this.Controls.Add(this.txtWork);
            this.Name = "frmInputAssist";
            this.Text = "入力支援";
            this.Load += new System.EventHandler(this.frmInputAssist_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtWork;
        private System.Windows.Forms.Button cmdConvert;
        private System.Windows.Forms.ComboBox combConvertType;
    }
}