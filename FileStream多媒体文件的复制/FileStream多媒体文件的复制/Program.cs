using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileStream多媒体文件的复制
{
    class Program
    {
        static void Main(string[] args)
        {
            string source = @"C:\Users\单凯\Desktop\董贞梦太晚.mp3";
            string target = @"C:\Users\单凯\Desktop\sk梦太晚.mp3";
            CopyFile(source, target);
            Console.WriteLine("文件复制成功！");
        }

        private static void CopyFile(string source, string target)
        {
            using (FileStream fsRead = new FileStream(source,
                FileMode.Open, FileAccess.Read))
            {
                using (FileStream fsWrite = new FileStream(target,
                    FileMode.OpenOrCreate, FileAccess.Write))
                {
                    byte[] buffer = new byte[1024 * 5];
                    while (true)
                    {
                        int len=fsRead.Read(buffer, 0, buffer.Length);
                        if(len==0)
                        {
                            break;
                        }
                        fsWrite.Write(buffer, 0, len);
                    }
                }
            }
        }
    }
}
