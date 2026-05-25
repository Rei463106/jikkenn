using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyPertialClient : MonoBehaviour
{
    private void Start()
    {
        var mc = new PartialTest { FirstName = "たろう", LastName = "やまだ" };
        Debug.Log(mc.Show());
        Debug.Log(mc.Greet());
    }
}
