using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DM : MonoBehaviour
{
    public string dmName;

    private void OnTriggerStay2D(Collider2D collision)
    {
        dmName = collision.gameObject.name;
    }
}
