using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UR : MonoBehaviour
{
    public string urName;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Sweets")
        {
            urName = collision.gameObject.name;
            Debug.Log(urName);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        urName = "";
        //Debug.Log(umName);
    }
}
