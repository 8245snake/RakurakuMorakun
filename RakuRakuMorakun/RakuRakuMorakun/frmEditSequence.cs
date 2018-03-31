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
    public partial class frmEditSequence : Form
    {
        private GridController CtpController;
        private Sequence CtpSequence;
        private int CnEditableColumn; //ユーザーが入力できる列

        public frmEditSequence(GridController controller, string stName)
        {
            InitializeComponent();
            CtpController = controller;
            CtpSequence = CtpController.GetSequence(stName);
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cmdSet_Click(object sender, EventArgs e)
        {
            long lRowsCount = grdSeqItems.Rows.Count;
            string[] stItems = new string[lRowsCount];

            //グリッドの内容を取り込む
            for (int nRow = 0; nRow < lRowsCount; nRow++)
            {
                stItems[nRow] = (grdSeqItems[CnEditableColumn, nRow].Value != null)? grdSeqItems[CnEditableColumn, nRow].Value.ToString() : "" ;
            }

            CtpSequence.Items = stItems;
            CtpController.AddSequence(CtpSequence);
            this.Dispose();
        }

        private void frmEditSequence_Load(object sender, EventArgs e)
        {
            //グリッド初期化
            InitGrid();

            //コンボボックス初期化
            InitcombBox();

        }

        private void grdSeqItems_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete || e.KeyData == Keys.Back) //Delete、BackSpace
            {
                //選択されているセルの内容を削除
                foreach (DataGridViewCell cell in grdSeqItems.SelectedCells)
                {
                    cell.Value = null;
                }
            }
            else if (e.KeyCode == Keys.V && e.Control) //Ctr + V（ペースト）
            {
                CtpController.PasteGrid(grdSeqItems, false);
            }
            else if (e.KeyCode == Keys.C && e.Control) //Ctr + C（コピー）
            {
                CtpController.CopyGrid(grdSeqItems);
            }
        }

        //グリッド初期化
        private void InitGrid()
        {
            grdSeqItems.Rows.Clear();
            grdSeqItems.Columns.Clear();

            DataTable tpData = CtpController.GetDataTable();
            Dictionary<string, string> dicNameValue;
            int nNextFlg;
            int nRow = 0;

            string[] stNamesArr = tpData.GetNames();
            CnEditableColumn = stNamesArr.Length; //ユーザーが入力できる列は反復子の次の列

            for (int i = 0; i < stNamesArr.Length; i++)
            {
                grdSeqItems.Columns.Add("Col" + i, stNamesArr[i]);
                grdSeqItems.Columns[i].ReadOnly = true;
                grdSeqItems.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            grdSeqItems.Columns.Add("Item", "項目");
            grdSeqItems.Columns[CnEditableColumn].SortMode = DataGridViewColumnSortMode.NotSortable;

            //インデックスを初期化
            tpData.InitIndex();
            nNextFlg = (int)INDEX_FLAG.NEXT;

            
            while (nNextFlg == (int)INDEX_FLAG.NEXT)
            {

                //行ヘッダーに番号入れる
                grdSeqItems.Rows.Add();
                grdSeqItems.Rows[nRow].HeaderCell.Value = (nRow + 1).ToString();
                grdSeqItems[CnEditableColumn, nRow].Value = CtpSequence.Item(nRow);

                dicNameValue = tpData.GetDictOfNowIndex();

                //反復子の取得
                foreach (KeyValuePair<string, string> pair in dicNameValue)
                {
                    SetCellByColName(pair.Key, nRow, pair.Value);
                }

                nRow++;
                nNextFlg = tpData.NextIndex();

            }
        }

        //列ヘッダー名と行数を指定して値を入れる。色をグレーにする。
        private void SetCellByColName(string stColName, int nRow, string stValue)
        {
            for (int i = 0; i < grdSeqItems.Columns.Count; i++)
            {
                if(grdSeqItems.Columns[i].HeaderText == stColName)
                {
                    grdSeqItems[i, nRow].Value = stValue;
                    grdSeqItems[i, nRow].Style.BackColor = Color.LightGray;

                }
            }
        }

        //グリッド初期化
        private void InitcombBox()
        {
            combName.Items.Clear();
            string[] stNamesArr = CtpController.GetNames();
            for (int i = 0; i < stNamesArr.Length; i++)
            {
                combName.Items.Add(stNamesArr[i]);
            }

            combName.SelectedIndex = (combName.Items.Count > 0) ? 0 : -1;
        }

        private void combName_TextChanged(object sender, EventArgs e)
        {
            combItem.Items.Clear();
            string stName = combName.Items[combName.SelectedIndex].ToString();
            string[] stItems = CtpController.GetItemsByName(stName);
            for (int i = 0; i < stItems.Length; i++)
            {
                combItem.Items.Add(stItems[i]);
            }
            combItem.SelectedIndex = 0;
        }

        //絞り込み
        private void cmdSearch_Click(object sender, EventArgs e)
        {
            string stName = combName.Items[combName.SelectedIndex].ToString();
            string stItem = combItem.Items[combItem.SelectedIndex].ToString();
            int nTargetCol = 0;

            for (int i = 0; i < grdSeqItems.ColumnCount; i++)
            {
                if (grdSeqItems.Columns[i].HeaderText == stName)
                {
                    nTargetCol = i;
                }
            }

            for (int lRow = 0; lRow < grdSeqItems.RowCount; lRow++)
            {
                if (grdSeqItems[nTargetCol,lRow].Value.ToString() != stItem)
                {
                    grdSeqItems.Rows[lRow].Visible = false;
                }
            }

        }

        //絞り込み解除
        private void cmdReset_Click(object sender, EventArgs e)
        {
            for (int lRow = 0; lRow < grdSeqItems.RowCount; lRow++)
            {
                grdSeqItems.Rows[lRow].Visible = true;
            }
        }

        //絞り込みを反転
        private void cmdReverse_Click(object sender, EventArgs e)
        {
            for (int lRow = 0; lRow < grdSeqItems.RowCount; lRow++)
            {
                grdSeqItems.Rows[lRow].Visible = !grdSeqItems.Rows[lRow].Visible;
            }
        }
    }
}
