﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

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

            //シーケンスの置換
            stTemplate = ReplaceSequence(stTemplate, lCount);

            //反復子の置換
            foreach (KeyValuePair<string, string> pair in dicNameValue)
            {
                stTemplate = stTemplate.Replace(pair.Key, pair.Value);
            }

            return stTemplate;
        }

        // シーケンスを0埋めで置換する
        private static string ReplaceSequence(string stTemplate, long lNumber)
        {
            Regex reg = new Regex("{0:0*}");
            MatchCollection matches = reg.Matches(stTemplate);
            string stTarget;
            string stFormatted;

            //TextBox1.Text内で正規表現と一致する対象を1つ検索
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
    }
}