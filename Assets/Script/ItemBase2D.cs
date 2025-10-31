using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public abstract class ItemBase2D : MonoBehaviour
{
    CursorPractice2 _cursorPractice2;
    public abstract void Activate();

    private void Start()
    {
        _cursorPractice2 = FindAnyObjectByType<CursorPractice2>();
    }

    public void PushButton()
    {
        _cursorPractice2.GetItem(this);
    }
}
