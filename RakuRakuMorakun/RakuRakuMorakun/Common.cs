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

        private static readonly Microsoft.JScript.Vsa.VsaEngine VsaEngine = Microsoft.JScript.Vsa.VsaEngine.CreateEngine();


        //バイナリシリアライズを使って任意の型Tのオブジェクトを複製する
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

        //任意の文字を式に埋め込むことができるstKeyをstValueに変える
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

        //オブジェクトをシリアライズしてXMLに保存
        public static void SaveSerializeData<T>(string stPath, T objData)
            where T : class
            {
            SoapFormatter formatter = new SoapFormatter();
            using (Stream stream = new FileStream(stPath, FileMode.Create))
            {
                formatter.Serialize(stream, objData);
            }
        }

        //XMLをデシリアライズしてオブジェクトを復元
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
    }


}
