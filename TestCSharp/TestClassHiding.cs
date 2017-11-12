using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * クラスのメンバの
 * メンバやメソッドに隠蔽の修飾子を付けて、外部からの参照を制限する
 * ・主な修飾子は
 アクセシビリティ   	説明
    public	            どこからでもアクセス可能
    protected   	    クラス内部と、派生クラスの内部からのみアクセス可能
    internal	        同一プロジェクト内のクラスからのみアクセス可能
    protected internal	同一プロジェクト内のクラス内部、または、派生クラスの内部からのみアクセス可能
    private protected	(C# 7.2 以降)同一プロジェクト内のクラス内部、かつ、派生クラスの内部からのみアクセス可能
    private	            クラス内部からのみアクセス可能
 */
namespace TestCSharp
{
    class TestClassHiding
    {
        public static void test1()
        {

        }

        public static void test2()
        {

        }
        public static void test3()
        {

        }
    }
}
