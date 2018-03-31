using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using static RakuRakuMorakun.Common;

namespace RakuRakuMorakun
{

    public static class Converter
    {
        //DataTableオブジェクトを元にしてテンプレート内の置換を行う。カウントアップは呼び出し元で行う。
        public static string ConvertStrData(string stTemplate, GridController tpController)
        {
            if (stTemplate.Length < 1) { return ""; }

            //条件付き文字列の置換
            stTemplate = ReplaceCondition(stTemplate, tpController);

            //シーケンスの置換
            stTemplate = ReplaceSequence(stTemplate, tpController);

            //番号の置換
            stTemplate = ReplaceNumber(stTemplate, tpController);

            //式の置換
            stTemplate = EvaluateExpression(stTemplate, tpController);

            //反復子の置換
            stTemplate = ReplaceIterator(stTemplate, tpController);

            return stTemplate;
        }


        //条件付き文字列の置換
        private static string ReplaceCondition(string stTemplate, GridController tpController)
        {
            if (tpController == null) { return ""; }

            DataTable tpData = tpController.GetDataTable();
            Condition[] tpConditions = tpController.GetConditions();

            for (int i = 0; i < tpConditions.Length; i++)
            {
                stTemplate = stTemplate.Replace(tpConditions[i].Name, tpConditions[i].GetResultString(tpData));
            }

            return stTemplate;
        }


        // 番号を0埋めで置換する
        private static string ReplaceNumber(string stTemplate, GridController tpController )
        {
            Regex reg = new Regex("{0:0*}");
            string stTarget;
            string stFormatted;
            long lNumber = tpController.GetDataTable().Index + 1;

            //正規表現と一致する対象を1つ検索
            Match match = reg.Match(stTemplate);

            while (match.Success)
            {
                //一致したら0埋め数値に置換
                stTarget = match.Value;
                stFormatted = string.Format(stTarget, lNumber);
                stTemplate = stTemplate.Replace(stTarget, stFormatted);
                //次に一致する対象を検索
                match = match.NextMatch();
            }

            return stTemplate;
        }

        //シーケンスを置換する
        private static string ReplaceSequence(string stTemplate, GridController tpController)
        {
            if (tpController == null) { return ""; }

            DataTable tpData = tpController.GetDataTable();
            Sequence[] tpSeqences = tpController.GetSequences();
            long lNumber = tpData.Index + 1;

            for (int i = 0; i < tpSeqences.Length; i++)
            {
                stTemplate = stTemplate.Replace(tpSeqences[i].Name, tpSeqences[i].Item((int)lNumber-1));
            }

            return stTemplate;
        } 

        //式を評価して置換する
        private static string EvaluateExpression(string stTemplate, GridController tpController)
        {
            Regex reg = new Regex("{=(?<Expression>[^}]*)}");

            string stTarget;
            string stExpression;
            long lNumber = tpController.GetDataTable().Index + 1;

            //正規表現と一致する対象を1つ検索
            Match match = reg.Match(stTemplate);

            while (match.Success)
            {
                stTarget = match.Value;
                stExpression = match.Groups["Expression"].Value;

                stTemplate = stTemplate.Replace(stTarget, Eval(stExpression, "num", lNumber.ToString()));

                //次に一致する対象を検索
                match = match.NextMatch();
            }

            return stTemplate;
        }

        //反復子の置換
        private static string ReplaceIterator(string stTemplate, GridController tpController)
        {
            if (tpController == null) { return ""; }

            DataTable tpData = tpController.GetDataTable();
            Dictionary<string, string> dicNameValue = tpData.GetDictOfNowIndex();

            //反復子の置換
            foreach (KeyValuePair<string, string> pair in dicNameValue)
            {
                stTemplate = stTemplate.Replace(pair.Key, pair.Value);
            }

            return stTemplate;
        }



        /// <summary>
        /// 条件付き文字列の名前を渡して現在の値を返す
        /// </summary>
        /// <param name="stName">条件付き文字列の名前</param>
        /// <param name="tpData">反復子データ</param>
        /// <param name="tpConditions">条件付き文字列の配列</param>
        /// <returns></returns>
        public static string ConvertConditionString(string stName, GridController tpController)
        {
            if (tpController == null) { return ""; }

            DataTable tpData = tpController.GetDataTable();
            Condition[] tpConditions = tpController.GetConditions();

            for (int i = 0; i < tpConditions.Length; i++)
            {
                if (tpConditions[i].Name == stName)
                {
                    return tpConditions[i].GetResultString(tpData);
                }
            }
            return "";
        }
    }
}
