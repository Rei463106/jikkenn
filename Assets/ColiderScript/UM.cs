using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UM : MonoBehaviour
{
    public string umName;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Sweets")
        {
            umName = collision.gameObject.name;
            //Debug.Log(umName);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        umName = "";
        //Debug.Log(umName);
    }
}
