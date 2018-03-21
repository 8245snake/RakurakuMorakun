using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RakuRakuMorakun;


namespace RakuRakuMorakun
{
    class Program
    {
        static void Main(string[] args)
        {
            DataTable myTable = new DataTable();

            myTable.Add(new CoveringIterator("{#1}",new string[] { "AAA", "BB", "CC" }));
            myTable.Add(new CoveringIterator("{#1}", new string[] { "あ", "い", "う", "え", "お" }));

            string stTemplate = "{0:000} {#1} {#2} {#3}";
            Condition[] cond = new Condition[] { new Condition("{#3}", "ああああ") };

            myTable.InitIndex();
            Console.WriteLine(myTable.Total + "回の網羅を行います");
            Console.WriteLine(Converter.ConvertStrData(stTemplate, myTable, cond));
            int nRtn = myTable.NextIndex();
            while (nRtn == (int)DataTable.INDEX_FLAG.NEXT)
            {
                Console.WriteLine(Converter.ConvertStrData(stTemplate, myTable, cond));
                nRtn = myTable.NextIndex();
            }
            Console.ReadKey();
        }
    }
}
