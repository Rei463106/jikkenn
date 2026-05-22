using UnityEngine;

//paizaの問題で使えそうなやつ
public class PatternMatching : MonoBehaviour
{
    private object i = 456;
    private Name _name = new Name() { FirstName = "山田", LastName = "太郎" };//オブジェクト初期化子を使ってる

    private void Start()
    {
        Debug.Log(_name switch
        {
            { FirstName: "山田", LastName: var n } => $"{n}さん、こんにちは",
            _ => "何もないです"
        }
        );
    }

    private void Update()
    {
        Debug.Log(i switch
        {
            123 => "123です",
            int j => "整数です",//「int型なら成功」
            _ => "意図しない値です"//破棄パターン
        });

        Debug.Log(i switch
        {
            123 => "123",
            var r => $"{r}です"
        }
        );
    }
}

internal class Name
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
}
