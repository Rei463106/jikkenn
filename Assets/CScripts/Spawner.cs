using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
   　//スポナーにくっつける。
    /// <summary>
    /// InstaticiateされるPrefab
    /// </summary>
    [SerializeField] GameObject _spawnParts;
    /// <summary>
    /// スポーンされる位置
    /// </summary>
    [SerializeField] Vector2 _position;
    /// <summary>
    /// 複数オブジェクトが存在しないようにするためのリスト
    /// </summary>
    private List<GameObject> list = new List<GameObject>();

    public void Spawn()
    {
        var part = Instantiate(_spawnParts, _position, Quaternion.identity);
        list.Add(part);
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == _spawnParts.name && list.Count > 1)
        {
            var a = list[1];
            list.RemoveAt(1);
            Destroy(a);
        }
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
       if(collision.name == _spawnParts.name)
       {
           list.RemoveAt(0);
       }
    }
}
