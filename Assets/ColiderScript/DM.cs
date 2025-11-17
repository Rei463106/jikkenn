using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DM : MonoBehaviour
{
    public string dmName;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Sweets")
        {
            dmName = collision.gameObject.name;
            //Debug.Log(umName);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        dmName = "";
        //Debug.Log(umName);
    }
}
