using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 键值对集合
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add(1, "张三");
            ht.Add(2, true);
            ht.Add(3, '男');
            ht.Add(false, "错误的");

            foreach (var item in ht.Keys)
            {
                Console.WriteLine("键是：{0}\t值是:{1}",item,ht[item]);
            }
        }
    }

    class Persion { }
    class Student : Persion { }
    class Programmer : Student { }
    class Driver : Programmer { }
}
