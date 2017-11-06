using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * C#のループ処理
 * ・foreach を使用して配列の要素分のループ処理ができる
 */ 

namespace TestCSharp
{
    class TestLoop
    {
        // for
        public static void test1()
        {
            // for文は CやJavaと同じ
            for (int i=0; i<100; i++)
            {
                Console.WriteLine("count {0}", i);
            }
        }

        // while
        public static void test2()
        {
            // while文もCやJavaと同じ
            while(true)
            {
                Console.WriteLine("if you enter 'e' it will exit.");

                string str = Console.ReadLine();
                if (str.Equals("e"))
                {
                    break;
                }
            }
        }


        // foreach
        public static void test3()
        {
            int[] vals = { 1, 2, 3, 4, 5 };
            string[] strs = { "a", "b", "c", "d", "e" };

            foreach (var v in vals)
            {
                Console.WriteLine("{0}", v);
            }

            foreach (var s in strs)
            {
                Console.WriteLine("{0}", s);
            }

            // 多次元配列
            int[, ] vals2 = { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 }, { 16, 17, 18, 19, 20 }, { 21, 22, 23, 24, 25 } };
            foreach (var v in vals2)
            {
                Console.WriteLine("{0}", v);
            }
        }
    }
}
