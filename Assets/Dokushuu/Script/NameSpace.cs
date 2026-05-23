//using SelfCSharp.Chap09.Other;
using System.Globalization;
using UnityEngine;
using Cs = SelfCSharp.Chap09.Other;//こう指定することで、同じクラス名を有していても使用可能に

public class NameSpace : MonoBehaviour
{
    //上のusingだと、System.GlobalizationのCultureInfoクラスかSelfCSharp.Chap09.OtherのCultureInfoクラスかあいまい
    //private CultureInfo _cultureInfo = new SelfCSharp.Chap09.Other.CultureInfo();

    private Cs.CultureInfo _culture = new Cs.CultureInfo();
    private CultureInfo _culture2 = new CultureInfo(3);
}

//名前空間
namespace SelfCSharp.Chap09.Other
{
    internal class CultureInfo
    {

    }
}

