using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 多态之虚函数
{
    class Program
    {
        static void Main(string[] args)
        {
            Chinese cn1 = new Chinese("韩梅梅");
            Chinese cn2 = new Chinese("李磊");
            Japanese jp1 = new Japanese("井边军");
            Japanese jp2 = new Japanese("苍井空");
            Korea k1 = new Korea("金秀贤");
            Korea k2 = new Korea("都敏俊");
            American a1 = new American("科比");
            American a2 = new American("小布什");
            Person[] pers = { cn1, cn2, jp1, jp2, k1, k2, a1, a2,new Person("张三") };
            for (int i = 0; i < pers.Length; i++)
            {
                //if(pers[i] is Chinese)
                //{
                //    ((Chinese)pers[i]).SayHello();
                //}
                //else if (pers[i] is Japanese)
                //{
                //    ((Japanese)pers[i]).SayHello();
                //}
                //else if (pers[i] is Korea)
                //{
                //    ((Korea)pers[i]).SayHello();
                //}
                //else if(pers[i] is American)
                //{
                //    ((American)pers[i]).SayHello();
                //}
                //else
                //{
                //    Console.WriteLine("报错");
                //}

                pers[i].SayHello();
            }
        }
    }

    public class Person
    {
        private string _name;

        public virtual void SayHello()
        {
            Console.WriteLine("我是人类");
        }

        public Person(string name)
        {
            this.Name = name;
        }
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

    public class Chinese:Person
    {
        public Chinese(string name):base(name)
        {

        }

        public override void SayHello()
        {
            Console.WriteLine("我是中国人，我叫{0}",this.Name);
        }
    }

    public class Japanese:Person
    {
        public Japanese(string name):base(name)
        {

        }

        public override void SayHello()
        {
            Console.WriteLine("我是日本人，我叫{0}",this.Name);
        }
    }

    public class American:Person
    {
        public American(string name) : base(name) { }

        public override void SayHello()
        {
            Console.WriteLine("我是美国人，我叫{0}",this.Name);
        }
    }

    public class Korea:Person
    {
        public Korea(string name) : base(name) { }

        public override void SayHello()
        {
            Console.WriteLine("我是韩国人，我叫{0}",this.Name);
        }

    }

}
