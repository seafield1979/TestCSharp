using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * 複数のオブジェクトをまとめて扱うことができるコレクションクラス
 * リスト、マップ、セット等がある
 */
namespace TestCSharp
{
    class TestCollection
    {
        public static void test1()
        {
            // リスト
            List<int> list1 = new List<int>();
            list1.Add(100);
            list1.Add(200);

            disp(list1);
            Console.WriteLine("list1:Length = {0}", list1.Count);

            // stringのリスト
            List<string> list2 = new List<string>();
            list2.Add("hoge");
            list2.Add("hage");

            disp(list2);
            Console.WriteLine("list2:Length = {0}", list2.Count);

            // 要素を参照
            Console.WriteLine("list2[1]={0}", list2[1]);

            // 要素に挿入
            list2.Insert(1, "huge");
            list2.InsertRange(1, new List<string>(){ "hoge","hage"});

            // 要素を削除
            List<int> list3 = new List<int>();
            for (int i=0; i<10; i++)
            {
                list3.Add(i * 10);
            }
            list3.RemoveAt(5);     // 指定の番号の要素を削除

            disp(list3);

            // 配列にコピーする
            Console.WriteLine("\n配列にコピーする");
            int[] array1 = new int[list3.Count];
            list3.CopyTo(array1);

            foreach (int value in array1)
            {
                Console.WriteLine("{0}", value);
            }

            // コレクションを連結する
            Console.WriteLine("\nコレクションを連結する");
            List<string> list41 = new List<string>() { "apple", "orange", "banana" };
            List<string> list42 = new List<string>() { "strawberry", "melon", "peach" };

            IEnumerable<string> list43 = list41.Concat(list42);
            disp(list43);

            // コレクションの最大値、最小値を求める
            List<string> list5 = new List<string>()
            {
                "hello", "こんにちは", "Guten Tag", "a"
            };
            Console.WriteLine("最大値:{0}", list5.Max(p => p.Length));

            Console.WriteLine("最小値:{0}", list5.Min(p => p.Length));

            // コレクションをフィルタする
            Console.WriteLine("\nコレクションをフィルタする");
            List<int> list6 = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                list6.Add(i * 10);
            }

            IEnumerable<int> where1 = list6.Where(p => p >= 50);
            disp(where1);

            // リストを並び替える
            Console.WriteLine("\nリストを並び替える");
            List<string> list7 = new List<string>() { "hello", "ok", "good", "1111111" };
            list7.Sort((x, y) => x.Length.CompareTo(y.Length));
            disp(list7);

            List<string> list72 = new List<string>() { "9", "3", "1", "5" , "0"};
            list72.Sort((x, y) => x.CompareTo(y));
            disp(list72);
        }

        public static void test2()
        {
            // 双方向リスト
            LinkedList<int> list1 = new LinkedList<int>();

            for (int i=0; i<10; i++)
            {
                list1.AddLast(i);
            }

            // 末尾から順に表示
            LinkedListNode<int> node = list1.Last;

            while(node != null)
            {
                Console.WriteLine("node:{0}", node.Value);
                node = node.Previous;
            }
        }


        public static void test3()
        {
            // Dictionary
            Dictionary<string, string> dic1 = new Dictionary<string, string>();

            dic1.Add("yamagata", "山形");
            dic1.Add("aomori", "青森");
            dic1.Add("iwate", "岩手");
            dic1.Add("akita", "秋田");
            dic1.Add("miyagi", "宮城");
            dic1.Add("fukushima", "福島");

            // 参照する
            string key = "yamagata";
            Console.WriteLine("key={0}:value={1}", key, dic1[key]);

            // 全要素を参照する
            foreach (string key1 in dic1.Keys)
            {
                Console.WriteLine("key={0}:value={1}", key1, dic1[key1]);
            }

            // 全値を参照する
            foreach (string value in dic1.Values)
            {
                Console.WriteLine("value={0}", value);
            }

            // 関数で表示
            Console.WriteLine("\n関数で表示");
            dispDictionary(dic1);

            // キーが含まれるか
            Console.WriteLine("contains key {0}", dic1.ContainsKey("yamagata"));
            Console.WriteLine("contains value {0}", dic1.ContainsValue("山形"));

            Console.WriteLine("要素数:{0}", dic1.Count);
        }

        public static void test4()
        {
            Stack<string> stack1 = new Stack<string>();

            stack1.Push("yama1");
            stack1.Push("yama2");
            stack1.Push("yama3");

            // 全要素を取り出す
            while( stack1.Count > 0)
            {
                string value = stack1.Pop();
                Console.WriteLine("value={0}", value);
            }
        }


        // 汎用関数

        // コレクションの全要素を表示する
        private static void disp<T>(IEnumerable<T> collection)
        {
            int count = 0;
            foreach (var value in collection)
            {
                Console.WriteLine("[{0}]: {1}", count, value);
                count++;
            }
        }

        // 辞書の全要素を表示する
        private static void dispDictionary<T, T2>(Dictionary<T, T2> dic)
        {
            foreach (var key1 in dic.Keys)
            {
                Console.WriteLine("key={0}:value={1}", key1, dic[key1]);
            }
        }
    }
}
