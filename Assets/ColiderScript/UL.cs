using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UL : MonoBehaviour
{
    public string ulName => 0 < ulList.Count ? ulList[0].name : string.Empty;
    List<GameObject> ulList = new List<GameObject>();
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Sweets")
        {
            ulList.Add(collision.gameObject);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (ulList.Contains(collision.gameObject))
        {
            ulList.Remove(collision.gameObject);
        }
    }
}
