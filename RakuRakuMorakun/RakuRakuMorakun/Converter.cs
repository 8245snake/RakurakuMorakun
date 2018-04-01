using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using static RakuRakuMorakun.Common;

namespace RakuRakuMorakun
{

    public class Converter
    {

        private delegate void Converters(ref string stTemplate, GridController tpController);
        static Converters ConvertStr = NotReplace;
        private static Converter instance = new Converter();

        private Converter()
        {

        }

        public static Converter GetInstance()
        {
            LoadDelegate();
            return instance;
        }

        /// <summary>
        /// 設定ファイルから処理順を読み込む
        /// </summary>
        public static void LoadDelegate()
        {
            SettingData setting = LoadSetting();
            ConvertStr = NotReplace;

            if (setting == null) //設定ファイル読み込みに失敗したらデフォルト設定にする
            {
                ConvertStr += ReplaceIterator;
                ConvertStr += ReplaceNumber;
                ConvertStr += ReplaceSequence;
                ConvertStr += ReplaceCondition;
                ConvertStr += EvaluateExpression;
                return;
            }

            foreach (DELEGATE_ID id in setting.DelegateId)
            {
                if (id == DELEGATE_ID.ITERATOR)
                {
                    ConvertStr += ReplaceIterator;
                }
                else if (id == DELEGATE_ID.SEQUENCE)
                {
                    ConvertStr += ReplaceSequence;
                }
                else if (id == DELEGATE_ID.CONDITION)
                {
                    ConvertStr += ReplaceCondition;
                }
                else if (id == DELEGATE_ID.NUMBER)
                {
                    ConvertStr += ReplaceNumber;
                }
                else if (id == DELEGATE_ID.EXPRESSION)
                {
                    ConvertStr += EvaluateExpression;
                }
            }
            
        }

        /// <summary>
        /// テンプレート内の置換を行う。カウントアップは呼び出し元で行うこと。
        /// </summary>
        /// <param name="stTemplate">テンプレート</param>
        /// <param name="tpController">GridControllerオブジェクト</param>
        /// <returns></returns>
        public string ConvertStrData(string stTemplate, GridController tpController)
        {
            if (stTemplate.Length < 1) { return ""; }
            if (tpController == null) { return ""; }

            ConvertStr(ref stTemplate, tpController);
            return stTemplate;
        }


        //文字列をそのまま返すダミー関数（デリゲートの初期化に使用）
        private static void NotReplace(ref string stTemplate, GridController tpController)
        { 
        }

        //条件付き文字列の置換
        private static void ReplaceCondition(ref string stTemplate, GridController tpController)
        {
            DataTable tpData = tpController.GetDataTable();
            Condition[] tpConditions = tpController.GetConditions();

            for (int i = 0; i < tpConditions.Length; i++)
            {
                stTemplate = stTemplate.Replace(tpConditions[i].Name, tpConditions[i].GetResultString(tpData));
            }
        }

        // 番号を0埋めで置換する
        private static void ReplaceNumber(ref string stTemplate, GridController tpController )
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
        }

        //シーケンスを置換する
        private static void ReplaceSequence(ref string stTemplate, GridController tpController)
        {
            if (tpController == null) { return ; }

            DataTable tpData = tpController.GetDataTable();
            Sequence[] tpSeqences = tpController.GetSequences();
            long lNumber = tpData.Index + 1;

            for (int i = 0; i < tpSeqences.Length; i++)
            {
                stTemplate = stTemplate.Replace(tpSeqences[i].Name, tpSeqences[i].Item((int)lNumber-1));
            }
        } 

        //式を評価して置換する
        private static void EvaluateExpression(ref string stTemplate, GridController tpController)
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
        }

        //反復子の置換
        private static void ReplaceIterator(ref string stTemplate, GridController tpController)
        {
            DataTable tpData = tpController.GetDataTable();
            Dictionary<string, string> dicNameValue = tpData.GetDictOfNowIndex();

            //反復子の置換
            foreach (KeyValuePair<string, string> pair in dicNameValue)
            {
                stTemplate = stTemplate.Replace(pair.Key, pair.Value);
            }
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
