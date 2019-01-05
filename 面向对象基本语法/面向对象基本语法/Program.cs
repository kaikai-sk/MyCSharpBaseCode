using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 面向对象基本语法
{
    class Program
    {
        static void Main(string[] args)
        {
            Person sunQuan = new Person();
            sunQuan.Name = "孙权";
            sunQuan.Age = -23;
            sunQuan.Gender = '妖';
            sunQuan.CHLSS();
            Console.ReadKey();
        }
    }
}
