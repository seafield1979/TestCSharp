using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * C#の構造体
 * ClassにできてStructにできないこと
 ・他のクラスから派生(他のクラスを継承)する
  ・継承に関連する修飾子(abstract, sealed, virtual, overrideなど)を使えるもクラスだけ
　・静的クラス
　・引数なしのコンストラクターの定義
　・デストラクターの定義
一方、クラス・構造体どちらでもできることは以下のとおりです。
　・引数なしコンストラクター、デストラクター以外のメンバー定義
　・インターフェイスの実装(複数も可)
　(構造体自身にはstatic修飾子を付けれないものの)静的メンバーの定義自体は可能
 */
namespace TestCSharp
{
    class TestStruct
    {
        public static void test1()
        {
            STest1 s1 = new STest1();
            s1.a = 100;
            s1.b = 200;
            s1.str = "hoge";
            s1.disp();
        }

        public static void test2()
        {
        }

        public static void test3()
        {

        }
    }

    struct STest1
    {
        public int a;
        public int b;
        public string str;

        int func1()
        {
            return this.a + this.b;
        }

        public void disp()
        {
            Console.WriteLine("{0} {1} {2}", a, b, str);
        }
    }
}
