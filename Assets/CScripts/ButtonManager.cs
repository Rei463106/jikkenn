using DG.Tweening;
using UnityEngine;
using UnityEngine.Events;
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
    public bool isButton = false;
    int count = 1;

    /// <summary>
    /// 点数加算用
    /// </summary>
    [SerializeField] Text _scoreText;
    static int score = 0;

    /// <summary>
    /// 時間管理用
    /// </summary>
    float gameTime = default;
    [SerializeField] float limitTime = default;
    [SerializeField] Text timerText;
    //現在の時間
    public float nowTime = default;
    //取り置きしておく時間
    float timerTime = default;

    //変数用
    CakeJudgeBase _cakeJudgeBaseResult;
    CakeJudgeBase _cakeJudgeBase;
    ListBox _listBox;
    ShortCake _shortCake;
    ResultAnim _resultAnim;

    [SerializeField] UnityEvent _resultCorrectEvent;
    [SerializeField] UnityEvent _resultIncorrectEvent;
    void Start()
    {
        //代入
        _listBox = GameObject.FindAnyObjectByType<ListBox>();
        _cakeJudgeBase = GameObject.FindAnyObjectByType<CakeJudgeBase>();
        _shortCake = GameObject.FindAnyObjectByType<ShortCake>();
        _resultAnim = GameObject.FindAnyObjectByType<ResultAnim>();

        ObjectMoveStart();
    }

    void Update()
    {

        if (isButton)
        {
            gameTime += Time.deltaTime;
            nowTime = limitTime - gameTime;
            timerText.text = $"{nowTime.ToString("000")}";
        }
        else
        {
            timerTime = nowTime;
            timerText.text = $"{timerTime.ToString("000")}";
            return;
        }

        //0以下になったらリザルト画面に進む
        if (nowTime <= 0)
        {
            _resultAnim.ResultAnimation();
            timerText.text = ("000");
        }
    }

    void ObjectMoveStart()
    {
        NowObject = Instantiate(m_objectPrefab, m_spawnPoint.position, Quaternion.identity);
        newCakeSelect();
        NowObject.transform.DOMove(m_finishPoint, stopTime).OnComplete(() => isButton = true);
        count++;
    }

    void ObjectMove()//オブジェクトを動かす、IsButtonがtrueの時実行
    {
        if (count >= 2 && isButton)
        {
            isButton = false;

            GameObject lastObject = NowObject;
            lastObject.transform.DOMove(m_destroyPoint, stopTime)
                .OnComplete(() => Destroy(lastObject));

            NowObject = Instantiate(m_objectPrefab, m_spawnPoint.position, Quaternion.identity);
            newCakeSelect();
            NowObject.transform.DOMove(m_finishPoint, stopTime)
                .OnComplete(() => isButton = true);
        }
    }

    void AddCount(bool correct)//正解だったらカウントを1足す
    {
        if (correct)
        {
            score++;
            _scoreText.text = $"{score}点";
        }
    }
    void Anim(bool correct)
    {
        //正解したか否かでアニメーションを変える
        //このアニメーションの終わりにケーキが動くようにObjectMoveを呼び出す。
        if (correct)
        {
            _resultCorrectEvent.Invoke();
        }
        else
        {
            _resultIncorrectEvent.Invoke();
        }
        foreach (var item in NowObject.GetComponentInChildren<NCColider>().list)
        {
            if (item != null)
            {
                item.transform.SetParent(NowObject.transform, true);
            }
        }
        Invoke("ObjectMove", 1);
    }



    public void FinalJudge()
    {
        bool finalJudge = _cakeJudgeBaseResult.JudgeObject();
        Anim(finalJudge);
        AddCount(finalJudge);
    }

    void newCakeSelect()
    {
        //リストから何を取り出したのかを入れておく
        //乱数になるように調整
        _cakeJudgeBaseResult = _listBox._cakeJudgeBaseArray[Random.Range(0, 6)];
        _cakeJudgeBaseResult.States();
        Debug.Log(_cakeJudgeBaseResult);
        if (_cakeJudgeBaseResult is ShortCake sc)
        {
            sc.SSetting(NowObject.GetComponentInChildren<DL>(), NowObject.GetComponentInChildren<DM>(), NowObject.GetComponentInChildren<DR>(),
                     NowObject.GetComponentInChildren<LS>(), NowObject.GetComponentInChildren<RS>(), NowObject.GetComponentInChildren<UL>(),
                     NowObject.GetComponentInChildren<UM>(), NowObject.GetComponentInChildren<UR>(), NowObject.GetComponentInChildren<CCake>()
                     , NowObject.GetComponentInChildren<CCream>());
        }
        else if (_cakeJudgeBaseResult is ChocoCake cc)
        {
            cc.CSetting(NowObject.GetComponentInChildren<DL>(), NowObject.GetComponentInChildren<DM>(), NowObject.GetComponentInChildren<DR>(),
                    NowObject.GetComponentInChildren<LS>(), NowObject.GetComponentInChildren<RS>(), NowObject.GetComponentInChildren<UL>(),
                    NowObject.GetComponentInChildren<UM>(), NowObject.GetComponentInChildren<UR>(), NowObject.GetComponentInChildren<CCake>()
                     , NowObject.GetComponentInChildren<CCream>());
        }
        else if (_cakeJudgeBaseResult is ShorCake2 sh)
        {
            sh.S2Setting(NowObject.GetComponentInChildren<DL>(), NowObject.GetComponentInChildren<DM>(), NowObject.GetComponentInChildren<DR>(),
                    NowObject.GetComponentInChildren<LS>(), NowObject.GetComponentInChildren<RS>(), NowObject.GetComponentInChildren<UL>(),
                    NowObject.GetComponentInChildren<UM>(), NowObject.GetComponentInChildren<UR>(), NowObject.GetComponentInChildren<CCake>()
                     , NowObject.GetComponentInChildren<CCream>());
        }
        else if (_cakeJudgeBaseResult is ChocoCake2 ch)
        {
            ch.C2Setting(NowObject.GetComponentInChildren<DL>(), NowObject.GetComponentInChildren<DM>(), NowObject.GetComponentInChildren<DR>(),
                    NowObject.GetComponentInChildren<LS>(), NowObject.GetComponentInChildren<RS>(), NowObject.GetComponentInChildren<UL>(),
                    NowObject.GetComponentInChildren<UM>(), NowObject.GetComponentInChildren<UR>(), NowObject.GetComponentInChildren<CCake>()
                     , NowObject.GetComponentInChildren<CCream>());
        }
        else if (_cakeJudgeBaseResult is PampkinCake pm)
        {
            pm.PSetting(NowObject.GetComponentInChildren<DL>(), NowObject.GetComponentInChildren<DM>(), NowObject.GetComponentInChildren<DR>(),
                    NowObject.GetComponentInChildren<LS>(), NowObject.GetComponentInChildren<RS>(), NowObject.GetComponentInChildren<UL>(),
                    NowObject.GetComponentInChildren<UM>(), NowObject.GetComponentInChildren<UR>(), NowObject.GetComponentInChildren<CCake>()
                     , NowObject.GetComponentInChildren<CCream>());
        }
        else if (_cakeJudgeBaseResult is PampkinCake2 pm2)
        {

            pm2.P2Setting(NowObject.GetComponentInChildren<DL>(), NowObject.GetComponentInChildren<DM>(), NowObject.GetComponentInChildren<DR>(),
                    NowObject.GetComponentInChildren<LS>(), NowObject.GetComponentInChildren<RS>(), NowObject.GetComponentInChildren<UL>(),
                    NowObject.GetComponentInChildren<UM>(), NowObject.GetComponentInChildren<UR>(), NowObject.GetComponentInChildren<CCake>()
                     , NowObject.GetComponentInChildren<CCream>());
        }
    }
   
}
