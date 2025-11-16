using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DR : MonoBehaviour
{
    public string drName;

    private void OnTriggerStay2D(Collider2D collision)
    {
        drName = collision.gameObject.name;
    }
}
