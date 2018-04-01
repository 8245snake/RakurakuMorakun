using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static RakuRakuMorakun.Common;

namespace RakuRakuMorakun
{
    /// <summary>
    /// 設定を持つデータクラス
    /// </summary>
    [Serializable]
    public class SettingData
    {
        private Condition[] CtpConditionArr;  //条件付き文字列
        private DELEGATE_ID[] CtpDelegateIdArr;  //中身はint

        public SettingData(Condition[] tpConditions, DELEGATE_ID[] tpDelegateIdArr)
        {
            CtpConditionArr = tpConditions;
            CtpDelegateIdArr = tpDelegateIdArr;

            if (CtpConditionArr == null) { CtpConditionArr = new Condition[] { }; }
            if (CtpDelegateIdArr == null) { CtpDelegateIdArr = new DELEGATE_ID[] { }; }
        }

        public Condition[] Conditions
        {
            get
            {
                return CtpConditionArr;
            }
        }


        public DELEGATE_ID[] DelegateId
        {
            get
            {
                return CtpDelegateIdArr;
            }
        }
    }

}