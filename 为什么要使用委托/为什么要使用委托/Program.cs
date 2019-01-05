using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 为什么要使用委托
{
    public delegate string DelProStr(string name);

    class Program
    {
        static void Main(string[] args)
        {
            //三个需求
            //1、将一个字符串数组中每个元素都转换成大写
            //2、将一个字符串数组中每个元素都转换成小写
            //3、将一个字符串数组中每个元素两边都加上 双引号
            string[] names = { "abCDefG", "HIJKlmnOP", "QRsTuvW", "XyZ" };
            //ProStr(names, AddSYH/*strToLower*//*strToUper*/);
            ProStr(names, delegate (string name)
             {
                 return "\"" + name + "\"";/*name.ToUpper();*//*name.ToLower();*/
             });
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
        }

        public  static void ProStr(string[] names, DelProStr del)
        {
            for (int i = 0; i < names.Length; i++)
            {
                names[i] = del(names[i]);
            }
        }

        //public static string strToUper(string name)
        //{
        //    return name.ToUpper();
        //}

        //public static string strToLower(string name)
        //{
        //    return name.ToLower();
        //}

        //public static string AddSYH(string name)
        //{
        //    return "\"" + name + "\"";
        //}

    }
}
