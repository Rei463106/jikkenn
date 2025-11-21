using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UR : MonoBehaviour
{
    public string urName => 0 < urList.Count ? urList[0].name : string.Empty;
    List<GameObject> urList = new List<GameObject>();
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Sweets")
        {
            urList.Add(collision.gameObject);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (urList.Contains(collision.gameObject))
        {
            urList.Remove(collision.gameObject);
        }
    }
}
