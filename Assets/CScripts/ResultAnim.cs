using UnityEngine;
using UnityEngine.Events;

public class ResultAnim : MonoBehaviour
{
    [SerializeField] UnityEvent _finishAnim;
    [SerializeField] ButtonManager _buttonManager;
    
    public void ResultAnimation()
    {
      _finishAnim.Invoke();
    }
   

}
