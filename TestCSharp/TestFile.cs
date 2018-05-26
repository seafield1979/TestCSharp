using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/**
 * ファイルの入出力
 */
namespace TestCSharp
{
    class TestFile
    {
        public static void test1()
        {
            TextFile tf1 = new TextFile();
            tf1.Write(@".\text1.txt", "hoge");

            tf1.WriteAll(@".\text2.txt", "hoge\nhoge");

            tf1.Append(@".\text2.txt", "append");

            string str = tf1.Read(@".\text1.txt");
            if (str != null)
            {
                Console.WriteLine(str);
            }

            string str2 = tf1.ReadAll(@".\text2.txt");
            if (str != null)
            {
                Console.WriteLine(str);
            }
        }

        public static void test2()
        {
            try
            {
                // バイナリファイルに書き込む
                byte[] bin1 = new byte[256];

                for (int i = 0; i < 256; i++)
                {
                    bin1[i] = (byte)i;
                }
                BinaryFile bf1 = new BinaryFile();
                bf1.WriteAll(@"data1.bin", bin1);

                Console.WriteLine("write to data1.bin");

                // バイナリファイルを読み込む
                byte[] bin2 = bf1.Read(@"data1.bin", 16, 16);
                foreach (byte data in bin2)
                {
                    Console.Write("{0:X2} ", data);
                }
                Console.WriteLine("");

                // バイナリファイルに書き込み
                byte[] bin3 = new byte[16] { 0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15 };
                bf1.Write(@"data2.bin", bin3, 0, 16, FileMode.Create);

                bf1.Write(@"data2.bin", bin3, 0, 8, FileMode.Append);

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
        public static void test3()
        {

        }
    }

    // テキストファイルを読み書きするクラス
    class TextFile
    {
        // Methods
        // テキストを書き込む
        public bool Write(string filePath, string text)
        {
            // usingを使用するとファイルのオープンに対応するclose処理(Dispose())を自動で呼び出してくれる。
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                sw.WriteLine(text);
                sw.Write(text);
            }

            return true;
        }

        // 全テキストを書き込む
        public void WriteAll(string filePath, string text)
        {
            File.WriteAllText(filePath, text);
        }

        // 追加書き込みする
        public void Append(string filePath, string text)
        {
            // 指定したファイルの末尾に文字列を追加書き込みする。
	        File.AppendAllText(filePath, text);
        }

        // ファイルからテキストを読み込む
        public string Read(string filePath)
        {
            StringBuilder sb = new StringBuilder();

            // using
            using (StreamReader sr = new StreamReader(filePath))
            {

                while (sr.Peek() >= 0)
                {
                    // ファイルを 1 行ずつ読み込む
                    sb.Append(sr.ReadLine());
                }
            }
            return sb.ToString();
        }

        // 全行をまとめて読み込み
        public string ReadAll(string filePath)
        {
            return File.ReadAllText(filePath, Encoding.GetEncoding(@"shift-jis"));
        }

    }

    //
    // バイナリデータを読み書きするクラス
    //
    class BinaryFile { 
        // バイナリファイルからバイト情報を読み込む
        public byte[] ReadAll(string filePath)
        {
            byte[] readData = File.ReadAllBytes(filePath);
            return readData;
        }

        // バイナリデータを読み込む（読み込み位置、サイズ指定バージョン)
        public byte[] Read(string filePath, int pos, int readSize)
        {
            byte[] buffer = null;

            using (var fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                int size;
                if (pos > fs.Length - 1)
                {
                    return null;
                }
                else if (pos + readSize > fs.Length)
                {
                    pos = (int)fs.Length - pos;
                    size = (int)fs.Length - pos;
                }
                else
                {
                    size = readSize;
                }

                buffer = new byte[size];
                fs.Seek(pos, SeekOrigin.Begin);
                fs.Read(buffer, 0, size);
            }
            return buffer;
        }

        // バイナリファイルにデータを書き込む
        public bool WriteAll(string filePath, byte[] data)
        {
            try
            {
                File.WriteAllBytes(filePath, data);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
        }

        // バイナリファイルにデータを書き込み
        // @input filePath: 書き込み先のファイルパス
        // @input data:     書き込みデータ
        // @input pos:      書き込みデータの先頭位置
        // @input size:     書き込みデータサイズ
        // @input mode:     書き込みモード(
        public bool Write(string filePath, byte[] data, int pos, int size, FileMode mode)
        {
            using (FileStream fs = new FileStream(filePath, mode, FileAccess.Write))
            {
                fs.Write(data, pos, size);
            }
            return true;
        }

    }
}
