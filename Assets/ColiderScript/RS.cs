using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RS : MonoBehaviour
{
    public string rsName;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Sweets")
        {
            rsName = collision.gameObject.name;
            //Debug.Log(umName);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        rsName = "";
        //Debug.Log(umName);
    }
}
