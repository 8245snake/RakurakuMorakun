using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static RakuRakuMorakun.Common;


namespace RakuRakuMorakun
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Eval(" new Date(2017,0,15,22,30)"));
            Console.ReadKey();
        }
    }
}
