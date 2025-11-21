using System.Collections.Generic;
using UnityEngine;
public class DL : MonoBehaviour
{
    //もしもこの中に二つ以上入れたければリストを使って管理すること。
    public string dlName => 0 < dlList.Count ? dlList[0].name : string.Empty;
    List<GameObject> dlList = new List<GameObject>();

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Sweets")
        {
           dlList.Add(collision.gameObject);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (dlList.Contains(collision.gameObject))
        {
            dlList.Remove(collision.gameObject);
        }
    }
}
