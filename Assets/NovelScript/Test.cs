using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour
{
    [Header("Text•\Ž¦—p")]
    [SerializeField] Text _text;

    private string[] lines;
    private int index = 0;

    void Start()
    {
        TextAsset textAsset = Resources.Load<TextAsset>("TestText");
        //ˆês‚¸‚Â‹æØ‚é
        lines = textAsset.text.Split('\n');

        ShowLine();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            ShowLine();
        }
    }

    private void ShowLine()
    {
        if (index >= lines.Length) return;

        string line = lines[index].Trim();
        _text.text = line;

        index++;
    }
}
