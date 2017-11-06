using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/**
 * C#の関数
 * グローバル関数は作れない(static 関数で代用)
 * 可変長引数を使用できる (params)
 * 出力用の引数を使用できる(output)
 * オーバーロード(引数の型や数が異なる同じ名前の関数)
 * 複数の戻り値を返せる(タプル、output)
 */

namespace TestCSharp
{
    class TestFunction
    {
        /**
         *  関数の基本
         */
        public static void test1()
        {
            Console.WriteLine("test1");

            // 引数戻り値なし
            func11();

            // 引数、戻り値あり
            int sum = func12(10, 20);
            Console.WriteLine("{0} + {1} = {2}",10, 20, sum);
        }

        /**
         * 出力用の引数
         */
        public static void test2()
        {
            Console.WriteLine("test2");

            int sum = 0;
            func21(100, 200, out sum);

            Console.WriteLine("{0}", sum);
        }

        /**
         * 可変引数
         */
         public static void test3()
        {
            int sum = func31(1, 2, 3, 4, 5);
            Console.WriteLine("sum = {0}", sum);

            string str = func32("I", "am", "a", "human");
            Console.WriteLine(str);
        }

        /**
         * 複数の戻り値を返す
         */
        public static void test4()
        {
            // タプルを使用
            var ret = func41(1, 2, 3, 4, 5);

            Console.WriteLine("sum:{0} count:{1}", ret.sum, ret.count);
        }

        /**
         * オーバーロード
         * 同じ名前の関数を複数定義できる
         */
        public static void test5()
        {
            func51();
            func51(100);
            func51(100, 200);
        }

        /**
         * 名前付き引数
         */
        public static void test6()
        {
            func61();

            func61(a: 10);

            func61(c: 20);

            func61(a: 10, b: 20, c: 30);
        }

        /**
         * デフォルト値付き引数
         * デフォルト値付き引数は実引数を省略できる。ただし、省略後の引数の後の引数を渡すことができない
         */
        public static void test7()
        {
            // ２つとも省略
            func71();

            // 後の１つだけ省略
            func71(100);

            // 後ろの１つだけ省略(は不可能)
            // func71("cool");    // コンパイルエラー
            func71(s: "cool");      // 名前を指定した場合はOK
        }

        // 引数、戻り値なしの関数
        private static void func11()
        {
            // ただ文字列を出力するだけ
            Console.WriteLine("func11");
        }

        // 引数、戻り値ありの関数
        private static int func12(int a, int b)
        {
            return a + b;
        }

        // out で出力用の引数を定義する
        private static void func21(int a, int b, out int sum)
        {
            sum = a + b;
        }

        // 可変長引数
        private static int func31(params int[] values)
        {
            int sum = 0;

            foreach (int a in values)
            {
                sum += a;
            }

            return sum;
        }

        private static string func32(params string[] strs)
        {
            string ret = "";

            foreach(string s in strs)
            {
                ret += s + " ";
            }
            return ret;
        }

        // タプルで複数の戻り値を返す
        private static (int sum, int count) func41(params int[] values)
        {
            int sum = 0;

            foreach (int a in values)
            {
                sum += a;
            }
            return (sum, values.Length);
        }

        // オーバーロード
        // 引数の型、数が異なる同名の関数を定義できる
        private static void func51()
        {
            Console.WriteLine("func51 1");
        }

        private static void func51(int a)
        {
            Console.WriteLine("func51 {0}", a);

        }

        private static void func51(int a, int b)
        {
            Console.WriteLine("func51 {0}, {1}", a, b);

        }

        // 名前付きメソッド
        // 引数を省略できるようにデフォルト値を指定しておく
        private static void func61(int a = 0, int b = 0, int c = 0)
        {
            Console.WriteLine("func61 {0} {1} {2}", a, b, c);
        }

        // 引数のデフォルト値
        private static void func71(int a = 0, string s = "hoge")
        {
            Console.WriteLine("{0} {1}", s, a);
        }
    }
}
