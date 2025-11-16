using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RS : MonoBehaviour
{
    public string rsName;

    private void OnTriggerStay2D(Collider2D collision)
    {
        rsName = collision.gameObject.name;
    }
}
