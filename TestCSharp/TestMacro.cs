using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * プリプロセッサ
 * #if や #define でコンパイル前にソースを処理することができる
 * CやC++でできていた defineでの定数定義はできない
 *    #define HOGE 1000   // これはエラーになる
 */



namespace TestCSharp
{
    class TestMacro
    {
        public static void test1()
        {
            // プロジェクトの設定で [DEBUG定数を定義] にチェックするとDEBUGが定義される
#if DEBUG
            Console.WriteLine("DEBUGが定義されている");
#else
            Console.WriteLine("DEBUGが定義されていない");
#endif

        }

        public static void test2()
        {
            // プロジェクトの設定で[条件付コンパイルシンボル]で追加したシンボルが定義されている
#if DEBUG1
            Console.WriteLine("DEBUG1が定義されている");
#else
            Console.WriteLine("DEBUG1が定義されていない");
#endif

#if DEBUG2
            Console.WriteLine("DEBUG2が定義されている");
#else
            Console.WriteLine("DEBUG2が定義されていない");
#endif
        }

        public static void test3()
        {
            // #region ~ #endregion の範囲が VS でブロックとして扱ってくれる
            // これにより、折り畳みができるようになる
#region ほげほげ
            Console.WriteLine("ほげほげ");
            #endregion

            // #warningを使用するとプリプロセッサを使用して特定のブロックが有効になった際に警告が出るようになる
            // #errorを使用するとこのブロックがコンパイル対象になった際にエラーになる。
            // コンパイルスイッチで本来ありえない組み合わせになった場合に
            // 強制的にエラーにすることができる
#if HOGE
#warning  警告テスト
#error
#endif
        }
    }
}
