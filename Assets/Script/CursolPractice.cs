using UnityEngine;

public class CursolPractice : MonoBehaviour
{
    /// <summary>
    /// �J�[�\������邽�߂̔z��
    /// </summary>
    [SerializeField] GameObject[] array;
    /// <summary>
    /// �J�[�\�������ǂ��̈ʒu�ɂ��邩
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
            //������Animation�œ_�ł�����Ȃǂ���΁A����ɃJ�[�\�����ۂ��Ȃ�̂ł́H
            array[NowIndex].GetComponent<SpriteRenderer>().color = Color.red;
        }
        //�X�V�Y�ꂸ��
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
            //������Animation�œ_�ł�����Ȃǂ���΁A����ɃJ�[�\�����ۂ��Ȃ�̂ł́H
            array[NowIndex].GetComponent<SpriteRenderer>().color = Color.red;
        }
        currentIndex = NowIndex;
    }

    void Effector(int NowIndex)
    {
        //�����Ńf���Q�[�g(��������UnityEvent)�g������悳����
        if (NowIndex == 0) AudioSource.PlayClipAtPoint(_audioClip, this.transform.position);
        if (NowIndex == 1) AudioSource.PlayClipAtPoint(_audioClip2, this.transform.position);
        if (NowIndex == 2) AudioSource.PlayClipAtPoint(_audioClip3, this.transform.position);
    }
}
