using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class movement : MonoBehaviour
{
    GameObject GetObject;
    Rigidbody2D rb;
    Transform tr;
    [Header("スピード調整")]
    public float speed = 3;

    

    // Start is called before the first frame update
    void Start()
    {
        //nanika(); 
        rb= GetComponent<Rigidbody2D>();
        moving();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void nanika()
    {
        //一方の型をもう一方の型に変更できるかのテスト
        //何に使えそうか？→
        bool a=true;
        GetObject.IsConvertibleTo<int>(a);
    }
    void moving()
    {
        string mi;
        mi = "aaa";
        mi.ToLower();
        transform.Describe();
        tr = GetComponent<Transform>();
        
    }
    
}
