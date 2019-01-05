using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 泛型委托
{
    public delegate int DelCompare<T>(T t1, T t2);

    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 3, 4, 5, 6, 7 };
            int max = GetMax<int>(nums, Compare1);
            Console.WriteLine(max);

            string[] names = { "wnferg", "reighreg", "hjhjhjhjhjhjhjhjhjhjhjhj" };
            string strMax = GetMax<string>(names, (string s1, string s2) =>
               {
                   return s1.Length - s2.Length;
               });
            Console.WriteLine(strMax);
        }

        public static T GetMax<T>(T[] nums,DelCompare<T> del)
        {
            T max = nums[0];
            for (int i = 0; i < nums.Length; i++)
            {
                if (del(max, nums[i]) < 0)
                {
                    max = nums[i];
                }
            }
            return max;
        }

        public static int Compare1(int n1,int n2)
        {
            return n1 - n2;
        }
    }
}
