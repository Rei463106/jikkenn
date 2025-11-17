using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LS : MonoBehaviour
{
    public string lsName;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Sweets")
        {
            lsName = collision.gameObject.name;
            //Debug.Log(umName);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        lsName = "";
        //Debug.Log(umName);
    }
}
