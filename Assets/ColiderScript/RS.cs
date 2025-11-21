using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RS : MonoBehaviour
{
    public string rsName => 0 < rsList.Count ? rsList[0].name : string.Empty;
    List<GameObject> rsList = new List<GameObject>();
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Sweets")
        {
            rsList.Add(collision.gameObject);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (rsList.Contains(collision.gameObject))
        {
            rsList.Remove(collision.gameObject);
        }
    }
}
