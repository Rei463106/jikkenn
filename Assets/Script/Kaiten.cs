using UnityEngine;

public class Kaiten : ItemBase2D
{
    public override void Activate()
    {
        Debug.Log("‰ñ“]‚µ‚½");
        animationName = "activate";
        base.Activate();
    }
}
