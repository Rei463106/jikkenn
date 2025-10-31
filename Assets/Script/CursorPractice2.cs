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
    public List<(ItemBase2D itemName, int itemNumber)> itemList = new List<(ItemBase2D itemName, int itemNumber)>();
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
            if (itemList.Count > 0)
            {
                var data = itemList[currentIndex];

                // 使う処理を先に実行（アイテムの効果）
                data.itemName.Activate();

                // アイテムの個数を1減らす
                //dataの方だけ変えても何も起きない！！
                int newCount = data.itemNumber - 1;

                if (newCount <= 0)
                {
                    // 残り0ならリストから削除
                    itemList.RemoveAt(currentIndex);
                }
                else
                {
                    // まだ残っているなら更新
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
        int index = itemList.FindIndex(x => x.itemName == item);

        //見つかった時の処理(ない時は-1が返される)
        if (index >= 0)
        {
            itemList[index] = (item, itemList[index].itemNumber + 1);
        }
        //見つからなかった時の処理
        else
        {
            itemList.Add((item, 1));
        }
    }


}


