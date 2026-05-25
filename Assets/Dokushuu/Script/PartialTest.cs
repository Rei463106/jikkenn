internal partial class PartialTest
{
    public string FirstName { get; set; } = "";
    public string LastName { get; set; } = "";

    static partial void Log();//パーシャルメソッド、まずこっちで本体を宣言(戻り値はvoid以外無理)
    //ただし、アクセス修飾子を明示的につけることにより戻り値の型を自由に定義、outの利用も可能に(後付けで自動生成コードを定義する場合)

    static void Main(string[] args)
    {
        Log();
    }

    public string Show()
    {
        return $"名前は{FirstName}{LastName}です。";
    }
}
