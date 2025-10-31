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
    public List<(ItemBase2D itemName, int itemNumber)> itemList = new List<(ItemBase2D itemName, int itemNumber)>();
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
            if (itemList.Count > 0)
            {
                var data = itemList[currentIndex];

                // �g���������Ɏ��s�i�A�C�e���̌��ʁj
                data.itemName.Activate();

                // �A�C�e���̌���1���炷
                //data�̕������ς��Ă������N���Ȃ��I�I
                int newCount = data.itemNumber - 1;

                if (newCount <= 0)
                {
                    // �c��0�Ȃ烊�X�g����폜
                    itemList.RemoveAt(currentIndex);
                }
                else
                {
                    // �܂��c���Ă���Ȃ�X�V
                    itemList[currentIndex] = (data.itemName, newCount);
                }

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
        int index = itemList.FindIndex(x => x.itemName == item);

        //�����������̏���(�Ȃ�����-1���Ԃ����)
        if (index >= 0)
        {
            itemList[index] = (item, itemList[index].itemNumber + 1);
        }
        //������Ȃ��������̏���
        else
        {
            itemList.Add((item, 1));
        }
    }


}


