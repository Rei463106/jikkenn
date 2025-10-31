using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CursorPractice2 : MonoBehaviour
{
    /// <summary>
    /// �J�[�\������邽�߂̔z��
    /// </summary>
    [SerializeField] GameObject[] array;
    /// <summary>
    /// �J�[�\�������ǂ��̈ʒu�ɂ��邩
    /// </summary>
    int currentIndex;
    /// <summary>
    /// ������A�C�e�������Ă������߂�List
    /// </summary>
    public List<(ItemBase2D itemName, int itemNumber)> _itemList = new List<(ItemBase2D itemName, int itemNumber)>();
    /// <summary>
    /// �A�C�e������\�����邽�߂̔z��
    /// </summary>
    [SerializeField] Text[] texts;

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
            if (_itemList.Count > 0)
            {
                var data = _itemList[currentIndex];

                // �g���������Ɏ��s�i�A�C�e���̌��ʁj
                data.itemName.Activate();

                // �A�C�e���̌���1���炷
                //data�̕������ς��Ă������N���Ȃ��I�I(�R�s�[��遨���̒l��ύX���ۂ��ƒu������)
                int newCount = data.itemNumber - 1;

                if (newCount <= 0)
                {
                    // �c��0�Ȃ烊�X�g����폜
                    _itemList.RemoveAt(currentIndex);
                }
                else
                {
                    // �܂��c���Ă���Ȃ�X�V
                    _itemList[currentIndex] = (data.itemName, newCount);
                }
                UpdateUI();
            }
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

    /// <summary>
    /// �A�C�e�����A�C�e�����X�g�ɒǉ�����
    /// </summary>
    /// <param name="item"></param>
    public void GetItem(ItemBase2D item)
    {
        int index = _itemList.FindIndex(x => x.itemName == item);

        //�����������̏���(�Ȃ�����-1���Ԃ����)
        if (index >= 0)
        {
            _itemList[index] = (item, _itemList[index].itemNumber + 1);
        }
        //������Ȃ��������̏���
        else
        {
            _itemList.Add((item, 1));
        }
        UpdateUI();
    }

    private void UpdateUI()
    {
        //��U��ɂ���
        for (int i = 0; i < texts.Length; i++)
        {
            texts[i].text = "";
        }
        //���݂̃��X�g�𔽉f����
        //List�͍��ڂ���������ǉ��ł��邽�߁A�A�C�e�������ɂ͕֗�
        for (int i = 0; i < _itemList.Count && i < texts.Length; i++)
        {
            texts[i].text = $"{_itemList[i].itemName.gameObject.name}�~{_itemList[i].itemNumber}";
        }
    }
}


