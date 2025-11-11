using UnityEngine;
using UnityEngine.InputSystem;

public class InputSys : MonoBehaviour
{
    void Start()
    {

    }


    void Update()
    {
        //現在のキーボード情報
        var current = Keyboard.current;
        //キーボード接続チェック
        if (current == null) return;

        //aキーが押されているかどうかの取得
        var aKey = current.aKey;
        //aキーが押された瞬間かどうか
        if (aKey.wasPressedThisFrame) Debug.Log("aキーが押された");
        //aキーを離した瞬間かどうか
        if (aKey.wasReleasedThisFrame) Debug.Log("aキーを離した");
        //aキーが押されているかどうか
        if (aKey.isPressed) Debug.Log("aキーが押されている");


        //現在のマウスの情報
        var current2 = Mouse.current;
        if (current2 == null) return;
        //マウスカーソルの位置取得
        var cursorPosition = current2.position.ReadValue();
        Debug.Log(cursorPosition);
        //左ボタンの入力取得
        var leftButton = current2.leftButton;
        //左ボタンが押されているか否かはキーの時と同じ
    }
}
