using System;
using System.Collections.Generic;

namespace RakuRakuMorakun
{
    public class DataTable
    {
        public enum INDEX_FLAG : int { NEXT, END };
        private CoveringIterator[] CtpTable;
        private int[] CnIndexArray;
        private long lNowIndex;

        public DataTable()
        {
            CtpTable = new CoveringIterator[] { };
        }

        //配列に要素を追加。同じ名前の要素が来たら末尾に追加する。
        public void Add(CoveringIterator tpItem)
        {
            bool blFind = false;
            int nIndex = 0;

            // 同じ名前の要素があるか探す
            for (int i = 0; i < CtpTable.Length; i++)
            {
                if (CtpTable[i].Name == tpItem.Name)
                {
                    blFind = true;
                    nIndex = i;
                    break;
                }
            }

            if (blFind) //あったらマージ
            {
                string[] stItemArr = tpItem.GetItemArr();
                bool[] blValidArr = tpItem.GetValidArr();

                CtpTable[nIndex].Add(stItemArr, blValidArr);
            }
            else //なければ普通に追加
            {
                int nMax = CtpTable.Length;
                Array.Resize(ref CtpTable, nMax + 1);
                CtpTable[nMax] = tpItem;
            }

        }

        //要素を削除（配列サイズが1つ減る）
        public void Delete(int nIndex)
        {
            int nMax = CtpTable.Length;
            if (nMax < 1) { return; }

            for (int i = nIndex + 1; i < CtpTable.Length; i++)
            {
                CtpTable[i - 1] = CtpTable[i];
            }
            Array.Resize(ref CtpTable, nMax - 1);
        }

        //インデックス配列を初期化する。カウントアップの前に呼ぶ。
        public void InitIndex()
        {
            CnIndexArray = new int[CtpTable.Length];
            lNowIndex = 0;
            for (int i = 0; i < CnIndexArray.Length; i++)
            {
                CnIndexArray[i] = 0;
            }
        }

        //インデックス配列を次に進める
        public int NextIndex()
        {
            bool blNotZero = false;
            for (int i = 0; i < CnIndexArray.Length; i++)
            {
                if (CnIndexArray[i] < CtpTable[i].Count - 1)
                {
                    CnIndexArray[i] += 1;
                    lNowIndex += 1;
                    return (int)INDEX_FLAG.NEXT;
                }
                CnIndexArray[i] = 0;
            }

            for (int i = 0; i < CnIndexArray.Length; i++)
            {
                if (CnIndexArray[i] != 0){blNotZero = true;}
            }

            if (blNotZero){
                lNowIndex += 1;
                return (int)INDEX_FLAG.NEXT;
            }
            lNowIndex = 0;
            return (int)INDEX_FLAG.END;
        }

        //現在のインデックスのパターンを辞書で返す
        public Dictionary<string, string> GetDictOfNowIndex()
        {
            Dictionary<string, string> dicNameValue = new Dictionary<string, string>();
            string stKey;
            string stValue;
            int nRow;
            for (int nColumn = 0; nColumn < CnIndexArray.Length; nColumn++)
            {
                if (!CtpTable[nColumn].Enabled()) { continue; }
                stKey = CtpTable[nColumn].Name;
                nRow = CnIndexArray[nColumn];
                stValue = Item(nRow, nColumn);
                dicNameValue.Add(stKey, stValue);
            }

            return dicNameValue;
        }

        //現在のインデックスのパターンを文字列で返す
        public string GetNowString()
        {
            Dictionary<string, string> dicNameValue = GetDictOfNowIndex();
            if (dicNameValue.Count < 1) { return ""; }
            string stRtn = "";
            foreach (KeyValuePair<string, string> pair in dicNameValue)
            {
                stRtn += ", " + pair.Key + " = " + pair.Value;
            }
            stRtn = stRtn.Substring(2);
            return stRtn;
        }

        //網羅回数を返すプロパティ
        public long Total
        {
            get
            {
                long lCount = 1;
                bool blNotZero = false;

                for (int i = 0; i < CtpTable.Length; i++)
                {
                    if (CtpTable[i].Count < 1) { continue; }
                    lCount *= CtpTable[i].Count;
                    blNotZero = true;
                }
                return (blNotZero)? lCount : 0;
            }
        }

        // グリッドで確保すべき行数を返す（1以上）
        public int Rows {
            get
            {
                int nMax = 1;
                for (int i = 0; i < CtpTable.Length; i++)
                {
                    nMax = (nMax < CtpTable[i].Length) ? CtpTable[i].Length : nMax;
                }
                return nMax;
            }
        }

        // グリッドで確保すべき列数を返す（1以上）
        public int Columns
        {
            get
            {
                return (CtpTable.Length > 0)? CtpTable.Length : 1;
            }
        }

        //現在のインデックスを返す
        public long Index { get { return lNowIndex; } }

        public string Name(int nIndex)
        {
            return CtpTable[nIndex].Name;
        }


        //反復子名の配列を取得。無効でも取得する。
        public string[] GetNames()
        {
            string[] stNames = new string[CtpTable.Length];

            for (int nCol = 0; nCol < CtpTable.Length; nCol++)
            {
                stNames[nCol] = CtpTable[nCol].Name;
            }
            return stNames;
        }

        //名前から要素の配列を返す。無効なものも返す。
        public string[] GetItemsByName(string stName) {
            int nCol = 0;

            for (int i = 0; i < CtpTable.Length; i++)
            {
                if (CtpTable[i].Name == stName)
                {
                    nCol = i;
                    break;
                }
            }
            return CtpTable[nCol].GetItemArr();
        }

        public void Item(int nRow, int nColumn, string stItem){
            if (CtpTable.Length <= nColumn) { return; }
            if (CtpTable[nColumn].Length <= nRow) { return; }
            CtpTable[nColumn].Item(nRow, stItem);
        }

        public string Item(int nRow, int nColumn){
            if (CtpTable.Length <= nColumn) { return ""; }
            if (CtpTable[nColumn].Length <= nRow) { return ""; }
            return CtpTable[nColumn].Item(nRow);
        }

        public void Enabled(int nRow, int nColumn, bool blEnabled)
        {
            if (CtpTable.Length <= nColumn) { return; }
            if (CtpTable[nColumn].Length <= nRow) { return; }
            CtpTable[nColumn].Enabled(nRow, blEnabled);
        }

        public bool Enabled(int nRow, int nColumn)
        {
            if (CtpTable.Length <= nColumn) { return false; }
            if (CtpTable[nColumn].Length <= nRow) { return false; }
            return CtpTable[nColumn].Enabled(nRow);
        }

    }
}
