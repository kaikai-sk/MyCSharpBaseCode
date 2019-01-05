using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 多态之抽象方法
{
    class Program
    {
        static void Main(string[] args)
        {
            //狗狗会叫；猫咪会叫
            Animal a = new Dog();
            a.Bark();
            a = new Cat();
            a.Bark();
        }
    }

    public abstract class Animal
    {
        public abstract void Bark();
    }

    public class Dog : Animal
    {
        public override void Bark()
        {
            Console.WriteLine("狗汪汪叫");
        }
    }

    public class Cat : Animal
    {
        public override void Bark()
        {
            Console.WriteLine("猫咪喵喵地叫");
        }
    }
}
