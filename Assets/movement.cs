using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class movement : MonoBehaviour
{
    GameObject GetObject;
    Rigidbody2D rb;
    Transform tr;
    [Header("�X�s�[�h����")]
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
        //����̌^����������̌^�ɕύX�ł��邩�̃e�X�g
        //���Ɏg���������H��
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
