using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 进程类
{
    class Program
    {
        static void Main(string[] args)
        {
            ////获得当前所有进程
            //Process[] pros = Process.GetProcesses();
            //foreach (var item in pros)
            //{
            //    item.Kill();
            //    Console.WriteLine(item);
            //}

            //通过进程的方式打开应用程序
            //Process.Start("notepad");
            //Process.Start("iexplore", "http://www.baidu.com");

            //通过一个进程打开指定的文件
            ProcessStartInfo psInfo = new ProcessStartInfo(@"C:\Users\单凯\Desktop\我的今年选课.doc");
            Process pro = new Process();
            pro.StartInfo = psInfo;
            pro.Start();
        }
    }
}
