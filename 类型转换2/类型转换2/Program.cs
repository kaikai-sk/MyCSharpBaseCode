using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 类型转换2
{
    class Program
    {
        static void Main(string[] args)
        {
            //int number = int.Parse("123");
            //Console.WriteLine(number);
            //Console.ReadKey();

            int number = 0;
            bool b=int.TryParse("123abc", out number);
            Console.WriteLine(b);
            Console.WriteLine(number);
            Console.ReadKey();
        }
    }
}
