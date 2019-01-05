using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileStream读写文件
{
    class Program
    {
        static void Main(string[] args)
        {
            ////使用文件字节流（FileStream）读取数据
            //FileStream fsRead = new FileStream(@"C:\Users\单凯\Desktop\t123.txt", FileMode.OpenOrCreate,
            //    FileAccess.Read);
            //byte[] buffer = new byte[1024 * 1024];
            ////返回本次读到的有效字节数
            //int len=fsRead.Read(buffer, 0, buffer.Length);
            //string s = Encoding.Default.GetString(buffer, 0, len);
            ////关闭文件流
            //fsRead.Close();
            ////施放流所占的资源
            //fsRead.Dispose();
            //Console.WriteLine(s);

            //使用fileStream写文件
            using (FileStream fsWrite = new FileStream(@"C:\Users\单凯\Desktop\t123.txt",
                FileMode.OpenOrCreate, FileAccess.Write))
            {
                string str = "看我朋友没有把你覆盖掉！";
                byte[] buferr = Encoding.Default.GetBytes(str);
                fsWrite.Write(buferr, 0, buferr.Length);
            }
            Console.WriteLine("写文件成功！");
        }
    }
}
