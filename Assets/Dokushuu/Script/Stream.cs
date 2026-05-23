using System;
using System.IO;
using UnityEngine;
//using (var reader = new StreamReader(@"c:\data\sample.txt")) { Console.WriteLine(reader.ReadToEnd()); }
//上の構文を使いたいなら、IDispozableを継承する必要があるらしい

public class Stream : MonoBehaviour
{
    //private int i = -10;
    private int s = int.MaxValue;

    private void Start()
    {
        //Debug.Log(i > 0 ? i : throw new Exception(("iは1でなければなりません")));//自分で例外を作れる
    }

    private void Update()
    {     
        try
        {
            checked
            {
               // Debug.Log(unchecked(++s));
                Debug.Log(++s);
                //オーバーフローを起こすが、例外にはならない
                //uncheckedで、この場では例外を出さないようにできる
            }
        }
        catch(OverflowException e)
        {
            Debug.Log(e);
            throw;//再スロー、元の原因が分かりやすい(throw new Exeptionとかだとエラー内容が上書きされちゃう)
        }
    }
}

internal class StreamRead
{
    private StreamReader _reader = new StreamReader(@"c:\data\sample.txt");

    private void ReadEnd()
    {
        Console.WriteLine(_reader.ReadToEnd());
    }

    static void Main(string[] args)
    {
        try
        {
            var r = new StreamReader(@"C:\nothing.dat");
        }
        catch (Exception e) when (e is FileNotFoundException || e is ArgumentException)
        {
            Console.WriteLine("例外です");
        }//例外が出た時の処理が同じとき
        catch (FileNotFoundException ex)
        {
            Console.WriteLine("ファイルなし");
            Console.WriteLine(ex.StackTrace);
        }//このcatchの引数を全ての例外の親であるExceptionにするのは控えること。その例外か分からなくなるため
        //catchを複数羅列すると、上の方が優先される
    }
}

