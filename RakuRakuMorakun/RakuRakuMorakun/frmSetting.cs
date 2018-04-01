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
    public partial class frmSetting : Form
    {
        SettingData CtpSettingData;
        private int CnColMain = 0;

        public frmSetting()
        {
            InitializeComponent();
        }

        private void frmSetting_Load(object sender, EventArgs e)
        {
            CtpSettingData = LoadSetting();

            if (CtpSettingData == null) //設定ファイルが無ければデフォルトを作成
            {
                CreateDefaultSettingFile(); //デフォルト設定を作成
                CtpSettingData = LoadSetting(); //設定をロード
                if (CtpSettingData == null) { this.Dispose(); } //それでも失敗したら終了
            }

            InitComboBoxOfDelegate();
            InitGridOfDelegate();
            InitGridOfCondition();

        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////
        /// 文字列処理設定
        ///////////////////////////////////////////////////////////////////////////////////////////////////////

        private void InitComboBoxOfDelegate()
        {
            combDelegate.Items.Clear();
            combDelegate.Items.Add(DELEGATE_ITERATOR_CAPTION);
            combDelegate.Items.Add(DELEGATE_SEQUENCE_CAPTION);
            combDelegate.Items.Add(DELEGATE_CONDITION_CAPTION);
            combDelegate.Items.Add(DELEGATE_NUMBER_CAPTION);
            combDelegate.Items.Add(DELEGATE_EXPRESSION_CAPTION);
            combDelegate.SelectedIndex = 0;

        }

        private void InitGridOfDelegate()
        {
            grdDelegate.Rows.Clear();
            grdDelegate.Columns[CnColMain].SortMode = DataGridViewColumnSortMode.NotSortable;
            int nRow = 0;

            foreach (DELEGATE_ID id in CtpSettingData.DelegateId)
            {
                grdDelegate.Rows.Add();
                grdDelegate[CnColMain, nRow].Value = GetDelegateCaption(id);
                grdDelegate.Rows[nRow].HeaderCell.Value = (nRow + 1).ToString();
                nRow++;
            }
        }

        //グリッド追加
        private void cmdDelegateAdd_Click(object sender, EventArgs e)
        {
            grdDelegate.Rows.Add();
            grdDelegate[CnColMain, grdDelegate.RowCount - 1].Value = combDelegate.Text;
            UpdateNumber();
        }

        //グリッドから削除
        private void cmdDelegateDelete_Click(object sender, EventArgs e)
        {
            int nSelectedRow = GetSelectedRowIndex(grdDelegate);
            if (nSelectedRow < 0) { return; }

            grdDelegate.Rows.RemoveAt(nSelectedRow);
            UpdateNumber();
        }

        //上に移動
        private void cmdDeledateUp_Click(object sender, EventArgs e)
        {
            int nSelectedRow = GetSelectedRowIndex(grdDelegate);
            if (nSelectedRow < 1) { return; }

            string stBuff = grdDelegate[CnColMain, nSelectedRow].Value.ToString();
            grdDelegate[CnColMain, nSelectedRow].Value = grdDelegate[CnColMain, nSelectedRow - 1].Value.ToString();
            grdDelegate[CnColMain, nSelectedRow - 1].Value = stBuff;
            grdDelegate[CnColMain, nSelectedRow].Selected = false;
            grdDelegate[CnColMain, nSelectedRow - 1].Selected = true;
        }

        //下に移動
        private void cmdDelegateDown_Click(object sender, EventArgs e)
        {
            int nSelectedRow = GetSelectedRowIndex(grdDelegate);
            if (nSelectedRow > grdDelegate.RowCount - 2) { return; }

            string stBuff = grdDelegate[CnColMain, nSelectedRow].Value.ToString();
            grdDelegate[CnColMain, nSelectedRow].Value = grdDelegate[CnColMain, nSelectedRow + 1].Value.ToString();
            grdDelegate[CnColMain, nSelectedRow + 1].Value = stBuff;
            grdDelegate[CnColMain, nSelectedRow].Selected = false;
            grdDelegate[CnColMain, nSelectedRow + 1].Selected = true;
        }

        //選択している行インデックスを取得
        private int GetSelectedRowIndex(DataGridView grdView)
        {
            DataGridViewCell cell = GridController.GetSelectedCell(grdView);
            if (cell == null) { return -1; }
            return  cell.RowIndex;
        }

        //行タイトルの番号を更新する
        private void UpdateNumber()
        {
            for (int i = 0; i < grdDelegate.RowCount; i++)
            {
                grdDelegate.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }

        }

        /// <summary>
        /// IDからキャプションを取得する
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private static string GetDelegateCaption(DELEGATE_ID id)
        {
            if (id == DELEGATE_ID.ITERATOR)
            {
                return DELEGATE_ITERATOR_CAPTION;
            }
            else if (id == DELEGATE_ID.SEQUENCE)
            {
                return DELEGATE_SEQUENCE_CAPTION;
            }
            else if (id == DELEGATE_ID.CONDITION)
            {
                return DELEGATE_CONDITION_CAPTION;
            }
            else if (id == DELEGATE_ID.NUMBER)
            {
                return DELEGATE_NUMBER_CAPTION;
            }
            else if (id == DELEGATE_ID.EXPRESSION)
            {
                return DELEGATE_EXPRESSION_CAPTION;
            }
            return "";
        }

        /// <summary>
        /// キャプションからIDを取得する。無ければDELEGATE_ID.ERRORを返す。
        /// </summary>
        /// <param name="stCaption"></param>
        /// <returns></returns>
        private static DELEGATE_ID GetDelegateID(string stCaption)
        {
            if (stCaption == DELEGATE_ITERATOR_CAPTION)
            {
                return DELEGATE_ID.ITERATOR;
            }
            else if (stCaption == DELEGATE_SEQUENCE_CAPTION)
            {
                return DELEGATE_ID.SEQUENCE;
            }
            else if (stCaption == DELEGATE_CONDITION_CAPTION)
            {
                return DELEGATE_ID.CONDITION;
            }
            else if (stCaption == DELEGATE_NUMBER_CAPTION)
            {
                return DELEGATE_ID.NUMBER;
            }
            else if (stCaption == DELEGATE_EXPRESSION_CAPTION)
            {
                return DELEGATE_ID.EXPRESSION;
            }
            return DELEGATE_ID.ERROR;
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////
        /// 条件付き文字列の設定
        ///////////////////////////////////////////////////////////////////////////////////////////////////////


        private void InitGridOfCondition()
        {

            grdCondition.Rows.Clear();
            grdCondition.Columns[CnColMain].SortMode = DataGridViewColumnSortMode.NotSortable;
            int nRow = 0;

            foreach (Condition item in CtpSettingData.Conditions)
            {
                grdCondition.Rows.Add();
                grdCondition[0, nRow].Value = item.Name;
                grdCondition[1, nRow].Value = item.TrueText;
                nRow++;
            }

        }




        ///////////////////////////////////////////////////////////////////////////////////////////////////////
        /// その他
        ///////////////////////////////////////////////////////////////////////////////////////////////////////

        //設定
        private void cmdSet_Click(object sender, EventArgs e)
        {
            //処理順の保存
            DELEGATE_ID[] tpIds = new DELEGATE_ID[grdDelegate.RowCount];
            for (int i = 0; i < grdDelegate.RowCount; i++)
            {
                tpIds[i] = GetDelegateID(grdDelegate[CnColMain, i].Value.ToString());
            }

            Condition[] tpConditions = new Condition[] { };

            SettingData data = new SettingData(tpConditions, tpIds);

            SaveSetting(data);

            this.Dispose();

        }

        //キャンセル
        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
