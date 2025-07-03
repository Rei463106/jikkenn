using UnityEngine;

public class player_move : MonoBehaviour
{
    //Startの中で宣言したものは他のところで使用できない…ので最初に宣言しておく
    //最初にRigidBody2Dと書いてればGetComponentの必要はない？？
    private Rigidbody2D rb;
    [SerializeField] float speed = 3.0f;


    void Start()
    {
        //これを書かないと、何のデータも入ってないものを呼び出すことになる。
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    //物理演算系はFixedUpdateの中でやるのが一般的

    private void FixedUpdate()
    {
        //左右入力キーを押した時の値を代入
        float horizontalKey = Input.GetAxis("Horizontal");

        //右キー
        //newで、直接速さを書き換えている！！
        //Aのコンポーネントのbの情報が得たい時A.bで取得
        //transformは(1.0)のベクトルを指す！
        if (horizontalKey > 0)
        {
            rb.velocity = new Vector2(speed, rb.velocity.y);
            //もしくは
            //rb.AddForce(transform.right*10.0f);
        }
        //左キー
        else if (horizontalKey < 0)
        {
            rb.velocity = new Vector2(-speed, rb.velocity.y);
            //もしくは
            //rb.AddForce(transform.left*10.0f);
        }
        else
        {
            rb.velocity = Vector2.zero;
        }
    }
}
