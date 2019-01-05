using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace 创建XML
{
    class Program
    {
        static void Main(string[] args)
        {
            //通过代码操作XML文件
            //1、应用命名空间
            //2. 创建XML文件对象
            XmlDocument doc = new XmlDocument();
            //3、创建第一行描述信息并添加到XML文件当中
            XmlDeclaration dec= doc.CreateXmlDeclaration("1.0", "utf-8", null);
            doc.AppendChild(dec);
            //4、创建根节点，并添加到文档中
            XmlElement books= doc.CreateElement("Books");
            doc.AppendChild(books);
            //5、给根节点创建子接点
            XmlElement book1 = doc.CreateElement("Book");
            books.AppendChild(book1);
            //6、给book1添加子节点
            XmlElement name1 = doc.CreateElement("Name");
            name1.InnerText = "金瓶梅";
            XmlElement price1 = doc.CreateElement("Price");
            price1.InnerText = "10";
            XmlElement des1 = doc.CreateElement("Des");
            des1.InnerText = "好看，不解释";

            book1.AppendChild(name1);
            book1.AppendChild(price1);
            book1.AppendChild(des1);

            //5、给根节点创建子接点
            XmlElement book2 = doc.CreateElement("Book");
            books.AppendChild(book2);
            //6、给book1添加子节点
            XmlElement name2 = doc.CreateElement("Name");
            name2.InnerText = "水浒传";
            XmlElement price2 = doc.CreateElement("Price");
            price2.InnerText = "90";
            XmlElement des2 = doc.CreateElement("Des");
            des2.InnerText = "108个拆迁户";

            book2.AppendChild(name2);
            book2.AppendChild(price2);
            book2.AppendChild(des2);

            doc.Save("Books.xml");
            Console.WriteLine("文件创建成功");
        }
    }
}
