using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using static RakuRakuMorakun.Common;

namespace RakuRakuMorakun
{
    public class GridController
    {
        private DataTable CtpDataTable;
        private Condition[] CtpConditionArr;
        private readonly Color cEnable = Color.White;
        private readonly Color cDisenable = Color.Gray;
        private int CnIteratorCount;  //反復子をカウント
        private int CnConditionCount; //条件付き文字列のカウント

        public GridController(){
            CtpDataTable = new DataTable();
            CtpConditionArr = new Condition[] { };
            CnIteratorCount = 0;
            CnConditionCount = 0;

            ////デバッグ用にデータを作る
            //CtpDataTable.Add(new CoveringIterator("{#1}", new string[] { "AA", "BB", }));
            //CtpDataTable.Add(new CoveringIterator("{#2}", new string[] { "ああ", "いい", "うう" }, new bool[] { true, false, false }));
            //CtpDataTable.Add(new CoveringIterator("{#1}", new string[] { "AA", "BB", }));
            //CtpDataTable.Add(new CoveringIterator("{#2}", new string[] { "ああ", "いい", "うう" }, new bool[] { true, false, false }));

        }

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
        public void AddColumn(DataGridView GridView, bool blDefaultEnabled = true) {

            //新しい列の名前
            string stName = GetNextIteratorName();

            //列を追加
            GridView.Columns.Add(stName, stName);

            //並び替えができないようにする
            foreach (DataGridViewColumn column in GridView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            if (blDefaultEnabled){return;}

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
                for (int nRow = cell.RowIndex; nRow < GridView.RowCount ; nRow++)
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
                for (int nRow = GridView.Rows.Count - 1 ; 0 <= nRow ; nRow--)
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

            //1件はかならずある
            stResult[lCount++] = Converter.ConvertStrData(stTemplate, CtpDataTable, CtpConditionArr);
            //取得予定件数に達したら終了
            if (lCount >= lGetCount) { return stResult; }
            int nRtn = CtpDataTable.NextIndex();
            while (nRtn == (int)DataTable.INDEX_FLAG.NEXT)
            {
                stResult[lCount++] = Converter.ConvertStrData(stTemplate, CtpDataTable, CtpConditionArr);
                nRtn = CtpDataTable.NextIndex();
                //取得予定件数に達したら終了
                if (lCount >= lGetCount) { return stResult; }
            }
            return stResult;
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

        //カウントを1つ上げて名前を返す
        public string GetNextIteratorName()
        {
            CnIteratorCount++;
            return string.Format(TEXT_FORMAT_ITERATOR, CnIteratorCount.ToString());
        }

        public string[] GetItemsByName(string stName)
        {
            return CtpDataTable.GetItemsByName(stName);
        }

        //選択されているセルの中の最も左上のセルを返す。選択されていなければnullを返す
        public DataGridViewCell GetSelectedCell(DataGridView DataGrid)
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

        //選択しているcell（左上）からペーストする
        public void PasteGrid(DataGridView grdDataGrid)
        {
            //クリップボードに文字列データがなければ抜ける
            if (!Clipboard.ContainsText()) { return; }

            //文字列データがあるときはこれを取得する。取得できないときは空の文字列（String.Empty）を返す
            string stText = Clipboard.GetText();

            string[] stRowsArr = stText.Split(new string[] { "\r\n" }, StringSplitOptions.None);
            int nSelectedRow = GetSelectedCell(grdDataGrid).RowIndex;
            int nNeedAddRows = nSelectedRow + stRowsArr.Length - grdDataGrid.RowCount;

            //足りない分の行を追加
            for (int i = 0; i < nNeedAddRows; i++)
            {
                grdDataGrid.Rows.Add();
                
            }

            for (int i = 0; i < stRowsArr.Length; i++)
            {
                PasteRow(grdDataGrid, i + nSelectedRow, stRowsArr[i]);
            }


        }

        //改行区切りの1列を貼り付ける。行数をオーバーするときは追加する
        public void PasteRow(DataGridView grdDataGrid, int nRow, string stText)
        {

            string[] stColsArr = stText.Split(new string[] { "\t" }, StringSplitOptions.None);
            int nSelectedColumn = GetSelectedCell(grdDataGrid).ColumnIndex;
            int nNeedAddCols = nSelectedColumn + stColsArr.Length - grdDataGrid.ColumnCount;

            //足りない分の列を追加
            for (int i = 0; i < nNeedAddCols; i++)
            {
                AddColumn(grdDataGrid);
            }

            for (int i = 0; i < stColsArr.Length; i++)
            {
                grdDataGrid[i + nSelectedColumn, nRow].Value = stColsArr[i];
            }


        }

        public long Total { get { return CtpDataTable.Total; } }
        public string[] Names { get { return CtpDataTable.GetNames(); } }

    }


}
