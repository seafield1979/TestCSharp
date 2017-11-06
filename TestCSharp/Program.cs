using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Input test command");

                // コマンドを入力
                string cmd = Console.ReadLine();
                char[] demiliter = { ' ' };
                string[] cmds = cmd.Split( demiliter );
                int testId = 1;

                if (cmds.Length < 1)
                {
                    break;
                }
                if (cmds.Length >= 2)
                {
                    int.TryParse(cmds[1], out testId);
                }

                bool exitFlag = false;

                // コマンドによる分岐
                switch (cmds[0])
                {
                    case "array":
                    case "ary":
                        break;
                    case "class":
                        break;
                    case "func":
                        testFunc(testId);
                        break;
                    case "if":
                        break;
                    case "loop":
                        testLoop(testId);
                        break;
                    case "str":
                        testStr(testId);
                        break;
                    case "exception":
                        break;
                    case "e":
                    case "exit":
                        exitFlag = true;
                        break;

                    case "var":
                        break;
                    default:
                        exitFlag = true;
                        break;
                }
                if (exitFlag)
                {
                    break;
                }
            }

            Console.WriteLine("test is finished");
            // 入力待ち
            string hoge = Console.ReadLine();

        }

        /**
         * 関数のテスト
         */
        static void testFunc(int testNo)
        {
            switch (testNo)
            {
                case 1:
                    TestFunction.test1();
                    break;
                case 2:
                    TestFunction.test2();
                    break;
                case 3:
                    TestFunction.test3();
                    break;
                case 4:
                    TestFunction.test4();
                    break;
                case 5:
                    TestFunction.test5();
                    break;
                case 6:
                    TestFunction.test6();
                    break;
                case 7:
                    TestFunction.test7();
                    break;
            }
        }

        /**
         * ループのテスト
         */
        static void testLoop(int testNo)
        {
            switch (testNo)
            {
                case 1:
                    TestLoop.test1();
                    break;
                case 2:
                    TestLoop.test2();
                    break;
                case 3:
                    TestLoop.test3();
                    break;

            }
        }

        /**
         * 文字列(string)
         */
        static void testStr(int testNo)
        {
            switch(testNo)
            {
                case 1:
                    TestString.test1();
                    break;
                case 2:
                    TestString.test2();
                    break;
                case 3:
                    TestString.test3();
                    break;
            }
        }
    }
}
