using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * C#のクラスの特徴
 * ・他の言語にある基本的な機能はすべて持っている
 * ・デストラクタはC++のようにプログラマが呼ばれるタイミングを指定できない。オブジェクト破棄のタイミングはJavaのようにシステムが管理する。
 * ・C++のように演算子のオーバーロードができる。
 * ・多重継承はできない
 * ・Javaと同じようなインターフェースが使用できる
 * ・コレクションの型にジェネリクスを使用できる
 */
namespace TestCSharp
{
    using NSTestClass;

    class TestClass
    {
        // オブジェクトの生成
        public static void test1()
        {
            CTest1 c1 = new CTest1();
            c1.disp();

            CTest1 c2 = new CTest1(1, 2, "hoge");
            c2.disp();

            // nullを代入して参照を切る
            c1 = null;
            c2 = null;
        }

        public static void test2()
        {
            CTest1Child c1 = new CTest1Child(1,2,3, "hoge");
            c1.disp();

        }
        public static void test3()
        {

        }

    }

    namespace NSTestClass
    {
        class CTest1
        {
            public int a;
            protected int b;
            protected string str;

            // コンストラクタ
            public CTest1()
            {
                a = 0;
                b = 0;
                str = null;
                Console.WriteLine("CTest1:Constructor");
            }

            // 引数を渡すコンストラクタ
            public CTest1(int a, int b, string str)
            {
                this.a = a;
                this.b = b;
                this.str = str;
                Console.WriteLine("CTest1:Constructor2");
            }

            // デストラクタ（実態はjavaのファイナライザ）
            ~CTest1()
            {
                Console.WriteLine("~CTest1()");
            }

            public void disp()
            {
                Console.WriteLine("a = {0}, b = {1} str={2}", a, b, str);
            }
        }

        // 子クラス
        class CTest1Child : CTest1
        {
            int c;

            public CTest1Child()
            {
                Console.WriteLine("CTest1Child:Constructor");
            }

            // 親クラスのコンストラクタを明示的に呼び出す
            public CTest1Child(int a, int b, int c, string str) : base(a, b, str)
            {
                Console.WriteLine("CTest1Child:Constructor2");
                this.c = c;
            }

            public new void disp()
            {
                Console.WriteLine("a = {0}, b = {1} c = {2} str={3}", a, b, c, str);
            }
        }
    }
}
