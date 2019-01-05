using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 面向对象基本语法
{
    class Person
    {
        private string _name;
        private int _age;
        private char _gender;

        public string Name
        {
            get{return _name;}
            set { _name = value; }
        }
        public int Age
        {
            get { return _age; }
            set
            {
                if(value<0 || value>250)
                {
                    value = 0;
                }
                this._age = value; }
        }
        public char Gender
        {
            get
            {
                if(_gender!='男' && _gender!='女')
                {
                    _gender = '男';
                }
                return _gender;
            }
            set { this._gender = value; }
        }




        public void CHLSS()
        {
            Console.WriteLine("我叫{0}，今年{1}岁了，我是{2}生，我能吃喝拉撒睡！",Name,Age,
                Gender);
        }
    }
}
