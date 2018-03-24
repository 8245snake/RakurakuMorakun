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
        public static string ConvertStrData(string stTemplate, DataTable tpData, Condition[] tpConditions = null)
        {
            if (stTemplate.Length < 1) { return ""; }

            Dictionary<string, string> dicNameValue = tpData.GetDictOfNowIndex();
            long lCount = tpData.Index + 1;

            //条件付き文字列の置換
            if (tpConditions != null)
            {
                for (int i = 0; i < tpConditions.Length; i++)
                {
                    stTemplate = stTemplate.Replace(tpConditions[i].Name, tpConditions[i].GetResultString(tpData));
                }
            }

            //番号の置換
            stTemplate = ReplaceNumber(stTemplate, lCount);

            //式の置換
            stTemplate = EvaluateExpression(stTemplate, lCount);

            //反復子の置換
            foreach (KeyValuePair<string, string> pair in dicNameValue)
            {
                stTemplate = stTemplate.Replace(pair.Key, pair.Value);
            }

            return stTemplate;
        }

        // 番号を0埋めで置換する
        private static string ReplaceNumber(string stTemplate, long lNumber)
        {
            Regex reg = new Regex("{0:0*}");
            string stTarget;
            string stFormatted;

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

        //式を評価して置換する
        private static string EvaluateExpression(string stTemplate, long lNumber)
        {
            Regex reg = new Regex("{=(?<Expression>[^}]*)}");

            string stTarget;
            string stExpression;

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
    }
}
