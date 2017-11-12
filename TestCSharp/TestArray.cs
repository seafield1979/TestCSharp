using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * C#の配列
 * ・配列の要素数をLengthで参照できる
 * ・foreachで要素数分の処理を行うことができる
 * ・多次元配列と配列の配列の２つを分けて使用できる
 */
namespace TestCSharp
{
    class TestArray
    {
        // ただの配列
        public static void test1()
        {
            // 配列の宣言
            int[] array = new int[5];
            int[] array2 = { 1, 2, 3, 4, 5 };

            // 配列の代入、参照
            array[0] = 1;
            array[1] = 2;
            array[2] = 3;
            array[3] = 4;
            array[4] = 5;

            foreach (var a in array)
            {
                Console.WriteLine("{0}", a);
            }
            for (int i=0; i<array2.Length; i++)
            {
                Console.WriteLine("{0}", array2[i]);
            }
        }

        // 多次元配列
        public static void test2()
        {
            // ２次元配列
            int[,] array = new int[3, 3];
            for (int i=0; i<3; i++)
            {
                for (int j=0; j<3; j++)
                {
                    array[i, j] = (i * 3) + (j + 1);
                    Console.WriteLine("[{0}][{1}] = {2}", i, j, array[i, j]);
                }
            }

            // ３次元配列
            int[,,] array2 = { 
                {{ 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } },
                {{ 21, 22, 23 }, { 24, 25, 26 }, { 27, 28, 29 } },
                {{ 31, 32, 33 }, { 34, 35, 36 }, { 37, 38, 39 } }
            };

            for (int i=0; i<3; i++)
            {
                for (int j=0; j<3; j++)
                {
                    for (int k=0; k<3; k++)
                    {
                        Console.WriteLine("[{0},{1},{2}] = {3}",i,j,k, array2[i, j, k]);
                    }
                }
            }
        }

        // 配列の配列
        // 要素数がばらばらな配列
        public static void test3()
        {
            int[] array1 = { 1, 2 };
            int[] array2 = { 3, 4, 5 };
            int[] array3 = { 6, 7, 8, 9 };
            int[][] array4 = { array1, array2, array3 };

            foreach(var a in array4)
            {
                foreach (var b in a)
                {
                    Console.Write("{0} ", b);
                }
                Console.WriteLine();
            }

            int[][] array5 = { new int[2], new int[3], new int[4] };
            for (int i=0; i<array5.Length; i++)
            {
                for (int j=0; j<array5[i].Length; j++)
                {
                    array5[i][j] = 0;
                }
            }

            array5[0][0] = 1;
            array5[1][1] = 2;
            array5[2][2] = 3;

            for (int i = 0; i < array5.Length; i++)
            {
                for (int j = 0; j < array5[i].Length; j++)
                {
                    Console.WriteLine("[{0}][{1}] = {2}", i, j, array5[i][j]);
                }
            }
        }
    }
}
