using UnityEngine;
using static SelfCSharp.Chap09.Nested.MyClass;

namespace SelfCSharp.Chap09.Nested
{
    public class NestedBasic : MonoBehaviour
    {
        private void Start()
        {
            var c = new MyClass();
            c.Run();
            //var h = new MyClass.MyHelper(); エラーになる…MyHelperがprivateの時
            var h = new MyHelper();//using static SelfCSharp.Chap09.Nested.MyClass;をつけるとこれだけでも呼び出し可能に
        }
    }

    internal class MyClass
    {
        internal class MyHelper//既定はprivate設定になっており、このままでは呼び出しできない
        {
            public void Show()
            {
                Debug.Log("Nested Class is runnning!!");
            }
        }

        public void Run()
        {
            var helper = new MyHelper();
            helper.Show();
        }
    }

}
