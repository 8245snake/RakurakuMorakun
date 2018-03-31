using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RakuRakuMorakun
{
    //反復子クラス
    [Serializable]
    public class CoveringIterator
    {
        private string CstName;
        private string[] CstCoveringPatternArr;
        private bool[] CblValidityArr;


        public CoveringIterator(string stName, string[] stItems = null, bool[] blValid = null)
        {
            int nMax;
            CstName = stName;

            if (stItems != null)
            {
                CstCoveringPatternArr = stItems;
            }
            else
            {
                CstCoveringPatternArr = new string[] { };
            }

            if (blValid != null)
            {
                CblValidityArr = blValid;
            }
            else
            {
                nMax = CstCoveringPatternArr.Length;
                CblValidityArr = new bool[nMax];
                for (int i = 0; i < nMax; i++)
                {
                    CblValidityArr[i] = true;
                }
            }
        }

        //要素の配列を返す
        public string[] GetItemArr()
        {
            return CstCoveringPatternArr;
        }

        //有効無効の配列を返す
        public bool[] GetValidArr()
        {
            return CblValidityArr;
        }

        //配列の要素数を返すプロパティ
        public int Length
        {
            get
            {
                return CstCoveringPatternArr.Length;
            }
        }

        //有効な要素数を返すプロパティ
        public int Count
        {
            get {
                int nCount = 0;
                for (int i = 0; i < CstCoveringPatternArr.Length; i++)
                {
                    if (CblValidityArr[i]) { nCount += 1; }
                }
                return nCount;
            }
        }

        //配列に要素を追加
        public void Add(string stItem)
        {
            int nMax = CstCoveringPatternArr.Length;
            Array.Resize(ref CstCoveringPatternArr, nMax + 1);
            CstCoveringPatternArr[nMax] = stItem;
            Array.Resize(ref CblValidityArr, nMax + 1);
            CblValidityArr[nMax] = true;
        }

        //配列に要素を追加
        public void Add(string[] stItem)
        {
            int nMax = CstCoveringPatternArr.Length;
            int nAddCount = stItem.Length;

            Array.Resize(ref CstCoveringPatternArr, nMax + nAddCount);
            Array.Resize(ref CblValidityArr, nMax + nAddCount);

            for (int i = nMax; i < nMax + nAddCount; i++)
            {
                CstCoveringPatternArr[i] = stItem[i - nMax];
                CblValidityArr[i] = true;
            }
        }

        //配列に要素を追加
        public void Add(string[] stItem, bool[] blValid)
        {
            int nMax = CstCoveringPatternArr.Length;
            int nAddCount = stItem.Length;

            Array.Resize(ref CstCoveringPatternArr, nMax + nAddCount);
            Array.Resize(ref CblValidityArr, nMax + nAddCount);

            for (int i = nMax; i < nMax + nAddCount; i++)
            {
                CstCoveringPatternArr[i] = stItem[i - nMax];
                CblValidityArr[i] = blValid[i - nMax];
            }
        }

        //配列に要素を追加（有効無効を設定）
        public void Add(string stItem, bool blValid)
        {
            int nMax = CstCoveringPatternArr.Length;
            Array.Resize(ref CstCoveringPatternArr, nMax + 1);
            CstCoveringPatternArr[nMax] = stItem;
            Array.Resize(ref CblValidityArr, nMax + 1);
            CblValidityArr[nMax] = blValid;
        }

        //全部FalseのときはFalseを返す
        public bool IsEnabled
        {
            get
            {
                for (int i = 0; i < CblValidityArr.Length; i++)
                {
                    if (CblValidityArr[i]) { return true; }
                }
                return false;
            }
        }

        public string Name { set { CstName = value; } get { return CstName; } }

        public void Item(int nIndex, string stItem) { CstCoveringPatternArr[nIndex] = stItem; }
        public string Item(int nIndex) { return CstCoveringPatternArr[nIndex]; }

        public void Enabled(int nIndex, bool blEnabled){ CblValidityArr[nIndex] = blEnabled;}
        public bool Enabled(int nIndex){return CblValidityArr[nIndex];}

        public override string ToString()
        {
            return string.Join(",", CstCoveringPatternArr);
        }
    }
}
