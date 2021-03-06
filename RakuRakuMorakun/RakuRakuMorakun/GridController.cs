﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using static RakuRakuMorakun.Common;

namespace RakuRakuMorakun
{
    [Serializable]
    public class GridController
    {
        private DataTable CtpDataTable;   //反復子
        private Condition[] CtpConditionArr;  //条件付き文字列
        private Sequence[] CtpSequenceArr;  //シーケンス

        private int CnIteratorCount;  //反復子をカウント
        private int CnConditionCount; //条件付き文字列のカウント
        private int CnSequenceCount; //シーケンスのカウント
        private string CstTemplate = ""; //テンプレート文字列（ファイル保存用）

        private readonly Color cEnable = Color.White;  //有効セルの色
        private readonly Color cDisenable = Color.Gray;  //無効セルの色

        public GridController(){
            CtpDataTable = new DataTable();
            CtpConditionArr = new Condition[] { };
            CtpSequenceArr = new Sequence[] { };
            CnIteratorCount = 0;
            CnConditionCount = 0;
            CnSequenceCount = 0;
        }

        /// //////////////////////////////////////////////////////////////////////////////////////
        /// プロパティ
        /// //////////////////////////////////////////////////////////////////////////////////////

        public long Total { get { return CtpDataTable.Total; } }
        public string Template { get { return CstTemplate; } set { CstTemplate = value; } }

        /// //////////////////////////////////////////////////////////////////////////////////////
        /// 反復子
        /// //////////////////////////////////////////////////////////////////////////////////////

        //反復子をグリッドから取得
        public void GetDataFromGrid(DataGridView GridView)
        {
            string stName;
            string stItem;
            CoveringIterator tpIterator;
            DataGridViewCell cell;

            CtpDataTable = new DataTable();

            for (int nCol = 0; nCol < GridView.ColumnCount; nCol++)
            {
                stName = GridView.Columns[nCol].HeaderText;
                tpIterator = new CoveringIterator(stName);
                for (int nRow = 0; nRow < GridView.RowCount; nRow++)
                {
                    cell = GridView[nCol, nRow];
                    //空白セルにnullが入っていることがある
                    stItem = (cell.Value != null) ? cell.Value.ToString() : "";
                    tpIterator.Add(stItem, (cell.Style.BackColor != cDisenable));
                }
                CtpDataTable.Add(tpIterator);
            }
        }

