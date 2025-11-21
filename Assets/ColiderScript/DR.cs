using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DR : MonoBehaviour
{
    public string drName => 0 < drList.Count ? drList[0].name : string.Empty;
    List<GameObject> drList = new List<GameObject>();
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Sweets")
        {
            drList.Add(collision.gameObject);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (drList.Contains(collision.gameObject))
        {
            drList.Remove(collision.gameObject);
        }
    }
}
