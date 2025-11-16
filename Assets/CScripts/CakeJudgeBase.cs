using UnityEngine;

public abstract class CakeJudgeBase : MonoBehaviour
{
    //これの派生をケーキにくっつける
    //合っているかの判断用
    public bool judgement;
    //判定用のメソッド
    public virtual bool JudgeObject()
    {
        return judgement;
    }
}
