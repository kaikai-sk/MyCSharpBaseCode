using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert类型转换
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "123abc";
            double d = Convert.ToDouble(s);
            int n = Convert.ToInt32(s);
            Console.WriteLine(d);
            Console.WriteLine(n);
            Console.ReadKey();
            
        }
    }
}
