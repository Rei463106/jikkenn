using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Collider2D))]
public class SpawnBase : MonoBehaviour, IDragHandler, IPointerDownHandler, IPointerUpHandler
{
    //スポーンしたアイテムがマウス操作で動くようにする。
    /// <summary>
    /// スポナーの場所指定用
    /// </summary>
    [SerializeField] Vector2 m_spawner;
    /// <summary>
    /// 
    /// </summary>

    void Start()
    {

    }

    void Update()
    {
        var current = Mouse.current;
        if (current != null)
        {

        }
        else return;
    }

    //名前は以下の三つでないとダメ
    public void OnDrag(PointerEventData eventData)
    {

    }

    public void OnPointerDown(PointerEventData eventData)
    {

    }

    public void OnPointerUp(PointerEventData eventData)
    {

    }


}
