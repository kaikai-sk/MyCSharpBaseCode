using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList集合
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add(3.14);
            list.Add(true);
            list.Add("张三");
            list.Add(50000m);
            list.Add(new int[] { 1, 2, 3, 4, 54, 56, 7, 8, 9 });
            list.Add(new Person());
            list.Add(list);
            for(int i=0;i<list.Count;i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }

    public class Person
    {
        public void SayHello()
        {
            Console.WriteLine("我是人类，你好");
        }
    }

}
