// #define PP_MAX (100)  エラー
#define PP_MAX

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// プリプロセッサのテスト
// コンパイル前に処理される #if ～ #endif 等の処理
//

namespace TestCSharp
{

    class TestPreprocessor
    {
        public static void test1()
        {
#if DEBUG
            Console.WriteLine("DEBUG");
#else
            Console.WriteLine("not DEBUG");
#endif

#if MODE1
            Console.WriteLine("MODE");
#else
            Console.WriteLine("not MODE");
#endif
        }

        public static void test2()
        {

        }
        public static void test3()
        {

        }
    }
}
