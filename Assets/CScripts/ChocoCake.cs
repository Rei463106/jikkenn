public class ChocoCake : CakeJudgeBase
{
    UM _um;

    public override bool JudgeObject()
    {
        if (_um.umName.Contains("banana")) judgement = true;
        else judgement = false;
        return judgement;
    }

    public void CSetting(UM um)
    {
        _um = um;
    }
}
