using System;
using UnityEngine;

public class GenericTest : MonoBehaviour
{
    private void Start()
    {
        //例1
        var gc = new GenericClass<int>();
        Debug.Log(gc.ReturnValue());
        Debug.Log(new GenericClass<string>().ReturnValue());

        //例2
        var mg = new MyGenerics<string>();//stringはIComparableを実装しているので使える
        Debug.Log(mg.Hoge("A", "G"));
    }
}

internal class GenericClass<T>//<T>は必須
{
    T _value = default(T);

    public T ReturnValue()
    {
        return _value;
    }
}

internal class MyGenerics<T> where T : IComparable<T>
{
    public int Hoge(T x, T y)
    {
        return x.CompareTo(y);
    }//T型の変数x,yが必ずしもCompareToメソッドを持っているとは限らない！なので… where T : IComparable<T> という制約をつける。
}

internal class MyGenerics2<T1, T2> where T1 : T2 { }//T1がT2と同じ型、またはT1がT2を継承している時　という制約
internal class VoidClass<T> where T : new() { }//コンストラクターの引数がないものしかインスタンス化できない


