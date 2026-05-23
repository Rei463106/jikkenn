using System.Text;
using UnityEngine;

/// <summary>
/// 拡張メソッド
/// </summary>
public class ExtentionSystem : MonoBehaviour
{
    //今回はSystem.Stringクラスに機能を追加する
    private string t = "ありがとう";
    private int i = 5;
    private void Start()
    {
        Debug.Log(t.Repeat(3));//自作文字列から呼び出し
        Debug.Log(i.Ruijou(3));
        Debug.Log(StringExtentions.Repeat("sun", 5));//クラスから呼び出し
        Debug.Log(t.Split());//既に用意されてるstringクラスの機能
    }
}

//staticクラスにする
internal static class StringExtentions
{
    //staticを入れる
    //this 拡張したいクラス　…の二点を入れる
    public static string Repeat(this string str, int count)
    {
        var builder = new StringBuilder();
        for (int i = 0; i < count; i++)
        {
            builder.Append(str);
        }
        return builder.ToString();
    }

    public static string Ruijou(this int rui, int count)
    {
        if (count == 0) return 1.ToString();

        var result = 1;
        for (int i = 0; i < count; i++)
        {
            result *= rui;
        }
        return result.ToString();
    }
}
