using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * 列挙型
 * 整数や文字列の値にまとめて名前を付けることができる
 */
namespace TestCSharp
{
    class TestEnum
    {
        public enum 年号
        {
            明治, 大正, 昭和, 平成
        }

        public enum Month
        {
            January = 1, February, March, April,
            May, June, July, August,
            September, October, November, December
        }

        public static void test1()
        {
            Console.WriteLine("{0} {1} {2} {3}", 年号.明治, 年号.大正, 年号.昭和, 年号.平成);

            for (int i = 1; i < Enum.GetNames(typeof(Month)).Length; i++)
            {
                Console.WriteLine("{0}:{1}", i, (Month)i);
            }
        }

        public static void test2()
        {

        }
        public static void test3()
        {

        }
    }

    class Enum1
    {
    }
}
