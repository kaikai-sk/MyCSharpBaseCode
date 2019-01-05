using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if结构
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入你跪键盘的时间：");
            int mins = Convert.ToInt32(Console.ReadLine());
            if(mins>60)
            {
                Console.WriteLine("好老公，不用你跪键盘了，去做晚饭吧！");
            }
            Console.ReadKey();
        }
    }
}
