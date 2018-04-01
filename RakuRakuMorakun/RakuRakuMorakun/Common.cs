using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;

namespace RakuRakuMorakun
{
    public static class Common
    {
        public static readonly string NUMBER_CAPTION = "番号が";
        public static readonly string EQUAL = "と等しいとき";
        public static readonly string NOTEQUAL = "と異なるとき";
        public static readonly string UNDER = "より小さいとき";
        public static readonly string OVER = "以上のとき";
        public static readonly string AND = " かつ ";
        public static readonly string OR = " もしくは ";
        public static readonly string AND_CAPTION = "全てに一致";
        public static readonly string OR_CAPTION = "どれかに一致";

        public static readonly string TEXT_FORMAT_TOTAL_COUNT = "網羅回数：{0}回";
        public static readonly string TEXT_FORMAT_ITERATOR = "{{#{0}}}";   //｛｝は｛｝でエスケープするらしい
        public static readonly string TEXT_FORMAT_CONDITION = "{{?{0}}}";
        public static readonly string TEXT_FORMAT_FOMULA = "{{={0}}}";
        public static readonly string TEXT_FORMAT_SEQUENCE = "{{${0}}}";

        public static readonly string FILENAME_SETTING = "rakuraku.rks";

        public enum INDEX_FLAG : int { NEXT, END };
        public enum EXTERNAL_FLAG : int { TEMPLATE, ITERATOR, CANCEL };
        public enum DELEGATE_ID : int { ITERATOR, CONDITION, SEQUENCE, NUMBER, EXPRESSION, ERROR};

        public static readonly string DELEGATE_ITERATOR_CAPTION = "反復子の置換";
        public static readonly string DELEGATE_CONDITION_CAPTION = "条件付き文字列の置換";
        public static readonly string DELEGATE_SEQUENCE_CAPTION = "シーケンスの置換";
        public static readonly string DELEGATE_NUMBER_CAPTION = "番号の置換";
        public static readonly string DELEGATE_EXPRESSION_CAPTION = "式の評価";

        private static readonly Microsoft.JScript.Vsa.VsaEngine VsaEngine = Microsoft.JScript.Vsa.VsaEngine.CreateEngine();


        /// <summary>
        /// バイナリシリアライズを使って任意の型のオブジェクトを複製する
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="objData"></param>
        /// <returns></returns>
        public static T CloneObject<T>(T objData)
        {
            using (System.IO.MemoryStream stream = new System.IO.MemoryStream())
            {
                BinaryFormatter binaryformatter = new BinaryFormatter();

                binaryformatter.Serialize(stream, objData);

                stream.Position = 0L;

                return (T)binaryformatter.Deserialize(stream);
            }
        }


        /// <summary>
        /// Javascriptの式を評価する。stKeyをstValueに変えて式に埋め込むことが可能
        /// </summary>
        /// <param name="stExpression"></param>
        /// <param name="stKey"></param>
        /// <param name="stValue"></param>
        /// <returns></returns>
        public static string Eval(string stExpression, string stKey = "", string stValue = "")
        {
            try
            {
                if (stKey != "")
                {
                    stExpression = stExpression.Replace(stKey, stValue);
                }
                return Microsoft.JScript.Eval.JScriptEvaluate(stExpression, VsaEngine).ToString();
            }
            catch
            {
                return "";
            }

        }

        /// <summary>
        /// オブジェクトをシリアライズしてXMLに保存する
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="stPath"></param>
        /// <param name="objData"></param>
        public static void SaveSerializeData<T>(string stPath, T objData)
            where T : class
            {
            SoapFormatter formatter = new SoapFormatter();
            using (Stream stream = new FileStream(stPath, FileMode.Create))
            {
                formatter.Serialize(stream, objData);
            }
        }

        /// <summary>
        /// XMLをデシリアライズしてオブジェクトを復元する
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="stPath"></param>
        /// <returns></returns>
        public static T DeserializeData<T>(string stPath)
            where T : class
        {
            SoapFormatter formatter = new SoapFormatter();
            T objRtn;
            using (Stream stream = new FileStream(stPath, FileMode.Open))
            {
                objRtn = (T)formatter.Deserialize(stream);
                return objRtn;
            }
        }

        /// <summary>
        /// カレントフォルダにある設定ファイルを読み込む。失敗したらnullを返す。
        /// </summary>
        /// <returns>失敗したらnullを返す</returns>
        public static SettingData LoadSetting()
        {
            string stCurrentDir = Environment.CurrentDirectory;
            string stSettingFilePath = Path.Combine(stCurrentDir, FILENAME_SETTING);
            SettingData data;
            try
            {
                data = DeserializeData<SettingData>(stSettingFilePath);
            }
            catch{
                data = null;
            }

            return data;
        }


        /// <summary>
        /// カレントフォルダに設定ファイルを保存する。
        /// </summary>
        public static void SaveSetting(SettingData data)
        {
            string stCurrentDir = Environment.CurrentDirectory;
            string stSettingFilePath = Path.Combine(stCurrentDir, FILENAME_SETTING);
            
            try
            {
                SaveSerializeData(stSettingFilePath, data);
            }
            catch
            {
                
            }
        }

        /// <summary>
        /// デフォルト設定を作成して保存する
        /// </summary>
        public static void CreateDefaultSettingFile()
        {
            DELEGATE_ID[] tpIds = new DELEGATE_ID[] 
            {
                DELEGATE_ID .ITERATOR,
                DELEGATE_ID .NUMBER,
                DELEGATE_ID .SEQUENCE,
                DELEGATE_ID .CONDITION,
                DELEGATE_ID .EXPRESSION
            };

            Condition[] tpConditions = new Condition[]
            {
                new Condition("{3桁}","{=('00000' + (num + 0)).slice(-3)}"),
                new Condition("{今日}","{=var now = new Date();now.getYear() + '/' + (now.getMonth() + 1) + '/' + now.getDate()}"),
                new Condition("{乱数}","{=Math.floor(Math.random()*100)}")
            };

            SettingData data = new SettingData(tpConditions, tpIds);

            SaveSetting(data);
        }
    }


}
