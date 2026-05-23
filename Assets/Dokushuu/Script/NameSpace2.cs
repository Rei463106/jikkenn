using System;
using UnityEngine;
using Chapter = SelfCSharp.Chap09.Other;

public class NameSpace2 : MonoBehaviour
{

}

namespace SelfCSharp.Chap09.Ns
{
    internal class NamespaceModifier
    {
        static void Main(string[] args)
        {
            //using Chapter = SelfCSharp.Chap09.Other;より、書くと「このクラス内でのChapter」を見てしまいCultureInfo()は存在しないと言われる
            //var ci = new Chapter.CultureInfo();
            var ci = new Chapter::CultureInfo();//::をつけると本来呼び出したい方のCultureInfoが呼び出される
        }
    }

    internal class Chapter { }//こっちの名前空間でもChapterを定義したい…。
}

/// <summary>
/// グローバル名前空間エイリアス(別名)
/// </summary>
internal class Util
{
    public static void Run()
    {
        Console.WriteLine("Util is Running");
    }
}

namespace SelfCSharp.Chap09.Util
{
    internal class NamespaceGlobal
    {
        static void Main(string[] args)
        {
            //型または名前空間の名前 'Run' が名前空間 'SelfCSharp.Chap09.Util' に存在しません (アセンブリ参照があることを確認してください)
            //SelfCSharp.Chap09の中に　Util.Run() はないと言われている
            //Util.Run(); …では、グローバルの方のUtilクラスを使いたい時は?
            global::Util.Run();
        }
    }
}

//内側が優先されがち
//現在の名前空間にあるものが最優先(現在の名前空間にそのクラスがあるか、メソッドがあるかを確認する)
//namespace内で宣言されたusing命令は外側のusing命令より優先


//名前空間のエイリアスは同名の名前解決より優先
//大枠のnamespace優先→大枠なくなったら、大枠の中で宣言されてるusing命令優先→別名宣言された方(using MyUtil=~~~みたいなの)優先
　
