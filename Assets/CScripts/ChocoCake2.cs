using UnityEngine;

public class ChocoCake2 : CakeJudgeBase
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
        if (string.IsNullOrEmpty(_dl.dlName) && _um.umName.Contains("Hoip") &&
            string.IsNullOrEmpty(_dm.dmName) && string.IsNullOrEmpty(_dr.drName) && _ls.lsName.Contains("banana") && _rs.rsName.Contains("banana") &&
            _ul.ulName.Contains("Hoip") && _ur.urName.Contains("Hoip") && _cCake.colorsIndex % 3 == 2 && _cCream.colorsIndex % 3 == 2)
            judgement = true;
        else judgement = false;
        return judgement;
    }

    public void C2Setting(DL dl, DM dm, DR dr, LS ls, RS rs, UL ul, UM um, UR ur, CCake cCake, CCream cCream)
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
        _cakeCollection._cakeState = CakeCollection.CakeState.Ch2;
    }
}
