using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 值传递和引用传递
{
    class Program
    {
        static void Main(string[] args)
        {
            ////值传递
            //int n1 = 10;
            //int n2 = n1;
            //n2 = 20;
            //Console.WriteLine(n1);
            //Console.WriteLine(n2);

            ////引用传递
            //Person p1 = new Person();
            //p1.Name = "张三";
            //Person p2 = p1;
            //p2.Name = "李四";
            //Console.WriteLine(p1.Name);
            //Console.WriteLine(p2.Name);

            //Person p = new Person();
            //p.Name = "张三";
            //Test(p);
            //Console.WriteLine(p.Name);

            //string s1 = "张三";
            //string s2 = s1;
            //s2 = "李四";
            //Console.WriteLine(s1);
            //Console.WriteLine(s2);

            int number = 10;
            TestTwo(ref number);
            Console.WriteLine(number);

        }

        public static void TestTwo(ref int n)
        {
            Console.WriteLine(n);
            n += 10;
        }

        public static void Test(Person pp)
        {
            Person p = pp;
            p.Name = "李四";
        }
    }

    class Person
    {
        string _name;

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }
    }
}
