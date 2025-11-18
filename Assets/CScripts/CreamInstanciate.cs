using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreamInstanciate : MonoBehaviour
{
    /// <summary>
    /// Instaticiate‚³‚ê‚éPrefab
    /// </summary>
    [SerializeField] GameObject _spawnParts;
    public void isSqueeze()
    {
        Debug.Log("squeeze");
        var part = Instantiate(_spawnParts, this.transform.position, Quaternion.identity);
    }
}
