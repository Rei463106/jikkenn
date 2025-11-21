using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DR : MonoBehaviour
{
    public string drName;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Sweets")
        {
            drName = collision.gameObject.name;
        
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        drName = "";
  
    }
}
