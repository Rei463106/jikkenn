using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TSceneChange : MonoBehaviour
{
    public void SceneMoved(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
