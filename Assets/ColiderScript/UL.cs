using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UL : MonoBehaviour
{
    public string ulName;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Sweets")
        {
            ulName = collision.gameObject.name;
            //Debug.Log(umName);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        ulName = "";
        //Debug.Log(umName);
    }
}
