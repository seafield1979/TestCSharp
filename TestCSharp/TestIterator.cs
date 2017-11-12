using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * イテレータ
 * 値のセットをforeach等でまとめて処理することができる
 * 
 * イテレータを返したい場合は  IEnumerable<型名> を戻り値にする
 * クラスのオブジェクトを foreachに渡したときにイテレータを返してもらいたい場合は GetEnumerator メソッドを実装する
 */
namespace TestCSharp
{
    class TestIterator
    {
        // イテレータを返してそれを使用する。
        public static void test1()
        {
            foreach (int i in TestEnumerable.FromTo(10, 20))
            {
                Console.Write("{0}\n", i);
            }
        }

        public static void test2()
        {
            TestEnumerable2<int> e2 = new TestEnumerable2<int>();
            
            foreach (int i in e2)
            {
                Console.WriteLine("{0}", i);
            }
        }
        public static void test3()
        {
            TestEnumerable3<string> e3 = new TestEnumerable3<string>();

            foreach (string s in e3)
            {
                Console.WriteLine(s);
            }
        }
    }

    class TestEnumerable
    {
        // これがイテレーター ブロック。IEnubrable を実装するクラスを自動生成してくれる。
        static public IEnumerable<int> FromTo(int from, int to)
        {
            while (from <= to)
                yield return from++;
        }
    }

    // 固定の列挙子を返す
    class TestEnumerable2<T>
    {
        /// 列挙子を取得
        /// GetEnumerator()メソッドは foreach の in の後のパラメータとして渡された場合に呼ばれる
        public IEnumerator<int> GetEnumerator()
        {
            for (int i=0; i<10; i++)
            {
                yield return i * 100;
            }
        }
    }

    // 自分が保持する配列を返す
    class TestEnumerable3<T>
    {
        private string[] strs;

        public TestEnumerable3()
        {
            strs = new string[5];
            strs[0] = "hoge1";
            strs[1] = "hoge2";
            strs[2] = "hoge3";
            strs[3] = "hoge4";
            strs[4] = "hoge5";
        }

        public IEnumerator<string> GetEnumerator()
        {
            yield return strs[0];
            yield return strs[1];
            yield return strs[2];
            yield return strs[3];
            yield return strs[4];
        }
    }
}
