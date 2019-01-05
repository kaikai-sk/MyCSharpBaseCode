using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 产生随机数
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. 创建能够产生随机数的对象
            Random r = new Random();
            while (true)
            {
                //2. 让这个对象调用相应的方法来产生随机数
                //   next函数的参数是左闭右开区间
                int number = r.Next(1, 11);
                Console.WriteLine(number);
                Console.ReadKey();
            }
        }
    }
}
