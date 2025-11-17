using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CCake : MonoBehaviour, IPointerDownHandler
{
    /// <summary>
    /// êFÇÃïœâªèW
    /// </summary>
    [SerializeField] Color[] colors;
    public int colorsIndex;
    SpriteRenderer spriteRenderer;
    ButtonManager _buttonManager;
    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        _buttonManager = GameObject.FindAnyObjectByType<ButtonManager>();
        spriteRenderer.color = colors[colorsIndex % 3];
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (_buttonManager.isButton)
        {
            spriteRenderer.color = colors[colorsIndex % 3];
            colorsIndex++;
        }
    }
}
