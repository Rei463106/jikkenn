using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMove : MonoBehaviour
{
    [SerializeField] FadeOut _fadeOut;
    //シーン移動用
    public void SceneMoving(string scene)
    {
        SceneManager.LoadScene(scene);
    }

    public void ResultAnimationAfter()
    {
        _fadeOut.Fading();
    }
}
