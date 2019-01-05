using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 接口
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Person
    {
        public void CHLSS()
        {
            Console.WriteLine("我是人类，可以吃喝拉撒睡！！！");
        }
    }

    public class NBAPlayer
    {
        public void KouLan()
        {
            Console.WriteLine("我可以扣篮！！！");
        }
    }

    public class Student : Person, IKouLanable
    {
        public void KouLan()
        {
            throw new NotImplementedException();
        }
    }

    public interface IKouLanable
    {
        void KouLan();
    }
}
