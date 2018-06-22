using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * クラスの継承
 * ある親クラスの属性を引きつぐ子クラスを作成する
 * 
 * C#の継承の特徴
 * ・コンストラクタの継承はC++に近く、子クラスのコンストラクタで自動で親クラスのコンストラクタが呼ばれる
 * ・親クラスのメソッドを呼び出せる(親クラスと子クラスで同じメソッド名の場合は base.メソッド名)
 * ・抽象クラスを作る場合は abstract を使用する
 */
namespace TestCSharp
{
    using TestInherit;

    class TestClassInherit
    {
        // 超基本的な継承のテスト
        public static void test1()
        {
            CParent p1 = new CParent();
            CChild c1 = new CChild();

            p1.disp();
            c1.disp();
        }

        // 子クラスのコンストラクタから親クラスのコンストラクタを呼び出す
        public static void test2()
        {
            CChild2 c2 = new CChild2(10, 20, 30);
            c2.disp();    
        }

        // アップキャストとポリモフィズム
        // 親クラスの変数に子クラスのオブジェクトを代入し、親クラスの変数を通して子クラスのメソッドを呼び出す
        public static void test3()
        {
            CChild31 c1 = new CChild31();
            CChild32 c2 = new CChild32();

            List<CParent3> list = new List<CParent3>();

            list.Add(c1);
            list.Add(c2);

            foreach (CParent3 p1 in list)
            {
                p1.disp();
            }
        }
    }

    namespace TestInherit
    {
        // 親クラス
        class CParent
        {
            // メンバー
            protected int a;
            protected int b;

            public CParent()
            {
                a = 1;
                b = 2;
            }
            public void disp()
            {
                Console.WriteLine("a={0} b={1}", a, b);
            }
        }

        // 子クラス
        class CChild : CParent
        {
            protected int c;

            public CChild()
            {
                c = 3;
            }
            public new void disp()
            {
                // 親クラスの同名のメソッドを呼ぶには base を付ける
                base.disp();
                Console.WriteLine("a={0} b={1} c={2}", a, b, c);
            } 
        }
    }


    // ２つ目の継承クラス
    // 子クラスのコンストラクタから親クラスの引数つきコンストラクタを呼び出す
    class CParent2
    {
        protected int a;
        protected int b;

        public CParent2(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
    }

    class CChild2 : CParent2
    {
        protected int c;

        public CChild2(int a, int b, int c) : base(a, b)
        {
            this.c = c;
        }

        public new void disp()
        {
            // 親クラスの同名のメソッドを呼ぶには base を付ける
            Console.WriteLine("a={0} b={1} c={2}", a, b, c);
        }
    }

    // アップキャスト:　親クラスの変数に子クラスの変数を渡すことをアップキャストという
    // アップキャストを用いてポリモフィズムを実現する
    abstract class CParent3
    {
        string name;

        public CParent3()
        {

        }

        public abstract void disp();
    }

    class CChild31 : CParent3
    {
        public CChild31()
        {

        }

        override public void disp()
        {
            Console.WriteLine("disp child1");
        }
    }

    class CChild32 : CParent3
    {
        public CChild32()
        {

        }

        override public void disp()
        {
            Console.WriteLine("disp child2");
        }
    }

}
