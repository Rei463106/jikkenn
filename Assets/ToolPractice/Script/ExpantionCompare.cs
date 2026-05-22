using System;

/// <summary>
/// ユーザー定義型を理解する
/// この時、比較・演算・文字列への変換を定義しておくと後で使いやすい
/// </summary>
public struct ExpantionCompare : IComparable<ExpantionCompare>
{
    /// <summary>アイテムのID </summary>
    public int Id;
    /// <summary>アイテムの名前 </summary>
    public string Name;
    /// <summary>アイテムの値段 </summary>
    public int Price;
    /// <summary>アイテムの攻撃力 </summary>
    public int Attack;
    /// <summary>アイテムの防御力 </summary>
    public int Defence;

    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="id"></param>
    /// <param name="name"></param>
    /// <param name="price"></param>
    /// <param name="attack"></param>
    /// <param name="defence"></param>
    public ExpantionCompare(int id, string name, int price, int attack, int defence)
    {
        this.Id = id;
        this.Name = name;
        this.Price = price;
        this.Attack = attack;
        this.Defence = defence;
    }

    /// <summary>
    /// 比較用
    /// </summary>
    /// <param name="other"></param>
    /// <returns></returns>
    public int CompareTo(ExpantionCompare other)
    {
        if (this.Id < other.Id)
            return -1;
        else if (this.Id > other.Id)
            return 1;
        else
            return 0;
    }

    /// <summary>
    /// 文字列
    /// </summary>
    /// <returns></returns>
    public override string ToString()
    {
        return $"Id:{this.Id},Name:{this.Name},Price:{this.Price},Attack:{this.Attack},Defence{this.Defence}";
    }

    //拡張メソッドの定義
    //public static ExpantionCompare operator +(ExpantionCompare e1, ExpantionCompare e2)
    //{
    //    int maxId=DataLoa
    //}
}
