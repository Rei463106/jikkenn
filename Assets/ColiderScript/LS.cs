using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LS : MonoBehaviour
{
    public string lsName;

    private void OnTriggerStay2D(Collider2D collision)
    {
        lsName = collision.gameObject.name;
    }
}
