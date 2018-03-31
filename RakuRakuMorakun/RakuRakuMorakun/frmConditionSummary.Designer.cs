namespace RakuRakuMorakun
{
    partial class frmConditionSummary
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
            this.grdSummary = new System.Windows.Forms.DataGridView();
            this.cmdClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdSummary)).BeginInit();
            this.SuspendLayout();
            // 
            // grdSummary
            // 
            this.grdSummary.AllowUserToAddRows = false;
            this.grdSummary.AllowUserToDeleteRows = false;
            this.grdSummary.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSummary.Location = new System.Drawing.Point(12, 12);
            this.grdSummary.Name = "grdSummary";
            this.grdSummary.ReadOnly = true;
            this.grdSummary.RowHeadersWidth = 100;
            this.grdSummary.RowTemplate.Height = 21;
            this.grdSummary.Size = new System.Drawing.Size(278, 213);
            this.grdSummary.TabIndex = 0;
            // 
            // cmdClose
            // 
            this.cmdClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdClose.Location = new System.Drawing.Point(182, 233);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(109, 33);
            this.cmdClose.TabIndex = 1;
            this.cmdClose.Text = "閉じる";
            this.cmdClose.UseVisualStyleBackColor = true;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // frmConditionSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 274);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.grdSummary);
            this.Name = "frmConditionSummary";
            this.Text = "条件付き文字列サマリ";
            this.Load += new System.EventHandler(this.frmConditionSummary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdSummary)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdSummary;
        private System.Windows.Forms.Button cmdClose;
    }
}