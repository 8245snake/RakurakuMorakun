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
    /// <summary>
    /// 入力支援クラス
    /// 
    /// シングルトン
    /// </summary>
    public partial class frmInputAssist : Form
    {
        private static frmInputAssist instance = new frmInputAssist();
        private static InputAssistConverter[] CtpConverters;

        public static frmInputAssist Instance {
            get
            {
                return (!instance.IsDisposed)? instance : new frmInputAssist();
            }
        }

        //コンストラクターはprivate
        private frmInputAssist()
        {
            InitializeComponent();
        }

        private void frmInputAssist_Load(object sender, EventArgs e)
        {
            //データを作る（いずれは設定で持ちたい）
            CtpConverters = new InputAssistConverter[4];
            CtpConverters[0] = new InputAssistConverter(",","\r\n","カンマ→改行");
            CtpConverters[1] = new InputAssistConverter("/", "\r\n", "スラッシュ→改行");
            CtpConverters[2] = new InputAssistConverter("\r\n", ",", "改行→カンマ");
            CtpConverters[3] = new InputAssistConverter("\r\n", "/", "改行→スラッシュ");

            combConvertType.Items.Clear();
            for (int i = 0; i < CtpConverters.Length; i++)
            {
                combConvertType.Items.Add(CtpConverters[i].Caption);
            }

            combConvertType.SelectedIndex = 0;


        }

        //「変換」ボタン
        private void cmdConvert_Click(object sender, EventArgs e)
        {
            int nIndex = combConvertType.SelectedIndex;
            if (nIndex < 0) { return; }

            txtWork.Text = txtWork.Text.Replace(CtpConverters[nIndex].OldString, CtpConverters[nIndex].NewString );
        }
    }


    //置換文字列
    public struct InputAssistConverter 
    {
        public string OldString { get; }    //変換前
        public string NewString { get; }    //変換後
        public string Caption { get; }      //コンボボックスに表示されるキャプション

        public InputAssistConverter(string stOldString, string stNewString, string stCaption)
        {
            OldString = stOldString;
            NewString = stNewString;
            Caption = stCaption;
        }

    }
}
