using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 文件读写
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] contents = File.ReadAllLines(@"C:\Users\单凯\Desktop\t123.txt", Encoding.Default);
            //foreach (string item in contents)
            //{
            //    Console.WriteLine(item);
            //}

            //string str = File.ReadAllText(@"C:\Users\单凯\Desktop\t123.txt", Encoding.Default);
            //Console.WriteLine(str);

            //byte[] b=File.ReadAllBytes(@"C:\Users\单凯\Desktop\t123.txt");
            //Console.WriteLine(Encoding.Default.GetString(b));

            //File.WriteAllLines(@"C:\Users\单凯\Desktop\t123.txt", new string[] { "几天天气好晴朗","处处都好风光",
            //"啊白痴的风格环境和可靠","而韩国【怕如果【恶搞了"});
            //Console.WriteLine("写文件OK");

            //File.WriteAllText(@"C:\Users\单凯\Desktop\t123.txt", "dehg[rehgjtkhtnbnrejgr0yh90fk\r\n"+
            //    "edhfwehgnrpioejgt\r\n"+
            //    "euwfo;ewhojf\r\n ");
            //Console.WriteLine("写文件OK");

            //File.AppendAllText(@"C:\Users\单凯\Desktop\t123.txt", "\r\n要学习文件流了");
            //Console.WriteLine("写文件OK");

            byte[] b = Encoding.Default.GetBytes("今天天气好晴朗，处处好风光！！！");
            File.WriteAllBytes(@"C:\Users\单凯\Desktop\t123.txt", b);
            Console.WriteLine("写文件成功！！");
        }
    }
}
