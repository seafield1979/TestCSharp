using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

// ファイルの情報参照、ファイル操作系のテスト
namespace TestCSharp
{
    class TestFile2
    {
        public static void test1()
        {
            // ファイルの情報を取得
            FileInfo fileInfo = new FileInfo(@".\text1.txt");
            Console.WriteLine("フルパス名:{0}", fileInfo.FullName);
            Console.WriteLine("ファイル名:{0}", fileInfo.Name);
            Console.WriteLine("拡張子:{0}", fileInfo.Extension);
            Console.WriteLine("ファイルサイズ:{0}", fileInfo.Length);
            
            Console.WriteLine("作成日時:{0}", fileInfo.CreationTime.ToString("yyyy/MM/dd hh:mm:ss"));
            Console.WriteLine("最終更新:{0}", fileInfo.LastWriteTime.ToString("yyyy/MM/dd hh:mm:ss"));
            Console.WriteLine("読み取り専用:{0}", fileInfo.IsReadOnly);

            // フォルダの情報を取得
            DirectoryInfo di = new DirectoryInfo(@".\");
            Console.WriteLine("フルパス名:{0}", di.FullName);
            Console.WriteLine("作成日時:{0}", di.CreationTime.ToString("yyyy/MM/dd hh:mm:ss"));

            // ファイルが存在するか
            string filePath = @".\text1.txt";
            if (File.Exists(filePath))
            {
                Console.WriteLine("{0}は存在します。", filePath);
            }
            else
            {
                Console.WriteLine("{0}は存在しません。", filePath);
            }

            // フォルダが存在するか
            string dirPath = @"..\Release";
            if (Directory.Exists(dirPath))
            {
                Console.WriteLine("{0}は存在します。", dirPath);
            }
            else
            {
                Console.WriteLine("{0}は存在しません。", dirPath);
            }
        }

        // ファイルの列挙
        public static void test2()
        {
            // 指定フォルダ以下のファイル、フォルダ名を取得する
            DirectoryInfo di = new DirectoryInfo(@"..\");
            foreach (var dir in di.EnumerateDirectories())
            {
                Console.WriteLine("dir:{0}", dir.Name);
            }

            foreach (var file in di.EnumerateFiles())
            {
                Console.WriteLine("file:{0}", file.Name);
            }
        }

        // ファイルを作成
        public static void test3()
        {
            FileStream stream = File.Create("sample.txt");
            Console.WriteLine("created sample.txt");

            FileInfo fileInfo = new FileInfo("sample2.txt");
            FileStream stream2 = fileInfo.Create();
            stream.Close();
            Console.WriteLine("created sample2.txt");
        }

        // ファイルをコピー
        public static void test4()
        {
            try
            {
                File.Delete(@".\temp\sample.txt");


                // ファイルをコピー
                File.Copy(@"sample.txt", @".\temp\sample.txt");
                Console.WriteLine(@"copy sample.txt to .\temp\sample.txt");

                // ファイルを上書きコピー
                File.Copy(@"sample.txt", @".\temp\sample.txt", true);
                Console.WriteLine(@"overwrite copy sample.txt to .\temp\sample.txt");

                // sample.txt を新規作成
                FileInfo fileInfo = new FileInfo("sample.txt");
                fileInfo.CopyTo(@".\temp\sample2.txt", true);
                Console.WriteLine(@"created .\temp\sample2.txt");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        // ファイルを削除する
        public static void test5()
        {
            string fileName = "sample.txt";

            // 削除対象のファイルがなかったら作成する
            if (File.Exists(fileName) == false)
            {
                File.Create(fileName).Close();
            }

            // ファイルを削除する
            File.Delete(fileName);

            // ファイルが削除されたかどうかを確認する
            if (File.Exists(fileName) == false)
            {
                Console.WriteLine("{0} is deleted.", fileName);
            }
            else
            {
                Console.WriteLine("{0} doesn't delete", fileName);
            }
        }

        // ファイルを移動する
        public static void test6()
        {
            string fileName1 = @"sample.txt";
            string fileName2 = @".\temp\sample.txt";

            if (File.Exists(fileName1) == false )
            {
                File.Create(fileName1).Close();
            }
            // 移動先のファイルが存在していたら削除してから移動
            if (File.Exists(fileName2))
            {
                File.Delete(fileName2);
            }

            File.Move(fileName1, fileName2);

            if (File.Exists(fileName2))
            {
                Console.WriteLine("copy is success.");
            }
        }

        // ディレクトリを作成する
        public static void test7()
        {
            DirectoryInfo di = Directory.CreateDirectory(@"temp");
        }

        // ディレクトリを削除する
        public static void test8()
        {
            string dirName = @".\temp2";

            if (Directory.Exists(dirName) == false)
            {
                Directory.CreateDirectory(dirName);
            }

            // 第２引数は ディレクトリ以下を完全に削除するか。
            Directory.Delete(dirName, true);

            Console.WriteLine("{0} is deleted.", dirName);
        }

        // ディレクトリを移動する
        public static void test9()
        {
            string dirName1 = @".\a";
            string dirName2 = @".\b";
            string dirName3 = @".\c";

            if (Directory.Exists(dirName1) == false)
            {
                Directory.CreateDirectory(dirName1);
            }
            if (Directory.Exists(@".\temp\a"))
            {
                Directory.Delete(@".\temp\a", true);
            }
            // 移動
            Directory.Move(dirName1, @".\temp\a");
            Console.WriteLine(@"move {0} to .\temp\", dirName1);

            // リネーム
            if (Directory.Exists(dirName2) == false)
            {
                Directory.CreateDirectory(dirName2);
            }
            if (Directory.Exists(dirName3) == true)
            {
                Directory.Delete(dirName3, true);
            }

            Directory.Move(dirName2, dirName3);
            Console.WriteLine(@"rename {0} to {1}", dirName2, dirName3);

        }

        // ファイル一覧を取得する
        public static void test10()
        {
            // 全ファイル
            string[] files = Directory.GetFiles(@".\");
            foreach( string file in files)
            {
                Console.WriteLine(file);
            }

            // 指定のパターンに一致するファイル
            Console.WriteLine("\n");
            files = Directory.GetFiles(@".\", @"text*.txt");
            foreach (string file in files)
            {
                Console.WriteLine(file);
            }
        }

        // ディレクトリ一覧を取得する
        public static void test11()
        {
            // 全ディレクトリ
            string[] direNames = Directory.GetDirectories(@".\");

            foreach (string dir in direNames)
            {
                Console.WriteLine(dir);
            }
        }

        // ファイル・ディレクトリの各種情報を取得する
        public static void test12()
        {
            // 作成日時
            Console.WriteLine("作成日時:{0}", File.GetCreationTime(@".\text1.txt").ToString("yyyy/MM/dd hh:mm:ss"));

            // 作成日時を設定
            File.SetCreationTime(@"text2.txt", DateTime.Now);

            // 最終アクセス日時を取得
            File.GetLastAccessTime(@"text1.txt").ToString("yyyy/MM/dd hh:mm:ss");

            // 最終更新日時を取得
            Console.WriteLine("最終更新日時:{0}", File.GetLastWriteTime(@"text1.txt").ToString("yyyy/MM/dd hh:mm:ss"));

            // ディレクトリ
            // 作成日時を取得
            Console.WriteLine("作成日時:{0}", Directory.GetCreationTime(@".\temp").ToString("yyyy/MM/dd hh:mm:ss"));

            // 作成日時を設定
            Directory.SetCreationTime(@".\temp", DateTime.Now);

            // 最終更新日時を取得
            Console.WriteLine("最終更新日時:{0}", Directory.GetLastWriteTime(@".\temp").ToString("yyyy/MM/dd hh:mm:ss"));
            
        }
    }
}
