using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * C#の静的の特徴は
 * ・staticコンストラクタが使用できる
 * ・staticクラス(静的メンバのみ)が作れる
 */

namespace TestCSharp
{
    class TestStatic
    {
        public static void test1()
        {
            StaticC1.disp1();
            StaticC1.disp2();
        }
        public static void test2()
        {
            StaticC1.a = 100;
            StaticC1.b = 200;
            StaticC1.disp2();
        }

        public static void test3()
        {

        }


        static class StaticC1
        {
            // static変数
            // １クラスで１つだけ値が存在する
            // インスタンスを作らなくても使用可能
            public static int a;
            public static int b;

            // staticコンストラクタ
            // システム初期化時に１回だけ呼ばれる
            static StaticC1()
            {
                a = 10;
                b = 20;
            }

            public static void disp1()
            {
                Console.WriteLine("disp1");
            }
            public static void disp2()
            {
                Console.WriteLine("disp2 {0} {1}", a, b);
            }

            // staticでないのでコンパイルエラー
            //public void disp3()
            //{
            //}
        }
    }
}
