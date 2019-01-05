using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace _0505stringBuilder
{
    class Program
    {
        public static object StopWatch { get; private set; }

        static void Main(string[] args)
        {
            String str = null;
            StringBuilder sb = new StringBuilder();//00:00:00.0219842
            //穿建了一个计时器，用来记录程序运行的时间
            Stopwatch sw = new Stopwatch();
            sw.Start();//开始计时
            for (int i=0;i<100000;i++)
            {
                str += i;
                //sb.Append(i);
            }
            sw.Stop();//结束计时
            Console.WriteLine(sw.Elapsed);//输出时间差

            
        }
    }
}
