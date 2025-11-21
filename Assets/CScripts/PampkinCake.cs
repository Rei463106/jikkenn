public class PampkinCake : CakeJudgeBase
{
    DL _dl;
    DM _dm;
    DR _dr;
    LS _ls;
    RS _rs;
    UL _ul;
    UM _um;
    UR _ur;
    CCake _cCake;
    CCream _cCream;

    public override bool JudgeObject()
    {
        if (string.IsNullOrEmpty(_dl.dlName) && _um.umName.Contains("Pumpkin") &&
            string.IsNullOrEmpty(_dm.dmName) && string.IsNullOrEmpty(_dr.drName) && _ls.lsName.Contains("Candle") && _rs.rsName.Contains("Candle") &&
            string.IsNullOrEmpty(_ul.ulName) && string.IsNullOrEmpty(_ur.urName) && _cCake.colorsIndex % 3 == 1 && _cCream.colorsIndex % 3 == 2)
            judgement = true;
        else judgement = false;
        return judgement;
    }

    public void PSetting(DL dl, DM dm, DR dr, LS ls, RS rs, UL ul, UM um, UR ur, CCake cCake, CCream cCream)
    {
        _dl = dl;
        _dm = dm;
        _dr = dr;
        _ls = ls;
        _rs = rs;
        _ul = ul;
        _um = um;
        _ur = ur;
        _cCake = cCake;
        _cCream = cCream;
    }

    public override void States()
    {
        base.States();
    }
}
