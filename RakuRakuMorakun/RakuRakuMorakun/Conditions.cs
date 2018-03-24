using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using static RakuRakuMorakun.Common;

namespace RakuRakuMorakun
{
    //条件付きで変化する文字列。複数の条件をまとめて結果を返す。
    [Serializable] // シリアル化可能
    public class Condition
    {
        private string CstName; //識別子
        private string CstTrueValue; //真のときの値
        private string CstFalseValue; //偽のときの値
        private string CstLogic; //AND OR
        private ConditionElement[] CtpConditions; //条件の配列

        public string Name{get{return CstName;} set { CstName = value; } }
        public string TrueText { get { return CstTrueValue; } set { CstTrueValue = value; } }
        public string FalseText { get { return CstFalseValue; } set { CstFalseValue = value; } }
        public string Logic { get { return CstLogic; } set { CstLogic = value; } }

        public Condition(string stName = "", string stTrue = "", string stFalse = "", string stLogic = "", ConditionElement[] tpConditions = null)
        {
            CstName = stName;
            CstTrueValue = stTrue;
            CstFalseValue = stFalse;
            CstLogic = stLogic;
            CtpConditions = tpConditions ?? (new ConditionElement[] { }); //nullなら初期化
        }

        public int Length { get { return CtpConditions.Length; } }

        public ConditionElement GetElement( int nIndex)
        {
            return CtpConditions[nIndex];
        }

        public void SetElement(int nIndex,ConditionElement tpElement)
        {
            CtpConditions[nIndex] = tpElement;
        }

        public void AddElement(ConditionElement tpElement) {
            int nMax = CtpConditions.Length;
            Array.Resize(ref CtpConditions, nMax + 1);
            CtpConditions[nMax] = tpElement;
        }

        public void DeleteElement(int nIndex)
        {
            bool blFind = false;
            int nCount = 0;

            for (int i = 0; i < CtpConditions.Length; i++)
            {
                nCount++;

                if (i == nIndex)
                {
                    blFind = true;
                    CtpConditions[i] = null;
                    if (CtpConditions.Length == 1) { break; }
                    continue;
                }

                if (blFind)
                {
                    CtpConditions[i - 1] = CtpConditions[i];
                }
            }

            Array.Resize(ref CtpConditions, nCount - 1);
        }

        //判別した結果の文字列を返す
        public string GetResultString(DataTable tpData)
        {
            return (Judge(tpData)) ? CstTrueValue : CstFalseValue;
        }

        // 全ての条件を見てTrueかFalseの判断を下す。ショートサーキットする。
        private bool Judge(DataTable tpData)
        {
            if (CtpConditions.Length < 1) { return true; } //無条件でTrue

            if (CstLogic == AND) //AND条件
            {
                for (int i = 0; i < CtpConditions.Length; i++)
                {
                    if (!CtpConditions[i].Judge(tpData)) { return false; } //AND条件のときはfalseでショートサーキット
                }
                return true;
            }
            else if (CstLogic == OR) //OR条件
            {
                for (int i = 0; i < CtpConditions.Length; i++)
                {
                    if (CtpConditions[i].Judge(tpData)) { return true; } //OR条件のときはtrueでショートサーキット
                }
                return false;
            }
            else
            {
                return false;
            }
        }

        public virtual string GetText()
        {
            string stRtn = "";
            for (int i = 0; i < CtpConditions.Length; i++)
            {
                stRtn += CtpConditions[i].GetText() + CstLogic;
            }

            //余計なCstLogic分を削る
            if (stRtn.Length > CstLogic.Length)
            {
                stRtn = stRtn.Substring(0, stRtn.Length - CstLogic.Length);
            }

            //条件なし
            if (stRtn == "") { stRtn = "無条件でTrue" ;  }
            return stRtn;
        }

        //コピーを返す
        public Condition Copy()
        {
            return CloneObject(this);
        }
    }



    //条件の最小単位（基底クラス）
    [Serializable] // シリアル化可能
    public class ConditionElement
    {

        protected string CstOperator; //演算子

        public ConditionElement(string stOperator)
        {
            CstOperator = stOperator;
        }

        public virtual string GetText() { return ""; }
        public virtual bool Judge(DataTable tpData) { return false; }

        public virtual string GetCondition(){ return ""; }
        public virtual string GetTarget() { return ""; }
        public virtual string GetOperator() { return CstOperator; }
    }

    // 文字列を対象とする条件
    [Serializable] // シリアル化可能
    public class ConditionOfString : ConditionElement
    {

        private string CstTargetName; //比較する反復子の名前
        private string CstTargetValue; //比較する値

        public ConditionOfString(string stTargetName, string stTargetValue, string stOperator) : base(stOperator)
        {
            CstTargetName = stTargetName;
            CstTargetValue = stTargetValue;
        }

        public override string GetText()
        {
            return CstTargetName + "が" + CstTargetValue + CstOperator;
        }

        public override bool Judge(DataTable tpData)
        {
            Dictionary<string, string> dicNameValue = tpData.GetDictOfNowIndex();

            if (!dicNameValue.ContainsKey(CstTargetName)) { return false; }

            string stCurrentValue = dicNameValue[CstTargetName];

            //Switch文に変数が使えないため
            if (CstOperator == EQUAL)
            {
                return (stCurrentValue == CstTargetValue);
            }
            else if (CstOperator == NOTEQUAL)
            {
                return (stCurrentValue != CstTargetValue);
            }
            else
            {
                return false;
            }
        }

        public override string GetCondition()
        {
            return CstTargetName;
        }

        public override string GetTarget()
        {
            return CstTargetValue;
        }

    }

    //番号を対象とする条件
    [Serializable] // シリアル化可能
    public class ConditionOfNumber : ConditionElement
    {

        private long ClTargetNumber; //比較する番号

        public ConditionOfNumber(long lTargetNumber, string stOperator) : base(stOperator)
        {
            ClTargetNumber = lTargetNumber;
        }

        public override string GetText()
        {
            return NUMBER_CAPTION + ClTargetNumber.ToString() + CstOperator;
        }

        public override bool Judge(DataTable tpData)
        {
            Dictionary<string, string> dicNameValue = tpData.GetDictOfNowIndex();

            if (tpData.Total < 1) { return false; }

            // 番号はインデックスに1足した値
            long lCurrentNumber = tpData.Index + 1;

            //Switch文に変数が使えないため
            if (CstOperator == EQUAL)
            {
                return (lCurrentNumber == ClTargetNumber);
            }
            else if (CstOperator == NOTEQUAL)
            {
                return (lCurrentNumber != ClTargetNumber);
            }
            else if (CstOperator == UNDER)
            {
                return (lCurrentNumber < ClTargetNumber);
            }
            else if (CstOperator == OVER)
            {
                return (lCurrentNumber >= ClTargetNumber);
            }
            else
            {
                return false;
            }
        }

        public override string GetCondition()
        {
            return NUMBER_CAPTION;
        }

        public override string GetTarget()
        {
            return ClTargetNumber.ToString();
        }
    }


}
