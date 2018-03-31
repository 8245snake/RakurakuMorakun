using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static RakuRakuMorakun.Common;

namespace RakuRakuMorakun
{
    public partial class frmEditCondition : Form
    {
        private GridController CtpController;
        private Condition CtpCondition;  //呼び出し元から渡される
        private Condition CtpCondition_Buff;  //このフォーム内だけで使われるCtpConditionのクローン

        public Condition Condition
        {
            get { return CtpCondition; }
            set { CtpCondition = value; }
        }

        public frmEditCondition(GridController controller, string stName)
        {
            InitializeComponent();
            this.CtpController = controller;
            CtpCondition = controller.GetCondition(stName);
            //ディープコピー
            CtpCondition_Buff = CtpCondition.Copy();
        }

        private void frmEditCondition_Load(object sender, EventArgs e)
        {
            InitCombAndOr();
            optIterator.Checked = true;
            grdConditionElement.Rows.Clear();

            //セルの内容に合わせて、行の高さが自動的に調節されるようにする
            grdConditionElement.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            //テキストを折り返して表示する
            grdConditionElement.Columns[0].DefaultCellStyle.WrapMode =DataGridViewTriState.True;

            //データを反映
            DisplayConditionToForm(CtpCondition_Buff);
        }

        //条件付き文字列データをフォームに反映
        private void DisplayConditionToForm(Condition tpCondition)
        {
            txtTrue.Text = tpCondition.TrueText;
            txtFalse.Text = tpCondition.FalseText;

            for (int nRow = 0; nRow < tpCondition.Length; nRow++)
            {
                grdConditionElement.Rows.Add();
                grdConditionElement[0,nRow].Value = tpCondition.GetElement(nRow).GetText();
            }
        }

        //条件要素の内容をコンボボックスなどに反映する
        private void DisplayElement(ConditionElement tpElement)
        {
            //オプションボタンの選択（Typeの方がいい？）
            if (tpElement.GetCondition() == NUMBER_CAPTION) //番号
            {
                optNumber.Checked = true;
            }
            else
            {
                optIterator.Checked = true;
            }

            combCondition.SelectedItem = tpElement.GetCondition();
            combItem.SelectedItem = tpElement.GetTarget();
            combOperator.SelectedItem = tpElement.GetOperator();
            

        }

        private void InitCombAndOr()
        {
            //コンボボックス初期化
            combAndOr.Items.Clear();
            combAndOr.Items.Add(AND_CAPTION);
            combAndOr.Items.Add(OR_CAPTION);
            combAndOr.SelectedIndex = 0;
        }

        private void ChangeVisible(bool blVisible)
        {
            combAndOr.Visible = blVisible;
            combCondition.Visible = blVisible;
            combItem.Visible = blVisible;
            combOperator.Visible = blVisible;
            lblGa.Visible = blVisible;
            lblFalse.Visible = blVisible;
            txtFalse.Visible = blVisible;
            cmdPull.Visible = blVisible;
            cmdPush.Visible = blVisible;
            grdConditionElement.Visible = blVisible;
        }

        //反復子を選択
        private void optIterator_CheckedChanged(object sender, EventArgs e)
        {
            if (!optIterator.Checked) { return; }

            combCondition.Items.Clear();
            string[] stNamesArr = CtpController.GetNames();
            for (int i = 0; i < stNamesArr.Length; i++)
            {
                combCondition.Items.Add(stNamesArr[i]);
            }

            combCondition.SelectedIndex = (combCondition.Items.Count > 0)? 0 : -1;

            //combItemは別のイベントで

            combOperator.Items.Clear();
            combOperator.Items.Add(EQUAL);
            combOperator.Items.Add(NOTEQUAL);
            combOperator.SelectedIndex = 0;
        }

        //番号を選択
        private void optSequence_CheckedChanged(object sender, EventArgs e)
        {
            if (!optNumber.Checked) { return; }

            combCondition.Items.Clear();
            combCondition.Items.Add("番号");
            combCondition.SelectedIndex = 0;

            combItem.Items.Clear();
            for (long lCount = 1; lCount <= CtpController.Total; lCount++)
            {
                combItem.Items.Add(lCount.ToString());
            }

            //選択状態
            combItem.SelectedIndex = (combItem.Items.Count > 0) ? 0 : -1;

            combOperator.Items.Clear();
            combOperator.Items.Add(EQUAL);
            combOperator.Items.Add(NOTEQUAL);
            combOperator.Items.Add(OVER);
            combOperator.Items.Add(UNDER);
            combOperator.SelectedIndex = 0;
        }

