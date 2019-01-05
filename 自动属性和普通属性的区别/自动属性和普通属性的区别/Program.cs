using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 自动属性和普通属性的区别
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Person
    {
        private string _name;
        public string Name
        {
            set { this._name = value; }
            get { return _name; }
        }

        /// <summary>
        /// 自动属性
        /// </summary>
        public int Age
        {
            set;
            get;
        }
    }
}
