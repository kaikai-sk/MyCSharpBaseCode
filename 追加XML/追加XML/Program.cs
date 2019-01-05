using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;

namespace 追加XML
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建xml 文档对象
            XmlDocument doc = new XmlDocument();
            //xmlwen文件的根节点
            XmlElement books = null;
            if (File.Exists("Books.xml"))
            {
                //如果文件存在 加载XML文件
                doc.Load("Books.xml");
                //获得文件的根节点
                books = doc.DocumentElement;

            }
            else
            {
                //如果文件不存在
                XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", "utf-8", null);
                doc.AppendChild(dec);
                books = doc.CreateElement("Books");
                doc.AppendChild(books);
            }
            //5、给根节点创建子接点
            XmlElement book1 = doc.CreateElement("Book");
            books.AppendChild(book1);
            //6、给book1添加子节点
            XmlElement name1 = doc.CreateElement("Name");
            name1.InnerText = "C#";
            XmlElement price1 = doc.CreateElement("Price");
            price1.InnerText = "888";
            XmlElement des1 = doc.CreateElement("Des");
            des1.InnerText = "云山雾罩";

            book1.AppendChild(name1);
            book1.AppendChild(price1);
            book1.AppendChild(des1);

            doc.Save("Books.xml");
            Console.WriteLine("文件保存成功！！");
        }
    }
}