        //反復子設定状態でコンボボックスが変化したとき
        private void combCondition_TextChanged(object sender, EventArgs e)
        {
            if (!optIterator.Checked) { return; }

            combItem.Items.Clear();
            string stName = combCondition.Items[combCondition.SelectedIndex].ToString();
            string[] stItems = CtpController.GetItemsByName(stName);
            for (int i = 0; i < stItems.Length; i++)
            {
                combItem.Items.Add(stItems[i]);
            }
            combItem.SelectedIndex = 0;

        }

        private ConditionOfString CreateConditionOfString()
        {
            string stName = combCondition.Items[combCondition.SelectedIndex].ToString();
            string stItem = combItem.Items[combItem.SelectedIndex].ToString();
            string stOperator = combOperator.Items[combOperator.SelectedIndex].ToString();
            return  new ConditionOfString(stName, stItem, stOperator);
        }


        private ConditionOfNumber CreateConditionOfSequence()
        {
            long lSequence = long.Parse(combItem.Items[combItem.SelectedIndex].ToString());
            string stOperator = combOperator.Items[combOperator.SelectedIndex].ToString();
            return new ConditionOfNumber(lSequence, stOperator);
        }
        
        //グリッドに追加ボタン
        private void cmdPush_Click(object sender, EventArgs e)
        {
            ConditionElement tpElement;
            if (optIterator.Checked)
            {
                tpElement = CreateConditionOfString();
            }
            else if (optNumber.Checked)
            {
                tpElement = CreateConditionOfSequence();
            }
            else
            {
                return;
            }

            //重複チェック
            for (int nRow = 0; nRow < grdConditionElement.Rows.Count; nRow++)
            {
                if (grdConditionElement[0, nRow].Value.ToString() == tpElement.GetText()) { return; }
            }

            grdConditionElement.Rows.Add(tpElement.GetText());
            CtpCondition_Buff.AddElement(tpElement);
        }

        //削除ボタン
        private void cmdPull_Click(object sender, EventArgs e)
        {
            int nRow = -1;
            foreach (DataGridViewRow row in grdConditionElement.SelectedRows)
            {
                nRow = row.Index;
                break;
            }

            foreach (DataGridViewCell cell in grdConditionElement.SelectedCells)
            {
                nRow = cell.RowIndex;
                break;
            }

            if (nRow < 0) { return; }

            //コンボボックスなどに反映
            DisplayElement(CtpCondition_Buff.GetElement(nRow));

            CtpCondition_Buff.DeleteElement(nRow);

            //グリッドに反映
            grdConditionElement.Rows.Clear();
            for (nRow = 0; nRow < CtpCondition_Buff.Length; nRow++)
            {
                grdConditionElement.Rows.Add();
                grdConditionElement[0, nRow].Value = CtpCondition_Buff.GetElement(nRow).GetText();
            }
        }

        //設定ボタン
        private void cmdSet_Click(object sender, EventArgs e)
        {
            //データを作成
            CtpCondition_Buff.Logic = combAndOr.Tag.ToString();
            CtpCondition_Buff.TrueText = txtTrue.Text;
            CtpCondition_Buff.FalseText = txtFalse.Text;

            CtpCondition = CtpCondition_Buff;

            CtpController.AddCondition(CtpCondition);
            this.Dispose();
        }

        //ANDとORは現在選択中の演算子をTagに入れる
        private void combAndOr_TextChanged(object sender, EventArgs e)
        {
            string stCaption = combAndOr.Items[combAndOr.SelectedIndex].ToString();
            if (stCaption == AND_CAPTION)
            {
                combAndOr.Tag = AND;
            }
            else if (stCaption == OR_CAPTION)
            {
                combAndOr.Tag = OR;
            }
            
        }

        private void vmdCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
