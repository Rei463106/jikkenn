using System.Text;
using UnityEngine;

/// <summary>
/// 拡張メソッド
/// </summary>
public class ExtentionSystem : MonoBehaviour
{
    //今回はSystem.Stringクラスに機能を追加する
    private string t = "ありがとう";

    private void Start()
    {
        Debug.Log(t.Repeat(3));
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
}
