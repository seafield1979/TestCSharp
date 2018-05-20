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
                    case "accessor":
                    case "acc":
                        testAccessor(testId);
                        break;
                    case "array":
                    case "ary":
                        testArray(testId);
                        break;
                    case "class":
                        testClass(testId);
                        break;
                    case "hiding":
                        testClassHiding(testId);
                        break;
                    case "inherit":
                        testClassInherit(testId);
                        break;
                    case "collection":
                        testCollection(testId);
                        break;
                    case "delegate":
                        testDelegate(testId);
                        break;
                    case "enum":
                        testEnum(testId);
                        break;
                    case "exception":
                        testException(testId);
                        break;
                    case "file":
                        testFile(testId);
                        break;
                    case "func":
                        testFunc(testId);
                        break;
                    case "gui":
                        testGUI(testId);
                        break;
                    case "if":
                        testIf(testId);
                        break;
                    case "interface":
                        testInterface(testId);
                        break;
                    case "iterator":
                        testIterator(testId);
                        break;
                    case "loop":
                        testLoop(testId);
                        break;
                    case "macro":
                        testMacro(testId);
                        break;
                    case "namespace":
                    case "ns":
                        testNamespace(testId);
                        break;
                    case "property":
                        testProperty(testId);
                        break;
                    case "rambda":
                        testRambda(testId);
                        break;
                    case "struct":
                        testStruct(testId);
                        break;
                    case "static":
                        testStatic(testId);
                        break;
                    case "string":
                    case "str":
                        testStr(testId);
                        break;
                    case "task":
                        testTask(testId);
                        break;
                    case "thread":
                        testThread(testId);
                        break;
                    case "tuple":
                        testTuple(testId);
                        break;
                    case "var":
                        testVar(testId);
                        break;
                    case "e":
                    case "exit":
                        exitFlag = true;
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
         * アクセサ(プロパティ)のテスト
         */
        static void testAccessor(int testNo)
        {
            switch (testNo)
            {
                case 1:
                    TestAccessor.test1();
                    break;
                case 2:
                    TestAccessor.test2();
                    break;
                case 3:
                    TestAccessor.test3();
                    break;
            }
        }

        /**
         * ループのテスト
         */
        static void testArray(int testNo)
        {
            switch (testNo)
            {
                case 1:
                    TestArray.test1();
                    break;
                case 2:
                    TestArray.test2();
                    break;
                case 3:
                    TestArray.test3();
                    break;

            }
        }


        /**
         * Classのテスト
         */
        static void testClass(int testNo)
        {
            switch (testNo)
            {
                case 1:
                    TestClass.test1();
                    break;
                case 2:
                    TestClass.test2();
                    break;
                case 3:
                    TestClass.test3();
                    break;

            }
        }

        /**
         * クラスのメンバーの隠蔽
         */
        static void testClassHiding(int testNo)
        {
            switch (testNo)
            {
                case 1:
                    TestClassHiding.test1();
                    break;
                case 2:
                    TestClassHiding.test2();
                    break;
                case 3:
                    TestClassHiding.test3();
                    break;

            }
        }

        /**
         * クラスの継承
         */
        static void testClassInherit(int testNo)
        {
            switch (testNo)
            {
                case 1:
                    TestClassInherit.test1();
                    break;
                case 2:
                    TestClassInherit.test2();
                    break;
                case 3:
                    TestClassInherit.test3();
                    break;

            }
        }

        /**
         * コレクション(List, Set, Dictionary)
         */
        static void testCollection(int testNo)
        {
            switch (testNo)
            {
                case 1:
                    TestCollection.test1();
                    break;
                case 2:
                    TestCollection.test2();
                    break;
                case 3:
                    TestCollection.test3();
                    break;

            }
        }

        /**
         * デリゲート
         */
        static void testDelegate(int testNo)
        {
            switch (testNo)
            {
                case 1:
                    TestDelegate.test1();
                    break;
                case 2:
                    TestDelegate.test2();
                    break;
                case 3:
                    TestDelegate.test3();
                    break;

            }
        }

        /**
         * 列挙型(Enumration)
         */
        static void testEnum(int testNo)
        {
            switch (testNo)
            {
                case 1:
                    TestEnum.test1();
                    break;
                case 2:
                    TestEnum.test2();
                    break;
                case 3:
                    TestEnum.test3();
                    break;

            }
        }

        /**
         * 例外
         */
        static void testException(int testNo)
        {
            switch (testNo)
            {
                case 1:
                    TestException.test1();
                    break;
                case 2:
                    TestException.test2();
                    break;
                case 3:
                    TestException.test3();
                    break;

            }
        }

        /**
         * ファイル入出力
         */
        static void testFile(int testNo)
        {
            switch (testNo)
            {
                case 1:
                    TestFile.test1();
                    break;
                case 2:
                    TestFile.test2();
                    break;
                case 3:
                    TestFile.test3();
                    break;

            }
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
         * GUIのテスト
         */
        static void testGUI(int testNo)
        {
            switch (testNo)
            {
                case 1:
                    TestGUI.test1();
                    break;
                case 2:
                    TestGUI.test2();
                    break;
                case 3:
                    TestGUI.test3();
                    break;

            }
        }

        /**
         * 条件分岐(if, switch)
         */
        static void testIf(int testNo)
        {
            switch (testNo)
            {
                case 1:
                    TestIf.test1();
                    break;
                case 2:
                    TestIf.test2();
                    break;
                case 3:
                    TestIf.test3();
                    break;

            }
        }

        /**
         * インターフェース(Interface)
         */
        static void testInterface(int testNo)
        {
            switch (testNo)
            {
                case 1:
                    TestInterface.test1();
                    break;
                case 2:
                    TestInterface.test2();
                    break;
                case 3:
                    TestInterface.test3();
                    break;

            }
        }

        /**
         * イテレータ(Iterator)
         */
        static void testIterator(int testNo)
        {
            switch (testNo)
            {
                case 1:
                    TestIterator.test1();
                    break;
                case 2:
                    TestIterator.test2();
                    break;
                case 3:
                    TestIterator.test3();
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
         * プリプロセッサ（マクロ)
         */
        static void testMacro(int testNo)
        {
            switch (testNo)
            {
                case 1:
                    TestMacro.test1();
                    break;
                case 2:
                    TestMacro.test2();
                    break;
                case 3:
                    TestMacro.test3();
                    break;

            }
        }

        /**
         * 名前空間
         */
        static void testNamespace(int testNo)
        {
            switch (testNo)
            {
                case 1:
                    TestNamespace.test1();
                    break;
                case 2:
                    TestNamespace.test2();
                    break;
                case 3:
                    TestNamespace.test3();
                    break;

            }
        }

        /**
         * プロパティ、ゲッターセッター
         */
        static void testProperty(int testNo)
        {
            switch (testNo)
            {
                case 1:
                    TestProperty.test1();
                    break;
                case 2:
                    TestProperty.test2();
                    break;
                case 3:
                    TestProperty.test3();
                    break;

            }
        }

        /**
         * ラムダ式
         */
        static void testRambda(int testNo)
        {
            switch (testNo)
            {
                case 1:
                    TestRambda.test1();
                    break;
                case 2:
                    TestRambda.test2();
                    break;
                case 3:
                    TestRambda.test3();
                    break;

            }
        }

        /**
         * 静的(static)
         */
        static void testStatic(int testNo)
        {
            switch (testNo)
            {
                case 1:
                    TestStatic.test1();
                    break;
                case 2:
                    TestStatic.test2();
                    break;
                case 3:
                    TestStatic.test3();
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

        /**
         * 構造体
         */
        static void testStruct(int testNo)
        {
            switch (testNo)
            {
                case 1:
                    TestStruct.test1();
                    break;
                case 2:
                    TestStruct.test2();
                    break;
                case 3:
                    TestStruct.test3();
                    break;
            }
        }

        /**
         * タスク(並列処理)
         */
        static void testTask(int testNo)
        {
            switch (testNo)
            {
                case 1:
                    TestStruct.test1();
                    break;
                case 2:
                    TestStruct.test2();
                    break;
                case 3:
                    TestStruct.test3();
                    break;
            }
        }

        /**
         * スレッド(並列処理)
         */
        static void testThread(int testNo)
        {
            switch (testNo)
            {
                case 1:
                    TestStruct.test1();
                    break;
                case 2:
                    TestStruct.test2();
                    break;
                case 3:
                    TestStruct.test3();
                    break;
            }
        }

        /**
         * タプル
         */
        static void testTuple(int testNo)
        {
            switch (testNo)
            {
                case 1:
                    TestStruct.test1();
                    break;
                case 2:
                    TestStruct.test2();
                    break;
                case 3:
                    TestStruct.test3();
                    break;
            }
        }

        /**
         * 変数
         */
        static void testVar(int testNo)
        {
            switch (testNo)
            {
                case 1:
                    TestStruct.test1();
                    break;
                case 2:
                    TestStruct.test2();
                    break;
                case 3:
                    TestStruct.test3();
                    break;
            }
        }
    }
}
