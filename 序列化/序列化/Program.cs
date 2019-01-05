using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace 序列化
{
    class Program
    {
        static void Main(string[] args)
        {
            //要将p这个对象传输给对方电脑
            //Person p = new Person();
            //p.Name = "张三";
            //p.Age = 19;
            //p.Gender = '男';
            //using (FileStream fsWrite = new FileStream(@"C:\Users\单凯\Desktop\序列化.txt",
            //    FileMode.OpenOrCreate,
            //    FileAccess.Write))
            //{
            //    //开始序列化对象
            //    BinaryFormatter bf = new BinaryFormatter();
            //    bf.Serialize(fsWrite, p);
            //}
            //Console.WriteLine("序列化成功！！！");

            //接受对方发送过来的数据，反序列化成对象
            Person p = null;
            using (FileStream fsRead = new FileStream(@"C:\Users\单凯\Desktop\序列化.txt",
                FileMode.OpenOrCreate,
                FileAccess.Read))
            {
                BinaryFormatter bf = new BinaryFormatter();
                p = (Person)bf.Deserialize(fsRead);
            }
            Console.WriteLine(p.Name);
            Console.WriteLine(p.Age);
            Console.WriteLine(p.Gender);
        }
    }

    [Serializable]
    public class Person
    {
        private string _name;
        private int _age;
        private char _gender;

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

        public int Age
        {
            get
            {
                return _age;
            }

            set
            {
                _age = value;
            }
        }

        public char Gender
        {
            get
            {
                return _gender;
            }

            set
            {
                _gender = value;
            }
        }
    }
}
