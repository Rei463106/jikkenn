using UnityEngine;

public class UpCast
{
    public string Aisatu { get; set; } = "こんにちは";

    //public UpCast(string aisatu)
    //{

    //}
}

internal class Cast : UpCast
{
    //public Cast(string aisatu) : base(aisatu)
    //{

    //}
}

internal class TestCast : MonoBehaviour
{
    private UpCast u = new Cast();//アップキャスト、子だけど親のようにふるまえる
    private UpCast u2 = new UpCast() { Aisatu = "こんにちゃ" };
    //var p=new Upcast();
    //p.Aisatu=""; みたいな感じ、
    //オブジェクト初期化子はコンストラクター実行後に値を書き換えるので、Get-Onlyに違反

    private void Start()
    {
        Debug.Log(u2.Aisatu);//ここでならu2はできあがってるので使える…？？
        u2.Aisatu = "こんばんは";//かなり書き換えができちゃう…。

        //Debug.Log(u is UpCast);//uはUpCast型に変換可能か？

        if (u is UpCast)
        {
            Debug.Log("書き換え可");
        }

        var u3 = u as UpCast;//asを使いUpCast型にキャストできる場合それがキャストされて帰ってくる
        if (u3 != null)
        {
            //できない場合はnullが帰ってくる
            Debug.Log("キャスト成功");
        }

        var type = typeof(UpCast);
        
    }
}