using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace 读取XML文档
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            //加载xml
            doc.Load("Books.xml");
            //获得根节点
            XmlElement books = doc.DocumentElement;
            //获得子节点，返回节点集合
            XmlNodeList list = books.ChildNodes;
            foreach (XmlNode item in list)
            {
                Console.WriteLine(item.InnerText);
            }
        }
    }
}
