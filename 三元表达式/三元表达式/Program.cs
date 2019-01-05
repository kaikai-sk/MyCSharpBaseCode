using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 三元表达式
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("请输入您的姓名");
                string name = Console.ReadLine();
                string result = name == "单凯" ? "真是人才" : "臭流氓！";
                Console.WriteLine(result);
                Console.ReadKey();
            }
        }
    }
}