        //グリッドに反復子を反映
        public void SetDataToGrid(DataGridView GridView)
        {
            //消去
            GridView.Rows.Clear();
            GridView.Columns.Clear();

            if (CtpDataTable.Total < 1)
            {
                //反復子がなくても最低でも1行1列は作る
                AddColumn(GridView);
                GridView.Rows.Add();
                return;
            }

            //行数・列数を設定
            GridView.RowCount = CtpDataTable.Rows;
            GridView.ColumnCount = CtpDataTable.Columns;

            for (int nCol = 0; nCol < GridView.ColumnCount; nCol++)
            {
                ////列タイトルと列名は反復子の名前
                GridView.Columns[nCol].Name = CtpDataTable.Name(nCol);
                GridView.Columns[nCol].HeaderText = CtpDataTable.Name(nCol);

                for (int nRow = 0; nRow < CtpDataTable.Rows; nRow++)
                {
                    //セルに値を格納
                    GridView[nCol, nRow].Value = CtpDataTable.Item(nRow, nCol);
                    //有効無効を色で表現
                    GridView[nCol, nRow].Style.BackColor = (CtpDataTable.Enabled(nRow, nCol)) ? cEnable : cDisenable;
                }
            }

            //並び替えができないようにする
            foreach (DataGridViewColumn column in GridView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        //右端に列を追加
        public void AddColumn(DataGridView GridView, bool blDefaultEnabled = true)
        {
            //新しい列の名前
            string stName = GetNextIteratorName();

            //列を追加
            GridView.Columns.Add(stName, stName);

            //並び替えができないようにする
            foreach (DataGridViewColumn column in GridView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            if (blDefaultEnabled) { return; }

            //デフォルトでグレーアウトして追加したい場合
            for (int nRow = 0; nRow < GridView.RowCount; nRow++)
            {
                GridView[GridView.ColumnCount - 1, nRow].Style.BackColor = cDisenable;
            }
        }

        //選択されている列を削除。列タイトルなどはそのままでシフトさせる
        public void DeleteColumn(DataGridView GridView)
        {
            //選択されているセルを取得
            foreach (DataGridViewCell cell in GridView.SelectedCells)
            {
                GridView.Columns.RemoveAt(cell.ColumnIndex);
                return;
            }
        }

        //選択されているセルより上を全て有効化
        public void ValidCells(DataGridView GridView)
        {
            //選択されているセルを取得
            foreach (DataGridViewCell cell in GridView.SelectedCells)
            {
                cell.Style.BackColor = cEnable;
                for (int nRow = 0; nRow < cell.RowIndex; nRow++)
                {
                    GridView[cell.ColumnIndex, nRow].Style.BackColor = cEnable;
                }
            }
            GridView.ClearSelection();
        }

        //選択されているセルより下を全て無効化
        public void InvalidCells(DataGridView GridView)
        {
            //選択されているセルを取得
            foreach (DataGridViewCell cell in GridView.SelectedCells)
            {
                cell.Style.BackColor = cDisenable;
                for (int nRow = cell.RowIndex; nRow < GridView.RowCount; nRow++)
                {
                    GridView[cell.ColumnIndex, nRow].Style.BackColor = cDisenable;
                }
            }
            GridView.ClearSelection();
        }

        //それぞれの列について行の後ろから見ていって空白なら無効化、文字が入っていれば終了
        public void InvalidEmptyCell(DataGridView GridView)
        {
            for (int nCol = 0; nCol < GridView.Columns.Count; nCol++)
            {
                for (int nRow = GridView.Rows.Count - 1; 0 <= nRow; nRow--)
                {
                    if (GridView[nCol, nRow].Value == null)
                    {
                        GridView[nCol, nRow].Style.BackColor = cDisenable;
                    }
                    else if (GridView[nCol, nRow].Value.ToString() == "")
                    {
                        GridView[nCol, nRow].Style.BackColor = cDisenable;
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }

        //全てのセルを有効化
        public void ValidAllCell(DataGridView GridView)
        {
            for (int nCol = 0; nCol < GridView.Columns.Count; nCol++)
            {
                for (int nRow = 0; nRow < GridView.Rows.Count; nRow++)
                {
                    GridView[nCol, nRow].Style.BackColor = cEnable;
                }
            }
        }

        //それぞれの列について行の先頭から見ていって空でなければなら有効化、空白なら終了
        public void ValidNotEmptyCell(DataGridView GridView)
        {
            for (int nCol = 0; nCol < GridView.Columns.Count; nCol++)
            {
                for (int nRow = 0; nRow < GridView.Rows.Count; nRow++)
                {
                    if (GridView[nCol, nRow].Value != null)
                    {
                        GridView[nCol, nRow].Style.BackColor = cEnable;
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }

        //新規行をグレーアウトする
        public void InvalidNewRow(DataGridView grdMain)
        {
            for (int nRow = 0; nRow < grdMain.Rows.Count; nRow++)
            {
                if (grdMain.Rows[nRow].IsNewRow)
                {
                    for (int nCol = 0; nCol < grdMain.Columns.Count; nCol++)
                    {
                        grdMain[nCol, nRow].Style.BackColor = cDisenable;
                    }
                }
            }
        }

        //選択している列をnDirectionParamで指定した先と入れ替える
        public void MoveColumn(DataGridView grdMain, int nDirectionParam)
        {
            DataGridViewCell cell = GetSelectedCell(grdMain);
            if (cell == null) { return; }
            int nSelectedCol = cell.ColumnIndex;
            int nSelectedRow = cell.RowIndex;

            if (nSelectedCol + nDirectionParam < 0 || nSelectedCol + nDirectionParam >= grdMain.ColumnCount) { return; }

            object objCellValueBuff;
            string stCellValueBuff = "";
            Color color;

            //タイトルも入れ替える
            stCellValueBuff = grdMain.Columns[nSelectedCol + nDirectionParam].HeaderText;
            grdMain.Columns[nSelectedCol + nDirectionParam].HeaderText = grdMain.Columns[nSelectedCol].HeaderText;
            grdMain.Columns[nSelectedCol].HeaderText = stCellValueBuff;

            for (int nRow = 0; nRow < grdMain.Rows.Count; nRow++)
            {
                //セルの値を入れ替える
                objCellValueBuff = grdMain[nSelectedCol + nDirectionParam, nRow].Value;
                stCellValueBuff = (objCellValueBuff != null) ? objCellValueBuff.ToString() : "";
                grdMain[nSelectedCol + nDirectionParam, nRow].Value = grdMain[nSelectedCol, nRow].Value;
                grdMain[nSelectedCol, nRow].Value = stCellValueBuff;

                //セルの色を入れ替える
                color = grdMain[nSelectedCol + nDirectionParam, nRow].Style.BackColor;
                grdMain[nSelectedCol + nDirectionParam, nRow].Style.BackColor = grdMain[nSelectedCol, nRow].Style.BackColor;
                grdMain[nSelectedCol, nRow].Style.BackColor = color;
            }

            //セル選択もずらす
            grdMain.ClearSelection();
            grdMain[nSelectedCol + nDirectionParam, nSelectedRow].Selected = true;

        }

        //カウントを1つ上げて名前を返す
        public string GetNextIteratorName()
        {
            CnIteratorCount++;
            return string.Format(TEXT_FORMAT_ITERATOR, CnIteratorCount.ToString());
        }

        //反復子の名前を指定して値の配列を返す
        public string[] GetItemsByName(string stName, bool blOnlyValidItem = true)
        {
            int nCol;
            string[] stItemsArr = CtpDataTable.GetItemsByName(stName, out nCol);
            int nCount = 0;

            if (blOnlyValidItem)
            {
                for (int i = 0; i < stItemsArr.Length; i++)
                {
                    if (CtpDataTable.Enabled(i, nCol))
                    {
                        stItemsArr[i] = CtpDataTable.Item(i,nCol);
                        nCount++;
                    }
                }
                Array.Resize(ref stItemsArr, nCount);
            }

            return stItemsArr;
            
        }

        public DataTable GetDataTable() {
            return CtpDataTable;
        }

        public string[] GetNames()
        {
            return CtpDataTable.GetNames();
        }

        /// //////////////////////////////////////////////////////////////////////////////////////
        /// 条件付き文字列
        /// //////////////////////////////////////////////////////////////////////////////////////

        //配列に追加する。すでに同名の条件付き文字列があれば置き換える
        public void AddCondition(Condition tpCondition)
        {
            int nMax = CtpConditionArr.Length;

            for (int i = 0; i < nMax; i++)
            {
                if (CtpConditionArr[i].Name == tpCondition.Name)
                {
                    CtpConditionArr[i] = tpCondition;
                    return;
                }
            }
            //なければ配列を拡張して追加
            Array.Resize(ref CtpConditionArr, nMax + 1);
            CtpConditionArr[nMax] = tpCondition;
        }

        //名前を指定して条件付き文字列を削除
        public void  DeleteCondition(string stName)
        {
            bool blFind = false;
            int nCount = 0;

            for (int i = 0; i < CtpConditionArr.Length; i++)
            {
                nCount++;

                //名前は一意
                if (CtpConditionArr[i].Name == stName)
                {
                    blFind = true;
                    CtpConditionArr[i] = null;
                    if (CtpConditionArr.Length == 1) { break; }
                    continue;
                }

                if (blFind)
                {
                    CtpConditionArr[i - 1] = CtpConditionArr[i];
                }
            }

            Array.Resize(ref CtpConditionArr, nCount - 1);
        }

        //フィールド内の条件付き文字列をグリッドに表示
        public void SetConditionToGrid(DataGridView grdCondition) {
            grdCondition.Rows.Clear();

            for (int nRow = 0; nRow < CtpConditionArr.Length; nRow++)
            {
                grdCondition.Rows.Add();
                //ToDo:列挙体にする
                grdCondition[0, nRow].Value = CtpConditionArr[nRow].Name;
                grdCondition[1, nRow].Value = CtpConditionArr[nRow].GetText();
                grdCondition[2, nRow].Value = CtpConditionArr[nRow].TrueText;
                grdCondition[3, nRow].Value = CtpConditionArr[nRow].FalseText;
            }
        }

        //名前を渡して条件付き文字列を返す。
        //既になければnewする
        public Condition GetCondition(string stName)
        {
            for (int i = 0; i < CtpConditionArr.Length; i++)
            {
                if (CtpConditionArr[i].Name == stName) { return CtpConditionArr[i]; }
            }

            return new Condition(stName);
        }

        //カウントを1つ上げて名前を返す
        public string GetNextConditionName()
        {
            CnConditionCount++;
            return string.Format(TEXT_FORMAT_CONDITION, CnConditionCount.ToString());
        }

        public Condition[] GetConditions()
        {
            return CtpConditionArr;
        }

        /// <summary>
        /// 条件付き文字列の名前の配列を返す
        /// </summary>
        /// <returns>条件付き文字列の名前の配列</returns>
        public string[] GetConditionNames()
        {
            string[] ConditionNames;

            ConditionNames = new string[CtpConditionArr.Length];

            for (int i = 0; i < CtpConditionArr.Length; i++)
            {
                ConditionNames[i] = CtpConditionArr[i].Name;
            }

            return ConditionNames;
        }

        /// //////////////////////////////////////////////////////////////////////////////////////
        /// シーケンス
        /// //////////////////////////////////////////////////////////////////////////////////////


        //配列に追加する。すでに同名のシーケンスがあれば置き換える
        public void AddSequence(Sequence tpSequence)
        {
            int nMax = CtpSequenceArr.Length;

            for (int i = 0; i < nMax; i++)
            {
                if (CtpSequenceArr[i].Name == tpSequence.Name)
                {
                    CtpSequenceArr[i] = tpSequence;
                    return;
                }
            }
            //なければ配列を拡張して追加
            Array.Resize(ref CtpSequenceArr, nMax + 1);
            CtpSequenceArr[nMax] = tpSequence;
        }

        //名前を指定してシーケンスを削除
        public void DeleteSequence(string stName)
        {
            bool blFind = false;
            int nCount = 0;

            for (int i = 0; i < CtpSequenceArr.Length; i++)
            {
                nCount++;

                //名前は一意
                if (CtpSequenceArr[i].Name == stName)
                {
                    blFind = true;
                    CtpSequenceArr[i] = null;
                    if (CtpSequenceArr.Length == 1) { break; }
                    continue;
                }

                if (blFind)
                {
                    CtpSequenceArr[i - 1] = CtpSequenceArr[i];
                }
            }

            Array.Resize(ref CtpSequenceArr, nCount - 1);
        }

        //フィールド内のシーケンスをグリッドに表示
        public void SetSequenceToGrid(DataGridView grdSequence)
        {
            grdSequence.Rows.Clear();

            for (int nRow = 0; nRow < CtpSequenceArr.Length; nRow++)
            {
                grdSequence.Rows.Add();
                //ToDo:列挙体にする
                grdSequence[0, nRow].Value = CtpSequenceArr[nRow].Name;
                grdSequence[1, nRow].Value = CtpSequenceArr[nRow].Text;
            }
        }

        //名前を渡してシーケンスを返す。
        //既になければnewする
        public Sequence GetSequence(string stName)
        {
            for (int i = 0; i < CtpSequenceArr.Length; i++)
            {
                if (CtpSequenceArr[i].Name == stName) { return CtpSequenceArr[i]; }
            }

            return new Sequence(stName);
        }

        //カウントを1つ上げて名前を返す
        public string GetNextSequenceName()
        {
            CnSequenceCount++;
            return string.Format(TEXT_FORMAT_SEQUENCE, CnSequenceCount.ToString());
        }

        public Sequence[] GetSequences()
        {
            return CtpSequenceArr;
        }

        public string[] GetSequenceNames()
        {
            string[] SequenceNames;

            SequenceNames = new string[CtpSequenceArr.Length];

            for (int i = 0; i < CtpSequenceArr.Length; i++)
            {
                SequenceNames[i] = CtpSequenceArr[i].Name;
            }

            return SequenceNames;
        }

        /// //////////////////////////////////////////////////////////////////////////////////////
        /// グリッド操作関係
        /// //////////////////////////////////////////////////////////////////////////////////////

        /// <summary>
        /// 選択されているセルの中の最も左上のセルを返す。選択されていなければnullを返す
        /// </summary>
        /// <returns></returns>
        public static DataGridViewCell GetSelectedCell(DataGridView DataGrid)
        {
            int nColMin = -1;
            int nRowMin = -1;

            //選択されているセルを取得
            foreach (DataGridViewCell cell in DataGrid.SelectedCells)
            {
                if (nColMin < 0) { nColMin = cell.ColumnIndex; }
                if (nRowMin < 0) { nRowMin = cell.RowIndex; }

                if (cell.ColumnIndex < nColMin){nColMin = cell.ColumnIndex;}
                if (cell.RowIndex < nRowMin) {nRowMin = cell.RowIndex;}
            }
            //何も選択されていない
            if (nColMin < 0 || nRowMin < 0) { return null; }

            return DataGrid[nColMin, nRowMin];
        }


        //第二引数がtrueなら表示されている列数を返す
        public int GetColumnCount(DataGridView grdDataGrid, bool blOnlyVisibleColumn = true)
        {
            if (!blOnlyVisibleColumn) { return grdDataGrid.ColumnCount; }

            int nCount = 0;

            for (int i = 0; i < grdDataGrid.ColumnCount; i++)
            {
                if (grdDataGrid.Columns[i].Visible) { nCount++; }
            }

            return nCount;
        }

        //第二引数がtrueなら表示されている行数を返す
        public int GetRowCount(DataGridView grdDataGrid, bool blOnlyVisibleRow = true)
        {
            if (!blOnlyVisibleRow) { return grdDataGrid.RowCount; }

            int nCount = 0;

            for (int i = 0; i < grdDataGrid.RowCount; i++)
            {
                if (grdDataGrid.Rows[i].Visible) { nCount++; }
            }

            return nCount;
        }


        //選択しているcell（左上）からペーストする。行数をオーバーするとき追加するか指定できる
        public void PasteGrid(DataGridView grdDataGrid, bool blAddRow = true, bool blOnlyVisibleCell = true)
        {
            //クリップボードに文字列データがなければ抜ける
            if (!Clipboard.ContainsText()) { return; }

            //文字列データがあるときはこれを取得する。取得できないときは空の文字列（String.Empty）を返す
            string stText = Clipboard.GetText();

            string[] stRowsArr = stText.Split(new string[] { "\r\n" }, StringSplitOptions.None);
            int nSelectedRow = GetSelectedCell(grdDataGrid).RowIndex;
            int nNeedAddRows = nSelectedRow + stRowsArr.Length - GetRowCount(grdDataGrid, blOnlyVisibleCell);

            if (blAddRow)
            {
                //足りない分の行を追加
                for (int i = 0; i < nNeedAddRows; i++)
                {
                    grdDataGrid.Rows.Add();
                }
            }


            int nCount = 0;

            for (int i = nSelectedRow; i < grdDataGrid.RowCount; i++)
            {
                if (stRowsArr.Length <= nCount) { break; }

                if (grdDataGrid.Rows[i].Visible)
                {
                    PasteRow(grdDataGrid, i, stRowsArr[nCount], blAddRow);
                    nCount++;
                }

            }

        }


        //改行区切りの1列を貼り付ける。列数をオーバーするとき追加するか指定できる
        public void PasteRow(DataGridView grdDataGrid, int nRow, string stText, bool blAddColumn = true, bool blOnlyVisibleCell = true)
        {

            string[] stColsArr = stText.Split(new string[] { "\t" }, StringSplitOptions.None);
            int nSelectedColumn = GetSelectedCell(grdDataGrid).ColumnIndex;
            int nNeedAddCols = nSelectedColumn + stColsArr.Length - GetColumnCount(grdDataGrid, blOnlyVisibleCell);

            if (blAddColumn) //足りない分の列を追加
            {
                for (int i = 0; i < nNeedAddCols; i++)
                {
                    AddColumn(grdDataGrid);
                }
            }

            int nCount = 0;

            for (int i = nSelectedColumn; i < grdDataGrid.ColumnCount; i++)
            {
                if (stColsArr.Length <= nCount) { break; }

                if (grdDataGrid[i, nRow].Visible)
                {
                    grdDataGrid[i, nRow].Value = stColsArr[nCount];
                    nCount++;
                }
                
            }

        }

        //クリップボードにコピー
        public void CopyGrid(DataGridView grdDataGrid)
        {
            int nColMin = -1;
            int nColMax = -1;
            int nRowmin = -1;
            int nRowMax = -1;
            string stBuff = "";
            string stRowText = "";
            string stResult = "";

            //セルの選択範囲を見つける
            foreach (DataGridViewCell cell in grdDataGrid.SelectedCells)
            {
                if (nColMin < 0)
                {
                    nColMin = cell.ColumnIndex;
                    nColMax = cell.ColumnIndex;
                    nRowmin = cell.ColumnIndex;
                    nRowMax = cell.ColumnIndex;
                    continue;
                }

                nColMin = (nColMin > cell.ColumnIndex) ? cell.ColumnIndex : nColMin;
                nColMax = (nColMax < cell.ColumnIndex) ? nColMax : cell.ColumnIndex;
                nRowmin = (nRowmin > cell.RowIndex) ? cell.RowIndex : nRowmin;
                nRowMax = (nRowMax < cell.RowIndex) ? nRowMax : cell.RowIndex;
            }

            if (nColMin < 0) { return; } //何も選択されていない

            for (int nRow = nRowmin; nRow <= nRowMax; nRow++)
            {
                for (int nCol = nColMin; nCol <= nColMax; nCol++)
                {
                    stBuff = (grdDataGrid[nCol, nRow].Value != null) ? grdDataGrid[nCol, nRow].Value.ToString() : "";

                    if (stRowText != "")  { stRowText += "\t" + stBuff;  }
                    else { stRowText += stBuff;  }
                    
                }

                if (stResult != "") {stResult += "\r\n" + stRowText; }
                else {stResult += stRowText;}

            }

            Clipboard.SetText(stResult);
        }

        //列タイトルを渡して列インデックスを返す
        public int GetColIndexByHeaderText(DataGridView grdData, string stColName)
        {
            for (int i = 0; i < grdData.ColumnCount; i++)
            {
                if (grdData.Columns[i].HeaderText == stColName)
                {
                    return i;
                }
            }
            return -1;
        }

        /// //////////////////////////////////////////////////////////////////////////////////////
        /// その他の関数
        /// //////////////////////////////////////////////////////////////////////////////////////

        //置換結果を配列で返す。件数を指定することができる。
        public string[] CreateResultArr(DataGridView grdMain, string stTemplate, long lGetCount = 0)
        {
            //反復子をグリッドから取得
            GetDataFromGrid(grdMain);

            //インデックスを初期化
            CtpDataTable.InitIndex();
            string[] stResult;
            long lTotal = CtpDataTable.Total;
            long lCount = 0;

            //0件ならとりあえず空の配列を返す
            if (lTotal < 1) { return new string[1]; }

            if (lGetCount < 1) //第三引数が0以下なら全件取得
            {
                stResult = new string[lTotal];
                lGetCount = lTotal;
            }
            else
            {
                stResult = new string[lGetCount];
            }

            Converter converter = Converter.GetInstance();

            //1件はかならずある
            stResult[lCount++] = converter.ConvertStrData(stTemplate, this);
            //取得予定件数に達したら終了
            if (lCount >= lGetCount) { return stResult; }
            int nRtn = CtpDataTable.NextIndex();
            while (nRtn == (int)INDEX_FLAG.NEXT)
            {
                stResult[lCount++] = converter.ConvertStrData(stTemplate, this);
                nRtn = CtpDataTable.NextIndex();
                //取得予定件数に達したら終了
                if (lCount >= lGetCount) { return stResult; }
            }
            return stResult;
        }



    }


}
