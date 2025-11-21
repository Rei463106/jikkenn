using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DM : MonoBehaviour
{
    public string dmName => 0 < dmList.Count ? dmList[0].name : string.Empty;
    List<GameObject> dmList = new List<GameObject>();
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Sweets")
        {
            dmList.Add(collision.gameObject);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (dmList.Contains(collision.gameObject))
        {
            dmList.Remove(collision.gameObject);
        }
    }
}
