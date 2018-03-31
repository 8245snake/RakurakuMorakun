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
    public partial class frmConditionSummary : Form
    {

        private GridController CtpController;

        public frmConditionSummary(GridController controller)
        {
            InitializeComponent();
            CtpController = controller;
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmConditionSummary_Load(object sender, EventArgs e)
        {
            InitGrid();

            OpitimizeFormSize();
        }

        //グリッド初期化
        private void InitGrid()
        {
            grdSummary.Rows.Clear();
            grdSummary.Columns.Clear();

            DataTable tpData = CtpController.GetDataTable();
            Dictionary<string, string> dicNameValue;
            int nNextFlg;
            int nRow = 0;

            string[] stNamesArr = tpData.GetNames();

            for (int i = 0; i < stNamesArr.Length; i++)
            {
                grdSummary.Columns.Add("Col" + i, stNamesArr[i]);
            }

            string[] stConditonNamesArr = CtpController.GetConditionNames();

            for (int i = 0; i < stConditonNamesArr.Length; i++)
            {
                grdSummary.Columns.Add("ConditionCol" + i, stConditonNamesArr[i]);
            }

            for (int i = 0; i < grdSummary.ColumnCount; i++)
            {
                grdSummary.Columns[i].ReadOnly = true;
                grdSummary.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            //インデックスを初期化
            tpData.InitIndex();
            nNextFlg = (int)INDEX_FLAG.NEXT;


            while (nNextFlg == (int)INDEX_FLAG.NEXT)
            {
                //行ヘッダーに番号入れる

                grdSummary.Rows.Add();
                grdSummary.Rows[nRow].HeaderCell.Value = (nRow + 1).ToString();

                //反復子の取得
                dicNameValue = tpData.GetDictOfNowIndex();

                //反復子を入れる
                foreach (KeyValuePair<string, string> pair in dicNameValue)
                {
                    SetCellByColName(pair.Key, nRow, pair.Value);
                }

                //条件付き文字列を入れる
                foreach (string stConditonName in stConditonNamesArr)
                {
                    SetCellByColName(stConditonName, nRow, Converter.ConvertConditionString(stConditonName,CtpController));
                }

                nRow++;
                nNextFlg = tpData.NextIndex();
            }

            //列の位置をユーザーが変更できるようにする
            grdSummary.AllowUserToOrderColumns = true;

        }

        //フォームのサイズをちょうどいいくらいにする
        private void OpitimizeFormSize()
        {
            int nMaxWidth = 1000;
            int nMaxHeight = 600;

            int nColWidthTotal = 0;
            int nRowHeightTotal = 0;
            int nMargin = 200;

            for (int i = 0; i < grdSummary.ColumnCount; i++)
            {
                nColWidthTotal += grdSummary.Columns[i].Width;
            }

            nRowHeightTotal = grdSummary.Rows[0].Height * grdSummary.RowCount;

            this.Width = (nColWidthTotal + nMargin < nMaxWidth)? nColWidthTotal + nMargin:nMaxWidth;
            this.Height = (nRowHeightTotal + nMargin < nMaxHeight) ? nRowHeightTotal + nMargin : nMaxHeight;
        }


        /// <summary>
        /// 列ヘッダー名と行数を指定して値を入れる
        /// </summary>
        /// <param name="stColName">列ヘッダー名</param>
        /// <param name="nRow">何行目か</param>
        /// <param name="stValue">書き込む値</param>
        private void SetCellByColName(string stColName, int nRow, string stValue)
        {
            int nTargetCol = CtpController.GetColIndexByHeaderText(grdSummary, stColName);

            if (nTargetCol < 0) { return; }

            grdSummary[nTargetCol, nRow].Value = stValue;

        }

    }
}
