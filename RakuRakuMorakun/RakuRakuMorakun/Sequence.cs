using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RakuRakuMorakun
{
    [Serializable]
    public class Sequence
    {
        private string CstName;
        private string[] CstItems;


        public Sequence(string stName = "", string[] stItems = null)
        {
            CstName = stName;
            CstItems = stItems;
        }

        /// //////////////////////////////////////////////////////////////////////////////////////
        /// プロパティ
        /// //////////////////////////////////////////////////////////////////////////////////////

        public string Name { set { CstName = value; } get { return CstName; } }
        public long Length { get { return CstItems.Length; } }
        public string[] Items { set { CstItems = value; }}
        public string Text { get{ return string.Join(",", CstItems); } }

        public string Item(int nIndex)
        {
            if (CstItems == null) { return ""; }
            if (nIndex < 0 || nIndex >= CstItems.Length) { return ""; }
            return CstItems[nIndex];
        }






    }
}
