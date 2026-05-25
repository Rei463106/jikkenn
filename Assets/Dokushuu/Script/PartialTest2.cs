using System;
using System.Diagnostics;

internal class Partial2
{

}

internal partial class PartialTest
{
    static partial void Log()
    {
        Console.WriteLine("ログを記録しました");
    }
    public string Greet() => $"こんにちは、{LastName}{FirstName}さん！";
}
