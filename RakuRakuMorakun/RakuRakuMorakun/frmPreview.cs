using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RakuRakuMorakun
{
    public partial class frmPreview : Form
    {
        frmMain frmMain;

        public frmPreview(frmMain frmA)
        {
            InitializeComponent();
            frmMain = frmA;
            this.TopMost = true;
        }


        public string PreviewText
        {
            set{ txtPreview.Text = value;}
            get{return txtPreview.Text; }
        }

        //フォームが破棄されるとき
        private void frmPreview_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMain.PreviewChecked = false;
        }
    }


}
