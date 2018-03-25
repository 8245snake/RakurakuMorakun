using System;
using System.Windows.Forms;
using static RakuRakuMorakun.Common;

namespace RakuRakuMorakun
{
    public partial class dialogDatarRcieved : Form
    {
        private int CnCommandMode;

        public dialogDatarRcieved()
        {
            InitializeComponent();
        }

        private void dialogDatarRcieved_Load(object sender, EventArgs e)
        {

        }

        public string RecievedText { set { txtData.Text = value; } }

        //呼び出し元に選択したボタンの情報を返すため
        public int CommandMode { get { return CnCommandMode; } }

        private void cmdTemplate_Click(object sender, EventArgs e)
        {
            CnCommandMode = (int)EXTERNAL_FLAG.TEMPLATE;
            this.Hide();
        }

        private void cmdIterator_Click(object sender, EventArgs e)
        {
            CnCommandMode = (int)EXTERNAL_FLAG.ITERATOR ;
            this.Hide();
        }

        //キャンセル
        private void cmdCancel_Click(object sender, EventArgs e)
        {
            CnCommandMode = (int)EXTERNAL_FLAG.CANCEL ;
            this.Hide();
        }
    }
}
