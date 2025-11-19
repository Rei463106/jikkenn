using System.Collections;
using System.Collections.Generic;
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

    public override bool JudgeObject()
    {
        if (_dl.dlName.Contains("strawberry") && _um.umName.Contains("banana") &&
            _dm.dmName == "" && _dr.drName == "" && _ls.lsName == "" && _rs.rsName == "" &&
            _ul.ulName == "" && _ur.urName == "" && _cCake.colorsIndex % 3 == 1 && _cCream.colorsIndex % 3 == 2)
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
}
