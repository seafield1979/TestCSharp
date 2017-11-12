using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * 名前空間
 * 名前空間それぞれで、同じ名前のクラスを定義することができる。
 * 階層化できるのでフォルダのようなもの。
 */
namespace TestCSharp
{
    using TestNS.NS3;

    class TestNamespace
    {
            
        public static void test1()
        {
            // 他の名前空間のクラスを使用する場合、名前空間込みの名前を指定する
            TestNS.NS2.Hoge1.disp();
        }

        public static void test2()
        {
            // usingで読み込んだものに関しては名前空間を省略できる。
            Hoge1.disp();
        }
        public static void test3()
        {

        }
    }

    namespace TestNS
    {
        namespace NS2
        {
            class Hoge1
            {
                public static void disp()
                {
                    Console.WriteLine("Namespace TestNS.Ns2");
                }
            }
        }
        namespace NS3
        {
            class Hoge1
            {
                public static void disp()
                {
                    Console.WriteLine("Namespace TestNS.Ns3");
                }
            }
        }
    }

}
