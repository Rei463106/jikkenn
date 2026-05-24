using System;
using UnityEngine;

public class StructTest : MonoBehaviour
{
    //構造体は継承はできないが、インターフェイスの実装は可能
    private void Start()
    {
        var c = new Coordinates();
        c._latitude = 35.6859392;
        c._longitude = 139.54839305;
        Debug.Log(c);

        var c2 = new Coordinates2(1, 2);
        Debug.Log(c2);
    }
}

internal struct Coordinates
{
    //値に初期値を入れられない
    public double _latitude, _longitude;
    public (int x, int y) _ints;

    //object型を継承しているためToString()のオーバーライドは可能
    public override string ToString()
    {
        return $"緯度:{_latitude},経度:{_longitude}";
    }
}

/// <summary>
/// 読み取り専用
/// </summary>
internal readonly struct Coordinates2
{
    private readonly double _x;//Get-Onlyにしても同じ
    private readonly double _y;

    public Coordinates2(double x, double y)
    {
        _x = x;
        _y = y;
    }

    public override string ToString()
    {
        return $"読み取り専用、{_x},{_y}";
    }
}

internal struct MutableValue
{
    public string Name { get; set; }
    public int[] _array;

    //public MutableValue()
    //{
    //    Name = "ななし";
    //}

    public void Update(string name)
    {
        Name = name;
    }  
}

internal class ReadOnlyNotation
{
    static readonly MutableValue _mv = new MutableValue();//全体にreadonlyをつける
    static void Main(string[] args)
    {
        //_mv.Name = "さとう";//MutableValueが構造体だとエラーになる
        Console.WriteLine(_mv.Name);
        //_mv._array = new int[] { 2, 3, 4 };//MutableValueが構造体だとエラーになる
        //構造体にすると、メンバーにreadonlyが付与される。
        _mv._array[0] = 1;//参照型にreadonlyをつけても要素の変更はできてしまう。こういうのを防ぎたいならIReadOnlyListとかにする

        //メソッドには自動でreadonlyは付かない→呼び出した時、値を複製してこのメソッドを実行することで値をreadonlyにするのを保つ
        //元の値は何も変わらない
        _mv.Update("りおん");
    }
}