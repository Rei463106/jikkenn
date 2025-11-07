using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Buttonが押された時に実行される処理
/// </summary>
public class ButtonManager : MonoBehaviour
{
    /// <summary>
    /// Instanciateさせるプレハブ
    /// </summary>
    [SerializeField] GameObject m_objectPrefab = null;
    /// <summary>
    /// スポーンしてほしい座標
    /// </summary>
    [SerializeField] Transform m_spawnPoint = null;
    /// <summary>
    /// 今画面内にあるオブジェクト
    /// </summary>
    GameObject NowObject;
    /// <summary>
    /// 真ん中まで来た時の座標
    /// </summary>
    [SerializeField] Vector2 m_finishPoint = default;
    /// <summary>
    /// 画面中央、端に移動するまでの時間
    /// </summary>
    [SerializeField] int stopTime = default;
    /// <summary>
    /// Destroyする時の座標
    /// </summary>
    [SerializeField] Vector2 m_destroyPoint = default;
    /// <summary>
    /// ボタンを連続で押せなくするための変数
    /// </summary>
    bool isButton = false;
    int count = 1;

    /// <summary>
    /// 点数加算用
    /// </summary>
    Text _scoreText;
    int score = 0;

    /// <summary>
    /// 時間管理用
    /// </summary>
    float gameTime = default;
    [SerializeField] float limitTime = default;
    [SerializeField] Text timerText;

    void Start()
    {
        NowObject = Instantiate(m_objectPrefab, m_spawnPoint.position, Quaternion.identity);
        NowObject.transform.DOMove(m_finishPoint, stopTime).OnComplete(() => isButton = true);
        count++;
    }

    void Update()
    {
        gameTime += Time.deltaTime;
        float nowTime = limitTime - gameTime;
        timerText.text = $"{nowTime.ToString("000")}";
        if (!isButton) return;
    }

    public void ObjectMove()//オブジェクトを動かす、IsButtonがtrueの時実行
    {
        if (count >= 2 && isButton)
        {
            isButton = false;
            GameObject lastObject = NowObject;
            //全部終わるまで待つ
            lastObject.transform.DOMove(m_destroyPoint, stopTime)
                .OnComplete(() => Destroy(lastObject));
            NowObject = Instantiate(m_objectPrefab, m_spawnPoint.position, Quaternion.identity);
            NowObject.transform.DOMove(m_finishPoint, stopTime).OnComplete(() => isButton = true);
        }
    }

    public void AddCount(bool correct)//正解だったらカウントを1足す
    {
        if (correct)
        {
            score++;
            _scoreText.text = $"{score}点";
        }
    }
    public void Anim(bool correct)
    {
        //正解したか否かでアニメーションを変える
        if (correct)
        {

        }
        else
        {

        }
    }

    public void newObject()
    {
        //合ってても間違ってても、NowObjectにObjectListのどれかを代入する
        //合っているか間違ってるかの実際の判定はケーキ側で行い、その結果をcorrectに渡す
    }
}
