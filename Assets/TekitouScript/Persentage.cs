using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 確率により、再生するアニメーションを変える
/// </summary>
public class Persentage : MonoBehaviour
{
    [Header("再生するアニメーションのTrigger名")]
    [SerializeField] private List<string> _triggerName = new List<string>();
    [Header("肝心のAnimator")]
    [SerializeField] private Animator _animator;

    //Listの何番目か
    private int _indexNumber = 0;


    public int indexNumber
    {
        get
        {
            return _indexNumber;
        }
    }

    private void Start()
    {
        float n = Random.Range(0, 100);
        //0.0004%
        if (n >= 0 && n <= 0.0004)
        {
            _animator.SetTrigger(_triggerName[0]);
            _indexNumber = 0;
        }
        //10%
        else if (0 <= n && n <= 10)
        {
            _animator.SetTrigger(_triggerName[1]);
            _indexNumber = 1;
        }
        //20%
        else if (n < 10 && n <= 30)
        {
            _animator.SetTrigger(_triggerName[2]);
            _indexNumber = 2;
        }
        //30%
        else if (n < 30 && n <= 60)
        {
            _animator.SetTrigger(_triggerName[3]);
            _indexNumber = 3;
        }
        //40%
        else if (n < 60 && n <= 100)
        {
            _animator.SetTrigger(_triggerName[4]);
            _indexNumber = 4;
        }
    }
}
