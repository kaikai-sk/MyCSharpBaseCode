using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 重写父类的tostring方法
{
    class Program
    {
        static void Main(string[] args)
        {
            //对象直接tostring会打印出命名空间
            Person p = new Person();
            p.Name = "张三";
            Console.WriteLine(p.ToString());
        }
    }

    public class Person
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

        public override string ToString()
        {
            return this.Name;
        }
    }
}
