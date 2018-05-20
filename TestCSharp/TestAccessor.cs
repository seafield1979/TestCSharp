using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//
// アクセッサーのテスト
//

namespace TestCSharp
{
    class TestAccessor
    {
        public static void test1()
        {
            Accessor1 c1 = new Accessor1();

            c1.A = 100;
            c1.Str = "hoge";
            c1.disp();

            Console.WriteLine("c1.a={0} c1.str={1}", c1.A, c1.Str);
        }
        public static void test2()
        {

        }
        public static void test3()
        {

        }
    }

    class Accessor1
    {
        private int a;
        private string str;

        // アクセッサ
        public int A
        {
            set { this.a = value; }
            get { return this.a; }
        }

        public string Str
        {
            set { this.str = value; }
            get { return this.str; }
        }

        public Accessor1()
        {
            a = 0;
            str = null;
        }

        public void disp()
        {
            Console.WriteLine("a={0} str={1}", a, str);
        }
    }
}
