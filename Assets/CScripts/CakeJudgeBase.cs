using UnityEngine;
using UnityEngine.UI;
public abstract class CakeJudgeBase : MonoBehaviour
{
    //これの派生をケーキにくっつける
    //合っているかの判断用
    public bool judgement;

    [SerializeField] Image _cakeImage;
    //判定用のメソッド
    public virtual bool JudgeObject()
    {
        return judgement;
    }

    public virtual void States()
    {
 
    }

}
