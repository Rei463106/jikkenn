public class ShortCake : CakeJudgeBase
{
    DL _dl;
    UM _um;

    public override bool JudgeObject()
    {
        if (_dl.dlName.Contains("strawberry")&&_um.umName.Contains("banana")) judgement = true;
        else judgement = false;
        return judgement;
    }

    public void SSetting(DL dl,UM um)
    {
        _dl = dl;
        _um = um;
    }
}
