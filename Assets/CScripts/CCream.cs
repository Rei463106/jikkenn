using UnityEngine;
using UnityEngine.EventSystems;

public class CCream : MonoBehaviour,IPointerDownHandler
{
    /// <summary>
    /// êFÇÃïœâªèW
    /// </summary>
    [SerializeField] Color[] colors;
    int colorsIndex;
    SpriteRenderer spriteRenderer;
    ButtonManager _buttonManager;
    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        _buttonManager = GameObject.FindAnyObjectByType<ButtonManager>();
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
