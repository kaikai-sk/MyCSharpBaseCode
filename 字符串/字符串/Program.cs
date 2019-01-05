using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 字符串
{
    class Program
    {
        static void Main(string[] args)
        {
            //string s1 = "123";
            //string s2 = "123";
            //Console.ReadKey();

            //可以将string看作是char类型的只读书组，可以用下标访问
            string s = "abcdefghijkl";
            //s[0] = '山'; 它是只读的
            char[] chs = s.ToCharArray();

            Console.WriteLine(s[0]);
            Console.WriteLine(s[4]);
            Console.ReadKey();
        }
    }
}
