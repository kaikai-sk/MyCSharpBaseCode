using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MD5加密
{
    /// <summary>
    /// 123 ----> 202cb962ac59075b964b07152d234b70
    ///           202cb962ac5975b964b7152d234b70
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string s = GetMD5("123");
            Console.WriteLine(s);
        }

        public static string GetMD5(string str)
        {
            //创建MD5对象
            MD5 md5 = MD5.Create();
            //将字符串转成字节数组
            byte[] buffer = Encoding.Default.GetBytes(str);
            //返回一个加密好的字节数组
            byte[] res=md5.ComputeHash(buffer);

            string strRes = "";
            for(int i=0;i<res.Length;i++)
            {
                strRes += res[i].ToString("x2");
            }
            return strRes;
        }
    }
}
