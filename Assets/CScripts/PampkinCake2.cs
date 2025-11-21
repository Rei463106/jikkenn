using UnityEngine;

public class PampkinCake2 : CakeJudgeBase
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
    [SerializeField] CakeCollection _cakeCollection;
    public override bool JudgeObject()
    {
        if (_ul.ulName.Contains("strawberry") && _um.umName.Contains("strawberry") && _ur.urName.Contains("strawberry") &&
            string.IsNullOrEmpty(_dl.dlName) && string.IsNullOrEmpty(_dm.dmName) && string.IsNullOrEmpty(_dr.drName)
            && string.IsNullOrEmpty(_ls.lsName) && string.IsNullOrEmpty(_rs.rsName)
              && _cCake.colorsIndex % 3 == 0 && _cCream.colorsIndex % 3 == 2)
            judgement = true;
        else judgement = false;
        return judgement;
    }

    public void P2Setting(DL dl, DM dm, DR dr, LS ls, RS rs, UL ul, UM um, UR ur, CCake cCake, CCream cCream)
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
        _cakeCollection._cakeState = CakeCollection.CakeState.Pu2;
    }
}
