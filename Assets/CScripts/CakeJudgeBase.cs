using UnityEngine;
using UnityEngine.EventSystems;

public class CakeJudgeBase : MonoBehaviour, IPointerDownHandler
{
    //これの派生をケーキにくっつける。
    /// <summary>
    /// クリームのゲームオブジェクト
    /// </summary>
    [SerializeField] GameObject CCream;
    /// <summary>
    /// 色の変化集
    /// </summary>
    Color[] colors;
    int colorsIndex;
    /// <summary>
    /// 判定が合っているか
    /// </summary>
    public bool judgement;

    public void OnPointerDown(PointerEventData eventData)
    {
        var a = CCream.GetComponent<SpriteRenderer>().color;
        a = colors[colorsIndex % 3];
        colorsIndex++;
    }
}
