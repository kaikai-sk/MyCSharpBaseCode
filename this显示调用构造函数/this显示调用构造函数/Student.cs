using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace this显示调用构造函数
{
    class Student
    {
        string _name;
        int _age;
        char _gender;
        int _chinese;
        int _math;
        int _english;

        ~Student()
        {

        }
        
        public Student(string name,int age,char gender,int chinese,int math,int english)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
            this.Chinese = chinese;
            this.Math = math;
            this.English = english;
        }

        public Student(int chinese,int math,int english):this("",0,'0',chinese,math,english)
        {

        }

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public int Age
        {
            get
            {
                return _age;
            }

            set
            {
                _age = value;
            }
        }

        public char Gender
        {
            get
            {
                return _gender;
            }

            set
            {
                _gender = value;
            }
        }

        public int Chinese
        {
            get
            {
                return _chinese;
            }

            set
            {
                _chinese = value;
            }
        }

        public int Math
        {
            get
            {
                return _math;
            }

            set
            {
                _math = value;
            }
        }

        public int English
        {
            get
            {
                return _english;
            }

            set
            {
                _english = value;
            }
        }
    }
}
