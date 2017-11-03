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
                    case "str":
                        testStr(testId);
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
