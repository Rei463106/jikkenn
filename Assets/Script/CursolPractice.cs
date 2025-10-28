using UnityEngine;

public class CursolPractice : MonoBehaviour
{
    /// <summary>
    /// カーソルを作るための配列
    /// </summary>
    [SerializeField] GameObject[] array;
    /// <summary>
    /// カーソルが今どこの位置にいるか
    /// </summary>
    int currentIndex;

    [SerializeField] AudioClip _audioClip;
    [SerializeField] AudioClip _audioClip2;
    [SerializeField] AudioClip _audioClip3;

    void Start()
    {
        currentIndex = 0;
        array[currentIndex].GetComponent<SpriteRenderer>().color = Color.red;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            DownCursor(currentIndex);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            UpCursor(currentIndex);
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            Effector(currentIndex);
        }
    }

    void DownCursor(int NowIndex)
    {

        if (NowIndex < array.Length - 1)
        {
            NowIndex++;
            array[NowIndex - 1].GetComponent<SpriteRenderer>().color = Color.white;
            array[NowIndex].GetComponent<SpriteRenderer>().color = Color.red;
        }
        else if (NowIndex == array.Length - 1)
        {
            NowIndex = 0;
            array[array.Length - 1].GetComponent<SpriteRenderer>().color = Color.white;
            //ここをAnimationで点滅させるなどすれば、さらにカーソルっぽくなるのでは？
            array[NowIndex].GetComponent<SpriteRenderer>().color = Color.red;
        }
        //更新忘れずに
        currentIndex = NowIndex;
    }

    void UpCursor(int NowIndex)
    {
        if (NowIndex > 0)
        {
            NowIndex--;
            array[NowIndex + 1].GetComponent<SpriteRenderer>().color = Color.white;
            array[NowIndex].GetComponent<SpriteRenderer>().color = Color.red;
        }
        else if (NowIndex == 0)
        {
            NowIndex = array.Length - 1;
            array[0].GetComponent<SpriteRenderer>().color = Color.white;
            //ここをAnimationで点滅させるなどすれば、さらにカーソルっぽくなるのでは？
            array[NowIndex].GetComponent<SpriteRenderer>().color = Color.red;
        }
        currentIndex = NowIndex;
    }

    void Effector(int NowIndex)
    {
        //ここでデリゲート(もしくはUnityEvent)使ったらよさそう
        if (NowIndex == 0) AudioSource.PlayClipAtPoint(_audioClip, this.transform.position);
        if (NowIndex == 1) AudioSource.PlayClipAtPoint(_audioClip2, this.transform.position);
        if (NowIndex == 2) AudioSource.PlayClipAtPoint(_audioClip3, this.transform.position);
    }
}
