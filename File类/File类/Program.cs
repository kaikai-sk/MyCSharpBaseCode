using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File类
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建一个文件
            //File.Create(@"C:\Users\单凯\Desktop\shankai.txt");
            //Console.WriteLine("创建成功！");

            //删除一个文件
            //File.Delete(@"C:\Users\单凯\Desktop\shankai.txt");
            //Console.WriteLine("删除成功！");

            //复制一个文件
            File.Copy(@"‪C:\Users\单凯\Desktop\t123.txt", "‪C:\\Users\\单凯\\Desktop\\temp.txt");
            Console.WriteLine("复制成功");
        }
    }
}
