using UnityEngine;
using UnityEngine.EventSystems;

[RequireComponent(typeof(Collider2D))]
public class SpawnBase : MonoBehaviour, IDragHandler, IPointerDownHandler, IPointerUpHandler
{
    //スポーンしたアイテムがマウス操作で動くようにする。
    SpriteRenderer _sprite;
    /// <summary>
    /// トリガーに入ってるか判定
    /// </summary>
    bool isT = default;
    int insideCount = 0;
    void Start()
    {
        _sprite = GetComponent<SpriteRenderer>();
    }

    //名前は以下の三つでないとダメ
    public void OnDrag(PointerEventData eventData)
    {
        Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = pos;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        //今回は使わないが、ピックアップ表示とかに使えそう
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        //もし範囲外で手を離したらそれをDestroyする
        if (isT) this.gameObject.SetActive(false);
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        //入っていなければ…の条件で
        if (collision.CompareTag("Floor") || collision.CompareTag("Cake"))
            insideCount++;
        //Debug.Log(collision.name);
        isT = insideCount == 0;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Floor") || collision.CompareTag("Cake"))
            insideCount--;

        isT = insideCount == 0;
    }
}
