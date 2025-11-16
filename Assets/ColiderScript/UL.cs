using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UL : MonoBehaviour
{
    public string ulName;

    private void OnTriggerStay2D(Collider2D collision)
    {
        ulName = collision.gameObject.name;
    }
}
