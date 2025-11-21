using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LS : MonoBehaviour
{
    public string lsName => 0 < lsList.Count ? lsList[0].name : string.Empty;
    List<GameObject> lsList = new List<GameObject>();
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Sweets")
        {
            lsList.Add(collision.gameObject);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (lsList.Contains(collision.gameObject))
        {
            lsList.Remove(collision.gameObject);
        }
    }
}
