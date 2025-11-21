using UnityEngine;

public class UM : MonoBehaviour
{
    public string umName;

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Sweets")
        {
            umName = collision.gameObject.name;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        umName = "";
    }


}
