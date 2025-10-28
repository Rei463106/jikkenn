using UnityEngine;
using UnityEngine.UI;

public class HPbar : MonoBehaviour
{
    [Header("プレイヤーの最大HP")]
    public int maxHP = 10;

    [Header("プレイヤーの現在のHP")]
    private int currentHP;

    //スライダーをいじる用
    public Slider hpSlider;

    // Start is called before the first frame update
    void Start()
    {
        //初期設定
        currentHP = maxHP;
        hpSlider.maxValue = maxHP;
        hpSlider.value = currentHP;
    }

    public void TakeDamege(int damege)
    {
        //HPを減らす処理
        currentHP -= damege;
        if (currentHP < 0)
        {
            currentHP = 0;//マイナスにならないように…
        }
        hpSlider.value = currentHP;
        if (currentHP == 0)
        {
            Debug.Log("ゲームオーバー！！");
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            TakeDamege(1);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
