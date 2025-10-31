using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CursorPractice2 : MonoBehaviour
{
    /// <summary>
    /// カーソルを作るための配列
    /// </summary>
    [SerializeField] GameObject[] array;
    /// <summary>
    /// カーソルが今どこの位置にいるか
    /// </summary>
    int currentIndex;
    /// <summary>
    /// 取ったアイテムを入れておくためのList
    /// </summary>
    public List<(ItemBase2D itemName, int itemNumber)> _itemList = new List<(ItemBase2D itemName, int itemNumber)>();
    /// <summary>
    /// アイテム名を表示するための配列
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

                // 使う処理を先に実行（アイテムの効果）
                data.itemName.Activate();

                // アイテムの個数を1減らす
                //dataの方だけ変えても何も起きない！！(コピー作る→その値を変更→丸ごと置き換え)
                int newCount = data.itemNumber - 1;

                if (newCount <= 0)
                {
                    // 残り0ならリストから削除
                    _itemList.RemoveAt(currentIndex);
                }
                else
                {
                    // まだ残っているなら更新
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

    /// <summary>
    /// アイテムをアイテムリストに追加する
    /// </summary>
    /// <param name="item"></param>
    public void GetItem(ItemBase2D item)
    {
        int index = _itemList.FindIndex(x => x.itemName == item);

        //見つかった時の処理(ない時は-1が返される)
        if (index >= 0)
        {
            _itemList[index] = (item, _itemList[index].itemNumber + 1);
        }
        //見つからなかった時の処理
        else
        {
            _itemList.Add((item, 1));
        }
        UpdateUI();
    }

    private void UpdateUI()
    {
        //一旦空にする
        for (int i = 0; i < texts.Length; i++)
        {
            texts[i].text = "";
        }
        //現在のリストを反映する
        //Listは項目を消したり追加できるため、アイテム処理には便利
        for (int i = 0; i < _itemList.Count && i < texts.Length; i++)
        {
            texts[i].text = $"{_itemList[i].itemName.gameObject.name}×{_itemList[i].itemNumber}";
        }
    }
}


