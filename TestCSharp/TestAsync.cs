using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestCSharp
{
    class TestAsync
    {
        public static void test1()
        {
            Console.WriteLine("TestAsync:test01:start");

            Async01();

            Console.WriteLine("TestAsync:test01:end");
        }

        public static void test2()
        {

        }
        public static void test3()
        {

        }

        public static async void Async01()
        {
            Task<int> task = Task.Run<int>(() => {
                int total = 0;
                for (int i = 1; i <= 100; ++i)
                    total += i;
                Thread.Sleep(4560); // 何か重い処理をしている...
                return total;
            });
            int result = await task;
            Console.WriteLine("result:{0}", result);
        }
    }
}
