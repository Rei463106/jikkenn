using UnityEngine;

public class Indexer : MonoBehaviour
{
    FreeArray _array = new FreeArray(5);

    private void Start()
    {
        _array[0] = 1;
        _array[1] = 10;
        _array[2] = 15;
        _array[3] = 30;
        _array[4] = 60;

        Debug.Log(_array[2]);
        Debug.Log(_array[-10]);
        Debug.Log(_array[6]);
    }
}

internal class FreeArray
{
    private int _size;
    private int[] _list;

    /// <summary>
    /// コンストラクター
    /// </summary>
    /// <param name="size"></param>
    public FreeArray(int size)
    {
        _size = size;
        _list = new int[size];//初期化
    }

    public int this[int index]
    {
        set
        {
            _list[GetIndex(index)] = value;
        }
        get
        {
            return _list[GetIndex(index)];
        }
    }

    private int GetIndex(int index)
    {
        if (index < 0)
            return 0;
        else
            return index % _size;
    }
}
