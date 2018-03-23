using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace RakuRakuMorakun
{
    public static class Common
    {
        public static readonly string SEQUENCE_CAPTION = "番号が";
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
        public static readonly string TEXT_FORMAT_CONDITION = "{{${0}}}";


        /// <summary>バイナリシリアライズを使って任意の型Tのオブジェクトを複製する</summary>
        /// <returns><paramref name="source"/>を複製したオブジェクト</returns>
        /// <exception cref="SerializationException"><paramref name="source"/>がシリアル化可能としてマークされていない</exception>
        public static T CloneObject<T>(T source)
        {
            // バイナリシリアライズによってsourceの複製を作成する
            using (System.IO.MemoryStream stream = new System.IO.MemoryStream())
            {
                BinaryFormatter f = new BinaryFormatter();

                f.Serialize(stream, source);

                stream.Position = 0L;

                return (T)f.Deserialize(stream);
            }
        }
    }
}
