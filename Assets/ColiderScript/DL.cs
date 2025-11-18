using UnityEngine;

public class DL : MonoBehaviour
{
    //もしもこの中に二つ以上入れたければリストを使って管理すること。
    public string dlName;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Sweets")
        {
            dlName = collision.gameObject.name;
            //Debug.Log(dlName);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        dlName = "";
        //Debug.Log(dlName);
    }
}
