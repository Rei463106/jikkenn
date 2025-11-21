using UnityEngine;
using UnityEngine.UI;

public class ResultText : MonoBehaviour
{
    [SerializeField] Text _resultText;
    private void Start()
    {
        int finalScore = ButtonManager.score;
        _resultText.text = finalScore.ToString();
        ButtonManager.score = 0;
    }
}
