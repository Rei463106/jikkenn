using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class CreamDrag : MonoBehaviour, IDragHandler, IPointerClickHandler, IPointerDownHandler, IBeginDragHandler
{

    //ホイップの操作
    SpriteRenderer _sprite;
    /// <summary>
    /// ホイップを絞るためのメソッドを登録する（今回は実験程度）
    /// </summary>
    public Action Squeeze;
    /// <summary>
    /// ドラッグ中は反応しないようにする
    /// </summary>
    bool isDrag;

    CreamInstanciate _creamInstanciate;
    void Start()
    {
        _sprite = GetComponent<SpriteRenderer>();
        _creamInstanciate=GameObject.FindAnyObjectByType<CreamInstanciate>();
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        isDrag = true; // ドラッグ開始
    }
    public void OnDrag(PointerEventData eventData)
    {
        Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = pos;
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        isDrag = false;
    }
    public void OnPointerClick(PointerEventData pointerEventData)
    {
        if (isDrag) return;
        _creamInstanciate.isSqueeze();
    }
   
}
