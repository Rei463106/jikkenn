using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageChange : MonoBehaviour
{
    [Header("Persentage")]
    [SerializeField] private Persentage _persantage;
    [Header("ImageList")]
    [SerializeField] private List<Image> _images = new List<Image>();

    private void Start()
    {
        _images[_persantage.indexNumber].enabled = true;
    }
}
