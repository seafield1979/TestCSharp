using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * 文字列のテスト用クラス
 */
namespace TestCSharp
{
    class TestString
    {
        /*
         * 文字列のテストいろいろ
         */
        public static void test1()
        {
            // 文字列を分割する
            char[] delimiters = { ' ' };
            string str = "one two three four five";
            string[] strs = str.Split(delimiters);

            foreach (var s in strs)
            {
                Console.WriteLine(s);
            }
        }
        public static void test2()
        {

        }

        public static void test3()
        {

        }
    }
}
