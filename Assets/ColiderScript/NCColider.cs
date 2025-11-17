using System.Collections.Generic;
using UnityEngine;

public class NCColider : MonoBehaviour
{
    //‰½‚ª“ü‚Á‚Ä‚¢‚é‚©‚ÌŽæ“¾
    public List<GameObject> list = new List<GameObject>();

    private void OnTriggerEnter2D(Collider2D collision)
    { 
        if (collision.CompareTag("Sweets"))
        {
            // ‚·‚Å‚É“ü‚Á‚Ä‚¢‚È‚¢Žž‚¾‚¯’Ç‰Á
            if (!list.Contains(collision.gameObject))
            {
                list.Add(collision.gameObject);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Sweets"))
        {
            list.Remove(collision.gameObject);
        }
    }
}
