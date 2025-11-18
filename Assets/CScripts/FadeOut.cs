using UnityEngine;
using UnityEngine.Events;

public class FadeOut : MonoBehaviour
{
    public UnityEvent _fadeAnim;
  

    public void Fading()
    {
        _fadeAnim.Invoke();
    }
}
