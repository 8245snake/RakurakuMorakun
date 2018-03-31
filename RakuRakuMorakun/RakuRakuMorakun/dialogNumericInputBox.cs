using System;
using System.Windows.Forms;

namespace RakuRakuMorakun
{
    public partial class dialogNumericInputBox : Form
    {
        private int CnReturn;
        private string CstInput;

        public int Result { get { return CnReturn; } }
        public int InputValue { get { return ParseInt(CstInput); } }

        public dialogNumericInputBox(string stMassage, string stTitle)
        {
            InitializeComponent();
            this.Text = stTitle;
            lblMessage.Text = stMassage;
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            CstInput = "";
            CnReturn = (int)DialogResult.Cancel;
            this.Hide();
        }

        private void cmdOK_Click(object sender, EventArgs e)
        {
            CstInput = txtInput.Text;
            CnReturn = (int)DialogResult.OK;
            this.Hide();
        }

        /// <summary>
        /// 文字を数値に変換する
        /// </summary>
        /// <param name="stValue"></param>
        /// <returns>int型の数値。paseに失敗していたら0を返す。</returns>
        private int ParseInt(string stValue) {
            try
            {
                return int.Parse(stValue);
            }
            catch {
                return 0;
            }
        }

        /// <summary>
        /// 数字のみ入力可とする
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            //0～9と、バックスペース以外の時は、イベントをキャンセルする
            if ((e.KeyChar < '0' || '9' < e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
    }
}
