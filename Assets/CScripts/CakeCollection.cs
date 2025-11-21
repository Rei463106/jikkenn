using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class CakeCollection : MonoBehaviour
{
    public CakeState _cakeState;
    [SerializeField] List<Image> _CakeImages = new List<Image>();
    private void Update()
    {
        foreach (var image in _CakeImages)
        {
            image.enabled = false;
        }
        if (_cakeState == CakeState.Sh)
        {
            _CakeImages[0].enabled = true;
        }
        else if(_cakeState == CakeState.Sh2)
        {
            _CakeImages[1].enabled = true;
        }
        else if(_cakeState==CakeState.Ch)
        {
            _CakeImages[2].enabled = true;
        }
        else if(_cakeState==CakeState.Ch2)
        {
            _CakeImages[3].enabled = true;
        }
        else if(_cakeState==CakeState.Pu)
        {
            _CakeImages[4].enabled = true;
        }
        else if(_cakeState== CakeState.Pu2)
        {
            _CakeImages[5].enabled = true;
        }
    }
    public enum CakeState
    {
        Sh, Sh2, Ch, Ch2, Pu, Pu2,
    }
}
