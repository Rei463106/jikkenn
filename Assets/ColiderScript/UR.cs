using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UR : MonoBehaviour
{
    public string urName;

    private void OnTriggerStay2D(Collider2D collision)
    {
        urName = collision.gameObject.name;
    }
}
