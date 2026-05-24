using System;
using UnityEngine;

public class EnumTest : MonoBehaviour
{
    private Season _season = Season.Spring;
    private void Start()
    {
        //これを使えばもっと簡単に配列にできそう
        Debug.Log(_season.ToString("D"));//整数値として表示
        Debug.Log(Season.Summer.ToString("D"));

        var styles = 0;
        styles += (int)FontStyle.Bold;//もし状態異常になった時でもこの演算をすればよさそう
        styles += (int)FontStyle.Italic;
        var style = Enum.Parse<FontStyle>(styles.ToString());//配列ではないので、どのフラグを持ってるか調べるには…
        //FontStyleの配列を作る→Hasflagを使って、style.HasFlag(~)とし配列の数分調べる→持ってたらそのフラグと対応した処理を呼び出す
        //その状態じゃなくなったら…一度全部Noneにして、その後まだ持ってる状態を入れなおす、など。
        Debug.Log(style);
    }
}

internal class EnumParse
{
    static void Main(string[] args)
    {
        var summer = (Season)Enum.Parse(typeof(Season), "Fall");//Seasonに属するものじゃないとエラーが起きる
        var num = (Season)Enum.Parse(typeof(Season), "6");//数字の方はそのまま数字が出力される(ない場合)
        Console.WriteLine($"{summer}-{summer.GetType()}");
        Console.WriteLine($"{num}-{num.GetType()}");

        var array = Enum.GetValues(typeof(Season));
        foreach (var v in array)
        {
            Console.WriteLine($"{(int)v}:{v}");
        }//列挙型の配列を取り出す
    }
}

/// <summary>
/// ビットフィールドを使用する
/// </summary>
internal class EnumBit
{
    static void Main(string[] args)
    {
        //var styles = FontStyle.Bold | FontStyle.Italic;

        //if (styles.HasFlag(FontStyle.Bold))
        //{
        //    Console.WriteLine("太字指定されています");
        //}
        //else if (styles.HasFlag(FontStyle.Bold | FontStyle.Italic))
        //{
        //    Console.WriteLine("太字＆斜体指定です");
        //}

        //Console.WriteLine(styles);

        var styles = 0;
        styles += (int)FontStyle.Bold;//もし状態異常になった時でもこの演算をすればよさそう
        styles += (int)FontStyle.Italic;

        //Console.WriteLine((FontStyle)Enum.Parse(typeof(FontStyle), styles.ToString()));
        var style = Enum.Parse<FontStyle>(styles.ToString());
        Console.WriteLine(style);
    }
}