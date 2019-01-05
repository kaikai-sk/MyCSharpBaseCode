using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Directory类控制台
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建文件夹
            //Directory.CreateDirectory(@"d:\a");
            //Console.WriteLine("文件夹创建成功"); 

            //删除文件夹
            //Directory.Delete(@"d:\a");
            //Console.WriteLine("文件夹删除成功！！！");

            //文件夹的剪切
            /*必须在同一个盘符下面*/
            //Directory.Move(@"d:\a", @"d:\sk");
            //Console.WriteLine("文件夹剪切成功");

            //string[] paths = Directory.GetFiles(@"C:\Users\单凯\Desktop\第八讲 多媒体","*.mkv");
            //for (int i = 0; i < paths.Length; i++)
            //{
            //    Console.WriteLine(paths[i]);
            //}

            //string[] paths = Directory.GetDirectories(@"C:\Users\单凯\Desktop\第八讲 多媒体");
            //for (int i = 0; i < paths.Length; i++)
            //{
            //    Console.WriteLine(paths[i]);
            //}

            //if(Directory.Exists(@"d:\a\b"))
            //{
            //    for(int i=0;i<100;i++)
            //    {
            //        Directory.CreateDirectory(@"d:\a\b\" + i);
            //    }
            //}
            //Console.WriteLine("创建100个文件夹完毕");

            //Directory.Delete("d:\\a", true);
            //Console.WriteLine("删除102个文件夹成功");

        }
    }
}
