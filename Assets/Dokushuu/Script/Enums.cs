
using System;

/// <summary>
/// 季節を表すenum
/// </summary>
internal enum Season
{
    Spring,
    Summer,
    Autumn,
    Winter
}

[Flags]
internal enum FontStyle
{
    Bold = 1,
    Italic = 2,
    UnderLine = 4,
    All = (Bold | Italic | UnderLine),//全てのメンバーを有効にした時の値
}//ビットフィールドを使用する時…列挙値に2の累乗を設定・Flag属性を付与