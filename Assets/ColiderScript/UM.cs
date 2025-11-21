using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UM : MonoBehaviour
{
    public string umName => 0 < umList.Count ? umList[0].name : string.Empty;
    List<GameObject> umList = new List<GameObject>();
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Sweets")
        {
            umList.Add(collision.gameObject);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (umList.Contains(collision.gameObject))
        {
            umList.Remove(collision.gameObject);
        }
    }
}
