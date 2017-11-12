using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * インターフェース
 * クラスに特定の機能のセットを実装させることができる
 */
namespace TestCSharp
{
    using NSTestInherit;

    class TestInterface
    {
        public static void test1()
        {
            CTest1 c1 = new CTest1();
            c1.disp();

            int sum = c1.calc(1, 2);
            Console.WriteLine("sum={0}", sum);
        }

        // インターフェースを実装したクラスはインターフェース型の変数に代入可能
        public static void test2()
        {
            ITest1 c1 = new CTest1();
            ITest1 c2 = new CTest2();

            c1.disp();
            c2.disp();

            Console.WriteLine("{0} {1}", c1.calc(10, 20), c2.calc(10, 20));
        }

        public static void test3()
        {

        }
    }

    namespace NSTestInherit
    {
        // インターフェースの定義
        // インターフェースにはメソッドの宣言(抽象メソッド)だけ定義できる
        // メソッドはすべて public 
        interface ITest1
        {
            void disp();
            int calc(int a, int b);
        }

        // インターフェースを実装するクラス
        class CTest1 : ITest1
        {
            public void disp()
            {
                Console.WriteLine("disp");


            }
            public int calc(int a, int b)
            {
                return a + b;
            }
        }

        class CTest2 : ITest1
        {
            public void disp()
            {
                Console.WriteLine("disp2");


            }
            public int calc(int a, int b)
            {
                return a * b;
            }
        }
    }
}
