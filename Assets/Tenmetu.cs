using System.Collections;
using UnityEngine;

//Unityシーン上に配置されたオブジェクト（Cubeなど）を5秒間、**1秒ごとに点滅（表示・非表示）**させてください。
//点滅中はDebug.Logで「Visible」または「Invisible」と表示してください。
//点滅が5回終わったら、最終的に表示された状態に戻して終了します。



public class Tenmetu : MonoBehaviour
{
    //ゲームオブジェクトを取得し、点滅のためのプログラムを書く。

    private Renderer rend;
    [Header("点滅の回数")]
    public float ten;
    void Start()
    {
        rend= GetComponent<Renderer>();
       
    }




    // IEnumerator Startarart()
    //{
    //１秒後に表示される、yield returnを書かないとエラー出るよ
    // yield return new WaitForSeconds(1.0f);
    // Debug.Log("InVisible");
    // this.gameObject.SetActive(false);
    // yield return new WaitForSeconds(2.0f);
    // Debug.Log("Visible");
    // this.gameObject.SetActive(true);
    // yield return new WaitForSeconds(3.0f);
    // Debug.Log("inVisible");
    // this.gameObject.SetActive(false);
    // yield return new WaitForSeconds(4.0f);
    // Debug.Log("visible");
    // this.gameObject.SetActive(true);
    // yield return new WaitForSeconds(5.0f);
    // Debug.Log("InVisible");


    // }

    IEnumerator BlinkCoroutine()
    {
        bool inVisible = true;

        for (int i = 0; i < ten; i++)
        {
            //falseをまず代入（一回目）
            inVisible = !inVisible;
            //表示、非表示だけ切り替える
            rend.enabled = inVisible;
            Debug.Log(inVisible ? "Visible" : "Invisible");

            //１秒後にまたこれを呼び出す。
            //何秒後に…という処理が来たらこやつを呼び出そう。
            yield return new WaitForSeconds(1f);
        }
        rend.enabled = true;
        Debug.Log("Visible");
    }

    

    // Update is called once per frame
    void Update()
    {
        //呼び出すときにはこれを使う。
        // StartCoroutine(Startarart());
        //Startの中に書くと一回しか呼び出されないので注意！！
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(BlinkCoroutine());
        }
    }
}
