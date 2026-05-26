using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttrBasic : MonoBehaviour
{
    private string _firstName;
    private string _lastName;

    private void Start()
    {
        Debug.Log(Show());
    }

    //旧形式であることを伝えられる
    [Obsolete("代替としてToStringメソッドを利用してください。")]
    private string Show()
    {
        return $"{_firstName}{_lastName}です";
    }
}
