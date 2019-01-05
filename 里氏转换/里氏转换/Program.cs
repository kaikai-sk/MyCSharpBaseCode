using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 里氏转换
{
    class Program
    {
        static void Main(string[] args)
        {
            //里氏转换
            //（1） 子类可以赋值给父类。如果有一个地方需要一个父类做参数，
            //      我们可以给一个子类代替
            //Student s = new Student();
            //Person p = s;
            //p.PersonSayHello();
            //s.PersonSayHello();
            //s.StudentSayHello();

            //string str = string.Join(",", new string[] { "1", "2", "3", "4", "5" });
            //Console.WriteLine(str);

            //（2） 如果父类中装的是子类对象，那么可以将这个父类对象强转为子类对象！
            //Person p = new Student();
            //Student s = (Student)p;
            //s.StudentSayHello();

            Person p = new Student();

            //if(p is Teacher)
            //{
            //    //Student s = (Student)p;
            //    Teacher s = (Teacher)p;
            //    s.TeacherSayHello();
            //}
            //else
            //{
            //    Console.WriteLine("转换失败！");
            //}

            //Teacher t = p as Teacher;
            //t.TeacherSayHello();
            Student s = p as Student;
            s.StudentSayHello();
        }
    }

    public class Person
    {
        public void PersonSayHello()
        {
            Console.WriteLine("我是父类！");
        }
    }

    public class Student:Person
    {
        public void StudentSayHello()
        {
            Console.WriteLine("我是学生！");
        }
    }

    public class Teacher:Person
    {
        public void TeacherSayHello()
        {
            Console.WriteLine("我是老师！");
        }
    }
}
