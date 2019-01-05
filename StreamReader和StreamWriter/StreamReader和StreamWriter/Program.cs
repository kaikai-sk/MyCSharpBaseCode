using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamReader和StreamWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            //使用StreamReader来都去一个文本文件
            //using (StreamReader sr = new StreamReader(@"C:\Users\单凯\Desktop\t123.txt",Encoding.Default))
            //{
            //    while(!sr.EndOfStream)
            //    {
            //        Console.WriteLine(sr.ReadLine());
            //    }
            //}

            //使用StreamWriter来写一个文件
            using (StreamWriter sw = new StreamWriter(@"C:\Users\单凯\Desktop\t123.txt",
                true))
            {
                sw.Write("看我有没有把你覆盖掉");
            }
            Console.WriteLine("写文件成功");
        }
    }
}
