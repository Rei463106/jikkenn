using UnityEngine;

public class Taoreru : ItemBase2D
{
    public override void Activate()
    {
        Debug.Log("“|‚ê‚½");
        animationName = "isTaoreru";
        base.Activate();
    }
}
